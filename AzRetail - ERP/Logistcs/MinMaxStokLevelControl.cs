using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Logistcs
{
    public partial class MinMaxStokLevelControl : DevExpress.XtraEditors.XtraForm
    {
        public MinMaxStokLevelControl()
        {
            InitializeComponent();
        }

        private DataTable dt;
        private void searchBtn_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            var type = string.Empty;
            type = radioGroup1.SelectedIndex == 0 ? " ITEM.CODE LIKE " : " ITEM.NAME LIKE ";

            var query =
                string.Format(@"
                    SELECT CAP.NR WAREHOUSE,CAP.NAME WAREHOUSENAME,ITEM.NAME ITEMNAME,ITEM.CODE ITEMCODE,
                    ISNULL((SELECT MAXLEVEL FROM {0}LG_{1}_INVDEF  (NOLOCK) WHERE ITEMREF=ITEM.LOGICALREF AND INVENNO=CAP.NR),0) MAXLEVEL,ITEM.LOGICALREF
                    FROM  L_CAPIWHOUSE CAP
                    FULL JOIN {0}LG_{1}_ITEMS ITEM (NOLOCK)   ON  {2} '{3}' WHERE CAP.FIRMNR={1} AND ITEM.CODE IS NOT NULL ",
                    Variables.FirmDb, Variables.FirmNr, type,searchTxt.Text.Trim());
            dt = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
            grid.DataSource = dt;
            splashScreenManager1.CloseWaitForm();
        }

        private void searchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter) searchBtn_Click(null,null);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Davam edirsiz?", "Diqqət",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            SqlTransaction transaction = null;
            try
            {


                var connection = new SqlConnection(Variables.ConnectionString);
                connection.Open();
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "QIYMET DEYISIMI");
                var command = connection.CreateCommand();
                command.CommandTimeout = 0;
                command.Transaction = transaction;
                var adapter = new SqlDataAdapter
                {
                    UpdateCommand = new SqlCommand(
                        string.Format(@"IF EXISTS(SELECT * FROM {0}LG_{1}_INVDEF WHERE ITEMREF=@ITEMREF AND INVENNO=@INVENNO)
                        BEGIN
                        UPDATE {0}LG_{1}_INVDEF SET MAXLEVEL=ISNULL(@MAXLEVEL,0) WHERE ITEMREF=@ITEMREF AND INVENNO=@INVENNO
                        END
                        ELSE
                        BEGIN
                        INSERT INTO {0}LG_{1}_INVDEF(INVENNO,ITEMREF,MINLEVEL,MAXLEVEL,SAFELEVEL,LOCATIONREF,PERCLOSEDATE,ABCCODE,
                        MINLEVELCTRL,MAXLEVELCTRL,SAFELEVELCTRL,NEGLEVELCTRL,IOCTRL,VARIANTREF,OUTCTRL)
                        VALUES(@INVENNO,@ITEMREF,0,ISNULL(@MAXLEVEL,0),0,0,0,0,0,0,0,0,0,0,0)
                        END  ", Variables.FirmDb,Variables.FirmNr), 
                        connection,
                        transaction)
                };


                adapter.UpdateCommand.Parameters.Add("@INVENNO", SqlDbType.Int, Int32.MaxValue, "WAREHOUSE");
                adapter.UpdateCommand.Parameters.Add("@ITEMREF", SqlDbType.Float, sizeof(float), "LOGICALREF");
                adapter.UpdateCommand.Parameters.Add("@MAXLEVEL", SqlDbType.Int, sizeof(float), "MAXLEVEL");
                adapter.Update(dt);
                transaction.Commit();
                dt.AcceptChanges();
                XtraMessageBox.Show("Yadda saxlanıldı!", "Diqqət!", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
               
            }
            catch (Exception exception)
            {
                transaction?.Rollback();
                XtraMessageBox.Show(exception.Message + "\n" + exception.ToString(), "Xəta!", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
        }
    }
}