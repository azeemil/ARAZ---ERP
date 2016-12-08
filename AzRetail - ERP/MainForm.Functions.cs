using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ERP.Administrator;
using ERP.Administrator.Properties;
using ERP.Administrator.ReportDesigns;
using ERP.CRM;
using ERP.CRM.Lotoreya;
using ERP.Finance;
using ERP.General;
using ERP.Logistcs;
using ERP.Logistcs.Reporting;
using ERP.Purchase;
using ERP.Market;
using ERP.Market.EndirimliQiymet;
using ERP.Market.MQ;
using ERP.Logistcs.CentralWHouse;
using ERP.CRM.TopluEmeliyyat;

namespace ERP
{
    public partial class MainForm
    {
        public void LoadAppDefaults()
        {
            userNameStsBar.Caption = Variables.WindowsUserName;
            AppVersionStsBar.Caption = Application.ProductVersion;
            AppNameStsBar.Caption = Application.ProductName;
            FirmNameStsBar.Caption = Variables.FirmName;
            FirmNrStsBar.Caption = Variables.FirmNr;
            userNameStsBar.Refresh();

        }

        void item_ItemClick(object sender, ItemClickEventArgs e)
        {
            var barCheckItem = e.Item as BarCheckItem;
            if (barCheckItem != null) 
            {
                ((XtraForm) barCheckItem.Tag).BringToFront();
                ActivateMdiChild((XtraForm) barCheckItem.Tag);
            }

        }

        public void SetTags()
        {
            // Administrator
            usersAdminElmnt.Tag = new Users();
            groupsAdminElmnt.Tag = new Groups();

            //Alis
            PurchOrdersAcElmnt.Tag = new PurchaseOrders();

            //Logistika
            WhouseOrders.Tag = new WhouseOrders();
            OrderGroupActElmnt.Tag = new OrderGroups();
        }

        public void NewForm(XtraForm form)
        {
            BarCheckItem item = new BarCheckItem { Caption = form.Text };
            item.CheckStyle = BarCheckStyles.Radio;
            item.GroupIndex = 1;
            
            item.Border = BorderStyles.Style3D;
            item.ItemClick += item_ItemClick;item.Tag = form;
            form.Tag = MdiToolBar.AddItem(item);
            form.MdiParent = this;
            form.Activated += Form_Activated;
            form.Show();
            form.FormClosed += (Form_FormClosed);
        }


        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = sender as XtraForm;
            if (form != null)
            {
                var s = form.Tag;

                MdiToolBar.ItemLinks.Remove(s as BarItemLink);
            }
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            var form = sender as XtraForm;
            var s = (BarCheckItemLink)form.Tag;
        }

        public void OpenOrBringToFront(XtraForm newForm)
        {

            foreach (Form form in MdiChildren)
            {
                if (form.Name == newForm.Name)
                {
                   form.BringToFront();
                    form.Activate();return;
                }
            }

            NewForm(newForm);

        }

        void LoadPermissions(){
            if (!User.IsAdmin)
            {
                AdministratorAcElmnt.Visible = false;
                PuchasePermissions();
                LogisticsPermissions();
                CrmPermissions();
                MarketPermissions();
                FinancePermissions();
            }
        }

        private void PuchasePermissions()
        {
            PurchAcElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '3'").Any();
            #region Transactions
            PurchTransactionsAcElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '3.1'").Any();
            PurchOrdersAcElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '3.1.1'").Any();

            #endregion
        }

        private void LogisticsPermissions()
        {
            LogisticsAcElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4'").Any();
            #region Transactions
            LogistcsTransactionAcElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.1'").Any();
            WhouseOrders.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.1.1'").Any();
            OrderGroupActElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.1.2'").Any();
            VeyselogluObaSifarisAccItem.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.1.3'").Any();
            MinMaxStokControlAccItem.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.1.4'").Any();
            centralWhouseOrdersAccElement.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.1.5'").Any();
            #endregion
            #region Reporting
            LogistcsReportingAcElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.2'").Any();
            LogistcsTransferedAmountİtm.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '4.2.1'").Any();
            #endregion
        }

        private void CrmPermissions()
        {
            CRMAccElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5'").Any();
            #region Transactions
            CRMAcOperation.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1'").Any();
            CustomersAccItem.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.1'").Any();
            CrmPositions.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.2'").Any();
            CrmGiftsAccItm.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.3'").Any();
            LotoreyaAccElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.4'").Any();
            TopluBonusAccElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.5'").Any();
            TopluMusteriAccElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.1.6'").Any();

            #endregion Transactions

            #region Reports
            CrmReportsAccGrp.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.2'").Any();
            CrmLogsAccElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '5.2.0'").Any();
            #endregion

        }

        private void MarketPermissions()
        {

            MarketAcElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1'").Any();
            #region Transactions
            MarketTransactionAccElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1'").Any();
            MarketPrintPriceAccItm.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1.0'").Any();
            EndirimliQiymetAccItm.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1.2'").Any();
            MarketKassirAccItem.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1.3'").Any();
            MalQebuluAccElement.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '1.1.4'").Any();
            #endregion
        }

