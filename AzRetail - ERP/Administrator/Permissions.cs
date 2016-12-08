using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using ERP.General;

namespace ERP.Administrator
{
    public partial class Permissions : XtraForm
    
    {
        public int PermissionType { get; set; }
        public int MasterId { get; set; }
        private DataSet ds;
        private DataTable general;
        private DataTable permissions;
        private DataTable Whouses ;
        private DataTable Branches;
        private DataTable BWPermissions = new DataTable();

        public int FirmNr { get; set; }

        void SelectBranchWhouse()
        {
            var command = string.Format("SELECT NR,NAME,CAST(0 AS BIT) PERMISSION FROM L_CAPIDIV WHERE FIRMNR = {0} ;" +
                                      "SELECT NR,NAME,CAST(0 AS BIT) PERMISSION FROM L_CAPIWHOUSE WHERE FIRMNR = {0}",
                                     FirmNr);
            DataSet dataSet = Functions.GetSqlServerDataset(Variables.TigerConnection, command);

            Branches = dataSet.Tables[0];
            Whouses = dataSet.Tables[1];
        }
        public Permissions()
        {

            InitializeComponent();
            tree.Columns[0].Visible = false;
            tree.Columns[1].OptionsColumn.AllowEdit = false;
            tree.Columns[1].OptionsColumn.AllowFocus = false;
            tree.Columns[2].OptionsColumn.ReadOnly = false;

           

            BWPermissions.Columns.Add("TYPE", typeof (int));
            BWPermissions.Columns.Add("TYPENAME", typeof(string));
            BWPermissions.Columns.Add("NR", typeof(int));
            BWPermissions.Columns.Add("NAME", typeof(string));
            BWPermissions.Columns.Add("STATUS", typeof(bool));
            BWPermissions.Columns["STATUS"].AllowDBNull = true;
        }

        void SetBWPermissions()
        {
            
            if (permissions.Select("LEVEL=1").Any())
            {
               
              var per = GetLevelPermission(permissions.Select("LEVEL=1").CopyToDataTable().Rows[0]["PERMISSION"]).Split(';');
                if(per.Length>0)
                {
                    SetBWPermissions(true,1, "1", "Iş Yerləri", per);
                }
            }
            else
            {
                SetBWPermissions(false, 1, "1", "Iş Yerləri", null);
            }

            if (permissions.Select("LEVEL=2").Any())
            {

                var per = GetLevelPermission(permissions.Select("LEVEL=2").CopyToDataTable().Rows[0]["PERMISSION"]).Split(';');
                if (per.Length > 0)
                {
                    SetBWPermissions(true, 2, "2", "Anbarlar", per);
                }
            }
            else
            {
                SetBWPermissions(false, 2, "2", "Anbarlar", null);
            }


            if (permissions.Select("LEVEL=3").Any())
            {

                var per = GetLevelPermission(permissions.Select("LEVEL=3").CopyToDataTable().Rows[0]["PERMISSION"]).Split(';');
                if (per.Length > 0)
                {
                    SetBWPermissions(true, 1, "3", "Giriş İş Yerləri", per);
                }
            }
            else
            {
                SetBWPermissions(false, 1, "3", "Giriş İş Yerləri", null);
            }


            if (permissions.Select("LEVEL=4").Any())
            {

                var per = GetLevelPermission(permissions.Select("LEVEL=4").CopyToDataTable().Rows[0]["PERMISSION"]).Split(';');
                if (per.Length > 0)
                {
                    SetBWPermissions(true, 1, "4", "Çıxış İş Yerləri", per);
                }
            }
            else
            {
                SetBWPermissions(false, 1, "4", "Çıxış İş Yerləri", null);
            }

            if (permissions.Select("LEVEL=5").Any())
            {

                var per = GetLevelPermission(permissions.Select("LEVEL=5").CopyToDataTable().Rows[0]["PERMISSION"]).Split(';');
                if (per.Length > 0)
                {
                    SetBWPermissions(true, 2, "5", "Giriş Anbarlar", per);
                }
            }
            else
            {
                SetBWPermissions(false, 2, "5", "Giriş Anbarlar", null);
            }

            if (permissions.Select("LEVEL=6").Any())
            {

                var per = GetLevelPermission(permissions.Select("LEVEL=6").CopyToDataTable().Rows[0]["PERMISSION"]).Split(';');
                if (per.Length > 0)
                {
                    SetBWPermissions(true, 2, "6", "Çıxış Anbarlar", per);
                }
            }
            else
            {
                SetBWPermissions(false, 2, "6", "Çıxış Anbarlar", null);
            }

        }

