@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_VIEWSS.S01_AddDeleteViews.MSVIEWSS_S01_TC09_AddView_NullRowLimit /testcontainer:..\..\MS-VIEWSS\TestSuite\bin\Debug\MS-VIEWSS_TestSuite.dll /runconfig:..\..\MS-VIEWSS\MS-VIEWSS.testsettings /unique
pause