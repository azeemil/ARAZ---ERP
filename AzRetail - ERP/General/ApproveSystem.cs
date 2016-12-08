using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraDiagram.Utils;

namespace ERP.General
{
    class ApproveSystem
    {
        public static string LastError { get; private set; }

        public static bool AddRequest(int id, int type,int firmnr,int createdby,string value)
        {
         var approveSystem = Functions.GetSqlServerDataTable(Variables.ConnectionString, $"SELECT * FROM ERP_APPROVESYS WHERE TYPE ={type}");

            if (approveSystem.Rows.Count == 0)
            {
                LastError = "Bu tipde təsdiq sistemi mövcud deyil!";
                return false;
            }
            var approveSystemrow = approveSystem.Rows[0];

            var approveUsers = Functions.GetSqlServerDataTable(Variables.ConnectionString, $"SELECT * FROM ERP_APPROVEUSERS WHERE TYPE = {type} AND FIRMNR = {firmnr} ORDER BY ID");
            if (approveUsers.Rows.Count == 0)
            {
                LastError = "Bu tip təsdiq üçün istifadəçi mövcud deyil!";
                return false;
            }

            int appLevel = (int)approveSystemrow["LEVEL"];
            bool isFirst = true;
          
                SqlConnection con = new SqlConnection(Variables.ConnectionString);
                con.Open();
                SqlCommand command = con.CreateCommand();
                SqlTransaction tran = con.BeginTransaction();
                command.Transaction = tran;
                command.CommandText = $@"INSERT INTO ERP_PENDINGAPPROVES (FIRMNR,TYPE,LEVEL,MASTERID,RETURNED,APPROVEUSERID,ONHOLD,CREATEDBY) 
                VALUES ({firmnr},{type},{appLevel},{id},@RETURNED,@APPROVEUSERID,1,{createdby}) ";
                
                try
                {
                    foreach (DataRow row in approveUsers.Rows)
                    {
                        command.Parameters.Clear();                        
                        command.Parameters.AddWithValue("@RETURNED", value);
                        command.Parameters.AddWithValue("@APPROVEUSERID", row["USERID"]);
                    if (appLevel == 0 || appLevel == 1) command.Parameters.AddWithValue("@ONHOLD", true);
                    else
                    {
                         command.Parameters.AddWithValue("@ONHOLD", isFirst);
                         isFirst = false;
                    }

                        command.ExecuteNonQuery();

                    }
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    LastError = ex.Message;
                    return false;
                }
                finally { con.Close(); }
            

            return true;
        }

        public static bool SetApproved(int id ,bool status,int approvedUser,string explanation){
            var pendingApproves = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                $@"SELECT * FROM ERP_PENDINGAPPROVES WHERE MASTERID={id} ORDER BY ID");
            if (!pendingApproves.Select($"APPROVEUSERID={approvedUser}").Any())
            {
                LastError = "Müraciət mövcud deyil!";
                return false;
            }

            DataRow row = pendingApproves.Select($"APPROVEUSERID={approvedUser}").CopyToDataTable().Rows[0];
            if ((bool) row["CANCELLED"])
            {
                LastError = "Müraciət artıq ləğv olunub!";
                return false;
            }
            if ((bool)row["STATUS"])
            {
                LastError = "Müraciət artıq təsdiqlənib!";
                return false;
            }

            if (!Functions.ExecuteStatement(Variables.ConnectionString,
                string.Format(@"UPDATE ERP_PENDINGAPPROVES SET {1},EXPLANATION = N'{2}' WHERE ID={0}", row["ID"],
                    (status) ? "STATUS = 1" : "CANCELLED = 1", explanation)))
                return false;

            return true;
        }

    }
}
