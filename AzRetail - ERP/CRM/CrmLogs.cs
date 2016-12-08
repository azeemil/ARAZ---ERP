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

namespace ERP.CRM
{
    public partial class CrmLogs : DevExpress.XtraEditors.XtraForm
    {
        public CrmLogs()
        {
            InitializeComponent();
            dateEdit1.DateTime = dateEdit2.DateTime = DateTime.Now;
        }

        private void ToExcelBtn_Click(object sender, EventArgs e)
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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var query = $@"SELECT USERNAME,BRANCH,CRMCARD,DESCRIPTION,EXPLANATION,RECORDDATE,
                (CASE TYPE WHEN 0 THEN N'Kart Qeydiyyatı' 
                           WHEN 1 THEN N'Bonus atrırma' 
		                   WHEN 2 THEN N'Bonus azaltma'
		                   WHEN 3 THEN N'Kart Transferi'
		                   WHEN 4 THEN N'Hədiyyə verilmə'
		                   WHEN 5 THEN N'Hədiyyə qaytarma'
		                   END) [TYPE]  
                FROM ERP_USERS USERS INNER JOIN ERP_CRMLOGS LOGS
                ON LOGS.USERID=USERS.ID AND CAST(RECORDDATE AS DATE) BETWEEN 
                 '{dateEdit1.DateTime.Date.ToString("yyyy-MM-dd")}' AND '{dateEdit2.DateTime.Date.ToString("yyyy-MM-dd")}' ";
            gridControl1.DataSource = General.Functions.GetSqlServerDataTable(Variables.ConnectionString, query);
            gridView1.BestFitColumns();
        }
    }
}