        void SetBWPermissions(bool isActiv,int type,string level,string name,string[] per)
        {
            if (type == 1 && isActiv)
            foreach (DataRow row in Branches.Rows)
            {
                BWPermissions.Rows.Add(level, name, row["NR"].ToString(), row["NAME"].ToString(),
                    (Array.FindAll(per, x => x.Trim()==row["NR"].ToString().Trim())).Any());
            }
            else 
                if (type == 1 && !isActiv)
            {
                foreach (DataRow row in Branches.Rows)
                {
                    BWPermissions.Rows.Add(level, name, row["NR"].ToString(), row["NAME"].ToString(),
                       false);
                }
            }
            else if (type == 2 && isActiv)
                    foreach (DataRow row in Whouses.Rows)
                    {
                        BWPermissions.Rows.Add(level, name, row["NR"].ToString(), row["NAME"].ToString(),
                            (Array.FindAll(per, x => x.Trim() == row["NR"].ToString().Trim())).Any());
                    }
            else if (type == 2 && !isActiv)
            {
                foreach (DataRow row in Whouses.Rows)
                {
                    BWPermissions.Rows.Add(level, name, row["NR"].ToString(), row["NAME"].ToString(),
                       false);
                }
            }
        }

        void SelectPermissions()
        {
            var command = string.Format("SELECT * FROM ERP_PERMISSIONS WHERE MASTERID = {0} AND [TYPE]={1} AND FIRMNR={2}",
                                        MasterId, PermissionType, FirmNr);
            permissions = Functions.GetSqlServerDataTable(Variables.ConnectionString, command);
           
        }

        private void Permissions_Load(object sender, EventArgs e)
        {
            SelectBranchWhouse();
            SelectPermissions();

            SetBWPermissions();
            BWPermissions = BWPermissions.Select("", "TYPE ASC").CopyToDataTable();
            gridControl1.DataSource = BWPermissions;
            TreeListLoad();
        }

        string GetLevelPermission( object ob)
        {
            MemoryStream ms = new MemoryStream((byte[])ob);

            StreamReader sr = new StreamReader(ms);
            string myStr = sr.ReadToEnd();
            return myStr;
        }

        private void Save_Click(object sender, EventArgs e)
        {
           


            MemoryStream ms;
            StreamWriter sw;
            
            #region branch whouse
            for(int i = 1 ; i<=6;i++)
                if (BWPermissions.Select("TYPE=" + i).Any())
                {
                    ms = new MemoryStream();
                    sw = new StreamWriter(ms);
                    if (BWPermissions.Select(string.Format("TYPE={0}AND STATUS = TRUE", i)).Any())
                    foreach (DataRow row in BWPermissions.Select(string.Format("TYPE={0}AND STATUS = TRUE", i)).CopyToDataTable().Rows)
                    {
                        sw.Write(row["NR"].ToString().Trim() + ";");
                    }

                    sw.Flush();
                    ms.Position = 0;
                    FileToDb(ms,i);
                }
            

            #endregion
            
            #region
            ms = new MemoryStream();
            sw = new StreamWriter(ms);

            string right = string.Empty;

            foreach (TreeListNode node in tree.Nodes)
            {
                if (bool.Parse(node["PERMISSION"].ToString())) right += node[0].ToString().Trim() + ";";
                if (node.HasChildren)
                {
                    TreeListNodeGet(node, ref right);
                   
                }

            }
           
            sw.Write(right); 
            sw.Flush();
            ms.Position = 0;
            FileToDb(ms, 0);
            
            #endregion

            DialogResult=DialogResult.OK;
        }

        void TreeListNodeGet(TreeListNode node,ref string right)
        {
            foreach (TreeListNode treenode in node.Nodes)
            {
                var l = (treenode["PERMISSION"] != null) && bool.Parse(treenode["PERMISSION"].ToString());
                if (l)
                    right += treenode[0].ToString().Trim() + ";";
                if (treenode.HasChildren) 
                    {
                        TreeListNodeGet(treenode, ref right);
                        
                    }
                              
            }
        }

        private void TreeListLoad()
        {
            if (!permissions.Select("LEVEL=0").Any()) return;
            var per = GetLevelPermission(permissions.Select("LEVEL=0").CopyToDataTable().Rows[0]["PERMISSION"]).Split(';');
            if (per.Length <= 0) return;
            foreach (TreeListNode treenode in tree.Nodes)
            {
                treenode["PERMISSION"] = (Array.FindAll(per, x => x.Trim()==treenode["ID"].ToString().Trim()).Length > 0);
                TreeListNodeSet(treenode,per);
            }
        }

