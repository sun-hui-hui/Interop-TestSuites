@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_CPSWS.S04_ResolveToEntities.MSCPSWS_S04_TC05_ResolveMultiple_NullResolveInput /testcontainer:..\..\MS-CPSWS\TestSuite\bin\Debug\MS-CPSWS_TestSuite.dll /runconfig:..\..\MS-CPSWS\MS-CPSWS.testsettings /unique
pause