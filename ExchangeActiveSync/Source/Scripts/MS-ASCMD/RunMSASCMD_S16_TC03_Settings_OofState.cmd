@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_ASCMD.S16_Settings.MSASCMD_S16_TC03_Settings_OofState /testcontainer:..\..\MS-ASCMD\TestSuite\bin\Debug\MS-ASCMD_TestSuite.dll /runconfig:..\..\MS-ASCMD\MS-ASCMD.testsettings /unique
pause