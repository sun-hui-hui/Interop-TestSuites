@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_LISTSWS.S02_OperationOnContentType.MSLISTSWS_S02_TC36_GetListContentTypesAndProperties_Succeed_BestMatchAndPrefix /testcontainer:..\..\MS-LISTSWS\TestSuite\bin\Debug\MS-LISTSWS_TestSuite.dll /runconfig:..\..\MS-LISTSWS\MS-LISTSWS.testsettings /unique
pause