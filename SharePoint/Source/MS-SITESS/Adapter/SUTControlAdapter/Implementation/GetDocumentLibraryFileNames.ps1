#-------------------------------------------------------------------------
# Copyright (c) 2014 Microsoft Corporation. All rights reserved.
# Use of this sample source code is subject to the terms of the Microsoft license 
# agreement under which you licensed this sample source code and is provided AS-IS.
# If you did not accept the terms of the license agreement, you are not authorized 
# to use this sample source code. For the terms of the license, please see the 
# license agreement between you and Microsoft.
#-------------------------------------------------------------------------

$script:ErrorActionPreference = "Stop"
$password = .\Get-ConfigurationPropertyValue.ps1 Password
$securePassword = ConvertTo-SecureString $password -AsPlainText -Force

$domain = .\Get-ConfigurationPropertyValue.ps1 Domain
$userName = .\Get-ConfigurationPropertyValue.ps1 UserName
$credential = new-object Management.Automation.PSCredential(($domain+"\"+$userName),$securePassword)

$computerName = .\Get-ConfigurationPropertyValue.ps1 SutComputerName
$siteCollectionUrl = .\Get-ConfigurationPropertyValue.ps1 SiteCollectionUrl
$mainUrl = "http://" + $computerName

$ret = invoke-command -computer $computerName -Credential $credential -scriptblock{

param(
    [string]$siteName,
    [string]$webName,
    [string]$listName,
	[string]$fileName,
    [string]$mainUrl,
    [string]$siteCollectionUrl
)
    $script:ErrorActionPreference = "Stop"
    [void][System.Reflection.Assembly]::LoadWithPartialName("Microsoft.SharePoint")

    $listDocNames = $null

    try
    {
        if([string]::IsNullOrEmpty($siteCollectionUrl))
        {
            $spSite = new-object Microsoft.SharePoint.SPSite($mainUrl)
        }
        else
        {
            $spSite = new-object Microsoft.SharePoint.SPSite($siteCollectionUrl)
        }

        if(![string]::IsNullOrEmpty($webName) -and ![string]::IsNullOrEmpty($siteName))
		{
			$spWeb = $spSite.OpenWeb($siteName +"/"+ $webName)
		}
        elseif(![string]::IsNullOrEmpty($siteName))
		{
			$spWeb=$spSite.OpenWeb($siteName)
		}
        else
		{
			$spWeb =  $spSite.RootWeb
		}

        $list = $spWeb.Lists[$listName] 
        $listDocItems = $list.Items

        Foreach ($listDocItem in $listDocItems)
        {
		    if ($listDocItem.Name.Contains($fileName))
                {
	                $listDocNames+=$listDocItem.Name+";"
                }
        }
    }
    finally
    {
        if ($spWeb -ne $null)
        {
            $spWeb.Close()
            $spWeb.Dispose()
        }
        if ($spSite -ne $null)
        {
            $spSite.Close()
            $spSite.Dispose()
        }
    }

    return $listDocNames
}-argumentlist $siteName, $webName, $listName, $fileName, $mainUrl, $siteCollectionUrl

return $ret