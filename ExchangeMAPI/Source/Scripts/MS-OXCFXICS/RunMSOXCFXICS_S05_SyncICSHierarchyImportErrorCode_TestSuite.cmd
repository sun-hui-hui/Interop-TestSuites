@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_OXCFXICS.S05_SyncICSHierarchyImportErrorCode_TestSuite.MSOXCFXICS_S05_SyncICSHierarchyImportErrorCode_TestSuite /testcontainer:..\..\MS-OXCFXICS\TestSuite\bin\Debug\MS-OXCFXICS_TestSuite.dll /runconfig:..\..\MS-OXCFXICS\MS-OXCFXICS.testsettings /unique
pause