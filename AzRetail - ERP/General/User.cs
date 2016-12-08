using System.Data;

namespace ERP.General
{
    public static class User
    {
        public static string UserName;
        public static string UserId;
        public static bool IsAdmin;
        public static bool ApiUse;
        public static DataTable UserPermission;
        public static DataTable Branch;
        public static DataTable Whouse;
        public static DataTable BranchIn;
        public static DataTable BranchOut;
        public static DataTable WhouseIn;
        public static DataTable WhouseOut;

    }
}