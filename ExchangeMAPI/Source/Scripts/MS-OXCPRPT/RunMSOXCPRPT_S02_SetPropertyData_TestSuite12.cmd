@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_OXCPRPT.S02_SetPropertyData_TestSuite.MSOXCPRPT_S02_SetPropertyData_TestSuite12 /testcontainer:..\..\MS-OXCPRPT\TestSuite\bin\Debug\MS-OXCPRPT_TestSuite.dll /runconfig:..\..\MS-OXCPRPT\MS-OXCPRPT.testsettings /unique
pause