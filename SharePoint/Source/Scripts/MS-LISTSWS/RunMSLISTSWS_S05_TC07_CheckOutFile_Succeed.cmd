@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_LISTSWS.S05_OperationOnFiles.MSLISTSWS_S05_TC07_CheckOutFile_Succeed /testcontainer:..\..\MS-LISTSWS\TestSuite\bin\Debug\MS-LISTSWS_TestSuite.dll /runconfig:..\..\MS-LISTSWS\MS-LISTSWS.testsettings /unique
pause