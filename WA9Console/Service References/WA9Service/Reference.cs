﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WA9Console.WA9Service {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/WebApplication9.Database")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ItemCountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItemNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ItemCount {
            get {
                return this.ItemCountField;
            }
            set {
                if ((this.ItemCountField.Equals(value) != true)) {
                    this.ItemCountField = value;
                    this.RaisePropertyChanged("ItemCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemName {
            get {
                return this.ItemNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemNameField, value) != true)) {
                    this.ItemNameField = value;
                    this.RaisePropertyChanged("ItemName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WA9Service.IWA9Service")]
    public interface IWA9Service {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWA9Service/getAllItems", ReplyAction="http://tempuri.org/IWA9Service/getAllItemsResponse")]
        WA9Console.WA9Service.Item[] getAllItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWA9Service/getAllItems", ReplyAction="http://tempuri.org/IWA9Service/getAllItemsResponse")]
        System.Threading.Tasks.Task<WA9Console.WA9Service.Item[]> getAllItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWA9Service/insertItem", ReplyAction="http://tempuri.org/IWA9Service/insertItemResponse")]
        string insertItem(WA9Console.WA9Service.Item item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWA9Service/insertItem", ReplyAction="http://tempuri.org/IWA9Service/insertItemResponse")]
        System.Threading.Tasks.Task<string> insertItemAsync(WA9Console.WA9Service.Item item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWA9Service/testFunction", ReplyAction="http://tempuri.org/IWA9Service/testFunctionResponse")]
        void testFunction();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWA9Service/testFunction", ReplyAction="http://tempuri.org/IWA9Service/testFunctionResponse")]
        System.Threading.Tasks.Task testFunctionAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWA9ServiceChannel : WA9Console.WA9Service.IWA9Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WA9ServiceClient : System.ServiceModel.ClientBase<WA9Console.WA9Service.IWA9Service>, WA9Console.WA9Service.IWA9Service {
        
        public WA9ServiceClient() {
        }
        
        public WA9ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WA9ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WA9ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WA9ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WA9Console.WA9Service.Item[] getAllItems() {
            return base.Channel.getAllItems();
        }
        
        public System.Threading.Tasks.Task<WA9Console.WA9Service.Item[]> getAllItemsAsync() {
            return base.Channel.getAllItemsAsync();
        }
        
        public string insertItem(WA9Console.WA9Service.Item item) {
            return base.Channel.insertItem(item);
        }
        
        public System.Threading.Tasks.Task<string> insertItemAsync(WA9Console.WA9Service.Item item) {
            return base.Channel.insertItemAsync(item);
        }
        
        public void testFunction() {
            base.Channel.testFunction();
        }
        
        public System.Threading.Tasks.Task testFunctionAsync() {
            return base.Channel.testFunctionAsync();
        }
    }
}