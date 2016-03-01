﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.18444.
// 
#pragma warning disable 1591

namespace AplicacionMaquinas.Seguridad {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="UDDISecurityServiceSoapBinding", Namespace="urn:uddi-org:v3_service")]
    public partial class UDDISecurityService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback discard_authTokenOperationCompleted;
        
        private System.Threading.SendOrPostCallback get_authTokenOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public UDDISecurityService() {
            this.Url = global::AplicacionMaquinas.Properties.Settings.Default.AplicacionMaquinas_Seguridad_UDDISecurityService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event discard_authTokenCompletedEventHandler discard_authTokenCompleted;
        
        /// <remarks/>
        public event get_authTokenCompletedEventHandler get_authTokenCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("discard_authToken", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        public void discard_authToken([System.Xml.Serialization.XmlElementAttribute("discard_authToken", Namespace="urn:uddi-org:api_v3")] discard_authToken discard_authToken1) {
            this.Invoke("discard_authToken", new object[] {
                        discard_authToken1});
        }
        
        /// <remarks/>
        public void discard_authTokenAsync(discard_authToken discard_authToken1) {
            this.discard_authTokenAsync(discard_authToken1, null);
        }
        
        /// <remarks/>
        public void discard_authTokenAsync(discard_authToken discard_authToken1, object userState) {
            if ((this.discard_authTokenOperationCompleted == null)) {
                this.discard_authTokenOperationCompleted = new System.Threading.SendOrPostCallback(this.Ondiscard_authTokenOperationCompleted);
            }
            this.InvokeAsync("discard_authToken", new object[] {
                        discard_authToken1}, this.discard_authTokenOperationCompleted, userState);
        }
        
        private void Ondiscard_authTokenOperationCompleted(object arg) {
            if ((this.discard_authTokenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.discard_authTokenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("get_authToken", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("authToken", Namespace="urn:uddi-org:api_v3")]
        public authToken get_authToken([System.Xml.Serialization.XmlElementAttribute("get_authToken", Namespace="urn:uddi-org:api_v3")] get_authToken get_authToken1) {
            object[] results = this.Invoke("get_authToken", new object[] {
                        get_authToken1});
            return ((authToken)(results[0]));
        }
        
        /// <remarks/>
        public void get_authTokenAsync(get_authToken get_authToken1) {
            this.get_authTokenAsync(get_authToken1, null);
        }
        
        /// <remarks/>
        public void get_authTokenAsync(get_authToken get_authToken1, object userState) {
            if ((this.get_authTokenOperationCompleted == null)) {
                this.get_authTokenOperationCompleted = new System.Threading.SendOrPostCallback(this.Onget_authTokenOperationCompleted);
            }
            this.InvokeAsync("get_authToken", new object[] {
                        get_authToken1}, this.get_authTokenOperationCompleted, userState);
        }
        
        private void Onget_authTokenOperationCompleted(object arg) {
            if ((this.get_authTokenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.get_authTokenCompleted(this, new get_authTokenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v3")]
    public partial class discard_authToken {
        
        private string authInfoField;
        
        /// <comentarios/>
        public string authInfo {
            get {
                return this.authInfoField;
            }
            set {
                this.authInfoField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v3")]
    public partial class authToken {
        
        private string authInfoField;
        
        /// <comentarios/>
        public string authInfo {
            get {
                return this.authInfoField;
            }
            set {
                this.authInfoField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v3")]
    public partial class get_authToken {
        
        private string userIDField;
        
        private string credField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string userID {
            get {
                return this.userIDField;
            }
            set {
                this.userIDField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cred {
            get {
                return this.credField;
            }
            set {
                this.credField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void discard_authTokenCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void get_authTokenCompletedEventHandler(object sender, get_authTokenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class get_authTokenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal get_authTokenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public authToken Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((authToken)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591