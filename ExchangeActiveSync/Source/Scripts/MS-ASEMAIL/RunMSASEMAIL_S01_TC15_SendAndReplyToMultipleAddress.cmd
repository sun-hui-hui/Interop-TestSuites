@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_ASEMAIL.S01_Email.MSASEMAIL_S01_TC15_SendAndReplyToMultipleAddress /testcontainer:..\..\MS-ASEMAIL\TestSuite\bin\Debug\MS-ASEMAIL_TestSuite.dll /runconfig:..\..\MS-ASEMAIL\MS-ASEMAIL.testsettings /unique
pause