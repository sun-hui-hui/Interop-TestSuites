@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_DWSS.S02_ManageData.MSDWSS_S02_TC05_GetDwsMetaData_MinimalIsTrue /testcontainer:..\..\MS-DWSS\TestSuite\bin\Debug\MS-DWSS_TestSuite.dll /runconfig:..\..\MS-DWSS\MS-DWSS.testsettings /unique
pause