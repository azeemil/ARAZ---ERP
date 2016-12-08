using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using ERP.General;

namespace ERP.Administrator.Properties
{
    public partial class KhProperties : XtraForm
    {
        private DataTable _dt;
        public KhProperties()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            if (satisKodeBtnEdt.Text.Trim().Length == 0 ||
                iadeKodeBtnEdt.Text.Trim().Length == 0 ||
                kartigKodeBtnEdt.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show(@"Bütün xanalar doldurulmalıdır!");
                return;
            }
           
            XDocument document = new XDocument(
       new XComment("Kassir Hesab Alma"),
       new XElement("Property",
        new XComment("Satis"),
       new XElement("SatisKod", satisKodeBtnEdt.Text),
       new XElement("SatisAd", satisNameBtnEdt.Text),
       new XComment("Iade"),
       new XElement("IadeKod", iadeKodeBtnEdt.Text),
       new XElement("IadeAd", iadeNameBtnEdt.Text),
       new XComment("KassaQaliq"),
       new XElement("KassaQaliqKod", kartigKodeBtnEdt.Text),
       new XElement("KassaQaliqAd", kartigNameBtnEdt.Text)
       ));

            var query = string.Format(@"
                    IF EXISTS(SELECT * FROM ERP_PROPERTIES WHERE TYPE=0 AND FIRMNR={0})
                    BEGIN 
                    UPDATE ERP_PROPERTIES SET PROPERITY=@PROPERITY , MODIFYDATE=GETDATE() WHERE TYPE=0 AND FIRMNR={0}
                    END
                    ELSE 
                    BEGIN
                    INSERT INTO ERP_PROPERTIES (FIRMNR,TYPE,PROPERITY)
                      VALUES ({0},0,@PROPERITY)
                    END
                                    ", Variables.FirmNr);
            SqlXml xml;
            using (var mem = new MemoryStream())
            {
                var writer = new StreamWriter(mem);
               
                writer.Write(document);
                writer.Flush();
                mem.Position = 0;
                XmlReader rdr = XmlReader.Create(mem);
               xml = new SqlXml(rdr);
            }
           

            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@PROPERITY", xml);
           
            Functions.ExecuteStatement(Variables.ConnectionString, command);
            DialogResult = DialogResult.OK;
        }

        private void kartigKodeBtnEdt_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ClientCards clcard = new ClientCards();
            if (clcard.ShowDialog() == DialogResult.OK)
            {
                var dr = clcard.gridView1.GetFocusedDataRow();
                kartigKodeBtnEdt.Text = dr["CODE"].ToString();
                kartigNameBtnEdt.Text = dr["DEFINITION_"].ToString();
            }
        }

        private void iadeKodeBtnEdt_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ClientCards clcard = new ClientCards();
            if (clcard.ShowDialog() == DialogResult.OK)
            {
                var dr = clcard.gridView1.GetFocusedDataRow();
                iadeKodeBtnEdt.Text = dr["CODE"].ToString();
                iadeNameBtnEdt.Text = dr["DEFINITION_"].ToString();
            }
        }

        private void satisKodeBtnEdt_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ClientCards clcard = new ClientCards();
            if (clcard.ShowDialog() == DialogResult.OK)
            {
                var dr = clcard.gridView1.GetFocusedDataRow();
                satisKodeBtnEdt.Text = dr["CODE"].ToString();
                satisNameBtnEdt.Text = dr["DEFINITION_"].ToString();
            }
        }

        private void KhProperties_Load(object sender, EventArgs e)
        {
            _dt = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                $"SELECT * FROM ERP_PROPERTIES WHERE TYPE = 0 AND FIRMNR={Variables.FirmNr}");
            if(_dt.Rows.Count==0) return;

            XDocument xml  = XDocument.Parse(_dt.Rows[0]["PROPERITY"].ToString());
            
            satisKodeBtnEdt.Text = xml.Element("Property").Element("SatisKod").Value;
            satisNameBtnEdt.Text = xml.Element("Property").Element("SatisAd").Value;
            iadeKodeBtnEdt.Text = xml.Element("Property").Element("IadeKod").Value;
            iadeNameBtnEdt.Text = xml.Element("Property").Element("IadeAd").Value;
            kartigKodeBtnEdt.Text = xml.Element("Property").Element("KassaQaliqKod").Value;
            kartigNameBtnEdt.Text = xml.Element("Property").Element("KassaQaliqAd").Value;
        
        }
    }
}