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
    internal class PromotionForm {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PromotionForm() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SensiblePOS.Backoffice.Resources.PromotionForm", typeof(PromotionForm).Assembly);
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
        ///   Looks up a localized string similar to เงินสด.
        /// </summary>
        internal static string PAY_METHOD_CASH {
            get {
                return ResourceManager.GetString("PAY_METHOD_CASH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ไม่ระบุ.
        /// </summary>
        internal static string PAY_METHOD_NOT_SPECIFIC {
            get {
                return ResourceManager.GetString("PAY_METHOD_NOT_SPECIFIC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to พร้อมเพย์.
        /// </summary>
        internal static string PAY_METHOD_PROMPTPAY {
            get {
                return ResourceManager.GetString("PAY_METHOD_PROMPTPAY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ไม่มี.
        /// </summary>
        internal static string TARGET_PRODUCT_NONE {
            get {
                return ResourceManager.GetString("TARGET_PRODUCT_NONE", resourceCulture);
            }
        }
    }
}
