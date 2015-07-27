#-------------------------------------------------------------------------
# Copyright (c) 2014 Microsoft Corporation. All rights reserved.
# Use of this sample source code is subject to the terms of the Microsoft license 
# agreement under which you licensed this sample source code and is provided AS-IS.
# If you did not accept the terms of the license agreement, you are not authorized 
# to use this sample source code. For the terms of the license, please see the 
# license agreement between you and Microsoft.
#-------------------------------------------------------------------------

#---------------------------------------------------------------------------------
# Purpose: Upload file to specified Document Library.
#---------------------------------------------------------------------------------
$script:ErrorActionPreference = "Stop"
$domain = .\Get-ConfigurationPropertyValue.ps1 Domain
$userName = .\Get-ConfigurationPropertyValue.ps1 UserName
$password = .\Get-ConfigurationPropertyValue.ps1 Password
$computerName = .\Get-ConfigurationPropertyValue.ps1 SUTComputerName
$transportType = .\Get-ConfigurationPropertyValue.ps1 TransportType

$requestUrl=.\Get-ConfigurationPropertyValue.ps1 TargetServiceUrl

$securePassword = $securePassword = ConvertTo-SecureString $password -AsPlainText -Force
$credential = new-object Management.Automation.PSCredential(($domain+"\"+$userName),$securePassword)

#invoke function remotely
$ret = invoke-command -computer $computerName -Credential $credential -scriptblock {
  param(
       [string]$documentLibraryTitle,
       [string]$requestUrl,
       [string]$transportType,
       [string]$fileName
  )
  $script:ErrorActionPreference = "Stop"
  [void][System.Reflection.Assembly]::LoadWithPartialName("Microsoft.SharePoint");
  try
  { 
      $spSites = new-object Microsoft.SharePoint.SPSite "$requestUrl"
      $spWeb =  $spSites.RootWeb
      $targetDocList = $spWeb.Lists[$documentLibraryTitle]
      $listFolder = $targetDocList.RootFolder

      if($listFolder -ne $null)
      {
          $folderName = $listFolder.Name
          $Files = $listFolder.Files
          $TimeFormat = [System.DateTime]::Now.ToString("yyyyHHmmss_fff")
          $fileData=[System.Text.Encoding]::UTF8.GetBytes("MSOUTSPS Test on [$TimeFormat]")
          $addedFile = $Files.Add($fileName, $fileData)
          $pathOfAddedFile = $transportType + "://" + $spSites.HostName + $addedFile.ServerRelativeUrl
          $ret = $pathOfAddedFile
      }
  }
  catch
  {
      throw $error[0]
  }
  finally
  {
      if($spSites -ne $null)
      {
          $spSites.Dispose()
      }
  }
  return $ret

} -argumentlist $documentLibraryTitle, $requestUrl, $transportType, $fileName

return $ret