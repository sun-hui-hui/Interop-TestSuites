@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_ASCNTC.S01_Sync.MSASCNTC_S01_TC04_Sync_RefreshRecipientInformationCache /testcontainer:..\..\MS-ASCNTC\TestSuite\bin\Debug\MS-ASCNTC_TestSuite.dll /runconfig:..\..\MS-ASCNTC\MS-ASCNTC.testsettings /unique
pause