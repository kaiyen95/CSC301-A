﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SymBank.Services
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SymBank")]
	public partial class SymBankDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertTransaction(Transaction instance);
    partial void UpdateTransaction(Transaction instance);
    partial void DeleteTransaction(Transaction instance);
    #endregion
		
		public SymBankDataContext() : 
				base(global::SymBank.Services.Properties.Settings.Default.SymBankConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public SymBankDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SymBankDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SymBankDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SymBankDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<Transaction> Transactions
		{
			get
			{
				return this.GetTable<Transaction>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AccountAdd")]
		public int AccountAdd([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Code", DbType="Int")] System.Nullable<int> code, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Type", DbType="Int")] System.Nullable<int> type, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(30)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ZipCode", DbType="NVarChar(5)")] string zipCode, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Creator", DbType="NVarChar(30)")] string creator, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Created", DbType="DateTime")] System.Nullable<System.DateTime> created, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Balance", DbType="Money")] System.Nullable<decimal> balance)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), code, type, name, zipCode, creator, created, balance);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AccountCredit")]
		public int AccountCredit([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Source", DbType="Int")] System.Nullable<int> source, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Amount", DbType="Money")] System.Nullable<decimal> amount, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Creator", DbType="NVarChar(30)")] string creator, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Created", DbType="DateTime")] System.Nullable<System.DateTime> created, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Code", DbType="Int")] ref System.Nullable<int> code)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), source, amount, creator, created, code);
			code = ((System.Nullable<int>)(result.GetParameterValue(4)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AccountDebit")]
		public int AccountDebit([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Source", DbType="Int")] System.Nullable<int> source, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Amount", DbType="Money")] System.Nullable<decimal> amount, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Creator", DbType="NVarChar(30)")] string creator, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Created", DbType="DateTime")] System.Nullable<System.DateTime> created, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Code", DbType="Int")] ref System.Nullable<int> code)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), source, amount, creator, created, code);
			code = ((System.Nullable<int>)(result.GetParameterValue(4)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AccountTransfer")]
		public int AccountTransfer([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Source", DbType="Int")] System.Nullable<int> source, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Target", DbType="Int")] System.Nullable<int> target, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Amount", DbType="Money")] System.Nullable<decimal> amount, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Creator", DbType="NVarChar(30)")] string creator, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Created", DbType="DateTime")] System.Nullable<System.DateTime> created, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Code", DbType="Int")] ref System.Nullable<int> code)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), source, target, amount, creator, created, code);
			code = ((System.Nullable<int>)(result.GetParameterValue(5)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Accounts")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private int _Type;
		
		private string _Name;
		
		private string _ZipCode;
		
		private string _Creator;
		
		private System.DateTime _Created;
		
		private System.DateTime _Updated;
		
		private decimal _Balance;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnTypeChanging(int value);
    partial void OnTypeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnZipCodeChanging(string value);
    partial void OnZipCodeChanged();
    partial void OnCreatorChanging(string value);
    partial void OnCreatorChanged();
    partial void OnCreatedChanging(System.DateTime value);
    partial void OnCreatedChanged();
    partial void OnUpdatedChanging(System.DateTime value);
    partial void OnUpdatedChanged();
    partial void OnBalanceChanging(decimal value);
    partial void OnBalanceChanged();
    #endregion
		
		public Account()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="Int NOT NULL")]
		public int Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Creator", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Creator
		{
			get
			{
				return this._Creator;
			}
			set
			{
				if ((this._Creator != value))
				{
					this.OnCreatorChanging(value);
					this.SendPropertyChanging();
					this._Creator = value;
					this.SendPropertyChanged("Creator");
					this.OnCreatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created", DbType="DateTime NOT NULL")]
		public System.DateTime Created
		{
			get
			{
				return this._Created;
			}
			set
			{
				if ((this._Created != value))
				{
					this.OnCreatedChanging(value);
					this.SendPropertyChanging();
					this._Created = value;
					this.SendPropertyChanged("Created");
					this.OnCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Updated", DbType="DateTime NOT NULL")]
		public System.DateTime Updated
		{
			get
			{
				return this._Updated;
			}
			set
			{
				if ((this._Updated != value))
				{
					this.OnUpdatedChanging(value);
					this.SendPropertyChanging();
					this._Updated = value;
					this.SendPropertyChanged("Updated");
					this.OnUpdatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Money NOT NULL")]
		public decimal Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this.OnBalanceChanging(value);
					this.SendPropertyChanging();
					this._Balance = value;
					this.SendPropertyChanged("Balance");
					this.OnBalanceChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Transactions")]
	public partial class Transaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private int _Type;
		
		private int _Source;
		
		private int _Target;
		
		private decimal _Amount;
		
		private string _Creator;
		
		private System.DateTime _Created;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnTypeChanging(int value);
    partial void OnTypeChanged();
    partial void OnSourceChanging(int value);
    partial void OnSourceChanged();
    partial void OnTargetChanging(int value);
    partial void OnTargetChanged();
    partial void OnAmountChanging(decimal value);
    partial void OnAmountChanged();
    partial void OnCreatorChanging(string value);
    partial void OnCreatorChanged();
    partial void OnCreatedChanging(System.DateTime value);
    partial void OnCreatedChanged();
    #endregion
		
		public Transaction()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="Int NOT NULL")]
		public int Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Source", DbType="Int NOT NULL")]
		public int Source
		{
			get
			{
				return this._Source;
			}
			set
			{
				if ((this._Source != value))
				{
					this.OnSourceChanging(value);
					this.SendPropertyChanging();
					this._Source = value;
					this.SendPropertyChanged("Source");
					this.OnSourceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Target", DbType="Int NOT NULL")]
		public int Target
		{
			get
			{
				return this._Target;
			}
			set
			{
				if ((this._Target != value))
				{
					this.OnTargetChanging(value);
					this.SendPropertyChanging();
					this._Target = value;
					this.SendPropertyChanged("Target");
					this.OnTargetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Money NOT NULL")]
		public decimal Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Creator", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Creator
		{
			get
			{
				return this._Creator;
			}
			set
			{
				if ((this._Creator != value))
				{
					this.OnCreatorChanging(value);
					this.SendPropertyChanging();
					this._Creator = value;
					this.SendPropertyChanged("Creator");
					this.OnCreatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created", DbType="DateTime NOT NULL")]
		public System.DateTime Created
		{
			get
			{
				return this._Created;
			}
			set
			{
				if ((this._Created != value))
				{
					this.OnCreatedChanging(value);
					this.SendPropertyChanging();
					this._Created = value;
					this.SendPropertyChanged("Created");
					this.OnCreatedChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
