using System;
using System.Data;
using System.IO;
using UnityObjects;

namespace ERP.General

{
    internal class Variables
    {

        public static string ConnectionString = @"Data Source='LSTARAZ01.retail.local';Application Name='ARAZ ERP';Initial Catalog='ARAZERP';User ID='terminal';Password='texnologiya252'";
        public static string TigerConnection = @"Data Source='LSTARAZ01.retail.local';Application Name='ARAZ ERP';Initial Catalog='ARAZ';User ID='terminal';Password='texnologiya252'";
        public static string TigerUser;
        public static string TigerPasssword;
        public static UnityApplicationClass UnityApplication = new UnityApplicationClass();
        public static bool ExitMode;
        public static MainForm MForm;

        public static string ApplicationPath
        {
            get
            {
                return Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            }
        }
        public static string ConfigPath
        {
            get
            {

                return Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "CONFIG.TXT");
            }
        }
        public static string FirmNr;
        public static string FirmDb;
        public static string FirmName;
        public static string FirmPeriod;
        public static string WindowsUserName;
        public static DateTime OperationDate;
       
        public static DataTable AllPermissions = new DataTable();
        public static DataTable Whouse = new DataTable();
        public static DataTable Branch = new DataTable();
        public static string BranchFiltrString;
        public static string WhouseFiltrString;
        public static string BranchFiltrStringIn;
        public static string WhouseFiltrStringIn;
        public static string BranchFiltrStringOut;
        public static string WhouseFiltrStringOut;
        public static string TigerUserName = "ERP";
        public static string TigerUserPassword = "ERPUSER";
    }
}