@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_OXCTABL.S04_ExpandRowRops_CollapseorExpandRowNotSupported_TestSuite.MSOXCTABL_S04_ExpandRowRops_CollapseorExpandRowNotSupported_TestSuite2 /testcontainer:..\..\MS-OXCTABL\TestSuite\bin\Debug\MS-OXCTABL_TestSuite.dll /runconfig:..\..\MS-OXCTABL\MS-OXCTABL.testsettings /unique
pause