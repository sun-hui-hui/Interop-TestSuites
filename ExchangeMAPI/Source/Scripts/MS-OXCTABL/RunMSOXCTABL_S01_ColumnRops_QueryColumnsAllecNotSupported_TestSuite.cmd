@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_OXCTABL.S01_ColumnRops_QueryColumnsAllecNotSupported_TestSuite.MSOXCTABL_S01_ColumnRops_QueryColumnsAllecNotSupported_TestSuite /testcontainer:..\..\MS-OXCTABL\TestSuite\bin\Debug\MS-OXCTABL_TestSuite.dll /runconfig:..\..\MS-OXCTABL\MS-OXCTABL.testsettings /unique
pause