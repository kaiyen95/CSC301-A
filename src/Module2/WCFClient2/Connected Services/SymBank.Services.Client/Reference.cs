﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClient2.SymBank.Services.Client {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Account", Namespace="http://schemas.datacontract.org/2004/07/SymBank.Services")]
    [System.SerializableAttribute()]
    public partial class Account : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BalanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreatorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime UpdatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipCodeField;
        
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
        public decimal Balance {
            get {
                return this.BalanceField;
            }
            set {
                if ((this.BalanceField.Equals(value) != true)) {
                    this.BalanceField = value;
                    this.RaisePropertyChanged("Balance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Code {
            get {
                return this.CodeField;
            }
            set {
                if ((this.CodeField.Equals(value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created {
            get {
                return this.CreatedField;
            }
            set {
                if ((this.CreatedField.Equals(value) != true)) {
                    this.CreatedField = value;
                    this.RaisePropertyChanged("Created");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Creator {
            get {
                return this.CreatorField;
            }
            set {
                if ((object.ReferenceEquals(this.CreatorField, value) != true)) {
                    this.CreatorField = value;
                    this.RaisePropertyChanged("Creator");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Updated {
            get {
                return this.UpdatedField;
            }
            set {
                if ((this.UpdatedField.Equals(value) != true)) {
                    this.UpdatedField = value;
                    this.RaisePropertyChanged("Updated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ZipCode {
            get {
                return this.ZipCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipCodeField, value) != true)) {
                    this.ZipCodeField = value;
                    this.RaisePropertyChanged("ZipCode");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SymBank.Services.Client.IAccountService")]
    public interface IAccountService {
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IAccountService/AddAccount", ReplyAction="http://tempuri.org/IAccountService/AddAccountResponse")]
        void AddAccount(WCFClient2.SymBank.Services.Client.Account item);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IAccountService/AddAccount", ReplyAction="http://tempuri.org/IAccountService/AddAccountResponse")]
        System.Threading.Tasks.Task AddAccountAsync(WCFClient2.SymBank.Services.Client.Account item);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IAccountService/GetAccount", ReplyAction="http://tempuri.org/IAccountService/GetAccountResponse")]
        WCFClient2.SymBank.Services.Client.Account GetAccount(int code);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IAccountService/GetAccount", ReplyAction="http://tempuri.org/IAccountService/GetAccountResponse")]
        System.Threading.Tasks.Task<WCFClient2.SymBank.Services.Client.Account> GetAccountAsync(int code);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IAccountService/GetAccountList", ReplyAction="http://tempuri.org/IAccountService/GetAccountListResponse")]
        WCFClient2.SymBank.Services.Client.Account[] GetAccountList();
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IAccountService/GetAccountList", ReplyAction="http://tempuri.org/IAccountService/GetAccountListResponse")]
        System.Threading.Tasks.Task<WCFClient2.SymBank.Services.Client.Account[]> GetAccountListAsync();
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IAccountService/GetAccountsForName", ReplyAction="http://tempuri.org/IAccountService/GetAccountsForNameResponse")]
        WCFClient2.SymBank.Services.Client.Account[] GetAccountsForName(string name);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IAccountService/GetAccountsForName", ReplyAction="http://tempuri.org/IAccountService/GetAccountsForNameResponse")]
        System.Threading.Tasks.Task<WCFClient2.SymBank.Services.Client.Account[]> GetAccountsForNameAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountServiceChannel : WCFClient2.SymBank.Services.Client.IAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServiceClient : System.ServiceModel.ClientBase<WCFClient2.SymBank.Services.Client.IAccountService>, WCFClient2.SymBank.Services.Client.IAccountService {
        
        public AccountServiceClient() {
        }
        
        public AccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddAccount(WCFClient2.SymBank.Services.Client.Account item) {
            base.Channel.AddAccount(item);
        }
        
        public System.Threading.Tasks.Task AddAccountAsync(WCFClient2.SymBank.Services.Client.Account item) {
            return base.Channel.AddAccountAsync(item);
        }
        
        public WCFClient2.SymBank.Services.Client.Account GetAccount(int code) {
            return base.Channel.GetAccount(code);
        }
        
        public System.Threading.Tasks.Task<WCFClient2.SymBank.Services.Client.Account> GetAccountAsync(int code) {
            return base.Channel.GetAccountAsync(code);
        }
        
        public WCFClient2.SymBank.Services.Client.Account[] GetAccountList() {
            return base.Channel.GetAccountList();
        }
        
        public System.Threading.Tasks.Task<WCFClient2.SymBank.Services.Client.Account[]> GetAccountListAsync() {
            return base.Channel.GetAccountListAsync();
        }
        
        public WCFClient2.SymBank.Services.Client.Account[] GetAccountsForName(string name) {
            return base.Channel.GetAccountsForName(name);
        }
        
        public System.Threading.Tasks.Task<WCFClient2.SymBank.Services.Client.Account[]> GetAccountsForNameAsync(string name) {
            return base.Channel.GetAccountsForNameAsync(name);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SymBank.Services.Client.ITransactionService")]
    public interface ITransactionService {
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/ITransactionService/Debit", ReplyAction="http://tempuri.org/ITransactionService/DebitResponse")]
        int Debit(int source, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/ITransactionService/Debit", ReplyAction="http://tempuri.org/ITransactionService/DebitResponse")]
        System.Threading.Tasks.Task<int> DebitAsync(int source, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/ITransactionService/Credit", ReplyAction="http://tempuri.org/ITransactionService/CreditResponse")]
        int Credit(int source, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/ITransactionService/Credit", ReplyAction="http://tempuri.org/ITransactionService/CreditResponse")]
        System.Threading.Tasks.Task<int> CreditAsync(int source, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/ITransactionService/Transfer", ReplyAction="http://tempuri.org/ITransactionService/TransferResponse")]
        int Transfer(int source, int target, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/ITransactionService/Transfer", ReplyAction="http://tempuri.org/ITransactionService/TransferResponse")]
        System.Threading.Tasks.Task<int> TransferAsync(int source, int target, decimal amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITransactionServiceChannel : WCFClient2.SymBank.Services.Client.ITransactionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TransactionServiceClient : System.ServiceModel.ClientBase<WCFClient2.SymBank.Services.Client.ITransactionService>, WCFClient2.SymBank.Services.Client.ITransactionService {
        
        public TransactionServiceClient() {
        }
        
        public TransactionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TransactionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransactionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransactionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Debit(int source, decimal amount) {
            return base.Channel.Debit(source, amount);
        }
        
        public System.Threading.Tasks.Task<int> DebitAsync(int source, decimal amount) {
            return base.Channel.DebitAsync(source, amount);
        }
        
        public int Credit(int source, decimal amount) {
            return base.Channel.Credit(source, amount);
        }
        
        public System.Threading.Tasks.Task<int> CreditAsync(int source, decimal amount) {
            return base.Channel.CreditAsync(source, amount);
        }
        
        public int Transfer(int source, int target, decimal amount) {
            return base.Channel.Transfer(source, target, amount);
        }
        
        public System.Threading.Tasks.Task<int> TransferAsync(int source, int target, decimal amount) {
            return base.Channel.TransferAsync(source, target, amount);
        }
    }
}
