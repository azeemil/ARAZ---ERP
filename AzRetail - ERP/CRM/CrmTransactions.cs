using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.CRM
{
    public partial class CrmTransactions : XtraForm
    {
        public string CardNo;
        public CrmTransactions(string cardNo)
        {
            CardNo = cardNo;
            InitializeComponent();
            Transactions();
        }

        public void Transactions()
        {
            var query = string.Format(@"
                SELECT  DIV.NR,DIV.NAME BRANCH ,H.Belge_no,H.Cari_kod,H.Puan,H.ToplamTutar,H.Kasa_No
                       ,H.DATECREATED,H.Aciklama  from  
				       inter_puan..INTERBONUS_PUANHAREKET H WITH (NOLOCK)
                       INNER JOIN {0}LK_{1}_POSKS POS WITH (NOLOCK) ON POS.KSCODE=H.Kasa_no and POS.FIRMREF={1} and  H.Cari_kod='{2}'
                       INNER JOIN L_CAPIDIV DIV WITH (NOLOCK) ON DIV.NR=POS.DIVREF AND DIV.FIRMNR={1}
                       ORDER BY Tarih
                              ", Variables.FirmDb,Variables.FirmNr,CardNo);
            try
            {
                gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.TigerConnection, query);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message, @"Səhf!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toExcelBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sv = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "Excel | *.xlsx",
                Filter = @"Excel | *.xlsx"
            };
            if (sv.ShowDialog() != DialogResult.OK) return;
            if (sv.FileName == string.Empty)
            {
                MessageBox.Show(@"Ad boşdur");
                return;
            }
            gridView1.ExportToXlsx(sv.FileName);
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
            }
        }
    }
}