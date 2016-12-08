using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Market.MQ
{
    public partial class RequestForm : XtraForm
    {
        private readonly string _command;
      
        private string _logicalref;

        public RequestForm(string command)
        {
            _command = command;
            InitializeComponent();
        }
        private void RequestForm_Load(object sender, EventArgs e)
        {
            OnLoad();
        }
        public  void OnLoad()
        {

            DataTable firmds = new DataTable();
            var conn = new SqlConnection(Variables.TigerConnection);
            var da = new SqlDataAdapter(_command, conn);
            da.Fill(firmds);
            _logicalref = firmds.Rows[0]["LOGICALREF"].ToString();
            fisno.Text = firmds.Rows[0]["FICHENO"].ToString();
            docno.Text = firmds.Rows[0]["DOCODE"].ToString();
            tip.Text = firmds.Rows[0]["TIP"].ToString();
            code.Text = firmds.Rows[0]["CODE"].ToString();
            definition.Text = firmds.Rows[0]["DEFINITION_"].ToString();
            sourceindex_code.Text = firmds.Rows[0]["SOURCEINDEX"].ToString();
            destindex_code.Text = firmds.Rows[0]["DESTINDEX"].ToString();
            ugirtrackingno.Text = firmds.Rows[0]["UGIRTRACKINGNO"].ToString();
            date.Text = firmds.Rows[0]["DATE_"].ToString();
            user.Text = firmds.Rows[0]["USERID"].ToString();
            RequestNo.Text = firmds.Rows[0]["ID"].ToString();
            total.Text = firmds.Rows[0]["NETTOTAL"].ToString();
            Explanation.Text = firmds.Rows[0]["EXPLANATION"].ToString();

            if (!string.IsNullOrEmpty(firmds.Rows[0]["ID"].ToString()))
            {
                
                if (!bool.Parse(firmds.Rows[0]["APPROVED"].ToString()))
                {

                    Explanation.Enabled = approv.Checked = save.Enabled = false;
                    cancel.Enabled = true;

                }
                else
                {
                    approv.Checked =  true;
                    cancel.Enabled = save.Enabled = Explanation.Enabled = false;
                }

            }
            else
            {
                approv.Checked = cancel.Enabled = false;
                Explanation.Enabled = save.Enabled = true;
            }

        }
        private void OnTextChange(object sender, EventArgs e)
        {
            label12.Text = (Explanation.MaxLength - Explanation.Text.Length).ToString();
        }
        private void SaveClick(object sender, EventArgs e)
        {
            if (Explanation.TextLength > 20)
            {
                if (XtraMessageBox.Show(
                    "Seçdiyiniz qaimə təsdiqləndikdən sonra sistemnən çıxarılacaqdır. Müraciət təsdiqlənməsə\nqaimə sistemnən çıxarılmayacaq. Əgər müraciətiniz təsdiqlənərsə müraciəti ləğv etmək\nmümkün olmayacaqdir",
                    "Diqqət!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    string insert = string.Format(@" INSERT INTO {0}REQUEST 
 ( STF_ID,TRCODE ,FICHENO, DOCODE, SOURCEINDEX,DESTINDEX,UGIRTRACKINGNO,
 CODE,DEFINITION_ ,TOTAL,DATE_,EMAIL,[BACKUP],CANCELLED,DELETED, APPROVED,EXPLANATION,[RECUSER],RECDATE )
 SELECT   FIS.LOGICALREF,FIS.TRCODE, FIS.FICHENO , FIS.DOCODE,FIS.SOURCEINDEX,FIS.DESTINDEX,FIS.UGIRTRACKINGNO,
          CLC.CODE , CLC.DEFINITION_ , FIS.NETTOTAL,FIS.DATE_,0,0,0,0,0,N'{5}',N'{4}' ,GETDATE()
FROM {0}LG_{1}_{2}_STFICHE FIS WITH(NOLOCK) 
LEFT JOIN {0}LG_{1}_CLCARD CLC WITH (NOLOCK) ON CLC.LOGICALREF =FIS.CLIENTREF 
LEFT JOIN L_CAPIWHOUSE CAP ON FIS.SOURCEINDEX=CAP.NR AND CAP.FIRMNR={1}
LEFT JOIN {0}REQUEST R ON R.STF_ID=FIS.LOGICALREF
WHERE FIS.LOGICALREF={3}
UPDATE  {0}LG_{1}_01_STFICHE  SET SPECODE='DELETE' WHERE LOGICALREF={3}


", Variables.FirmDb, Variables.FirmNr,Variables.FirmPeriod, _logicalref, User.UserName, Explanation.Text);
                    SqlConnection conn = new SqlConnection(Variables.TigerConnection);
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = insert;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    OnLoad();
                    XtraMessageBox.Show("Müraciətiniz " + RequestNo.Text + @" nömrəsi ilə qeydə alındı!");
                    DialogResult = DialogResult.OK;
                }
               
            }
            else
            {
                XtraMessageBox.Show("Səbəb 20 simvoldan az ola bilməz!");
            }
        }
        private void OnCancel(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(
                    RequestNo.Text + " nömrəli müraciətiniz ləğv ediləcəldir. \nDavam Edirsiz?",
                    "Diqqət!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(Variables.TigerConnection);
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = string.Format(@"
                UPDATE  {0}LG_{2}_{3}_STFICHE  SET SPECODE='ELTERMINAL' WHERE LOGICALREF=(SELECT STF_ID FROM {0}REQUEST WHERE ID={1})
                DELETE {0}REQUEST WHERE ID={1}", Variables.FirmDb, RequestNo.Text, Variables.FirmNr,Variables.FirmPeriod);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                XtraMessageBox.Show("Müraciət ləğv olundu!");
                DialogResult = DialogResult.OK;
            }
        }
        private void OnExplanationChange(object sender, KeyEventArgs e)
        {
            if (!e.Control || (e.KeyCode != Keys.A)) return;
            ((TextBox) sender)?.SelectAll();
            e.Handled = true;
        }
    }
}