@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_OXCMSG.S07_RopRecipient.MSOXCMSG_S07_TC03_ErrorCodesOfReadModifyRemoveAllRecipients /testcontainer:..\..\MS-OXCMSG\TestSuite\bin\Debug\MS-OXCMSG_TestSuite.dll /runconfig:..\..\MS-OXCMSG\MS-OXCMSG.testsettings /unique
pause