﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TagBot.App.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string startingDirectory {
            get {
                return ((string)(this["startingDirectory"]));
            }
            set {
                this["startingDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string databaseLocation {
            get {
                return ((string)(this["databaseLocation"]));
            }
            set {
                this["databaseLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%d - %v - %c, %s")]
        public string albumFormatterString {
            get {
                return ((string)(this["albumFormatterString"]));
            }
            set {
                this["albumFormatterString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("yyyy-MM-dd")]
        public string customDateFormatter {
            get {
                return ((string)(this["customDateFormatter"]));
            }
            set {
                this["customDateFormatter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{\"dmb\":\"Dave Matthews Band\",\"dm\":\"Dave Matthews\",\"d&t\":\"Dave Matthews\",\"d&f\":\"Dav" +
            "e Matthews\"}")]
        public string artistTransformation {
            get {
                return ((string)(this["artistTransformation"]));
            }
            set {
                this["artistTransformation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%t %0[%m]%0")]
        public string titleFormatterString {
            get {
                return ((string)(this["titleFormatterString"]));
            }
            set {
                this["titleFormatterString"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/Syco54645/TagBot")]
        public string applicationRepo {
            get {
                return ((string)(this["applicationRepo"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%d - %v - %c, %s")]
        public string defaultAlbumFormatterString {
            get {
                return ((string)(this["defaultAlbumFormatterString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("yyyy-MM-dd")]
        public string defaultCustomDateFormatter {
            get {
                return ((string)(this["defaultCustomDateFormatter"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%t %0[%m]%0")]
        public string defaultTitleFormatterString {
            get {
                return ((string)(this["defaultTitleFormatterString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{\"dmb\":\"Dave Matthews Band\",\"dm\":\"Dave Matthews\",\"d&t\":\"Dave Matthews\",\"d&f\":\"Dav" +
            "e Matthews\"}")]
        public string defaultArtistTransformation {
            get {
                return ((string)(this["defaultArtistTransformation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.0.0")]
        public string requiredDatabaseMeta {
            get {
                return ((string)(this["requiredDatabaseMeta"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool enableMp3 {
            get {
                return ((bool)(this["enableMp3"]));
            }
            set {
                this["enableMp3"] = value;
            }
        }
    }
}
