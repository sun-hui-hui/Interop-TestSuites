@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_OXORULE.S03_ProcessOutOfOfficeRule.MSOXORULE_S03_TC07_OOFBehaviorsForFlagDisableSpecificOOFRule /testcontainer:..\..\MS-OXORULE\TestSuite\bin\Debug\MS-OXORULE_TestSuite.dll /runconfig:..\..\MS-OXORULE\MS-OXORULE.testsettings /unique
pause