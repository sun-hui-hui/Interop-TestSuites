@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_ASAIRS.S02_BodyPreference.MSASAIRS_S02_TC05_BodyPreference_NoAllOrNone_TruncatedContentReturned /testcontainer:..\..\MS-ASAIRS\TestSuite\bin\Debug\MS-ASAIRS_TestSuite.dll /runconfig:..\..\MS-ASAIRS\MS-ASAIRS.testsettings /unique
pause