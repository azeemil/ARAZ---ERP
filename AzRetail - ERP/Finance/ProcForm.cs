using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.General;
using UnityObjects;

namespace ERP.Finance
{
    public partial class ProcForm : XtraForm
    {
       
        private readonly KassTransactions _mf;
        private readonly string _decimalChar;
        private DataSet _dataSet;
        private LogForm _logForm;
        public ProcForm(KassTransactions mf)
        {
            _mf = mf;
            InitializeComponent();
            _decimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            


        }

        private void ProcForm_Load(object sender, EventArgs e)
        {
            

            var dr = _mf.gridView1.GetFocusedDataRow();
            docNoTxt.Text = dr["LOGICALREF"].ToString();
            cashierNoTxt.Text = dr["CASHIERCODE"].ToString();
            cashierTxt.Text = dr["CASHIERNAME"].ToString();
            dateTxt.Text = DateTime.Parse(dr["DATE_"].ToString()).ToShortDateString();
            rtCodeTxt.Text = dr["EXPLANATION"].ToString();

            branchNoTxt.Text = dr["OFFICECODE"].ToString();
            branchTxt.Text = dr["NAME"].ToString();
            zNoTxt.Text = dr["ZNO"].ToString();
            zTotalTxt.Text = dr["ZREPORTTOTAL"].ToString();
            bKodeTxt.Text = dr["BKOD"].ToString();
            bNameTxt.Text = dr["BAD"].ToString();
            explanationTxt.Text = dr["EXPLAN_"].ToString().Trim();
            
            ferqTxt.Text = dr["FERQ"].ToString();
            posTerminalTxt.Text = dr["CARDTOTAL"].ToString();
            cashTxt.Text = ((float.Parse(zTotalTxt.Text.Replace(".", _decimalChar).Replace(",", _decimalChar))) -
                                        (float.Parse(posTerminalTxt.Text.Replace(".", _decimalChar).Replace(",", _decimalChar)))).ToString(CultureInfo.InvariantCulture);

            iadeTxt.Text = dr["RTFICHETOTAL"].ToString();

            prk1Txt.Text = cashTxt.Text;

            if (float.Parse(iadeTxt.Text, CultureInfo.InvariantCulture.NumberFormat) > 0) prk2Txt.Text = iadeTxt.Text;

            if (float.Parse(ferqTxt.Text, CultureInfo.InvariantCulture.NumberFormat) > 0)
                kassaartigiTxt.Text = ferqTxt.Text;
            else
            {
                kassaeskiyiTxt.Text = ferqTxt.Text;
                groupControl3.Enabled = true;
            }


           

            var kassirQ = string.Format(@"
                                SELECT CLC.CODE,CLC.DEFINITION_,CP.TOTAL FROM {0}LK_{1}_01_CPCUFFS CP
                                INNER JOIN {0}LG_{1}_CLCARD CLC ON CLC.LOGICALREF=CP.CLIENTREF AND CP.MASTERREF={2};
                                SELECT BA.CODE,BA.DEFINITION_,CP.TOTAL  FROM {0}LK_{1}_01_CPBNFICHE CP
                                INNER JOIN {0}LG_{1}_BANKACC BA ON BA.LOGICALREF=CP.BNACCREF
                                AND  CP.MASTERREF={2}
                                        ",Variables.FirmDb,Variables.FirmNr,docNoTxt.Text.Trim());
             _dataSet = Functions.GetSqlServerDataset(Variables.ConnectionString, kassirQ);

             gridControl1.DataSource = _dataSet.Tables[1];
             gridControl2.DataSource = _dataSet.Tables[0];

        }

        private void buttonEdit6_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
        }

