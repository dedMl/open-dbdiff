﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBDiff.Schema.SQLServer.Generates.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("sa")]
        public string SQLServerUserOrigin {
            get {
                return ((string)(this["SQLServerUserOrigin"]));
            }
            set {
                this["SQLServerUserOrigin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("sa")]
        public string SQLServerUserDestination {
            get {
                return ((string)(this["SQLServerUserDestination"]));
            }
            set {
                this["SQLServerUserDestination"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int SQLServerConnectionTypeOrigin {
            get {
                return ((int)(this["SQLServerConnectionTypeOrigin"]));
            }
            set {
                this["SQLServerConnectionTypeOrigin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int SQLServerConnectionTypeDestination {
            get {
                return ((int)(this["SQLServerConnectionTypeDestination"]));
            }
            set {
                this["SQLServerConnectionTypeDestination"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SQLServerNameOrigin {
            get {
                return ((string)(this["SQLServerNameOrigin"]));
            }
            set {
                this["SQLServerNameOrigin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SQLServerNameDestination {
            get {
                return ((string)(this["SQLServerNameDestination"]));
            }
            set {
                this["SQLServerNameDestination"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int SQLServerDatabaseOrigin {
            get {
                return ((int)(this["SQLServerDatabaseOrigin"]));
            }
            set {
                this["SQLServerDatabaseOrigin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int SQLServerDatabaseDestination {
            get {
                return ((int)(this["SQLServerDatabaseDestination"]));
            }
            set {
                this["SQLServerDatabaseDestination"] = value;
            }
        }
    }
}