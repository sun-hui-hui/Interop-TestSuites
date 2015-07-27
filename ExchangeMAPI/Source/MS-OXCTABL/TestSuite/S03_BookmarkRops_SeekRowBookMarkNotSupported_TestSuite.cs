//-----------------------------------------------------------------------
// Copyright (c) 2014 Microsoft Corporation. All rights reserved.
// Use of this sample source code is subject to the terms of the Microsoft license 
// agreement under which you licensed this sample source code and is provided AS-IS.
// If you did not accept the terms of the license agreement, you are not authorized 
// to use this sample source code. For the terms of the license, please see the 
// license agreement between you and Microsoft.
//-----------------------------------------------------------------------
//-----------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.MS_OXCTABL {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.SpecExplorer.Runtime.Testing;
    using Microsoft.Protocols.TestTools;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Spec Explorer", "3.6.100.0")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuite : PtfTestClassBase {
        
        public S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuite() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "2000000");
        }
        
        #region Expect Delegates
        public delegate void CheckMAPIHTTPTransportSupportedDelegate1(bool isSupported);
        #endregion
        
        #region Event Metadata
        static System.Reflection.MethodBase CheckMAPIHTTPTransportSupportedInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter), "CheckMAPIHTTPTransportSupported", typeof(bool).MakeByRefType());
        #endregion
        
        #region Adapter Instances
        private Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter IMS_OXCTABLAdapterInstance;
        #endregion
        
        #region Class Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void ClassInitialize(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext context) {
            PtfTestClassBase.Initialize(context);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void ClassCleanup() {
            PtfTestClassBase.Cleanup();
        }
        #endregion
        
        #region Test Initialization and Cleanup
        protected override void TestInitialize() {
            this.InitializeTestManager();
            this.IMS_OXCTABLAdapterInstance = ((Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter)(this.Manager.GetAdapter(typeof(Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter))));
        }
        
        protected override void TestCleanup() {
            base.TestCleanup();
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuite() {
            this.Manager.BeginTest("MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuite");
            this.Manager.Comment("reaching state \'S0\'");
            bool temp0;
            this.Manager.Comment("executing step \'call CheckMAPIHTTPTransportSupported(out _)\'");
            this.IMS_OXCTABLAdapterInstance.CheckMAPIHTTPTransportSupported(out temp0);
            this.Manager.AddReturn(CheckMAPIHTTPTransportSupportedInfo, null, temp0);
            this.Manager.Comment("reaching state \'S1\'");
            int temp2 = this.Manager.ExpectReturn(this.QuiescenceTimeout, true, new ExpectedReturn(S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuiteCheckMAPIHTTPTransportSupportedChecker)), new ExpectedReturn(S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuiteCheckMAPIHTTPTransportSupportedChecker1)));
            if ((temp2 == 0)) {
                this.Manager.Comment("reaching state \'S4\'");
                goto label0;
            }
            if ((temp2 == 1)) {
                this.Manager.Comment("reaching state \'S5\'");
                this.Manager.Comment("executing step \'call InitializeTable(ATTACHMENTS_TABLE)\'");
                this.IMS_OXCTABLAdapterInstance.InitializeTable(Microsoft.Protocols.TestSuites.MS_OXCTABL.TableType.ATTACHMENTS_TABLE);
                this.Manager.Comment("reaching state \'S8\'");
                this.Manager.Comment("checking step \'return InitializeTable\'");
                this.Manager.Comment("reaching state \'S10\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp1;
                this.Manager.Comment("executing step \'call RopSeekRowBookmark(True,True,True)\'");
                temp1 = this.IMS_OXCTABLAdapterInstance.RopSeekRowBookmark(true, true, true);
                this.Manager.Checkpoint("MS-OXCTABL_R512");
                this.Manager.Comment("reaching state \'S12\'");
                this.Manager.Comment("checking step \'return RopSeekRowBookmark/ecNotSupported\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues.ecNotSupported, temp1, "return of RopSeekRowBookmark, state S12");
                this.Manager.Comment("reaching state \'S14\'");
                goto label0;
            }
            throw new InvalidOperationException("never reached");
        label0:
;
            this.Manager.EndTest();
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuiteCheckMAPIHTTPTransportSupportedChecker(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out False]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S1");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuiteCheckMAPIHTTPTransportSupportedChecker1(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S1");
        }
        #endregion
        
        #region Test Starting in S2
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuite1() {
            this.Manager.BeginTest("MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuite1");
            this.Manager.Comment("reaching state \'S2\'");
            bool temp3;
            this.Manager.Comment("executing step \'call CheckMAPIHTTPTransportSupported(out _)\'");
            this.IMS_OXCTABLAdapterInstance.CheckMAPIHTTPTransportSupported(out temp3);
            this.Manager.AddReturn(CheckMAPIHTTPTransportSupportedInfo, null, temp3);
            this.Manager.Comment("reaching state \'S3\'");
            int temp5 = this.Manager.ExpectReturn(this.QuiescenceTimeout, true, new ExpectedReturn(S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuite1CheckMAPIHTTPTransportSupportedChecker)), new ExpectedReturn(S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuite1CheckMAPIHTTPTransportSupportedChecker1)));
            if ((temp5 == 0)) {
                this.Manager.Comment("reaching state \'S6\'");
                this.Manager.Comment("executing step \'call InitializeTable(INVALID_TABLE)\'");
                this.IMS_OXCTABLAdapterInstance.InitializeTable(Microsoft.Protocols.TestSuites.MS_OXCTABL.TableType.INVALID_TABLE);
                this.Manager.Comment("reaching state \'S9\'");
                this.Manager.Comment("checking step \'return InitializeTable\'");
                this.Manager.Comment("reaching state \'S11\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp4;
                this.Manager.Comment("executing step \'call RopSeekRowBookmark(True,True,True)\'");
                temp4 = this.IMS_OXCTABLAdapterInstance.RopSeekRowBookmark(true, true, true);
                this.Manager.Checkpoint("MS-OXCTABL_R168");
                this.Manager.Comment("reaching state \'S13\'");
                this.Manager.Comment("checking step \'return RopSeekRowBookmark/ecNotSupported\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues.ecNotSupported, temp4, "return of RopSeekRowBookmark, state S13");
                this.Manager.Comment("reaching state \'S15\'");
                goto label1;
            }
            if ((temp5 == 1)) {
                this.Manager.Comment("reaching state \'S7\'");
                goto label1;
            }
            throw new InvalidOperationException("never reached");
        label1:
;
            this.Manager.EndTest();
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuite1CheckMAPIHTTPTransportSupportedChecker(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S3");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkNotSupported_TestSuite1CheckMAPIHTTPTransportSupportedChecker1(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out False]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S3");
        }
        #endregion
    }
}