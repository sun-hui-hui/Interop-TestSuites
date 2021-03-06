//-----------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.MS_SHDACCWS
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "SharedAccessSoap", Namespace = "http://schemas.microsoft.com/sharepoint/soap/")]
    public partial class SharedAccessSoap : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback IsOnlyClientOperationCompleted;

        /// <remarks/>
        public SharedAccessSoap()
        {
        }

        /// <remarks/>
        public event IsOnlyClientCompletedEventHandler IsOnlyClientCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sharepoint/soap/IsOnlyClient", RequestNamespace = "http://schemas.microsoft.com/sharepoint/soap/", ResponseNamespace = "http://schemas.microsoft.com/sharepoint/soap/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool IsOnlyClient(string id)
        {
            object[] results = this.Invoke("IsOnlyClient", new object[] {
                    id});
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginIsOnlyClient(string id, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("IsOnlyClient", new object[] {
                    id}, callback, asyncState);
        }

        /// <remarks/>
        public bool EndIsOnlyClient(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public void IsOnlyClientAsync(string id)
        {
            this.IsOnlyClientAsync(id, null);
        }

        /// <remarks/>
        public void IsOnlyClientAsync(string id, object userState)
        {
            if ((this.IsOnlyClientOperationCompleted == null))
            {
                this.IsOnlyClientOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsOnlyClientOperationCompleted);
            }
            this.InvokeAsync("IsOnlyClient", new object[] {
                    id}, this.IsOnlyClientOperationCompleted, userState);
        }

        private void OnIsOnlyClientOperationCompleted(object arg)
        {
            if ((this.IsOnlyClientCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsOnlyClientCompleted(this, new IsOnlyClientCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void IsOnlyClientCompletedEventHandler(object sender, IsOnlyClientCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsOnlyClientCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal IsOnlyClientCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public bool Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}