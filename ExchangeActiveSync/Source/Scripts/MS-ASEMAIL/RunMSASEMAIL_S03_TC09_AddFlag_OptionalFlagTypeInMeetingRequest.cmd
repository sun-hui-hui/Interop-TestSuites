@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_ASEMAIL.S03_EmailFlag.MSASEMAIL_S03_TC09_AddFlag_OptionalFlagTypeInMeetingRequest /testcontainer:..\..\MS-ASEMAIL\TestSuite\bin\Debug\MS-ASEMAIL_TestSuite.dll /runconfig:..\..\MS-ASEMAIL\MS-ASEMAIL.testsettings /unique
pause