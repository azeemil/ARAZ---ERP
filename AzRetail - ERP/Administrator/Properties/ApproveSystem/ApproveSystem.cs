using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP.Administrator.Properties.ApproveSystem
{
    public partial class ApproveSystem : XtraForm
    {
        public ApproveSystem()
        {
            InitializeComponent();
            RefreshGrid();
        }

      
        public void RefreshGrid()
        {
            gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.ConnectionString, $@"                
                  SELECT APP.ID,USERNAME ,TYPE,USERID FROM ERP_APPROVEUSERS APP 
                  INNER JOIN ERP_USERS USERS ON USERS.ID=USERID AND APP.FIRMNR={Variables.FirmNr} AND TYPE={typeCmbx.SelectedIndex}
                                                                          ");
        }
        private void grid_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {

                if (XtraMessageBox.Show("Sətir silinəcək! \nDavam edirsiz?", "Diqqət",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int[] a = gridView1.GetSelectedRows();
                    if (a.Length > 0)
                    {
                        string values = a.Select(t => (DataRowView)gridView1.GetRow(t)).Aggregate(string.Empty,
                            (current, row) => current + (row.Row["USERID"] + ","));
                        values = values.Remove(values.Length - 1, 1);
                        Functions.ExecuteStatement(Variables.ConnectionString,
                            $@"DELETE FROM ERP_APPROVEUSERS WHERE ID IN ({values})");
                    }

                }


            }
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                var users = new Users();
                users.gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
                users.gridView1.OptionsSelection.MultiSelect = true;
                users.EditUserBtn.Visible = users.newUserBtn.Visible = false;
                users.StartPosition = FormStartPosition.CenterScreen;
                users.SelectBtn.Visible = true;
                if (users.ShowDialog() == DialogResult.OK)
                {

                    if (users.gridView1.GetSelectedRows().Count() <= 0) return;

                    int[] a = users.gridView1.GetSelectedRows();
                    if (a.Length == 0) return;
                    string values = a.Select(t => (DataRowView)users.gridView1.GetRow(t)).Aggregate(string.Empty,
                        (current, row) => current + (row.Row["ID"] + ","));

                    values = values.Remove(values.Length - 1, 1);

                    var query =
                        $@"INSERT INTO  ERP_APPROVEUSERS (FIRMNR,TYPE,USERID) 
                          SELECT {Variables.FirmNr},{typeCmbx.SelectedIndex},ID FROM ERP_USERS WHERE ID IN ({values}) AND 
                           ID NOT IN (SELECT USERID FROM ERP_APPROVEUSERS WHERE TYPE={typeCmbx.SelectedIndex})
                     ";
                    Functions.ExecuteStatement(Variables.ConnectionString, query);

                }


            }
            RefreshGrid();
            e.Handled = false;

        }
        private void typeCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void EditSystem_Click(object sender, EventArgs e)
        {
            ApproveSysProperties prop = new ApproveSysProperties();
            prop.Text = typeCmbx.Text;
            var PropTable = Functions.GetSqlServerDataTable(Variables.ConnectionString, $"SELECT * FROM ERP_APPROVESYS WHERE TYPE = {typeCmbx.SelectedIndex}");
            if (PropTable.Rows.Count > 0)
                prop.typeCmbx.SelectedIndex = (int)PropTable.Rows[0]["LEVEL"];
            if (prop.ShowDialog() != DialogResult.OK) return;
            var query = string.Format(@"
        IF EXISTS(SELECT * FROM ERP_APPROVESYS WHERE TYPE = {0})
BEGIN 
UPDATE ERP_APPROVESYS SET LEVEL={1},EXPLANATION = N'{3}' WHERE TYPE = {0}
END 
ELSE 
BEGIN 
INSERT INTO ERP_APPROVESYS(TYPE,LEVEL,DESCR,EXPLANATION) VALUES ({0},{1},N'{2}',N'{3}')
END
                         ", typeCmbx.SelectedIndex, prop.typeCmbx.SelectedIndex,typeCmbx.Text, prop.typeCmbx.Text);
            Functions.ExecuteStatement(Variables.ConnectionString, query);


        }
    }
}