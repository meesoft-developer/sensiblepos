﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SensiblePOS.Resources {
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
    internal class FindReceiptForm {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FindReceiptForm() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SensiblePOS.Resources.FindReceiptForm", typeof(FindReceiptForm).Assembly);
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
        ///   Looks up a localized string similar to ทำรายการออก.
        /// </summary>
        internal static string checkOutReceiptStr {
            get {
                return ResourceManager.GetString("checkOutReceiptStr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to บุคคลทั่วไป.
        /// </summary>
        internal static string DEFAULT_CUSTOMER {
            get {
                return ResourceManager.GetString("DEFAULT_CUSTOMER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal error.
        /// </summary>
        internal static string DIALOG_MSG_INTERNAL_ERROR {
            get {
                return ResourceManager.GetString("DIALOG_MSG_INTERNAL_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ไม่พบข้อมูล.
        /// </summary>
        internal static string DIALOG_MSG_RECEIPT_NOT_FOUND {
            get {
                return ResourceManager.GetString("DIALOG_MSG_RECEIPT_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ดำเนินการยกเลิกใบเสร็จเรียบร้อย.
        /// </summary>
        internal static string DIALOG_MSG_VOID_DONE {
            get {
                return ResourceManager.GetString("DIALOG_MSG_VOID_DONE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to คุณต้องการยกเลิกใบเสร็จหมายเลข &apos;{0}&apos; ใช่หรือไม่?.
        /// </summary>
        internal static string DIALOG_MSG_VOID_FORM {
            get {
                return ResourceManager.GetString("DIALOG_MSG_VOID_FORM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to การค้นหาใบเสร็จ.
        /// </summary>
        internal static string DIALOG_TITLE_FIND_RECEIPT {
            get {
                return ResourceManager.GetString("DIALOG_TITLE_FIND_RECEIPT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ยกเลิกใบเสร็จ.
        /// </summary>
        internal static string DIALOG_TITLE_VOID_RECEIPT {
            get {
                return ResourceManager.GetString("DIALOG_TITLE_VOID_RECEIPT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ส่วนลด.
        /// </summary>
        internal static string DISCOUNT_TYPE {
            get {
                return ResourceManager.GetString("DISCOUNT_TYPE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to รหัสผู้ใช้งานไม่ถูกต้องหรือไม่มีสิทธิ์.
        /// </summary>
        internal static string LOGIN_CUSTOM_ERROR {
            get {
                return ResourceManager.GetString("LOGIN_CUSTOM_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ไม่พบข้อมูล Tag ในใบเสร็จที่ระบุ.
        /// </summary>
        internal static string notFoundTagStr {
            get {
                return ResourceManager.GetString("notFoundTagStr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to สินค้า.
        /// </summary>
        internal static string PRODUCT_TYPE {
            get {
                return ResourceManager.GetString("PRODUCT_TYPE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ชำระแล้ว.
        /// </summary>
        internal static string STATUS_PAID {
            get {
                return ResourceManager.GetString("STATUS_PAID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ยกเลิก.
        /// </summary>
        internal static string STATUS_VOID {
            get {
                return ResourceManager.GetString("STATUS_VOID", resourceCulture);
            }
        }
    }
}
