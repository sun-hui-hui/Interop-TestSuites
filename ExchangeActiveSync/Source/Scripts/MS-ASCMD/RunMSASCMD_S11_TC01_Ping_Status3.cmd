@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_ASCMD.S11_Ping.MSASCMD_S11_TC01_Ping_Status3 /testcontainer:..\..\MS-ASCMD\TestSuite\bin\Debug\MS-ASCMD_TestSuite.dll /runconfig:..\..\MS-ASCMD\MS-ASCMD.testsettings /unique
pause