﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniBug.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool GridShowBorders {
            get {
                return ((bool)(this["GridShowBorders"]));
            }
            set {
                this["GridShowBorders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("197, 197, 197")]
        public global::System.Drawing.Color GridBorderColor {
            get {
                return ((global::System.Drawing.Color)(this["GridBorderColor"]));
            }
            set {
                this["GridBorderColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("172, 212, 253")]
        public global::System.Drawing.Color GridSelectionBackColor {
            get {
                return ((global::System.Drawing.Color)(this["GridSelectionBackColor"]));
            }
            set {
                this["GridSelectionBackColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color GridSelectionForeColor {
            get {
                return ((global::System.Drawing.Color)(this["GridSelectionForeColor"]));
            }
            set {
                this["GridSelectionForeColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Segoe UI, 8.25pt")]
        public global::System.Drawing.Font GridFont {
            get {
                return ((global::System.Drawing.Font)(this["GridFont"]));
            }
            set {
                this["GridFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection RecentProjectsNames {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RecentProjectsNames"]));
            }
            set {
                this["RecentProjectsNames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection RecentProjectsPaths {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RecentProjectsPaths"]));
            }
            set {
                this["RecentProjectsPaths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool GridAlternatingRowColor {
            get {
                return ((bool)(this["GridAlternatingRowColor"]));
            }
            set {
                this["GridAlternatingRowColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color GridRowBackColor {
            get {
                return ((global::System.Drawing.Color)(this["GridRowBackColor"]));
            }
            set {
                this["GridRowBackColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color GridAlternateRowBackColor {
            get {
                return ((global::System.Drawing.Color)(this["GridAlternateRowBackColor"]));
            }
            set {
                this["GridAlternateRowBackColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int[] GridIssuesSort {
            get {
                return ((int[])(this["GridIssuesSort"]));
            }
            set {
                this["GridIssuesSort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection GridIssuesColumnsSettings {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["GridIssuesColumnsSettings"]));
            }
            set {
                this["GridIssuesColumnsSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int[] GridTasksSort {
            get {
                return ((int[])(this["GridTasksSort"]));
            }
            set {
                this["GridTasksSort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection GridTasksColumnsSettings {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["GridTasksColumnsSettings"]));
            }
            set {
                this["GridTasksColumnsSettings"] = value;
            }
        }
    }
}
