﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SensiblePOS.Backoffice.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SystemForm {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SystemForm() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SensiblePOS.Backoffice.Resources.SystemForm", typeof(SystemForm).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to เพิ่มโซนขาย.
        /// </summary>
        internal static string ADD_NEW_ZONE {
            get {
                return ResourceManager.GetString("ADD_NEW_ZONE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to บันทึกข้อมูลเรียบร้อย.
        /// </summary>
        internal static string DATA_SAVED {
            get {
                return ResourceManager.GetString("DATA_SAVED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to คุณค้องการรีเซตค่าคิวของโซน {0} หรือไม่ ?.
        /// </summary>
        internal static string DIALOG_MSG_RESET_QUEUE {
            get {
                return ResourceManager.GetString("DIALOG_MSG_RESET_QUEUE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to การจัดคิว.
        /// </summary>
        internal static string DIALOG_TITLE_RESET_QUEUE {
            get {
                return ResourceManager.GetString("DIALOG_TITLE_RESET_QUEUE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to คิวล่าสุด: {0}.
        /// </summary>
        internal static string MASK_LAST_QUEUE {
            get {
                return ResourceManager.GetString("MASK_LAST_QUEUE", resourceCulture);
            }
        }
    }
}