        private void FinancePermissions()
        {
            FinanceAcElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '2'").Any();
            #region Transactions
            AccountingTransactionActElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '2.1'").Any();
            TopluFacturaAccItm.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '2.1.1'").Any();
            CassirHesabAlmaActElmnt.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '2.1.2'").Any();
            DocumentKontrolAccItm.Visible = User.UserPermission.Select("LEVEL=0 AND PERMISSION = '2.1.3'").Any();
            
            #endregion
        }




        private void AccordionClick(object sender, EventArgs e)
        {

            var accordionControlElement = sender as AccordionControlElement;
            if (accordionControlElement == null) return;
            XtraForm tag = (XtraForm)accordionControlElement.Tag;

            foreach (Form form in MdiChildren)
            {
                if (form.Name == tag.Name)
                {
                    form.BringToFront();
                    ActivateMdiChild(form);
                    return;
                }
            }

            Type type = tag.GetType();
            var fm = Activator.CreateInstance(type, this) as XtraForm;
            NewForm(fm);

        }


        #region onClick


        private void WhouseOrders_Click(object sender, EventArgs e)
        {
            WhouseOrders order = new WhouseOrders(this);
            OpenOrBringToFront(order);

        }
        private void LotoreyaAccElmnt_Click(object sender, EventArgs e)
        {
           LotoreyaList form = new LotoreyaList();
            OpenOrBringToFront(form);
        }
        private void CustomersItm_Click(object sender, EventArgs e)
        {
            OpenOrBringToFront(new CustomersFrm());
        }

        private void CrmPositions_Click(object sender, EventArgs e)
        {
            OpenOrBringToFront(new CrmPosition());
        }

        private void CrmLogsAccElmnt_Click(object sender, EventArgs e)
        {
            OpenOrBringToFront(new CrmLogs());
        }

        private void MarketPrintPriceAccItm_Click(object sender, EventArgs e)
        {
            OpenOrBringToFront(new ERP.Market.BarcodePrint.PriceEtiketPrint());
        }

        private void ReportTemplatesAccItem_Click(object sender, EventArgs e)
        {
            OpenOrBringToFront(new ReportDesigns());
        }
        private void CassirHesabAlmaActElmnt_Click(object sender, EventArgs e)
        {
          
            KassTransactions kass = new KassTransactions();
            OpenOrBringToFront(kass);

        }

        private void EndirimliQiymetAccItm_Click(object sender, EventArgs e)
        {
            PrcChange prcChange = new PrcChange();
            OpenOrBringToFront(prcChange);
        }

     
        private void VeyselogluObaSifarisAccItem_Click(object sender, EventArgs e)
        {
            VeyseloglunaSifaris frm = new VeyseloglunaSifaris();
            OpenOrBringToFront(frm);

        }

        private void MarketKassirAccItem_Click(object sender, EventArgs e)
        {
            Cashiers cashier = new Cashiers();
            OpenOrBringToFront(cashier);
        }

        private void DocumentKontrolAccItm_Click(object sender, EventArgs e)
        {
            DocumentControl doc = new DocumentControl();
            OpenOrBringToFront(doc);
        }
        private void MinMaxStokControlAccItem_Click(object sender, EventArgs e)
        {
            MinMaxStokLevelControl frm = new MinMaxStokLevelControl();
            OpenOrBringToFront(frm);
        }
        private void CrmGiftsAccItm_Click(object sender, EventArgs e)
        {
            CrmGift frm = new CrmGift();
            OpenOrBringToFront(frm);
        }
        private void AccMobileNumbersItm_Click(object sender, EventArgs e)
        {
            MobileNumbers frm = new MobileNumbers();
            OpenOrBringToFront(frm);
        }

        private void MalQebuluAccElement_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            var mq = new MqFrm();
            OpenOrBringToFront(mq);
            splashScreenManager1.CloseWaitForm();
        }

        private void LogistcsTransferedAmountİtm_Click(object sender, EventArgs e)
        {
            TransferredAmountControlForm frm = new TransferredAmountControlForm();
            OpenOrBringToFront(frm);
        }
        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            ExcelToInvoice frm = new ExcelToInvoice();
            OpenOrBringToFront(frm);
        }
        private void ApproveSystemAccElement_Click(object sender, EventArgs e)
        {
            ERP.Administrator.Properties.ApproveSystem.ApproveSystem frm = new ERP.Administrator.Properties.ApproveSystem.ApproveSystem();
            OpenOrBringToFront(frm);
        }

        private void KSPropertiesAccElmnt_Click(object sender, EventArgs e)
        {
            KhProperties frm = new KhProperties();
            frm.ShowDialog();
        }
        private void centralWhouseOrdersAccElement_Click(object sender, EventArgs e)
        {
           CentralWhouseOrders order = new CentralWhouseOrders();
            OpenOrBringToFront(order);
        }

        private void TopluBonusAccElmnt_Click(object sender, EventArgs e)
        {
            TopluBonus tpb = new TopluBonus();
            OpenOrBringToFront(tpb);
        }

        private void TopluMusteriAccElmnt_Click(object sender, EventArgs e)
        {
            TopluMusteri tpm = new TopluMusteri();
            OpenOrBringToFront(tpm);
        }
        #endregion
    }

       
    }

