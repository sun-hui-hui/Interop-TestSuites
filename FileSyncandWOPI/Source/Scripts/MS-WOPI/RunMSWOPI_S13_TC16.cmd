@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_WOPI.MS_WOPI_S13_PutChanges.TestCase_S13_TC16_PutChanges_ReturnAppliedStorageIndexIdEntries_Zero /testcontainer:..\..\MS-WOPI\TestSuite\bin\Debug\MS-WOPI_TestSuite.dll /runconfig:..\..\MS-WOPI\MS-WOPI.testsettings /unique
pause