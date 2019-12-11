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

namespace CM.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CAFEMANAGEMENT")]
	public partial class CMDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertACCOUNT(ACCOUNT instance);
    partial void UpdateACCOUNT(ACCOUNT instance);
    partial void DeleteACCOUNT(ACCOUNT instance);
    partial void InsertBILL(BILL instance);
    partial void UpdateBILL(BILL instance);
    partial void DeleteBILL(BILL instance);
    partial void InsertCUSTOMER(CUSTOMER instance);
    partial void UpdateCUSTOMER(CUSTOMER instance);
    partial void DeleteCUSTOMER(CUSTOMER instance);
    partial void InsertEMPLOYEE(EMPLOYEE instance);
    partial void UpdateEMPLOYEE(EMPLOYEE instance);
    partial void DeleteEMPLOYEE(EMPLOYEE instance);
    partial void InsertPRODUCT(PRODUCT instance);
    partial void UpdatePRODUCT(PRODUCT instance);
    partial void DeletePRODUCT(PRODUCT instance);
    partial void InsertPRODUCT_BILL(PRODUCT_BILL instance);
    partial void UpdatePRODUCT_BILL(PRODUCT_BILL instance);
    partial void DeletePRODUCT_BILL(PRODUCT_BILL instance);
    partial void InsertPRODUCTTYPE(PRODUCTTYPE instance);
    partial void UpdatePRODUCTTYPE(PRODUCTTYPE instance);
    partial void DeletePRODUCTTYPE(PRODUCTTYPE instance);
    #endregion
		
		public CMDataContext() : 
				base(global::CM.DAL.Properties.Settings.Default.CAFEMANAGEMENTConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public CMDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CMDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CMDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CMDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ACCOUNT> ACCOUNTs
		{
			get
			{
				return this.GetTable<ACCOUNT>();
			}
		}
		
		public System.Data.Linq.Table<BILL> BILLs
		{
			get
			{
				return this.GetTable<BILL>();
			}
		}
		
		public System.Data.Linq.Table<CUSTOMER> CUSTOMERs
		{
			get
			{
				return this.GetTable<CUSTOMER>();
			}
		}
		
		public System.Data.Linq.Table<EMPLOYEE> EMPLOYEEs
		{
			get
			{
				return this.GetTable<EMPLOYEE>();
			}
		}
		
		public System.Data.Linq.Table<PRODUCT> PRODUCTs
		{
			get
			{
				return this.GetTable<PRODUCT>();
			}
		}
		
		public System.Data.Linq.Table<PRODUCT_BILL> PRODUCT_BILLs
		{
			get
			{
				return this.GetTable<PRODUCT_BILL>();
			}
		}
		
		public System.Data.Linq.Table<PRODUCTTYPE> PRODUCTTYPEs
		{
			get
			{
				return this.GetTable<PRODUCTTYPE>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ACCOUNT")]
	public partial class ACCOUNT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _DisplayName;
		
		private string _UserName;
		
		private string _PassWord;
		
		private System.Nullable<int> _AccountType;
		
		private string _EmployeeId;
		
		private EntityRef<EMPLOYEE> _EMPLOYEE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnDisplayNameChanging(string value);
    partial void OnDisplayNameChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPassWordChanging(string value);
    partial void OnPassWordChanged();
    partial void OnAccountTypeChanging(System.Nullable<int> value);
    partial void OnAccountTypeChanged();
    partial void OnEmployeeIdChanging(string value);
    partial void OnEmployeeIdChanged();
    #endregion
		
		public ACCOUNT()
		{
			this._EMPLOYEE = default(EntityRef<EMPLOYEE>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DisplayName", DbType="NVarChar(100)")]
		public string DisplayName
		{
			get
			{
				return this._DisplayName;
			}
			set
			{
				if ((this._DisplayName != value))
				{
					this.OnDisplayNameChanging(value);
					this.SendPropertyChanging();
					this._DisplayName = value;
					this.SendPropertyChanged("DisplayName");
					this.OnDisplayNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassWord", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string PassWord
		{
			get
			{
				return this._PassWord;
			}
			set
			{
				if ((this._PassWord != value))
				{
					this.OnPassWordChanging(value);
					this.SendPropertyChanging();
					this._PassWord = value;
					this.SendPropertyChanged("PassWord");
					this.OnPassWordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountType", DbType="Int")]
		public System.Nullable<int> AccountType
		{
			get
			{
				return this._AccountType;
			}
			set
			{
				if ((this._AccountType != value))
				{
					this.OnAccountTypeChanging(value);
					this.SendPropertyChanging();
					this._AccountType = value;
					this.SendPropertyChanged("AccountType");
					this.OnAccountTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="Char(5) NOT NULL", CanBeNull=false)]
		public string EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					if (this._EMPLOYEE.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EMPLOYEE_ACCOUNT", Storage="_EMPLOYEE", ThisKey="EmployeeId", OtherKey="Id", IsForeignKey=true)]
		public EMPLOYEE EMPLOYEE
		{
			get
			{
				return this._EMPLOYEE.Entity;
			}
			set
			{
				EMPLOYEE previousValue = this._EMPLOYEE.Entity;
				if (((previousValue != value) 
							|| (this._EMPLOYEE.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EMPLOYEE.Entity = null;
						previousValue.ACCOUNTs.Remove(this);
					}
					this._EMPLOYEE.Entity = value;
					if ((value != null))
					{
						value.ACCOUNTs.Add(this);
						this._EmployeeId = value.Id;
					}
					else
					{
						this._EmployeeId = default(string);
					}
					this.SendPropertyChanged("EMPLOYEE");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BILL")]
	public partial class BILL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private System.Nullable<System.DateTime> _DateCreated;
		
		private string _EmployeeId;
		
		private string _CustomerId;
		
		private System.Nullable<decimal> _Total;
		
		private EntitySet<PRODUCT_BILL> _PRODUCT_BILLs;
		
		private EntityRef<CUSTOMER> _CUSTOMER;
		
		private EntityRef<EMPLOYEE> _EMPLOYEE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnDateCreatedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateCreatedChanged();
    partial void OnEmployeeIdChanging(string value);
    partial void OnEmployeeIdChanged();
    partial void OnCustomerIdChanging(string value);
    partial void OnCustomerIdChanged();
    partial void OnTotalChanging(System.Nullable<decimal> value);
    partial void OnTotalChanged();
    #endregion
		
		public BILL()
		{
			this._PRODUCT_BILLs = new EntitySet<PRODUCT_BILL>(new Action<PRODUCT_BILL>(this.attach_PRODUCT_BILLs), new Action<PRODUCT_BILL>(this.detach_PRODUCT_BILLs));
			this._CUSTOMER = default(EntityRef<CUSTOMER>);
			this._EMPLOYEE = default(EntityRef<EMPLOYEE>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Char(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._DateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="Char(5)")]
		public string EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					if (this._EMPLOYEE.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", DbType="Char(5)")]
		public string CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					if (this._CUSTOMER.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Money")]
		public System.Nullable<decimal> Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				if ((this._Total != value))
				{
					this.OnTotalChanging(value);
					this.SendPropertyChanging();
					this._Total = value;
					this.SendPropertyChanged("Total");
					this.OnTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BILL_PRODUCT_BILL", Storage="_PRODUCT_BILLs", ThisKey="Id", OtherKey="BillId")]
		public EntitySet<PRODUCT_BILL> PRODUCT_BILLs
		{
			get
			{
				return this._PRODUCT_BILLs;
			}
			set
			{
				this._PRODUCT_BILLs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CUSTOMER_BILL", Storage="_CUSTOMER", ThisKey="CustomerId", OtherKey="Id", IsForeignKey=true)]
		public CUSTOMER CUSTOMER
		{
			get
			{
				return this._CUSTOMER.Entity;
			}
			set
			{
				CUSTOMER previousValue = this._CUSTOMER.Entity;
				if (((previousValue != value) 
							|| (this._CUSTOMER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CUSTOMER.Entity = null;
						previousValue.BILLs.Remove(this);
					}
					this._CUSTOMER.Entity = value;
					if ((value != null))
					{
						value.BILLs.Add(this);
						this._CustomerId = value.Id;
					}
					else
					{
						this._CustomerId = default(string);
					}
					this.SendPropertyChanged("CUSTOMER");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EMPLOYEE_BILL", Storage="_EMPLOYEE", ThisKey="EmployeeId", OtherKey="Id", IsForeignKey=true)]
		public EMPLOYEE EMPLOYEE
		{
			get
			{
				return this._EMPLOYEE.Entity;
			}
			set
			{
				EMPLOYEE previousValue = this._EMPLOYEE.Entity;
				if (((previousValue != value) 
							|| (this._EMPLOYEE.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EMPLOYEE.Entity = null;
						previousValue.BILLs.Remove(this);
					}
					this._EMPLOYEE.Entity = value;
					if ((value != null))
					{
						value.BILLs.Add(this);
						this._EmployeeId = value.Id;
					}
					else
					{
						this._EmployeeId = default(string);
					}
					this.SendPropertyChanged("EMPLOYEE");
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
		
		private void attach_PRODUCT_BILLs(PRODUCT_BILL entity)
		{
			this.SendPropertyChanging();
			entity.BILL = this;
		}
		
		private void detach_PRODUCT_BILLs(PRODUCT_BILL entity)
		{
			this.SendPropertyChanging();
			entity.BILL = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CUSTOMER")]
	public partial class CUSTOMER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Name;
		
		private System.Nullable<System.DateTime> _Birthday;
		
		private EntitySet<BILL> _BILLs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnBirthdayChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthdayChanged();
    #endregion
		
		public CUSTOMER()
		{
			this._BILLs = new EntitySet<BILL>(new Action<BILL>(this.attach_BILLs), new Action<BILL>(this.detach_BILLs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="Char(30)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthday", DbType="DateTime")]
		public System.Nullable<System.DateTime> Birthday
		{
			get
			{
				return this._Birthday;
			}
			set
			{
				if ((this._Birthday != value))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._Birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CUSTOMER_BILL", Storage="_BILLs", ThisKey="Id", OtherKey="CustomerId")]
		public EntitySet<BILL> BILLs
		{
			get
			{
				return this._BILLs;
			}
			set
			{
				this._BILLs.Assign(value);
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
		
		private void attach_BILLs(BILL entity)
		{
			this.SendPropertyChanging();
			entity.CUSTOMER = this;
		}
		
		private void detach_BILLs(BILL entity)
		{
			this.SendPropertyChanging();
			entity.CUSTOMER = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EMPLOYEE")]
	public partial class EMPLOYEE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Name;
		
		private System.Nullable<System.DateTime> _Birthday;
		
		private System.Nullable<System.DateTime> _Daystart;
		
		private System.Nullable<bool> _Gender;
		
		private string _PhoneNumber;
		
		private string _Email;
		
		private EntitySet<ACCOUNT> _ACCOUNTs;
		
		private EntitySet<BILL> _BILLs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnBirthdayChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthdayChanged();
    partial void OnDaystartChanging(System.Nullable<System.DateTime> value);
    partial void OnDaystartChanged();
    partial void OnGenderChanging(System.Nullable<bool> value);
    partial void OnGenderChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public EMPLOYEE()
		{
			this._ACCOUNTs = new EntitySet<ACCOUNT>(new Action<ACCOUNT>(this.attach_ACCOUNTs), new Action<ACCOUNT>(this.detach_ACCOUNTs));
			this._BILLs = new EntitySet<BILL>(new Action<BILL>(this.attach_BILLs), new Action<BILL>(this.detach_BILLs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(30)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthday", DbType="DateTime")]
		public System.Nullable<System.DateTime> Birthday
		{
			get
			{
				return this._Birthday;
			}
			set
			{
				if ((this._Birthday != value))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._Birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Daystart", DbType="DateTime")]
		public System.Nullable<System.DateTime> Daystart
		{
			get
			{
				return this._Daystart;
			}
			set
			{
				if ((this._Daystart != value))
				{
					this.OnDaystartChanging(value);
					this.SendPropertyChanging();
					this._Daystart = value;
					this.SendPropertyChanged("Daystart");
					this.OnDaystartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Bit")]
		public System.Nullable<bool> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(10)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(30)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EMPLOYEE_ACCOUNT", Storage="_ACCOUNTs", ThisKey="Id", OtherKey="EmployeeId")]
		public EntitySet<ACCOUNT> ACCOUNTs
		{
			get
			{
				return this._ACCOUNTs;
			}
			set
			{
				this._ACCOUNTs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EMPLOYEE_BILL", Storage="_BILLs", ThisKey="Id", OtherKey="EmployeeId")]
		public EntitySet<BILL> BILLs
		{
			get
			{
				return this._BILLs;
			}
			set
			{
				this._BILLs.Assign(value);
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
		
		private void attach_ACCOUNTs(ACCOUNT entity)
		{
			this.SendPropertyChanging();
			entity.EMPLOYEE = this;
		}
		
		private void detach_ACCOUNTs(ACCOUNT entity)
		{
			this.SendPropertyChanging();
			entity.EMPLOYEE = null;
		}
		
		private void attach_BILLs(BILL entity)
		{
			this.SendPropertyChanging();
			entity.EMPLOYEE = this;
		}
		
		private void detach_BILLs(BILL entity)
		{
			this.SendPropertyChanging();
			entity.EMPLOYEE = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PRODUCT")]
	public partial class PRODUCT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Name;
		
		private string _ProductId;
		
		private System.Nullable<decimal> _Price;
		
		private string _Description;
		
		private System.Nullable<bool> _IsTopping;
		
		private EntitySet<PRODUCT_BILL> _PRODUCT_BILLs;
		
		private EntityRef<PRODUCTTYPE> _PRODUCTTYPE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnProductIdChanging(string value);
    partial void OnProductIdChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnIsToppingChanging(System.Nullable<bool> value);
    partial void OnIsToppingChanged();
    #endregion
		
		public PRODUCT()
		{
			this._PRODUCT_BILLs = new EntitySet<PRODUCT_BILL>(new Action<PRODUCT_BILL>(this.attach_PRODUCT_BILLs), new Action<PRODUCT_BILL>(this.detach_PRODUCT_BILLs));
			this._PRODUCTTYPE = default(EntityRef<PRODUCTTYPE>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Char(4)")]
		public string ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._PRODUCTTYPE.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(500)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsTopping", DbType="Bit")]
		public System.Nullable<bool> IsTopping
		{
			get
			{
				return this._IsTopping;
			}
			set
			{
				if ((this._IsTopping != value))
				{
					this.OnIsToppingChanging(value);
					this.SendPropertyChanging();
					this._IsTopping = value;
					this.SendPropertyChanged("IsTopping");
					this.OnIsToppingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PRODUCT_PRODUCT_BILL", Storage="_PRODUCT_BILLs", ThisKey="Id", OtherKey="ProductId")]
		public EntitySet<PRODUCT_BILL> PRODUCT_BILLs
		{
			get
			{
				return this._PRODUCT_BILLs;
			}
			set
			{
				this._PRODUCT_BILLs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PRODUCTTYPE_PRODUCT", Storage="_PRODUCTTYPE", ThisKey="ProductId", OtherKey="Id", IsForeignKey=true)]
		public PRODUCTTYPE PRODUCTTYPE
		{
			get
			{
				return this._PRODUCTTYPE.Entity;
			}
			set
			{
				PRODUCTTYPE previousValue = this._PRODUCTTYPE.Entity;
				if (((previousValue != value) 
							|| (this._PRODUCTTYPE.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PRODUCTTYPE.Entity = null;
						previousValue.PRODUCTs.Remove(this);
					}
					this._PRODUCTTYPE.Entity = value;
					if ((value != null))
					{
						value.PRODUCTs.Add(this);
						this._ProductId = value.Id;
					}
					else
					{
						this._ProductId = default(string);
					}
					this.SendPropertyChanged("PRODUCTTYPE");
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
		
		private void attach_PRODUCT_BILLs(PRODUCT_BILL entity)
		{
			this.SendPropertyChanging();
			entity.PRODUCT = this;
		}
		
		private void detach_PRODUCT_BILLs(PRODUCT_BILL entity)
		{
			this.SendPropertyChanging();
			entity.PRODUCT = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PRODUCT_BILL")]
	public partial class PRODUCT_BILL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _BillId;
		
		private string _ProductId;
		
		private System.Nullable<int> _Amount;
		
		private EntityRef<BILL> _BILL;
		
		private EntityRef<PRODUCT> _PRODUCT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBillIdChanging(string value);
    partial void OnBillIdChanged();
    partial void OnProductIdChanging(string value);
    partial void OnProductIdChanged();
    partial void OnAmountChanging(System.Nullable<int> value);
    partial void OnAmountChanged();
    #endregion
		
		public PRODUCT_BILL()
		{
			this._BILL = default(EntityRef<BILL>);
			this._PRODUCT = default(EntityRef<PRODUCT>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillId", DbType="Char(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string BillId
		{
			get
			{
				return this._BillId;
			}
			set
			{
				if ((this._BillId != value))
				{
					if (this._BILL.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBillIdChanging(value);
					this.SendPropertyChanging();
					this._BillId = value;
					this.SendPropertyChanged("BillId");
					this.OnBillIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._PRODUCT.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Int")]
		public System.Nullable<int> Amount
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BILL_PRODUCT_BILL", Storage="_BILL", ThisKey="BillId", OtherKey="Id", IsForeignKey=true)]
		public BILL BILL
		{
			get
			{
				return this._BILL.Entity;
			}
			set
			{
				BILL previousValue = this._BILL.Entity;
				if (((previousValue != value) 
							|| (this._BILL.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BILL.Entity = null;
						previousValue.PRODUCT_BILLs.Remove(this);
					}
					this._BILL.Entity = value;
					if ((value != null))
					{
						value.PRODUCT_BILLs.Add(this);
						this._BillId = value.Id;
					}
					else
					{
						this._BillId = default(string);
					}
					this.SendPropertyChanged("BILL");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PRODUCT_PRODUCT_BILL", Storage="_PRODUCT", ThisKey="ProductId", OtherKey="Id", IsForeignKey=true)]
		public PRODUCT PRODUCT
		{
			get
			{
				return this._PRODUCT.Entity;
			}
			set
			{
				PRODUCT previousValue = this._PRODUCT.Entity;
				if (((previousValue != value) 
							|| (this._PRODUCT.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PRODUCT.Entity = null;
						previousValue.PRODUCT_BILLs.Remove(this);
					}
					this._PRODUCT.Entity = value;
					if ((value != null))
					{
						value.PRODUCT_BILLs.Add(this);
						this._ProductId = value.Id;
					}
					else
					{
						this._ProductId = default(string);
					}
					this.SendPropertyChanged("PRODUCT");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PRODUCTTYPE")]
	public partial class PRODUCTTYPE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Name;
		
		private EntitySet<PRODUCT> _PRODUCTs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public PRODUCTTYPE()
		{
			this._PRODUCTs = new EntitySet<PRODUCT>(new Action<PRODUCT>(this.attach_PRODUCTs), new Action<PRODUCT>(this.detach_PRODUCTs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Char(4) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PRODUCTTYPE_PRODUCT", Storage="_PRODUCTs", ThisKey="Id", OtherKey="ProductId")]
		public EntitySet<PRODUCT> PRODUCTs
		{
			get
			{
				return this._PRODUCTs;
			}
			set
			{
				this._PRODUCTs.Assign(value);
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
		
		private void attach_PRODUCTs(PRODUCT entity)
		{
			this.SendPropertyChanging();
			entity.PRODUCTTYPE = this;
		}
		
		private void detach_PRODUCTs(PRODUCT entity)
		{
			this.SendPropertyChanging();
			entity.PRODUCTTYPE = null;
		}
	}
}
#pragma warning restore 1591
