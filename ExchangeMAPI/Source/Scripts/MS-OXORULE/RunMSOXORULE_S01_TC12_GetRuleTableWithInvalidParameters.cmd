@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_OXORULE.S01_AddModifyDeleteRetrieveRules.MSOXORULE_S01_TC12_GetRuleTableWithInvalidParameters /testcontainer:..\..\MS-OXORULE\TestSuite\bin\Debug\MS-OXORULE_TestSuite.dll /runconfig:..\..\MS-OXORULE\MS-OXORULE.testsettings /unique
pause