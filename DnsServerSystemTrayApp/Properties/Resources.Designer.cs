﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DnsServerSystemTrayApp.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DnsServerSystemTrayApp.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to A&amp;bout.
        /// </summary>
        internal static string AboutMenuItem {
            get {
                return ResourceManager.GetString("AboutMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure to close the system tray icon?
        ///
        ///Closing the system tray icon will not stop Technitium DNS Server..
        /// </summary>
        internal static string AreYouSureYouWantToQuit {
            get {
                return ResourceManager.GetString("AreYouSureYouWantToQuit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Dashboard.
        /// </summary>
        internal static string DashboardMenuItem {
            get {
                return ResourceManager.GetString("DashboardMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to E&amp;xit.
        /// </summary>
        internal static string ExitMenuItem {
            get {
                return ResourceManager.GetString("ExitMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap logo {
            get {
                object obj = ResourceManager.GetObject("logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon logo2 {
            get {
                object obj = ResourceManager.GetObject("logo2", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Network DNS.
        /// </summary>
        internal static string NetworkDnsMenuItem {
            get {
                return ResourceManager.GetString("NetworkDnsMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Close System Tray Icon?.
        /// </summary>
        internal static string Quit {
            get {
                return ResourceManager.GetString("Quit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Service.
        /// </summary>
        internal static string ServiceMenuItem {
            get {
                return ResourceManager.GetString("ServiceMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Technitium DNS Server.
        /// </summary>
        internal static string ServiceName {
            get {
                return ResourceManager.GetString("ServiceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to R&amp;estart.
        /// </summary>
        internal static string ServiceRestartMenuItem {
            get {
                return ResourceManager.GetString("ServiceRestartMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Start.
        /// </summary>
        internal static string ServiceStartMenuItem {
            get {
                return ResourceManager.GetString("ServiceStartMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to St&amp;op.
        /// </summary>
        internal static string ServiceStopMenuItem {
            get {
                return ResourceManager.GetString("ServiceStopMenuItem", resourceCulture);
            }
        }
    }
}
