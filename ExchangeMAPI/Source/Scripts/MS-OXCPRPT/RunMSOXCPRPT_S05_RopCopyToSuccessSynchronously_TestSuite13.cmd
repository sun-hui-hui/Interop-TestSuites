@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_OXCPRPT.S05_RopCopyToSuccessSynchronously_TestSuite.MSOXCPRPT_S05_RopCopyToSuccessSynchronously_TestSuite13 /testcontainer:..\..\MS-OXCPRPT\TestSuite\bin\Debug\MS-OXCPRPT_TestSuite.dll /runconfig:..\..\MS-OXCPRPT\MS-OXCPRPT.testsettings /unique
pause