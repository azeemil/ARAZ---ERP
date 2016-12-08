using System;
using System.Data;
using System.Linq;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Administrator
{
    public partial class Modul : XtraForm
    {
        private DataTable _roles;
        public Modul()
        {
            InitializeComponent();
        }

        //private int _saveMode = 0;
        //private int id,level;

       

        new void Refresh()
        {_roles=Functions.GetSqlServerDataTable(Variables.ConnectionString, "SELECT * FROM ROLES");
            ModulsTree.DataSource = _roles;
        }

         void Refresh(string l)
            {
            _roles=Functions.GetSqlServerDataTable(Variables.ConnectionString, "SELECT * FROM ROLES");
            ModulsTree.DataSource = _roles;
            LevelLookUp.Properties.DataSource = null;
            if (_roles.Select("LEVEL="+l).Any())
            {
                LevelLookUp.Properties.DataSource = _roles.Select("LEVEL="+l).CopyToDataTable();
            }

           }
         void RefreshLookUp(string l){
             LevelLookUp.Properties.DataSource = null;
             if (_roles.Select("LEVEL=" + l).Any())
             {
                 LevelLookUp.Properties.DataSource = _roles.Select("LEVEL=" + l).CopyToDataTable();
             }

         }
        private void Modul_Load(object sender, EventArgs e)
        {
            Refresh();  
        }

        //private void SaveModulBtn_Click(object sender, EventArgs e)
        //{
        //    if (ModulNameTxt.Text.Trim().Length == 0)
        //    {
        //        XtraMessageBox.Show("Ad xanası boşdur!!!");
        //        return;
        //    }
        //    var activyStatus = activty.Checked ? "1" : "0";
        //    var selectedRow = (DataRowView)LevelLookUp.GetSelectedDataRow();
        //    #region new
        //    switch (_saveMode)
        //    {

        //        case 1: Functions.ExecuteStatement(Variables.ConnectionString,
        //                string.Format(@"INSERT INTO ROLES ([PARENTID],[LEVEL],[DESCRIPTION],[IMAGEINDEX],[ACTIVITY])
        //                             VALUES (IDENT_CURRENT ('ROLES'),1,'{0}',1,{1})", ModulNameTxt.Text.Trim(),activyStatus));
        //            break;
        //        case 2:
        //            Functions.ExecuteStatement(Variables.ConnectionString,
        //                string.Format(@"INSERT INTO ROLES ([PARENTID],[LEVEL],[DESCRIPTION],[IMAGEINDEX],[ACTIVITY])
        //                             VALUES ({1},2,'{0}',2,{2})", ModulNameTxt.Text.Trim(), selectedRow["ID"],activyStatus));
        //            break;
               
        //        case 3:
        //            Functions.ExecuteStatement(Variables.ConnectionString,
        //                string.Format(@"INSERT INTO ROLES ([PARENTID],[LEVEL],[DESCRIPTION],[IMAGEINDEX],[ACTIVITY])
        //                             VALUES ({1},3,'{0}',2,{2})", ModulNameTxt.Text.Trim(), selectedRow["ID"], activyStatus));
        //            break;
        //        case 4:
        //            Functions.ExecuteStatement(Variables.ConnectionString,
        //                string.Format(@"INSERT INTO ROLES ([PARENTID],[LEVEL],[DESCRIPTION],[IMAGEINDEX],[ACTIVITY])
        //                             VALUES ({1},4,'{0}',2,{2})", ModulNameTxt.Text.Trim(), selectedRow["ID"], activyStatus));
        //            break;
        //        case 5:
        //            Functions.ExecuteStatement(Variables.ConnectionString,
        //                string.Format(@"INSERT INTO ROLES ([PARENTID],[LEVEL],[DESCRIPTION],[IMAGEINDEX],[ACTIVITY])
        //                             VALUES ({1},5,'{0}',2,{2})", ModulNameTxt.Text.Trim(), selectedRow["ID"], activyStatus));
        //            break;

        //    }

        //    #endregion



        //    Refresh();
        //    CancelModulBtn_Click(null,null);
        //}

        private void CancelModulBtn_Click(object sender, EventArgs e)
        {

            ModulNameTxt.Text = string.Empty;
            SaveModulBtn.Enabled = false;
            CancelModulBtn.Enabled = false;
            
            ModulsTree.Enabled = true;
            ContextMenu.Enabled = true;
            ModulNameTxt.Enabled = false;
            LevelLookUp.Properties.DataSource = null;
            LevelLookUp.Enabled = false;
        }
        

       
     

        //private void NewTreeItem(int treeLevel)
        //{
        //    Refresh((treeLevel-1).ToString());
        //    _saveMode = treeLevel;
        //    level = treeLevel;
        //    LevelLookUp.Enabled = treeLevel!= 1;

        //    ModulNameTxt.Enabled = true;
        //    SaveModulBtn.Enabled = true;
        //    CancelModulBtn.Enabled = true;
        //    ModulsTree.Enabled = false;
        //    ContextMenu.Enabled = false;
           
            
        //}

       // private void səviyyə1ToolStripMenuItem_Click(object sender, EventArgs e)
       // {
       //     NewTreeItem(1);
       // }

       // private void səviyyə2ToolStripMenuItem_Click(object sender, EventArgs e)
       // {
           
       //     NewTreeItem(2);
       //}
       // private void səviyyə3ToolStripMenuItem_Click(object sender, EventArgs e)
       // {
       //     NewTreeItem(3);
       // }
       // private void səviyyə4ToolStripMenuItem_Click(object sender, EventArgs e)
       // {
       //     NewTreeItem(4);
       // }
        private void dəyişToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModulNameTxt.Enabled = true;
            SaveModulBtn.Enabled = true;
            CancelModulBtn.Enabled = true;
            ModulsTree.Enabled = false; 
            ContextMenu.Enabled = false;
          //  _saveMode = 2;
            var node = ModulsTree.FocusedNode;
            ModulNameTxt.Text = node[2].ToString();
            LevelLookUp.Enabled = node["LEVEL"].ToString().Trim() != "1";
            RefreshLookUp(node["LEVEL"].ToString().Trim());
            ModulNameTxt.Enabled = true;
            var aaa = LevelLookUp.Properties.GetKeyValueByDisplayValue("1");

            LevelLookUp.EditValue = (string)LevelLookUp.Properties.GetDisplayValueByKeyValue(2);
            
            SaveModulBtn.Enabled = true;
            CancelModulBtn.Enabled = true;
            ModulsTree.Enabled = false; 
            ContextMenu.Enabled = false;
          //  _saveMode = 2;
        }

        private void səviyyə5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // NewTreeItem(5);
        }

      
       

       

      
      


 
    }
}