        private void iadeNameBtnEdt_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void keskikKodeBtnEdt_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ClientCards clcard = new ClientCards(rtCodeTxt.Text);
            if (clcard.ShowDialog() == DialogResult.OK)
            {
                var dr = clcard.gridView1.GetFocusedDataRow();
                keskikKodeBtnEdt.Text = dr["CODE"].ToString();
                keskiknameBtnEdt.Text = dr["DEFINITION_"].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            var keskikTotal = float.Parse(kassaeskiyiTxt.Text, CultureInfo.InvariantCulture);
            if (kassaeskiyiChbx.Checked)
                if (Math.Abs(keskikTotal) > 0)
                {
                    if (keskikKodeBtnEdt.Text.Trim().Length == 0)
                    {
                        XtraMessageBox.Show("Kassa eskiyi hesabı seçilməyib!");
                        return;
                    }
                }

            Enabled = false;
            spManager.ShowWaitForm();
            _logForm = new LogForm();
            //negd mebleg
            var cashTotal = float.Parse(cashTxt.Text, CultureInfo.InvariantCulture);
            if (satisChbx.Checked)
                if (cashTotal > 0)
                    PostKassa(satisKodeBtnEdt.Text, satisNameBtnEdt.Text, cashTotal, 11,false);

            //iade mebleg
            var iadeTotal = float.Parse(iadeTxt.Text, CultureInfo.InvariantCulture);
            if (iadeChbx.Checked)
                if (iadeTotal > 0)
                    PostKassa(iadeKodeBtnEdt.Text, iadeNameBtnEdt.Text, iadeTotal, 12,false);

            //kassa artigi
            var kartigiTotal = float.Parse(kassaartigiTxt.Text, CultureInfo.InvariantCulture);
            if (kassaartigiChbx.Checked)
                if (kartigiTotal > 0)
                    PostKassa(kartigKodeBtnEdt.Text, kartigNameBtnEdt.Text, kartigiTotal, 11,false);
            
            // kassa eskiyi
            if (kassaeskiyiChbx.Checked)
                if (Math.Abs(keskikTotal) > 0)
                {
                    PostKassa(keskikKodeBtnEdt.Text, keskiknameBtnEdt.Text, Math.Abs(keskikTotal), 12,true);
                }
            
            //diger odemeler

            var veresiye = _dataSet.Tables[0];
            if (digerOdemelerChbx.Checked)
                if (veresiye.Rows.Count > 0)
                    for (int i = 0; i < veresiye.Rows.Count; i++)
                        PostKassa(veresiye.Rows[i][0].ToString(), veresiye.Rows[i][1].ToString(), float.Parse(veresiye.Rows[i][2].ToString(), CultureInfo.InvariantCulture), 12,false);

            //kredit odemeleri 
            
            var kreditTable = _dataSet.Tables[1];
            if (posterminalChbx.Checked)
            if (kreditTable.Rows.Count > 0)
                for (int i = 0; i < kreditTable.Rows.Count; i++)
                    PostCredit(kreditTable.Rows[i][0].ToString(), kreditTable.Rows[i][2].ToString(), kreditTable.Rows[i][1].ToString());

              


           

            Functions.ExecuteStatement(Variables.ConnectionString,
                $"UPDATE {Variables.FirmDb}LK_{Variables.FirmNr}_{Variables.FirmPeriod}_CASHIERPAYMENT SET STATUS = 1,APPROVED = 1 WHERE LOGICALREF = {docNoTxt.Text}");
            Enabled = true;
            spManager.CloseWaitForm();
            _logForm.ShowDialog();
            DialogResult = DialogResult.OK;
        }


        public void PostKassa(string clKode,string clName,float total,int trcode, bool tradingGrp)
        {

            var descr = docNoTxt.Text + " - " + clName;
            Data sdTransaction = Variables.UnityApplication.NewDataObject(DataObjectType.doSafeDepositTrans);
            sdTransaction.New();
            sdTransaction.DataFields.FieldByName("TYPE").Value = trcode;
            sdTransaction.DataFields.FieldByName("NUMBER").Value = "~";
            sdTransaction.DataFields.FieldByName("SD_CODE").Value = bKodeTxt.Text;
            sdTransaction.DataFields.FieldByName("DIVISION").Value = int.Parse(branchNoTxt.Text.Trim());
            sdTransaction.DataFields.FieldByName("AUXIL_CODE").Value = "SISTEM";
            sdTransaction.DataFields.FieldByName("DESCRIPTION").Value = descr;
            sdTransaction.DataFields.FieldByName("DATE").Value = DateTime.Parse(dateTxt.Text.ToString(CultureInfo.CurrentCulture.DateTimeFormat));
            sdTransaction.DataFields.FieldByName("MASTER_TITLE").Value = docNoTxt.Text;
            sdTransaction.DataFields.FieldByName("AMOUNT").Value = total.ToString(CultureInfo.InvariantCulture).Replace(",",".");
            sdTransaction.DataFields.FieldByName("TC_XRATE").Value = 1;
            sdTransaction.DataFields.FieldByName("TC_AMOUNT").Value = total;
            if (tradingGrp) sdTransaction.DataFields.FieldByName("TRADING_GRP").Value = "KASSA_ESKIGI";
            if (trcode == 12) sdTransaction.DataFields.FieldByName("SIGN").Value = 1;

            Lines transaction = sdTransaction.DataFields.FieldByName("ATTACHMENT_ARP").Lines;
            transaction.AppendLine();
            transaction[(transaction.Count - 1)].FieldByName("ARP_CODE").Value = clKode;
            transaction[(transaction.Count - 1)].FieldByName("AUXIL_CODE").Value = "SISTEM";

            if (trcode == 11) transaction[(transaction.Count - 1)].FieldByName("CREDIT").Value = total.ToString(CultureInfo.InvariantCulture).Replace(",", "."); 
            if (trcode == 12) transaction[(transaction.Count - 1)].FieldByName("DEBIT").Value = total.ToString(CultureInfo.InvariantCulture).Replace(",", "."); 

            transaction[(transaction.Count - 1)].FieldByName("DOC_NUMBER").Value = docNoTxt.Text;
            transaction[(transaction.Count - 1)].FieldByName("DESCRIPTION").Value = docNoTxt.Text;

            transaction[(transaction.Count - 1)].FieldByName("TC_XRATE").Value = 1;
            transaction[(transaction.Count - 1)].FieldByName("TC_AMOUNT").Value = total.ToString(CultureInfo.InvariantCulture).Replace(",", "."); 
            if (tradingGrp) transaction[(transaction.Count - 1)].FieldByName("TRADING_GRP").Value = "KASSA_ESKIGI";
            string errorMessage = null;
            string ficheno;
            if (!sdTransaction.Post())
            {
                if (sdTransaction.ErrorCode != 0)
                {

                    errorMessage += @" DB Error : ( " + (sdTransaction.ErrorCode) + ") - " + sdTransaction.ErrorDesc;
                }
                else if (sdTransaction.ValidateErrors.Count > 0)
                {
                    for (int i = 0; i < sdTransaction.ValidateErrors.Count; i++)
                        errorMessage += @"XML Error : (" + (sdTransaction.ValidateErrors[i].ID) + ") - " +
                                        sdTransaction.ValidateErrors[i].Error;

                }

                if (errorMessage != null && errorMessage.Length == 0) errorMessage = sdTransaction.ErrorDesc;
               
              
            }
            else
            {

                ficheno = sdTransaction.DataFields.FieldByName("NUMBER").Value.ToString();
                _logForm.docnoLst.Items.Add(ficheno);
                _logForm.type.Items.Add((trcode == 11) ? "Mədaxil" : "Məxaric");
                _logForm.clcard.Items.Add(clName);
                _logForm.total.Items.Add(total);
            
            }

           
            _logForm.errorstring.Items.Add((string.IsNullOrEmpty(errorMessage))? " ": errorMessage);
            
       
        }
   
