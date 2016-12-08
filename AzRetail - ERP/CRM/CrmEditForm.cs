using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using ERP.General;
using ErrorType = DevExpress.DXCore.Controls.XtraEditors.DXErrorProvider.ErrorType;


namespace ERP.CRM
{
    public partial class CrmEditForm : XtraForm
    {
        private DataRow _row;
        public CrmEditForm(DataRow row)
        {
            this._row = row;
            InitializeComponent();
            BDayText.Text = string.Empty;
            if (Variables.ConnectionString != null)
                Position.Properties.DataSource =
              Functions.GetSqlServerDataTable(connectionString: Variables.ConnectionString, sqlStatement: "SELECT NAME N'NAME' FROM ERP_CRMPOSITIONS");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int errorCount = 0;
            if (NameTxbx.Text.Trim().Length <3)
            {
                alertControl1.Show(this, "Səhv", "Ad ən az 3 hərfdən ibarət olmalıdır!");
                errorCount++;
            }
            if (SNameTxbx.Text.Trim().Length <3)
            {
                alertControl1.Show(this, "Səhv", "Soyad ən az 3 hərfdən ibarət olmalıdır!");
                errorCount++;
            }
            if (FNameTxbx.Text.Trim().Length < 3)
            {
                alertControl1.Show(this, "Səhv", "Ata adı ən az 3 hərfdən ibarət olmalıdır!");
                errorCount++;
            }
          
            if (BDayText.Text.Length==0)
            {
                alertControl1.Show(this, "Səhv", "Doğum tarixi daxil edilməyib!");
                errorCount++;
            }
            if ((DateTime.Now.Year - BDayText.DateTime.Year)<16|| (DateTime.Now.Year - BDayText.DateTime.Year) > 80)
            {
                alertControl1.Show(this, "Səhv", "Doğum tarixi 16 - 80 yaş aralığında olmalıdır!");
                errorCount++;
            }

            if (MaritialRadio.SelectedIndex==-1)
            {
                alertControl1.Show(this, "Səhv", "Aile vəziyyəti seçilməyib!");
                errorCount++;
            }

            if (SexRadio.SelectedIndex == -1)
            {
                alertControl1.Show(this, "Səhv", "Cins seçilməyib!");
                errorCount++;
            }

            if (ContactCode.Text.Trim().Length < 3 || ContactTxbx.Text.Trim().Length < 7)
            {
                alertControl1.Show(this, "Səhv", "Əlaqə nömrəsi qeyd edilməyib!");
                errorCount++;
            }

            if (Position.Text.Trim().Length < 3 || ContactTxbx.Text.Trim().Length < 7)
            {
                alertControl1.Show(this, "Səhv", "Vəzifə qeyd edilməyib!");
                errorCount++;
            }

            NameTxbx.Text = ToInvarianTitleCase(NameTxbx.Text);
            SNameTxbx.Text = ToInvarianTitleCase(SNameTxbx.Text);
            FNameTxbx.Text = ToInvarianTitleCase(FNameTxbx.Text);
            if (errorCount==0)
            DialogResult =DialogResult.OK;

            
        }
        public static string ToInvarianTitleCase(string self)
        {
            if (string.IsNullOrWhiteSpace(self))
            {return self;
            }

            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(self.ToLower());
        }
        private void NameTxbx_Validated(object sender, EventArgs e)
        {
            var a = sender as TextEdit;
            a.Text = ToInvarianTitleCase(a.Text);
        }

       
    }
}