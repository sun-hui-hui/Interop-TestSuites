@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_DWSS.S03_ManageFolders.MSDWSS_S03_TC07_DeleteFolder_DeleteFolderSuccessfully /testcontainer:..\..\MS-DWSS\TestSuite\bin\Debug\MS-DWSS_TestSuite.dll /runconfig:..\..\MS-DWSS\MS-DWSS.testsettings /unique
pause