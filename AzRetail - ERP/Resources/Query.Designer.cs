﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ERP.Resources {
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode()]
    [CompilerGenerated()]
    public class Query {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Query() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static ResourceManager ResourceManager {
            get {
                if (ReferenceEquals(resourceMan, null)) {
                    ResourceManager temp = new ResourceManager("ERP.Resources.Query", typeof(Query).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE ERP_PERMISSIONS
        ///(
        ///ID INT IDENTITY(1,1),
        ///FIRMNR INT,
        ///MASTERID INT,
        ///[TYPE] INT,
        ///[LEVEL] INT,
        ///PERMISSION VARBINARY(MAX),
        ///DESCRIPTION NVARCHAR(20)
        ///).
        /// </summary>
        public static string CreatePermission {
            get {
                return ResourceManager.GetString("CreatePermission", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE ERP_USERS 
        ///(
        ///ID INT IDENTITY(1,1),
        ///USERNAME NVARCHAR (51) UNIQUE,
        ///DISPLAYNAME NVARCHAR(51),
        ///FIRSTNAME NVARCHAR(21),
        ///LASTNAME NVARCHAR(30),
        ///EMAIL NVARCHAR(51),
        ///ACTIV  BIT,
        ///ISADMIN BIT,
        ///LOBJECT BIT,
        ///RECUSER NVARCHAR(51),
        ///RECDATE DATETIME
        ///).
        /// </summary>
        public static string CreateUsers {
            get {
                return ResourceManager.GetString("CreateUsers", resourceCulture);
            }
        }
    }
}