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
    public partial class S03_BookmarkRops_FreebookmarkNotSupported_TestSuite : PtfTestClassBase {
        
        public S03_BookmarkRops_FreebookmarkNotSupported_TestSuite() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "2000000");
        }
        
        #region Expect Delegates
        public delegate void CheckMAPIHTTPTransportSupportedDelegate1(bool isSupported);
        
        public delegate void CheckRequirementEnabledDelegate1(bool enabled);
        #endregion
        
        #region Event Metadata
        static System.Reflection.MethodBase CheckMAPIHTTPTransportSupportedInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter), "CheckMAPIHTTPTransportSupported", typeof(bool).MakeByRefType());
        
        static System.Reflection.MethodBase CheckRequirementEnabledInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter), "CheckRequirementEnabled", typeof(int), typeof(bool).MakeByRefType());
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
        public void MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuite() {
            this.Manager.BeginTest("MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuite");
            this.Manager.Comment("reaching state \'S0\'");
            bool temp0;
            this.Manager.Comment("executing step \'call CheckMAPIHTTPTransportSupported(out _)\'");
            this.IMS_OXCTABLAdapterInstance.CheckMAPIHTTPTransportSupported(out temp0);
            this.Manager.AddReturn(CheckMAPIHTTPTransportSupportedInfo, null, temp0);
            this.Manager.Comment("reaching state \'S1\'");
            int temp5 = this.Manager.ExpectReturn(this.QuiescenceTimeout, true, new ExpectedReturn(S03_BookmarkRops_FreebookmarkNotSupported_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuiteCheckMAPIHTTPTransportSupportedChecker)), new ExpectedReturn(S03_BookmarkRops_FreebookmarkNotSupported_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuiteCheckMAPIHTTPTransportSupportedChecker1)));
            if ((temp5 == 0)) {
                this.Manager.Comment("reaching state \'S4\'");
                goto label1;
            }
            if ((temp5 == 1)) {
                this.Manager.Comment("reaching state \'S5\'");
                this.Manager.Comment("executing step \'call InitializeTable(INVALID_TABLE)\'");
                this.IMS_OXCTABLAdapterInstance.InitializeTable(Microsoft.Protocols.TestSuites.MS_OXCTABL.TableType.INVALID_TABLE);
                this.Manager.Comment("reaching state \'S8\'");
                this.Manager.Comment("checking step \'return InitializeTable\'");
                this.Manager.Comment("reaching state \'S10\'");
                bool temp1;
                this.Manager.Comment("executing step \'call CheckRequirementEnabled(549,out _)\'");
                this.IMS_OXCTABLAdapterInstance.CheckRequirementEnabled(549, out temp1);
                this.Manager.AddReturn(CheckRequirementEnabledInfo, null, temp1);
                this.Manager.Comment("reaching state \'S12\'");
                int temp4 = this.Manager.ExpectReturn(this.QuiescenceTimeout, true, new ExpectedReturn(S03_BookmarkRops_FreebookmarkNotSupported_TestSuite.CheckRequirementEnabledInfo, null, new CheckRequirementEnabledDelegate1(this.MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuiteCheckRequirementEnabledChecker)), new ExpectedReturn(S03_BookmarkRops_FreebookmarkNotSupported_TestSuite.CheckRequirementEnabledInfo, null, new CheckRequirementEnabledDelegate1(this.MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuiteCheckRequirementEnabledChecker1)));
                if ((temp4 == 0)) {
                    this.Manager.Comment("reaching state \'S14\'");
                    Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp2;
                    this.Manager.Comment("executing step \'call RopFreeBookmark()\'");
                    temp2 = this.IMS_OXCTABLAdapterInstance.RopFreeBookmark();
                    this.Manager.Checkpoint("MS-OXCTABL_R249");
                    this.Manager.Checkpoint("MS-OXCTABL_R551");
                    this.Manager.Comment("reaching state \'S18\'");
                    this.Manager.Comment("checking step \'return RopFreeBookmark/ecNotSupported\'");
                    TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues.ecNotSupported, temp2, "return of RopFreeBookmark, state S18");
                    this.Manager.Comment("reaching state \'S22\'");
                    goto label0;
                }
                if ((temp4 == 1)) {
                    this.Manager.Comment("reaching state \'S15\'");
                    Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp3;
                    this.Manager.Comment("executing step \'call RopFreeBookmark()\'");
                    temp3 = this.IMS_OXCTABLAdapterInstance.RopFreeBookmark();
                    this.Manager.Checkpoint("MS-OXCTABL_R249");
                    this.Manager.Checkpoint("MS-OXCTABL_R551");
                    this.Manager.Comment("reaching state \'S19\'");
                    this.Manager.Comment("checking step \'return RopFreeBookmark/ecNotSupported\'");
                    TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues.ecNotSupported, temp3, "return of RopFreeBookmark, state S19");
                    this.Manager.Comment("reaching state \'S23\'");
                    goto label0;
                }
                throw new InvalidOperationException("never reached");
            label0:
;
                goto label1;
            }
            throw new InvalidOperationException("never reached");
        label1:
