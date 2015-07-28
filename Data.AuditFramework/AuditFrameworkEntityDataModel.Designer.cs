﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace CodeCharm.Data.AuditFramework
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AuditFrameworkEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AuditFrameworkEntities object using the connection string found in the 'AuditFrameworkEntities' section of the application configuration file.
        /// </summary>
        public AuditFrameworkEntities() : base("name=AuditFrameworkEntities", "AuditFrameworkEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AuditFrameworkEntities object.
        /// </summary>
        public AuditFrameworkEntities(string connectionString) : base(connectionString, "AuditFrameworkEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AuditFrameworkEntities object.
        /// </summary>
        public AuditFrameworkEntities(EntityConnection connection) : base(connection, "AuditFrameworkEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ActionCode> ActionCodes
        {
            get
            {
                if ((_ActionCodes == null))
                {
                    _ActionCodes = base.CreateObjectSet<ActionCode>("ActionCodes");
                }
                return _ActionCodes;
            }
        }
        private ObjectSet<ActionCode> _ActionCodes;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Catalog> Catalogs
        {
            get
            {
                if ((_Catalogs == null))
                {
                    _Catalogs = base.CreateObjectSet<Catalog>("Catalogs");
                }
                return _Catalogs;
            }
        }
        private ObjectSet<Catalog> _Catalogs;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ActionCodes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToActionCodes(ActionCode actionCode)
        {
            base.AddObject("ActionCodes", actionCode);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Catalogs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCatalogs(Catalog catalog)
        {
            base.AddObject("Catalogs", catalog);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AuditFrameworkModel", Name="ActionCode")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ActionCode : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ActionCode object.
        /// </summary>
        /// <param name="code">Initial value of the Code property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        public static ActionCode CreateActionCode(global::System.String code, global::System.String description)
        {
            ActionCode actionCode = new ActionCode();
            actionCode.Code = code;
            actionCode.Description = description;
            return actionCode;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Code
        {
            get
            {
                return _Code;
            }
            set
            {
                if (_Code != value)
                {
                    OnCodeChanging(value);
                    ReportPropertyChanging("Code");
                    _Code = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Code");
                    OnCodeChanged();
                }
            }
        }
        private global::System.String _Code;
        partial void OnCodeChanging(global::System.String value);
        partial void OnCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AuditFrameworkModel", Name="Catalog")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Catalog : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Catalog object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="auditedSchema">Initial value of the AuditedSchema property.</param>
        /// <param name="auditedTableName">Initial value of the AuditedTableName property.</param>
        /// <param name="version">Initial value of the Version property.</param>
        /// <param name="auditingTableName">Initial value of the AuditingTableName property.</param>
        /// <param name="archived">Initial value of the Archived property.</param>
        public static Catalog CreateCatalog(global::System.Int32 id, global::System.String auditedSchema, global::System.String auditedTableName, global::System.Int32 version, global::System.String auditingTableName, global::System.Boolean archived)
        {
            Catalog catalog = new Catalog();
            catalog.Id = id;
            catalog.AuditedSchema = auditedSchema;
            catalog.AuditedTableName = auditedTableName;
            catalog.Version = version;
            catalog.AuditingTableName = auditingTableName;
            catalog.Archived = archived;
            return catalog;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AuditedSchema
        {
            get
            {
                return _AuditedSchema;
            }
            set
            {
                OnAuditedSchemaChanging(value);
                ReportPropertyChanging("AuditedSchema");
                _AuditedSchema = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("AuditedSchema");
                OnAuditedSchemaChanged();
            }
        }
        private global::System.String _AuditedSchema;
        partial void OnAuditedSchemaChanging(global::System.String value);
        partial void OnAuditedSchemaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AuditedTableName
        {
            get
            {
                return _AuditedTableName;
            }
            set
            {
                OnAuditedTableNameChanging(value);
                ReportPropertyChanging("AuditedTableName");
                _AuditedTableName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("AuditedTableName");
                OnAuditedTableNameChanged();
            }
        }
        private global::System.String _AuditedTableName;
        partial void OnAuditedTableNameChanging(global::System.String value);
        partial void OnAuditedTableNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Version
        {
            get
            {
                return _Version;
            }
            set
            {
                OnVersionChanging(value);
                ReportPropertyChanging("Version");
                _Version = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Version");
                OnVersionChanged();
            }
        }
        private global::System.Int32 _Version;
        partial void OnVersionChanging(global::System.Int32 value);
        partial void OnVersionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AuditingTableName
        {
            get
            {
                return _AuditingTableName;
            }
            set
            {
                OnAuditingTableNameChanging(value);
                ReportPropertyChanging("AuditingTableName");
                _AuditingTableName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("AuditingTableName");
                OnAuditingTableNameChanged();
            }
        }
        private global::System.String _AuditingTableName;
        partial void OnAuditingTableNameChanging(global::System.String value);
        partial void OnAuditingTableNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Archived
        {
            get
            {
                return _Archived;
            }
            set
            {
                OnArchivedChanging(value);
                ReportPropertyChanging("Archived");
                _Archived = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Archived");
                OnArchivedChanged();
            }
        }
        private global::System.Boolean _Archived;
        partial void OnArchivedChanging(global::System.Boolean value);
        partial void OnArchivedChanged();

        #endregion

    
    }

    #endregion

    
}
