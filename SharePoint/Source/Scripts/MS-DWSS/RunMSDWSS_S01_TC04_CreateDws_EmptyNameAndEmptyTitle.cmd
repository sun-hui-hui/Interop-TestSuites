@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_DWSS.S01_ManageSites.MSDWSS_S01_TC04_CreateDws_EmptyNameAndEmptyTitle /testcontainer:..\..\MS-DWSS\TestSuite\bin\Debug\MS-DWSS_TestSuite.dll /runconfig:..\..\MS-DWSS\MS-DWSS.testsettings /unique
pause