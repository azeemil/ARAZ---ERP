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
using DevExpress.XtraGrid.Views.Grid;
using ERP.Administrator;
using ERP.General;
using ERP.Logistcs;

namespace ERP.Market
{
    public partial class ReportTamplateUserPermissions : DevExpress.XtraEditors.XtraForm
    {
        public ReportTamplateUserPermissions()
        {
            InitializeComponent();
           
        }

        public int ReportId { get; set; }

        public void RefreshGrid()
        {
           gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.ConnectionString, $@"                
                SELECT US.USERNAME [USER],UP.ID FROM  ERP_RT_USERPERMISSON UP  
                INNER JOIN ERP_USERS US ON US.ID=USERID AND UP.TEMPLATEID={ReportId}
                ORDER BY UP.ID
                                                                          ");
        }
        private void grid_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                var row = gridView1.GetFocusedDataRow();
                if (row == null) return;
               
                if (XtraMessageBox.Show("Sətir silinəcək! \nDavam edirsiz?", "Diqqət",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
              
                    Functions.ExecuteStatement(Variables.ConnectionString,
                        $@"DELETE FROM ERP_RT_USERPERMISSON WHERE ID={row["ID"]}");
                e.Handled = false;
                return;
            }
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                 var users = new Users();
                 users.gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
                 users.gridView1.OptionsSelection.MultiSelect = true;
                users.EditUserBtn.Visible = users.newUserBtn.Visible = false;
                users.SelectBtn.Visible = true;
                if (users.ShowDialog() == DialogResult.OK)
                {

                    if (users.gridView1.GetSelectedRows().Count() <= 0) return;

                    int[] a = users.gridView1.GetSelectedRows();
                    string values = a.Select(t => (DataRowView)users.gridView1.GetRow(t)).Aggregate(string.Empty,
                        (current, row) => current + (row.Row["ID"] + ","));

                    values = values.Remove(values.Length - 1, 1);

                    var query =
                        $@"
                     INSERT INTO   ERP_RT_USERPERMISSON (FIRMNR,USERID,TEMPLATEID) 
                      SELECT {Variables.FirmNr},ID,{ReportId} AS TEMPLATEID FROM ERP_USERS WHERE ID IN ({values}) AND 
                     ID NOT IN (SELECT ID FROM ERP_RT_USERPERMISSON WHERE TEMPLATEID={ReportId} AND FIRMNR={Variables.FirmNr})";
                    Functions.ExecuteStatement(Variables.ConnectionString, query);
                    RefreshGrid();

                }

            }
        }

        
    }
}