;
            this.Manager.EndTest();
        }
        
        private void MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuiteCheckMAPIHTTPTransportSupportedChecker(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out False]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S1");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuiteCheckMAPIHTTPTransportSupportedChecker1(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S1");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuiteCheckRequirementEnabledChecker(bool enabled) {
            this.Manager.Comment("checking step \'return CheckRequirementEnabled/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, enabled, "enabled of CheckRequirementEnabled, state S12");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuiteCheckRequirementEnabledChecker1(bool enabled) {
            this.Manager.Comment("checking step \'return CheckRequirementEnabled/[out False]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, enabled, "enabled of CheckRequirementEnabled, state S12");
        }
        #endregion
        
        #region Test Starting in S2
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuite1() {
            this.Manager.BeginTest("MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuite1");
            this.Manager.Comment("reaching state \'S2\'");
            bool temp6;
            this.Manager.Comment("executing step \'call CheckMAPIHTTPTransportSupported(out _)\'");
            this.IMS_OXCTABLAdapterInstance.CheckMAPIHTTPTransportSupported(out temp6);
            this.Manager.AddReturn(CheckMAPIHTTPTransportSupportedInfo, null, temp6);
            this.Manager.Comment("reaching state \'S3\'");
            int temp11 = this.Manager.ExpectReturn(this.QuiescenceTimeout, true, new ExpectedReturn(S03_BookmarkRops_FreebookmarkNotSupported_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuite1CheckMAPIHTTPTransportSupportedChecker)), new ExpectedReturn(S03_BookmarkRops_FreebookmarkNotSupported_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuite1CheckMAPIHTTPTransportSupportedChecker1)));
            if ((temp11 == 0)) {
                this.Manager.Comment("reaching state \'S6\'");
                this.Manager.Comment("executing step \'call InitializeTable(ATTACHMENTS_TABLE)\'");
                this.IMS_OXCTABLAdapterInstance.InitializeTable(Microsoft.Protocols.TestSuites.MS_OXCTABL.TableType.ATTACHMENTS_TABLE);
                this.Manager.Comment("reaching state \'S9\'");
                this.Manager.Comment("checking step \'return InitializeTable\'");
                this.Manager.Comment("reaching state \'S11\'");
                bool temp7;
                this.Manager.Comment("executing step \'call CheckRequirementEnabled(549,out _)\'");
                this.IMS_OXCTABLAdapterInstance.CheckRequirementEnabled(549, out temp7);
                this.Manager.AddReturn(CheckRequirementEnabledInfo, null, temp7);
                this.Manager.Comment("reaching state \'S13\'");
                int temp10 = this.Manager.ExpectReturn(this.QuiescenceTimeout, true, new ExpectedReturn(S03_BookmarkRops_FreebookmarkNotSupported_TestSuite.CheckRequirementEnabledInfo, null, new CheckRequirementEnabledDelegate1(this.MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuite1CheckRequirementEnabledChecker)), new ExpectedReturn(S03_BookmarkRops_FreebookmarkNotSupported_TestSuite.CheckRequirementEnabledInfo, null, new CheckRequirementEnabledDelegate1(this.MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuite1CheckRequirementEnabledChecker1)));
                if ((temp10 == 0)) {
                    this.Manager.Comment("reaching state \'S16\'");
                    Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp8;
                    this.Manager.Comment("executing step \'call RopFreeBookmark()\'");
                    temp8 = this.IMS_OXCTABLAdapterInstance.RopFreeBookmark();
                    this.Manager.Checkpoint("MS-OXCTABL_R249");
                    this.Manager.Checkpoint("MS-OXCTABL_R551");
                    this.Manager.Comment("reaching state \'S20\'");
                    this.Manager.Comment("checking step \'return RopFreeBookmark/ecNotSupported\'");
                    TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues.ecNotSupported, temp8, "return of RopFreeBookmark, state S20");
                    this.Manager.Comment("reaching state \'S24\'");
                    goto label2;
                }
                if ((temp10 == 1)) {
                    this.Manager.Comment("reaching state \'S17\'");
                    Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp9;
                    this.Manager.Comment("executing step \'call RopFreeBookmark()\'");
                    temp9 = this.IMS_OXCTABLAdapterInstance.RopFreeBookmark();
                    this.Manager.Checkpoint("MS-OXCTABL_R249");
                    this.Manager.Checkpoint("MS-OXCTABL_R551");
                    this.Manager.Comment("reaching state \'S21\'");
                    this.Manager.Comment("checking step \'return RopFreeBookmark/ecNotSupported\'");
                    TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues.ecNotSupported, temp9, "return of RopFreeBookmark, state S21");
                    this.Manager.Comment("reaching state \'S25\'");
                    goto label2;
                }
                throw new InvalidOperationException("never reached");
            label2:
;
                goto label3;
            }
            if ((temp11 == 1)) {
                this.Manager.Comment("reaching state \'S7\'");
                goto label3;
            }
            throw new InvalidOperationException("never reached");
        label3:
;
            this.Manager.EndTest();
        }
        
        private void MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuite1CheckMAPIHTTPTransportSupportedChecker(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S3");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuite1CheckRequirementEnabledChecker(bool enabled) {
            this.Manager.Comment("checking step \'return CheckRequirementEnabled/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, enabled, "enabled of CheckRequirementEnabled, state S13");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuite1CheckRequirementEnabledChecker1(bool enabled) {
            this.Manager.Comment("checking step \'return CheckRequirementEnabled/[out False]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, enabled, "enabled of CheckRequirementEnabled, state S13");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_FreebookmarkNotSupported_TestSuite1CheckMAPIHTTPTransportSupportedChecker1(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out False]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S3");
        }
        #endregion
    }
}