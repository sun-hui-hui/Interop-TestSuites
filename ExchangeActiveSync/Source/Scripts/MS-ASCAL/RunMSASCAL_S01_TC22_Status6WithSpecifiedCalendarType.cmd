@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_ASCAL.S01_CalendarElement.MSASCAL_S01_TC22_Status6WithSpecifiedCalendarType /testcontainer:..\..\MS-ASCAL\TestSuite\bin\Debug\MS-ASCAL_TestSuite.dll /runconfig:..\..\MS-ASCAL\MS-ASCAL.testsettings /unique
pause