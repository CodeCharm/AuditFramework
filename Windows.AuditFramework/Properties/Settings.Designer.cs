﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeCharm.Windows.AuditFramework.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("db_audit")]
        public string AuditingSchema {
            get {
                return ((string)(this["AuditingSchema"]));
            }
            set {
                this["AuditingSchema"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{AuditedSchema}º{TableName}")]
        public string AuditTableFormat {
            get {
                return ((string)(this["AuditTableFormat"]));
            }
            set {
                this["AuditTableFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AlwaysRecreateAuditingSupport {
            get {
                return ((bool)(this["AlwaysRecreateAuditingSupport"]));
            }
            set {
                this["AlwaysRecreateAuditingSupport"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("AUDIT")]
        public string AuditingFilegroup {
            get {
                return ((string)(this["AuditingFilegroup"]));
            }
            set {
                this["AuditingFilegroup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RemoveAll {
            get {
                return ((bool)(this["RemoveAll"]));
            }
            set {
                this["RemoveAll"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TrackByPrimaryKeys {
            get {
                return ((bool)(this["TrackByPrimaryKeys"]));
            }
            set {
                this["TrackByPrimaryKeys"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>dbo</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection SchemasToAudit {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SchemasToAudit"]));
            }
            set {
                this["SchemasToAudit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>AuditTrail</string>
  <string>dtproperties</string>
  <string>__RefactorLog</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection TablesNotAudited {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["TablesNotAudited"]));
            }
            set {
                this["TablesNotAudited"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>SystemUser</string>\r\n  <string>AuthorityName</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ColumnsNotStoredInAudit {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ColumnsNotStoredInAudit"]));
            }
            set {
                this["ColumnsNotStoredInAudit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>ProcExec</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ExecuteGrantees {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ExecuteGrantees"]));
            }
            set {
                this["ExecuteGrantees"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=;Initial Catalog=;Integrated Security=True")]
        public string AuditingDatabaseConnectionString {
            get {
                return ((string)(this["AuditingDatabaseConnectionString"]));
            }
            set {
                this["AuditingDatabaseConnectionString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoDeployToDatabase {
            get {
                return ((bool)(this["AutoDeployToDatabase"]));
            }
            set {
                this["AutoDeployToDatabase"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%LOCALAPPDATA%\\AuditLogs")]
        public string OutputPath {
            get {
                return ((string)(this["OutputPath"]));
            }
            set {
                this["OutputPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool GenerateBaseline {
            get {
                return ((bool)(this["GenerateBaseline"]));
            }
            set {
                this["GenerateBaseline"] = value;
            }
        }
    }
}
