using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Market
{
    public partial class DocumentControl :  XtraForm
    {
        public DocumentControl()
        {
            InitializeComponent();
            _dataTabledt = new DataTable();
            _dataTabledt.Columns.Add("LOGICALREF", typeof(int));
            _dataTabledt.Columns.Add("TRCODE", typeof(int));
            _dataTabledt.Columns.Add("INVTYPE", typeof(string));
            _dataTabledt.Columns.Add("FICHENO", typeof(string));
            _dataTabledt.Columns.Add("DOCODE", typeof(string));
            _dataTabledt.Columns.Add("SOURCEINDEX", typeof(int));
            _dataTabledt.Columns.Add("DESTINDEX", typeof(int));

            grid.DataSource = _dataTabledt;
        }

        private readonly DataTable _dataTabledt;
        private DataTable _dt;

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(barkodTxt.Text.Trim().Length==0)
            {
                XtraMessageBox.Show("Barkod xanası boşdur!");
                return;
            }
            var query =
                $@"
                    SELECT (CASE TRCODE WHEN 1 THEN N'Alış'
                    WHEN 2 THEN N'Pərakəndə Satış İadə'
                    WHEN 6 THEN N'Alış İadə'
                    WHEN 7 THEN N'Pərakəndə Satış'
                    WHEN 12 THEN N'Sarf'
                    WHEN 13 THEN N'Ürətim'
                    WHEN 15 THEN N'Mərkəzdən Gələn'
                    WHEN 20 THEN N'Mərkəzdən Çıxan'
                    WHEN 25 THEN N'Anbar Transferi' END) INVTYPE,
					FICHENO,DOCODE,SOURCEINDEX,DESTINDEX,TRCODE,LOGICALREF
                    FROM {Variables.FirmDb}LG_{Variables.FirmNr}_{Variables.FirmPeriod}_STFICHE WHERE LOGICALREF = {
                    barkodTxt.Text.Trim()} ";
            try
            {
                _dt = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, @"Səhf!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearBtn_Click(null, null);
            }
            if(_dt.Rows.Count==0)
            {
                labelControl1.Text = @"Axtarış üzrə nəticə tapılmadı!";
                clearBtn_Click(null, null);
                return;
            }
            if (!checkEdit1.Checked)
            {
                barkodTxt.Enabled = false;
                ControlledBtn.Enabled = true;
                ControlledBtn.Focus();
            }
            else
            {
                ControlledBtn_Click(null, null);
                clearBtn_Click(null,null);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            barkodTxt.Text = string.Empty;
            barkodTxt.Enabled = true;
            ControlledBtn.Enabled = false;
            barkodTxt.Focus();
        }

      

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }

        private void barkodTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchBtn_Click(null, null);

        }

        private void ControlledBtn_Click(object sender, EventArgs e)
        {
            var query = string.Format(@"
                    
                    UPDATE {0}LG_{1}_{5}_STFICHE SET SPECODE='KONTROL' {3} ,GENEXP4=N'{4}' WHERE LOGICALREF = {2} "
                                  , Variables.FirmDb, Variables.FirmNr, barkodTxt.Text.Trim(),
                                  (lockCbx.Checked) ? ", APPROVE=1 " : string.Empty,User.UserName,Variables.FirmPeriod
                                  );
            if (Functions.ExecuteStatement(Variables.TigerConnection, query)) //
            {
                labelControl1.Text = @"Qeydə alındı!";
                _dataTabledt.Rows.Add(_dt.Rows[0]["LOGICALREF"], _dt.Rows[0]["TRCODE"], _dt.Rows[0]["INVTYPE"],
                    _dt.Rows[0]["FICHENO"], _dt.Rows[0]["DOCODE"],
                    _dt.Rows[0]["SOURCEINDEX"], _dt.Rows[0]["DESTINDEX"]);
            }
            else
            {
                labelControl1.Text = @"Qeydə alınmadı!";
            }
            clearBtn_Click(null, null);
        }
    }
}
