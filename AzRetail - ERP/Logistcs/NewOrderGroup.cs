using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Logistcs
{
    public partial class NewOrderGroup : XtraForm
    {
        public NewOrderGroup()
        {
            InitializeComponent();
            DestBranchLookUp.Properties.DataSource = User.BranchOut;
            SourceBranchCmbx.Properties.DataSource = User.BranchIn;
        }

        private void branchCmbx_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void SourceBranchCmbx_EditValueChanged(object sender, EventArgs e)
        {
            if (SourceBranchCmbx.Text.Trim().Length > 0)
            {
                var datarow = (DataRowView)SourceBranchCmbx.GetSelectedDataRow();
                if (User.WhouseOut.Select("DIVISNR=" + datarow["NR"]).Any())
                {
                    var dr = User.WhouseOut.Select("DIVISNR=" + datarow["NR"]).CopyToDataTable();

                    SourceWhouseCmbx.Properties.DataSource = dr;
                    SourceWhouseCmbx.ItemIndex = 0;
                }
                else
                {
                    SourceWhouseCmbx.Properties.DataSource = null;
                }
            }
        }

        private void DestBranchLookUp_EditValueChanged(object sender, EventArgs e)
        {
            if (DestBranchLookUp.Text.Trim().Length > 0)
            {
                var datarow = (DataRowView)DestBranchLookUp.GetSelectedDataRow();
                if (User.WhouseIn.Select("DIVISNR=" + datarow["NR"]).Any())
                {
                    var dr = User.WhouseIn.Select("DIVISNR=" + datarow["NR"]).CopyToDataTable();

                    DestWhouseLookUp.Properties.DataSource = dr;
                    DestWhouseLookUp.ItemIndex = 0;
                }
                else
                {
                    DestWhouseLookUp.Properties.DataSource = null;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (DestBranchLookUp.Text.Trim().Length == 0)
            {

                XtraMessageBox.Show("Iş Yeri məlumatları daxil edilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (DestWhouseLookUp.Text.Trim().Length == 0)
            {

                XtraMessageBox.Show("Anbar məlumatları daxil edilməyib!", "Xəta!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            SqlConnection conn = new SqlConnection(Variables.ConnectionString);
            conn.Open();
            SqlTransaction tran = conn.BeginTransaction();
            SqlCommand command = new SqlCommand
            {
                Connection = conn,
                Transaction = tran,
                CommandText = string.Format(@"INSERT INTO {0}LK_{1}_{2}_PURCHORDERDISTFICHE  
    (ORDERREF,STATUS,TRANSFER_TYPE,FICHETYPE,EXPLANATION,DATE_,SOURCEBRANCH,DESTBRANCH,SOURCEINDEX,DESTINDEX,RECDATE,RECUSER) 
   VALUES (NULL,0,1,2,1,GETDATE(),{5},{4},{7},{6},GETDATE(),{3}) 
          SELECT SCOPE_IDENTITY()", Variables.FirmDb,
                    Variables.FirmNr, Variables.FirmPeriod, User.UserId, SourceBranchCmbx.Text.Trim(),
                    DestBranchLookUp.Text.Trim()
                    , SourceWhouseCmbx.Text.Trim(), DestWhouseLookUp.Text.Trim()
                    )
            };
            try
            {
                var id = command.ExecuteScalar();
                tran.Commit();
                XtraMessageBox.Show(string.Format("Sifariş qrupu {0} nömrəsi ilə qeydə alındı!", id), "Məlumat!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                tran.Rollback();
                XtraMessageBox.Show(ex.Message, "Diqqət", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }
    }
}