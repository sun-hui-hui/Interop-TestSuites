@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_ASCON.S03_ItemOperations.MSASCON_S03_TC08_ItemOperations_MessagePart /testcontainer:..\..\MS-ASCON\TestSuite\bin\Debug\MS-ASCON_TestSuite.dll /runconfig:..\..\MS-ASCON\MS-ASCON.testsettings /unique
pause