        private void TreeListNodeSet(TreeListNode node,string [] per)
        {
            foreach (TreeListNode treenode in node.Nodes)
            {
                treenode["PERMISSION"] = (Array.FindAll(per, x => x.Trim() == treenode["ID"].ToString().Trim()).Length > 0);
                if (treenode.HasChildren) TreeListNodeSet(treenode, per);
            }

            
        }

        private void FileToDb(MemoryStream ms, int level)
        {
            using (var sqlCommand = new SqlCommand())
            {
            sqlCommand.CommandText = @"
            IF NOT EXISTS (SELECT * FROM ERP_PERMISSIONS WHERE TYPE=@TYPE AND LEVEL=@LEVEL AND MASTERID=@MASTERID AND FIRMNR=@FIRMNR)
            BEGIN 
            INSERT INTO ERP_PERMISSIONS (FIRMNR,MASTERID,TYPE,LEVEL,PERMISSION)
            VALUES (@FIRMNR,@MASTERID ,@TYPE  ,@LEVEL ,@PERMISSION)
            END 
            ELSE 
            BEGIN
            UPDATE ERP_PERMISSIONS SET PERMISSION=@PERMISSION WHERE TYPE=@TYPE AND LEVEL=@LEVEL AND MASTERID=@MASTERID AND FIRMNR=@FIRMNR 
            END
                                      ";
            byte[] file = ms.ToArray();
            sqlCommand.Parameters.Add("@FIRMNR", SqlDbType.Int).Value = FirmNr;
            sqlCommand.Parameters.Add("@MASTERID", SqlDbType.Int).Value = MasterId;
            sqlCommand.Parameters.Add("@TYPE", SqlDbType.Int).Value = PermissionType;
            sqlCommand.Parameters.Add("@LEVEL", SqlDbType.Int).Value = level;
            sqlCommand.Parameters.Add("@PERMISSION", SqlDbType.VarBinary, file.Length).Value = file;
            Functions.ExecuteStatement(Variables.ConnectionString, sqlCommand);
            }
        }
        private void chekbox_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == null)return;
            var state = (sender as CheckEdit).Checked;
            TreeListNode node = tree.FocusedNode;
            node["PERMISSION"] = state;
            if (node.HasChildren) ChangeCheckState(node, state);
            if (state)
            
            {
                var rootnode = node.ParentNode;
                while (rootnode != null)
                {
                    rootnode["PERMISSION"] = true;
                    rootnode = rootnode.ParentNode;
                }
            }else
            { 
                var rootnode = node.ParentNode;
                while (rootnode != null)
                {
                    var st = ChangeParentCheckState(rootnode);
                    if (st) break;
                    rootnode["PERMISSION"] = st;
                    rootnode = rootnode.ParentNode;
                }
           
            }

           // ChangeParentCheckState(node.ParentNode, state);
        }
        void ChangeCheckState(TreeListNode node,bool state)
        {
            foreach (TreeListNode treenode in node.Nodes)
            {
                treenode["PERMISSION"] = state;
                if (treenode.HasChildren) ChangeCheckState(treenode, state);
            }
        }

         bool ChangeParentCheckState(TreeListNode node)
         {
            
            foreach (TreeListNode treenode in node.Nodes)
            {
                if (bool.Parse(treenode["PERMISSION"].ToString()))
                    return true;
            }
             return false;
         }

         private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
         {
             if (gridView1.GetFocusedRow() != null)
             {
                 var a = ((DataRowView)gridView1.GetFocusedRow())["TYPE"].ToString();
                 foreach (DataRow row in BWPermissions.Rows)
                 {
                     if (row["TYPE"].ToString() == a)
                         row["STATUS"] = true;
                 }
             }
         }

         private void gridControl1_MouseClick(object sender, MouseEventArgs e)
         {
             if (e.Button == MouseButtons.Right)
             {
                 popupMenu1.ShowPopup(Cursor.Position);
             }
         }

         private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
         {
             if (gridView1.GetFocusedRow() != null)
             {
                 var a = ((DataRowView)gridView1.GetFocusedRow())["TYPE"].ToString();
                 foreach (DataRow row in BWPermissions.Rows)
                 {
                     if (row["TYPE"].ToString() == a)
                         row["STATUS"] = false;
                 }
             }
         }

      
    }
}