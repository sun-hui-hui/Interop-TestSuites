@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_ASEMAIL.S02_EmailVoiceAttachment.MSASEMAIL_S02_TC02_VoiceAttachment_IncludedUmCallerIDInRequest /testcontainer:..\..\MS-ASEMAIL\TestSuite\bin\Debug\MS-ASEMAIL_TestSuite.dll /runconfig:..\..\MS-ASEMAIL\MS-ASEMAIL.testsettings /unique
pause