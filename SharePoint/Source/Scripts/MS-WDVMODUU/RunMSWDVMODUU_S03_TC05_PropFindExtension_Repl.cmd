@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_WDVMODUU.S03_PropFindExtension.MSWDVMODUU_S03_TC05_PropFindExtension_Repl /testcontainer:..\..\MS-WDVMODUU\TestSuite\bin\Debug\MS-WDVMODUU_TestSuite.dll /runconfig:..\..\MS-WDVMODUU\MS-WDVMODUU.testsettings /unique
pause