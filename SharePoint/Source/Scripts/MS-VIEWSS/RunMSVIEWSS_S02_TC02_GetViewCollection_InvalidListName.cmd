@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_VIEWSS.S02_GetAllViews.MSVIEWSS_S02_TC02_GetViewCollection_InvalidListName /testcontainer:..\..\MS-VIEWSS\TestSuite\bin\Debug\MS-VIEWSS_TestSuite.dll /runconfig:..\..\MS-VIEWSS\MS-VIEWSS.testsettings /unique
pause