        public void PostCredit(string bankCode,string total,string clcard)
        {
          
            Data arpVoucher =Variables.UnityApplication.NewDataObject(DataObjectType.doARAPVoucher);
            arpVoucher.New();
            arpVoucher.DataFields.FieldByName("TYPE").Value = 70;
            arpVoucher.DataFields.FieldByName("NUMBER").Value = "~";
            arpVoucher.DataFields.FieldByName("DATE").Value = DateTime.Parse(dateTxt.Text.ToString(CultureInfo.CurrentCulture.DateTimeFormat));
            arpVoucher.DataFields.FieldByName("AUXIL_CODE").Value = "SISTEM";
            arpVoucher.DataFields.FieldByName("NOTES1").Value = docNoTxt.Text;
            arpVoucher.DataFields.FieldByName("DIVISION").Value = int.Parse(branchNoTxt.Text.Trim());
            arpVoucher.DataFields.FieldByName("DEPARTMENT").Value = 0;
            

            Lines transaction = arpVoucher.DataFields.FieldByName("TRANSACTIONS").Lines;
            transaction.AppendLine();
            transaction[(transaction.Count - 1)].FieldByName("ARP_CODE").Value = satisKodeBtnEdt.Text;
            transaction[(transaction.Count - 1)].FieldByName("BANKACC_CODE").Value = bankCode;
            transaction[(transaction.Count - 1)].FieldByName("CREDIT").Value = total.ToString(CultureInfo.InvariantCulture).Replace(",", "."); 
            

            string errorMessage = null;
            string ficheno = string.Empty;
            if (!arpVoucher.Post())
            {

                if (arpVoucher.ErrorCode != 0)
                {

                    errorMessage += @" DB Error : ( " + (arpVoucher.ErrorCode) + ") - " + arpVoucher.ErrorDesc;
                }
                else if (arpVoucher.ValidateErrors.Count > 0)
                {
                    for (int i = 0; i < arpVoucher.ValidateErrors.Count - 1; i++)
                        errorMessage += @"XML Error : (" + (arpVoucher.ValidateErrors[i].ID) + ") - " +
                                        arpVoucher.ValidateErrors[i].Error;

                }

                if (errorMessage != null && errorMessage.Trim().Length == 0) errorMessage = arpVoucher.ErrorDesc;

            }
            else
            {
                ficheno = arpVoucher.DataFields.FieldByName("NUMBER").Value.ToString();
            }
            
            _logForm.docnoLst.Items.Add(ficheno);
            _logForm.type.Items.Add("Kredit Kartı");
            _logForm.clcard.Items.Add(clcard);
            _logForm.total.Items.Add(total);
            _logForm.errorstring.Items.Add((string.IsNullOrEmpty(errorMessage)) ? " " : errorMessage);
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}