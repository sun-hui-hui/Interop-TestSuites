@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_OXCROPS.S04_MessageROPs.MSOXCROPS_S04_TC02_TestRopGetMessageStatus /testcontainer:..\..\MS-OXCROPS\TestSuite\bin\Debug\MS-OXCROPS_TestSuite.dll /runconfig:..\..\MS-OXCROPS\MS-OXCROPS.testsettings /unique
pause