﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3623
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.3623.
// 
#pragma warning disable 1591

namespace FINTWeb.serverFINTFachada {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="serverFINTFachadaSoap", Namespace="http://tempuri.org/")]
    public partial class serverFINTFachada : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback agregarUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback chequearUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback modificarUsuarioOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public serverFINTFachada() {
            this.Url = global::FINTWeb.Properties.Settings.Default.FINTWeb_localhost_serverFINTFachada;
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
        public event agregarUsuarioCompletedEventHandler agregarUsuarioCompleted;
        
        /// <remarks/>
        public event chequearUsuarioCompletedEventHandler chequearUsuarioCompleted;
        
        /// <remarks/>
        public event modificarUsuarioCompletedEventHandler modificarUsuarioCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/agregarUsuario", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int agregarUsuario(string nombre, string login, string passwd, rol tipo) {
            object[] results = this.Invoke("agregarUsuario", new object[] {
                        nombre,
                        login,
                        passwd,
                        tipo});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void agregarUsuarioAsync(string nombre, string login, string passwd, rol tipo) {
            this.agregarUsuarioAsync(nombre, login, passwd, tipo, null);
        }
        
        /// <remarks/>
        public void agregarUsuarioAsync(string nombre, string login, string passwd, rol tipo, object userState) {
            if ((this.agregarUsuarioOperationCompleted == null)) {
                this.agregarUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnagregarUsuarioOperationCompleted);
            }
            this.InvokeAsync("agregarUsuario", new object[] {
                        nombre,
                        login,
                        passwd,
                        tipo}, this.agregarUsuarioOperationCompleted, userState);
        }
        
        private void OnagregarUsuarioOperationCompleted(object arg) {
            if ((this.agregarUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.agregarUsuarioCompleted(this, new agregarUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/chequearUsuario", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet chequearUsuario(string login, string passwd) {
            object[] results = this.Invoke("chequearUsuario", new object[] {
                        login,
                        passwd});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void chequearUsuarioAsync(string login, string passwd) {
            this.chequearUsuarioAsync(login, passwd, null);
        }
        
        /// <remarks/>
        public void chequearUsuarioAsync(string login, string passwd, object userState) {
            if ((this.chequearUsuarioOperationCompleted == null)) {
                this.chequearUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnchequearUsuarioOperationCompleted);
            }
            this.InvokeAsync("chequearUsuario", new object[] {
                        login,
                        passwd}, this.chequearUsuarioOperationCompleted, userState);
        }
        
        private void OnchequearUsuarioOperationCompleted(object arg) {
            if ((this.chequearUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.chequearUsuarioCompleted(this, new chequearUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/modificarUsuario", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool modificarUsuario(string nombre, string passwd, int id) {
            object[] results = this.Invoke("modificarUsuario", new object[] {
                        nombre,
                        passwd,
                        id});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void modificarUsuarioAsync(string nombre, string passwd, int id) {
            this.modificarUsuarioAsync(nombre, passwd, id, null);
        }
        
        /// <remarks/>
        public void modificarUsuarioAsync(string nombre, string passwd, int id, object userState) {
            if ((this.modificarUsuarioOperationCompleted == null)) {
                this.modificarUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmodificarUsuarioOperationCompleted);
            }
            this.InvokeAsync("modificarUsuario", new object[] {
                        nombre,
                        passwd,
                        id}, this.modificarUsuarioOperationCompleted, userState);
        }
        
        private void OnmodificarUsuarioOperationCompleted(object arg) {
            if ((this.modificarUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.modificarUsuarioCompleted(this, new modificarUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum rol {
        
        /// <remarks/>
        Administrador,
        
        /// <remarks/>
        Usuario,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void agregarUsuarioCompletedEventHandler(object sender, agregarUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class agregarUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal agregarUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void chequearUsuarioCompletedEventHandler(object sender, chequearUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class chequearUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal chequearUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void modificarUsuarioCompletedEventHandler(object sender, modificarUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class modificarUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal modificarUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591