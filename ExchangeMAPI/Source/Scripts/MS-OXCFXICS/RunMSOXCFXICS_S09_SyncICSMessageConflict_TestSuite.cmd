@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_OXCFXICS.S09_SyncICSMessageConflict_TestSuite.MSOXCFXICS_S09_SyncICSMessageConflict_TestSuite /testcontainer:..\..\MS-OXCFXICS\TestSuite\bin\Debug\MS-OXCFXICS_TestSuite.dll /runconfig:..\..\MS-OXCFXICS\MS-OXCFXICS.testsettings /unique
pause