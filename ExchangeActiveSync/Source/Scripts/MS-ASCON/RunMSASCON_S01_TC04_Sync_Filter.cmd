@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_ASCON.S01_Sync.MSASCON_S01_TC04_Sync_Filter /testcontainer:..\..\MS-ASCON\TestSuite\bin\Debug\MS-ASCON_TestSuite.dll /runconfig:..\..\MS-ASCON\MS-ASCON.testsettings /unique
pause