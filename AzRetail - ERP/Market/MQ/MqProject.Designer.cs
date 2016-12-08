using  ERP;
namespace ERP.Market.MQ
{
    partial class MqFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MqFrm));
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP.General.Wait), true, true);
            this.invView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.invLOGICALREF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invFICHENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invDOCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invDATE_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invTIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invSOURCEINDEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invDEFINITION_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invNETTOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invTRCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invBILLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invREQUEST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invBRANCHNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invBRANCH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridInvoice = new DevExpress.XtraGrid.GridControl();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mtView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mtLOGICALREF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mtFICHENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mtDOCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mtDATE_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mtNETTOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mtSOURCEINDEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mtSOURCEWHOUSENAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mtTIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mtDESTWHOUSENAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mtDESTINDEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mtTRCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mtREQUEST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mtAPPROVED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UGIRTRACKINGNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterial = new DevExpress.XtraGrid.GridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.mtTypes = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.mtInvNoTxt = new DevExpress.XtraEditors.TextEdit();
            this.mtDocnoTxt = new DevExpress.XtraEditors.TextEdit();
            this.mtSearch = new DevExpress.XtraEditors.SimpleButton();
            this.TransferInvChbx = new DevExpress.XtraEditors.CheckEdit();
            this.TransferSourceWhouseChbx = new DevExpress.XtraEditors.CheckEdit();
            this.TransferDocnoChbx = new DevExpress.XtraEditors.CheckEdit();
            this.TransferDateChbx = new DevExpress.XtraEditors.CheckEdit();
            this.TransferBegDate = new DevExpress.XtraEditors.DateEdit();
            this.TransferEndDate = new DevExpress.XtraEditors.DateEdit();
            this.TransferDestWhouseCmbx = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.TransferSourceWhouseCmbx = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.TransferDestWhouseChbx = new DevExpress.XtraEditors.CheckEdit();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.irsaliyye = new DevExpress.XtraEditors.GroupControl();
            this.invTypes = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.invSearch = new DevExpress.XtraEditors.SimpleButton();
            this.invBranchCmbx = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.invDocnoTxbx = new DevExpress.XtraEditors.TextEdit();
            this.invWhouseChbx = new DevExpress.XtraEditors.CheckEdit();
            this.invDocnoChbx = new DevExpress.XtraEditors.CheckEdit();
            this.invDateChbx = new DevExpress.XtraEditors.CheckEdit();
            this.invInvnoTxbx = new DevExpress.XtraEditors.TextEdit();
            this.InvBegDate = new DevExpress.XtraEditors.DateEdit();
            this.invBranchChbx = new DevExpress.XtraEditors.CheckEdit();
            this.InvEndDate = new DevExpress.XtraEditors.DateEdit();
            this.invInvnoChbx = new DevExpress.XtraEditors.CheckEdit();
            this.invWhouseCmbx = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.tab = new DevExpress.XtraTab.XtraTabControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.InvRefreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.InvDetailsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.InvPrintBtn = new DevExpress.XtraBars.BarButtonItem();
            this.InvPrintSelectedBtn = new DevExpress.XtraBars.BarButtonItem();
            this.InvGridToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.InvDeleteRequest = new DevExpress.XtraBars.BarSubItem();
            this.InvRequestBtn = new DevExpress.XtraBars.BarButtonItem();
            this.InvCancelRequestBtn = new DevExpress.XtraBars.BarButtonItem();
            this.InvApproveRequest = new DevExpress.XtraBars.BarButtonItem();
            this.invGridPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.InvSendToApproveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.mtRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.mtDetails = new DevExpress.XtraBars.BarButtonItem();
            this.mtPrint = new DevExpress.XtraBars.BarButtonItem();
            this.mtPrintSelected = new DevExpress.XtraBars.BarButtonItem();
            this.mtGridToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.mtRequestSub = new DevExpress.XtraBars.BarSubItem();
            this.mtNewRequestBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.mtGeneralReport = new DevExpress.XtraBars.BarButtonItem();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.invREQUESTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mtREQUESTID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.invView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaterial)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtInvNoTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtDocnoTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferInvChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferSourceWhouseChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferDocnoChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferDateChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferBegDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferBegDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferDestWhouseCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferSourceWhouseCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferDestWhouseChbx.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.irsaliyye)).BeginInit();
            this.irsaliyye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invBranchCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invDocnoTxbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invWhouseChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invDocnoChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invDateChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invInvnoTxbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvBegDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvBegDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invBranchChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invInvnoChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invWhouseCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).BeginInit();
            this.tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // invView
            // 
            this.invView.Appearance.HorzLine.BorderColor = System.Drawing.Color.Gray;
            this.invView.Appearance.HorzLine.Options.UseBorderColor = true;
            this.invView.Appearance.SelectedRow.BackColor = System.Drawing.Color.Silver;
            this.invView.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.invView.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.invView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.invView.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.invView.Appearance.VertLine.BorderColor = System.Drawing.Color.Gray;
            this.invView.Appearance.VertLine.Options.UseBorderColor = true;
            this.invView.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invView.Appearance.ViewCaption.Options.UseFont = true;
            this.invView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.invView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.invLOGICALREF,
            this.invFICHENO,
            this.invDOCODE,
            this.invDATE_,
            this.invTIP,
            this.invSOURCEINDEX,
            this.invNAME,
            this.invCODE,
            this.invDEFINITION_,
            this.invNETTOTAL,
            this.invTRCODE,
            this.invBILLED,
            this.invREQUEST,
            this.invBRANCHNO,
            this.invBRANCH,
            this.invREQUESTID});
            this.invView.GridControl = this.gridInvoice;
            this.invView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.invView.IndicatorWidth = 50;
            this.invView.Name = "invView";
            this.invView.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.invView.OptionsSelection.MultiSelect = true;
            this.invView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.invView.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.invView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.invView.OptionsView.ShowAutoFilterRow = true;
            this.invView.OptionsView.ShowFooter = true;
            this.invView.OptionsView.ShowGroupPanel = false;
            this.invView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.invView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.invView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.invView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.invView.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.invView.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // invLOGICALREF
            // 
            this.invLOGICALREF.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invLOGICALREF.AppearanceHeader.Options.UseFont = true;
            this.invLOGICALREF.FieldName = "LOGICALREF";
            this.invLOGICALREF.Name = "invLOGICALREF";
            this.invLOGICALREF.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // invFICHENO
            // 
            this.invFICHENO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invFICHENO.AppearanceHeader.Options.UseFont = true;
            this.invFICHENO.Caption = "Qaimə №";
            this.invFICHENO.FieldName = "FICHENO";
            this.invFICHENO.Name = "invFICHENO";
            this.invFICHENO.OptionsColumn.AllowEdit = false;
            this.invFICHENO.OptionsColumn.AllowFocus = false;
            this.invFICHENO.OptionsColumn.ReadOnly = true;
            this.invFICHENO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FICHENO", "{0}")});
            this.invFICHENO.Visible = true;
            this.invFICHENO.VisibleIndex = 1;
            this.invFICHENO.Width = 67;
            // 
            // invDOCODE
            // 
            this.invDOCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invDOCODE.AppearanceHeader.Options.UseFont = true;
            this.invDOCODE.Caption = "Sənəd №";
            this.invDOCODE.FieldName = "DOCODE";
            this.invDOCODE.Name = "invDOCODE";
            this.invDOCODE.OptionsColumn.AllowEdit = false;
            this.invDOCODE.OptionsColumn.AllowFocus = false;
            this.invDOCODE.OptionsColumn.ReadOnly = true;
            this.invDOCODE.Visible = true;
            this.invDOCODE.VisibleIndex = 2;
            // 
            // invDATE_
            // 
            this.invDATE_.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invDATE_.AppearanceHeader.Options.UseFont = true;
            this.invDATE_.Caption = "Tarix";
            this.invDATE_.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.invDATE_.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.invDATE_.FieldName = "DATE_";
            this.invDATE_.Name = "invDATE_";
            this.invDATE_.OptionsColumn.AllowEdit = false;
            this.invDATE_.OptionsColumn.AllowFocus = false;
            this.invDATE_.OptionsColumn.ReadOnly = true;
            this.invDATE_.Visible = true;
            this.invDATE_.VisibleIndex = 3;
            this.invDATE_.Width = 98;
            // 
            // invTIP
            // 
            this.invTIP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invTIP.AppearanceHeader.Options.UseFont = true;
            this.invTIP.Caption = "Növ";
            this.invTIP.FieldName = "TIP";
            this.invTIP.Name = "invTIP";
            this.invTIP.OptionsColumn.AllowEdit = false;
            this.invTIP.OptionsColumn.AllowFocus = false;
            this.invTIP.OptionsColumn.ReadOnly = true;
            this.invTIP.Visible = true;
            this.invTIP.VisibleIndex = 11;
            this.invTIP.Width = 57;
            // 
            // invSOURCEINDEX
            // 
            this.invSOURCEINDEX.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invSOURCEINDEX.AppearanceHeader.Options.UseFont = true;
            this.invSOURCEINDEX.Caption = "Anbar №";
            this.invSOURCEINDEX.FieldName = "SOURCEINDEX";
            this.invSOURCEINDEX.Name = "invSOURCEINDEX";
            this.invSOURCEINDEX.OptionsColumn.AllowEdit = false;
            this.invSOURCEINDEX.OptionsColumn.AllowFocus = false;
            this.invSOURCEINDEX.OptionsColumn.ReadOnly = true;
            this.invSOURCEINDEX.Visible = true;
            this.invSOURCEINDEX.VisibleIndex = 6;
            this.invSOURCEINDEX.Width = 64;
            // 
            // invNAME
            // 
            this.invNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invNAME.AppearanceHeader.Options.UseFont = true;
            this.invNAME.Caption = "Anbar";
            this.invNAME.FieldName = "NAME";
            this.invNAME.Name = "invNAME";
            this.invNAME.OptionsColumn.AllowEdit = false;
            this.invNAME.OptionsColumn.AllowFocus = false;
            this.invNAME.OptionsColumn.ReadOnly = true;
            this.invNAME.Visible = true;
            this.invNAME.VisibleIndex = 7;
            this.invNAME.Width = 98;
            // 
            // invCODE
            // 
            this.invCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invCODE.AppearanceHeader.Options.UseFont = true;
            this.invCODE.Caption = "Cari Kodu";
            this.invCODE.FieldName = "CODE";
            this.invCODE.Name = "invCODE";
            this.invCODE.OptionsColumn.AllowEdit = false;
            this.invCODE.OptionsColumn.AllowFocus = false;
            this.invCODE.OptionsColumn.ReadOnly = true;
            this.invCODE.Visible = true;
            this.invCODE.VisibleIndex = 8;
            this.invCODE.Width = 98;
            // 
            // invDEFINITION_
            // 
            this.invDEFINITION_.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invDEFINITION_.AppearanceHeader.Options.UseFont = true;
            this.invDEFINITION_.Caption = "Cari Adı";
            this.invDEFINITION_.FieldName = "DEFINITION_";
            this.invDEFINITION_.Name = "invDEFINITION_";
            this.invDEFINITION_.OptionsColumn.AllowEdit = false;
            this.invDEFINITION_.OptionsColumn.AllowFocus = false;
            this.invDEFINITION_.OptionsColumn.ReadOnly = true;
            this.invDEFINITION_.Visible = true;
            this.invDEFINITION_.VisibleIndex = 9;
            this.invDEFINITION_.Width = 255;
            // 
            // invNETTOTAL
            // 
            this.invNETTOTAL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invNETTOTAL.AppearanceHeader.Options.UseFont = true;
            this.invNETTOTAL.Caption = "Tutar";
            this.invNETTOTAL.FieldName = "NETTOTAL";
            this.invNETTOTAL.Name = "invNETTOTAL";
            this.invNETTOTAL.OptionsColumn.AllowEdit = false;
            this.invNETTOTAL.OptionsColumn.AllowFocus = false;
            this.invNETTOTAL.OptionsColumn.ReadOnly = true;
            this.invNETTOTAL.Visible = true;
            this.invNETTOTAL.VisibleIndex = 10;
            this.invNETTOTAL.Width = 106;
            // 
            // invTRCODE
            // 
            this.invTRCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invTRCODE.AppearanceHeader.Options.UseFont = true;
            this.invTRCODE.Caption = "TRCODE";
            this.invTRCODE.FieldName = "TRCODE";
            this.invTRCODE.Name = "invTRCODE";
            this.invTRCODE.OptionsColumn.ShowInCustomizationForm = false;
            this.invTRCODE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // invBILLED
            // 
            this.invBILLED.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invBILLED.AppearanceHeader.Options.UseFont = true;
            this.invBILLED.Caption = "Fakturalanıb";
            this.invBILLED.FieldName = "BILLED";
            this.invBILLED.Name = "invBILLED";
            this.invBILLED.OptionsColumn.AllowEdit = false;
            this.invBILLED.OptionsColumn.AllowFocus = false;
            this.invBILLED.OptionsColumn.ReadOnly = true;
            this.invBILLED.Visible = true;
            this.invBILLED.VisibleIndex = 12;
            this.invBILLED.Width = 71;
            // 
            // invREQUEST
            // 
            this.invREQUEST.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invREQUEST.AppearanceHeader.Options.UseFont = true;
            this.invREQUEST.Caption = "Silinəcək";
            this.invREQUEST.FieldName = "REQUEST";
            this.invREQUEST.Name = "invREQUEST";
            this.invREQUEST.OptionsColumn.AllowEdit = false;
            this.invREQUEST.OptionsColumn.AllowFocus = false;
            this.invREQUEST.OptionsColumn.ReadOnly = true;
            this.invREQUEST.Visible = true;
            this.invREQUEST.VisibleIndex = 13;
            this.invREQUEST.Width = 109;
            // 
            // invBRANCHNO
            // 
            this.invBRANCHNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invBRANCHNO.AppearanceHeader.Options.UseFont = true;
            this.invBRANCHNO.Caption = "Filial №";
            this.invBRANCHNO.FieldName = "BRANCHNO";
            this.invBRANCHNO.Name = "invBRANCHNO";
            this.invBRANCHNO.OptionsColumn.AllowEdit = false;
            this.invBRANCHNO.OptionsColumn.AllowFocus = false;
            this.invBRANCHNO.OptionsColumn.ReadOnly = true;
            this.invBRANCHNO.Visible = true;
            this.invBRANCHNO.VisibleIndex = 4;
            this.invBRANCHNO.Width = 53;
            // 
            // invBRANCH
            // 
            this.invBRANCH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invBRANCH.AppearanceHeader.Options.UseFont = true;
            this.invBRANCH.Caption = "Filial";
            this.invBRANCH.FieldName = "BRANCH";
            this.invBRANCH.Name = "invBRANCH";
            this.invBRANCH.OptionsColumn.AllowEdit = false;
            this.invBRANCH.OptionsColumn.AllowFocus = false;
            this.invBRANCH.OptionsColumn.ReadOnly = true;
            this.invBRANCH.Visible = true;
            this.invBRANCH.VisibleIndex = 5;
            this.invBRANCH.Width = 92;
            // 
            // gridInvoice
            // 
            this.gridInvoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridInvoice.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gridInvoice.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridInvoice.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gridInvoice.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridInvoice.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridInvoice.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridInvoice.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridInvoice.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridInvoice.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gridInvoice.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridInvoice.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridInvoice.EmbeddedNavigator.TextStringFormat = "Sənəd {0} of {1}";
            gridLevelNode3.RelationName = "Level1";
            this.gridInvoice.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            this.gridInvoice.Location = new System.Drawing.Point(0, 146);
            this.gridInvoice.MainView = this.invView;
            this.gridInvoice.Name = "gridInvoice";
            this.gridInvoice.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridInvoice.Size = new System.Drawing.Size(1320, 502);
            this.gridInvoice.TabIndex = 1;
            this.gridInvoice.UseEmbeddedNavigator = true;
            this.gridInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.invView,
            this.gridView7});
            this.gridInvoice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridInvoice_MouseClick);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridView7
            // 
            this.gridView7.GridControl = this.gridInvoice;
            this.gridView7.Name = "gridView7";
            // 
            // mtView
            // 
            this.mtView.Appearance.HorzLine.BorderColor = System.Drawing.Color.Gray;
            this.mtView.Appearance.HorzLine.Options.UseBorderColor = true;
            this.mtView.Appearance.SelectedRow.BackColor = System.Drawing.Color.Silver;
            this.mtView.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mtView.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mtView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.mtView.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.mtView.Appearance.VertLine.BorderColor = System.Drawing.Color.Gray;
            this.mtView.Appearance.VertLine.Options.UseBorderColor = true;
            this.mtView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.mtView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.mtLOGICALREF,
            this.mtFICHENO,
            this.mtDOCODE,
            this.mtDATE_,
            this.mtNETTOTAL,
            this.mtSOURCEINDEX,
            this.mtSOURCEWHOUSENAME,
            this.mtTIP,
            this.mtDESTWHOUSENAME,
            this.mtDESTINDEX,
            this.mtTRCODE,
            this.mtREQUEST,
            this.mtAPPROVED,
            this.UGIRTRACKINGNO,
            this.mtREQUESTID});
            this.mtView.GridControl = this.gridMaterial;
            this.mtView.IndicatorWidth = 50;
            this.mtView.Name = "mtView";
            this.mtView.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.mtView.OptionsSelection.MultiSelect = true;
            this.mtView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.mtView.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.mtView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.mtView.OptionsView.ShowAutoFilterRow = true;
            this.mtView.OptionsView.ShowGroupPanel = false;
            this.mtView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.mtView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.mtView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView2_CustomDrawRowIndicator);
            this.mtView.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView2_RowStyle);
            this.mtView.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // mtLOGICALREF
            // 
            this.mtLOGICALREF.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mtLOGICALREF.AppearanceHeader.Options.UseFont = true;
            this.mtLOGICALREF.FieldName = "LOGICALREF";
            this.mtLOGICALREF.Name = "mtLOGICALREF";
            // 
            // mtFICHENO
            // 
            this.mtFICHENO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mtFICHENO.AppearanceHeader.Options.UseFont = true;
            this.mtFICHENO.Caption = "Qaimə №";
            this.mtFICHENO.FieldName = "FICHENO";
            this.mtFICHENO.Name = "mtFICHENO";
            this.mtFICHENO.OptionsColumn.AllowEdit = false;
            this.mtFICHENO.OptionsColumn.AllowFocus = false;
            this.mtFICHENO.Visible = true;
            this.mtFICHENO.VisibleIndex = 1;
            this.mtFICHENO.Width = 83;
            // 
            // mtDOCODE
            // 
            this.mtDOCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mtDOCODE.AppearanceHeader.Options.UseFont = true;
            this.mtDOCODE.Caption = "Sənəd №";
            this.mtDOCODE.FieldName = "DOCODE";
            this.mtDOCODE.Name = "mtDOCODE";
            this.mtDOCODE.OptionsColumn.AllowEdit = false;
            this.mtDOCODE.OptionsColumn.AllowFocus = false;
            this.mtDOCODE.Visible = true;
            this.mtDOCODE.VisibleIndex = 2;
            this.mtDOCODE.Width = 97;
            // 
            // mtDATE_
            // 
            this.mtDATE_.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mtDATE_.AppearanceHeader.Options.UseFont = true;
            this.mtDATE_.Caption = "Tarix";
            this.mtDATE_.FieldName = "DATE_";
            this.mtDATE_.Name = "mtDATE_";
            this.mtDATE_.OptionsColumn.AllowEdit = false;
            this.mtDATE_.OptionsColumn.AllowFocus = false;
            this.mtDATE_.Visible = true;
            this.mtDATE_.VisibleIndex = 3;
            this.mtDATE_.Width = 110;
            // 
            // mtNETTOTAL
            // 
            this.mtNETTOTAL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mtNETTOTAL.AppearanceHeader.Options.UseFont = true;
            this.mtNETTOTAL.Caption = "Toplam";
            this.mtNETTOTAL.FieldName = "NETTOTAL";
            this.mtNETTOTAL.Name = "mtNETTOTAL";
            this.mtNETTOTAL.OptionsColumn.AllowEdit = false;
            this.mtNETTOTAL.OptionsColumn.AllowFocus = false;
            this.mtNETTOTAL.Visible = true;
            this.mtNETTOTAL.VisibleIndex = 9;
            this.mtNETTOTAL.Width = 104;
            // 
            // mtSOURCEINDEX
            // 
            this.mtSOURCEINDEX.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mtSOURCEINDEX.AppearanceHeader.Options.UseFont = true;
            this.mtSOURCEINDEX.Caption = "Anbar (1) №";
            this.mtSOURCEINDEX.FieldName = "SOURCEINDEX";
            this.mtSOURCEINDEX.Name = "mtSOURCEINDEX";
            this.mtSOURCEINDEX.OptionsColumn.AllowEdit = false;
            this.mtSOURCEINDEX.OptionsColumn.AllowFocus = false;
            this.mtSOURCEINDEX.Visible = true;
            this.mtSOURCEINDEX.VisibleIndex = 4;
            this.mtSOURCEINDEX.Width = 110;
            // 
            // mtSOURCEWHOUSENAME
            // 
            this.mtSOURCEWHOUSENAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mtSOURCEWHOUSENAME.AppearanceHeader.Options.UseFont = true;
            this.mtSOURCEWHOUSENAME.Caption = "Anbar (1)";
            this.mtSOURCEWHOUSENAME.FieldName = "SOURCEWHOUSENAME";
            this.mtSOURCEWHOUSENAME.Name = "mtSOURCEWHOUSENAME";
            this.mtSOURCEWHOUSENAME.OptionsColumn.AllowEdit = false;
            this.mtSOURCEWHOUSENAME.OptionsColumn.AllowFocus = false;
            this.mtSOURCEWHOUSENAME.Visible = true;
            this.mtSOURCEWHOUSENAME.VisibleIndex = 5;
            this.mtSOURCEWHOUSENAME.Width = 110;
            // 
            // mtTIP
            // 
            this.mtTIP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mtTIP.AppearanceHeader.Options.UseFont = true;
            this.mtTIP.Caption = "Növ";
            this.mtTIP.FieldName = "TIP";
            this.mtTIP.Name = "mtTIP";
            this.mtTIP.OptionsColumn.AllowEdit = false;
            this.mtTIP.OptionsColumn.AllowFocus = false;
            this.mtTIP.Visible = true;
            this.mtTIP.VisibleIndex = 8;
            this.mtTIP.Width = 168;
            // 
            // mtDESTWHOUSENAME
            // 
            this.mtDESTWHOUSENAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mtDESTWHOUSENAME.AppearanceHeader.Options.UseFont = true;
            this.mtDESTWHOUSENAME.Caption = "Anbar (2)";
            this.mtDESTWHOUSENAME.FieldName = "DESTWHOUSENAME";
            this.mtDESTWHOUSENAME.Name = "mtDESTWHOUSENAME";
            this.mtDESTWHOUSENAME.OptionsColumn.AllowEdit = false;
            this.mtDESTWHOUSENAME.OptionsColumn.AllowFocus = false;
            this.mtDESTWHOUSENAME.Visible = true;
            this.mtDESTWHOUSENAME.VisibleIndex = 7;
            this.mtDESTWHOUSENAME.Width = 110;
            // 
            // mtDESTINDEX
            // 
            this.mtDESTINDEX.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mtDESTINDEX.AppearanceHeader.Options.UseFont = true;
            this.mtDESTINDEX.Caption = "Anbar (2) №";
            this.mtDESTINDEX.FieldName = "DESTINDEX";
            this.mtDESTINDEX.Name = "mtDESTINDEX";
            this.mtDESTINDEX.OptionsColumn.AllowEdit = false;
            this.mtDESTINDEX.OptionsColumn.AllowFocus = false;
            this.mtDESTINDEX.Visible = true;
            this.mtDESTINDEX.VisibleIndex = 6;
            this.mtDESTINDEX.Width = 123;
            // 
            // mtTRCODE
            // 
            this.mtTRCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mtTRCODE.AppearanceHeader.Options.UseFont = true;
            this.mtTRCODE.Caption = "TROCDE";
            this.mtTRCODE.FieldName = "TRCODE";
            this.mtTRCODE.Name = "mtTRCODE";
            // 
            // mtREQUEST
            // 
            this.mtREQUEST.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mtREQUEST.AppearanceHeader.Options.UseFont = true;
            this.mtREQUEST.Caption = "Silinəcək";
            this.mtREQUEST.FieldName = "REQUEST";
            this.mtREQUEST.Name = "mtREQUEST";
            this.mtREQUEST.OptionsColumn.AllowEdit = false;
            this.mtREQUEST.OptionsColumn.AllowFocus = false;
            this.mtREQUEST.OptionsColumn.ReadOnly = true;
            this.mtREQUEST.Visible = true;
            this.mtREQUEST.VisibleIndex = 10;
            this.mtREQUEST.Width = 71;
            // 
            // mtAPPROVED
            // 
            this.mtAPPROVED.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mtAPPROVED.AppearanceHeader.Options.UseFont = true;
            this.mtAPPROVED.Caption = "Yoxlanılıb";
            this.mtAPPROVED.FieldName = "APPROVE";
            this.mtAPPROVED.Name = "mtAPPROVED";
            this.mtAPPROVED.OptionsColumn.AllowEdit = false;
            this.mtAPPROVED.OptionsColumn.AllowFocus = false;
            this.mtAPPROVED.Visible = true;
            this.mtAPPROVED.VisibleIndex = 11;
            this.mtAPPROVED.Width = 80;
            // 
            // UGIRTRACKINGNO
            // 
            this.UGIRTRACKINGNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.UGIRTRACKINGNO.AppearanceHeader.Options.UseFont = true;
            this.UGIRTRACKINGNO.Caption = "İzləmə №";
            this.UGIRTRACKINGNO.FieldName = "UGIRTRACKINGNO";
            this.UGIRTRACKINGNO.Name = "UGIRTRACKINGNO";
            this.UGIRTRACKINGNO.OptionsColumn.AllowEdit = false;
            this.UGIRTRACKINGNO.OptionsColumn.AllowFocus = false;
            this.UGIRTRACKINGNO.Visible = true;
            this.UGIRTRACKINGNO.VisibleIndex = 12;
            this.UGIRTRACKINGNO.Width = 87;
            // 
            // gridMaterial
            // 
            this.gridMaterial.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMaterial.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode1.RelationName = "Level1";
            this.gridMaterial.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridMaterial.Location = new System.Drawing.Point(0, 156);
            this.gridMaterial.MainView = this.mtView;
            this.gridMaterial.Name = "gridMaterial";
            this.gridMaterial.Size = new System.Drawing.Size(1320, 492);
            this.gridMaterial.TabIndex = 2;
            this.gridMaterial.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mtView});
            this.gridMaterial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridMaterial_MouseClick);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridMaterial);
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.Image = global::ERP.Properties.Resources.icon_lorry;
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1320, 648);
            this.xtraTabPage2.Text = "Material Sənədləri";
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.groupControl2.Controls.Add(this.mtTypes);
            this.groupControl2.Controls.Add(this.mtInvNoTxt);
            this.groupControl2.Controls.Add(this.mtDocnoTxt);
            this.groupControl2.Controls.Add(this.mtSearch);
            this.groupControl2.Controls.Add(this.TransferInvChbx);
            this.groupControl2.Controls.Add(this.TransferSourceWhouseChbx);
            this.groupControl2.Controls.Add(this.TransferDocnoChbx);
            this.groupControl2.Controls.Add(this.TransferDateChbx);
            this.groupControl2.Controls.Add(this.TransferBegDate);
            this.groupControl2.Controls.Add(this.TransferEndDate);
            this.groupControl2.Controls.Add(this.TransferDestWhouseCmbx);
            this.groupControl2.Controls.Add(this.TransferSourceWhouseCmbx);
            this.groupControl2.Controls.Add(this.TransferDestWhouseChbx);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1320, 156);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Axtarış";
            // 
            // mtTypes
            // 
            this.mtTypes.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.mtTypes.Appearance.Options.UseFont = true;
            this.mtTypes.HorizontalScrollbar = true;
            this.mtTypes.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(25)), "Transfer", System.Windows.Forms.CheckState.Checked, "1.1.4.2.1.0"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(20)), "Mərkəzdən Çıxan", System.Windows.Forms.CheckState.Checked, "1.1.4.2.1.1"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(15)), "Mərkəzdən Gələn", System.Windows.Forms.CheckState.Checked, "1.1.4.2.1.2"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(11)), "İmha", System.Windows.Forms.CheckState.Checked, "1.1.4.2.1.3"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(12)), "Sərf", System.Windows.Forms.CheckState.Checked, "1.1.4.2.1.4"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(13)), "Ürətim", System.Windows.Forms.CheckState.Checked, "1.1.4.2.1.5")});
            this.mtTypes.Location = new System.Drawing.Point(552, 27);
            this.mtTypes.MultiColumn = true;
            this.mtTypes.Name = "mtTypes";
            this.mtTypes.Size = new System.Drawing.Size(179, 117);
            this.mtTypes.TabIndex = 29;
            // 
            // mtInvNoTxt
            // 
            this.mtInvNoTxt.Enabled = false;
            this.mtInvNoTxt.Location = new System.Drawing.Point(96, 29);
            this.mtInvNoTxt.Name = "mtInvNoTxt";
            this.mtInvNoTxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.mtInvNoTxt.Properties.Appearance.Options.UseFont = true;
            this.mtInvNoTxt.Properties.Mask.EditMask = "f0";
            this.mtInvNoTxt.Size = new System.Drawing.Size(150, 22);
            this.mtInvNoTxt.TabIndex = 28;
            // 
            // mtDocnoTxt
            // 
            this.mtDocnoTxt.Enabled = false;
            this.mtDocnoTxt.Location = new System.Drawing.Point(96, 56);
            this.mtDocnoTxt.Name = "mtDocnoTxt";
            this.mtDocnoTxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.mtDocnoTxt.Properties.Appearance.Options.UseFont = true;
            this.mtDocnoTxt.Size = new System.Drawing.Size(150, 22);
            this.mtDocnoTxt.TabIndex = 27;
            // 
            // mtSearch
            // 
            this.mtSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtSearch.Appearance.Options.UseFont = true;
            this.mtSearch.Image = ((System.Drawing.Image)(resources.GetObject("mtSearch.Image")));
            this.mtSearch.Location = new System.Drawing.Point(796, 27);
            this.mtSearch.Name = "mtSearch";
            this.mtSearch.Size = new System.Drawing.Size(161, 40);
            this.mtSearch.TabIndex = 18;
            this.mtSearch.Text = "Axtar";
            this.mtSearch.Click += new System.EventHandler(this.MtSearch);
            // 
            // TransferInvChbx
            // 
            this.TransferInvChbx.Location = new System.Drawing.Point(4, 29);
            this.TransferInvChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TransferInvChbx.Name = "TransferInvChbx";
            this.TransferInvChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.TransferInvChbx.Properties.Appearance.Options.UseFont = true;
            this.TransferInvChbx.Properties.Caption = "Qaimə №";
            this.TransferInvChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.TransferInvChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.TransferInvChbx.Size = new System.Drawing.Size(85, 22);
            this.TransferInvChbx.TabIndex = 26;
            this.TransferInvChbx.CheckedChanged += new System.EventHandler(this.MtCheckEditCheckedChanged);
            // 
            // TransferSourceWhouseChbx
            // 
            this.TransferSourceWhouseChbx.Location = new System.Drawing.Point(303, 29);
            this.TransferSourceWhouseChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TransferSourceWhouseChbx.Name = "TransferSourceWhouseChbx";
            this.TransferSourceWhouseChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.TransferSourceWhouseChbx.Properties.Appearance.Options.UseFont = true;
            this.TransferSourceWhouseChbx.Properties.Caption = "(G)Anbar";
            this.TransferSourceWhouseChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.TransferSourceWhouseChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.TransferSourceWhouseChbx.Size = new System.Drawing.Size(85, 22);
            this.TransferSourceWhouseChbx.TabIndex = 12;
            this.TransferSourceWhouseChbx.Tag = "2";
            this.TransferSourceWhouseChbx.CheckedChanged += new System.EventHandler(this.MtCheckEditCheckedChanged);
            // 
            // TransferDocnoChbx
            // 
            this.TransferDocnoChbx.Location = new System.Drawing.Point(4, 56);
            this.TransferDocnoChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TransferDocnoChbx.Name = "TransferDocnoChbx";
            this.TransferDocnoChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.TransferDocnoChbx.Properties.Appearance.Options.UseFont = true;
            this.TransferDocnoChbx.Properties.Caption = "Sənəd №";
            this.TransferDocnoChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.TransferDocnoChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.TransferDocnoChbx.Size = new System.Drawing.Size(85, 22);
            this.TransferDocnoChbx.TabIndex = 25;
            this.TransferDocnoChbx.CheckedChanged += new System.EventHandler(this.MtCheckEditCheckedChanged);
            // 
            // TransferDateChbx
            // 
            this.TransferDateChbx.EditValue = true;
            this.TransferDateChbx.Location = new System.Drawing.Point(4, 86);
            this.TransferDateChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TransferDateChbx.Name = "TransferDateChbx";
            this.TransferDateChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.TransferDateChbx.Properties.Appearance.Options.UseFont = true;
            this.TransferDateChbx.Properties.Caption = "Tarix";
            this.TransferDateChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.TransferDateChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.TransferDateChbx.Size = new System.Drawing.Size(85, 22);
            this.TransferDateChbx.TabIndex = 9;
            this.TransferDateChbx.Tag = "5";
            this.TransferDateChbx.CheckedChanged += new System.EventHandler(this.MtCheckEditCheckedChanged);
            // 
            // TransferBegDate
            // 
            this.TransferBegDate.EditValue = new System.DateTime(2015, 1, 22, 0, 0, 0, 0);
            this.TransferBegDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TransferBegDate.Location = new System.Drawing.Point(95, 84);
            this.TransferBegDate.Name = "TransferBegDate";
            this.TransferBegDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TransferBegDate.Properties.Appearance.Options.UseFont = true;
            this.TransferBegDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.TransferBegDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TransferBegDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TransferBegDate.Size = new System.Drawing.Size(86, 24);
            this.TransferBegDate.TabIndex = 10;
            // 
            // TransferEndDate
            // 
            this.TransferEndDate.EditValue = new System.DateTime(2015, 1, 22, 0, 0, 0, 0);
            this.TransferEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TransferEndDate.Location = new System.Drawing.Point(187, 84);
            this.TransferEndDate.Name = "TransferEndDate";
            this.TransferEndDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TransferEndDate.Properties.Appearance.Options.UseFont = true;
            this.TransferEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.TransferEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TransferEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TransferEndDate.Size = new System.Drawing.Size(88, 24);
            this.TransferEndDate.TabIndex = 11;
            // 
            // TransferDestWhouseCmbx
            // 
            this.TransferDestWhouseCmbx.Location = new System.Drawing.Point(397, 57);
            this.TransferDestWhouseCmbx.Name = "TransferDestWhouseCmbx";
            this.TransferDestWhouseCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TransferDestWhouseCmbx.Properties.Appearance.Options.UseFont = true;
            this.TransferDestWhouseCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TransferDestWhouseCmbx.Properties.DisplayMember = "DISPLAYNAME";
            this.TransferDestWhouseCmbx.Properties.ValueMember = "NR";
            this.TransferDestWhouseCmbx.Size = new System.Drawing.Size(129, 22);
            this.TransferDestWhouseCmbx.TabIndex = 22;
            // 
            // TransferSourceWhouseCmbx
            // 
            this.TransferSourceWhouseCmbx.Location = new System.Drawing.Point(397, 29);
            this.TransferSourceWhouseCmbx.Name = "TransferSourceWhouseCmbx";
            this.TransferSourceWhouseCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TransferSourceWhouseCmbx.Properties.Appearance.Options.UseFont = true;
            this.TransferSourceWhouseCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TransferSourceWhouseCmbx.Properties.DisplayMember = "DISPLAYNAME";
            this.TransferSourceWhouseCmbx.Properties.ValueMember = "NR";
            this.TransferSourceWhouseCmbx.Size = new System.Drawing.Size(129, 22);
            this.TransferSourceWhouseCmbx.TabIndex = 13;
            // 
            // TransferDestWhouseChbx
            // 
            this.TransferDestWhouseChbx.Location = new System.Drawing.Point(303, 57);
            this.TransferDestWhouseChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TransferDestWhouseChbx.Name = "TransferDestWhouseChbx";
            this.TransferDestWhouseChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.TransferDestWhouseChbx.Properties.Appearance.Options.UseFont = true;
            this.TransferDestWhouseChbx.Properties.Caption = "(Ç)Anbar";
            this.TransferDestWhouseChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.TransferDestWhouseChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.TransferDestWhouseChbx.Size = new System.Drawing.Size(85, 22);
            this.TransferDestWhouseChbx.TabIndex = 21;
            this.TransferDestWhouseChbx.Tag = "2";
            this.TransferDestWhouseChbx.CheckedChanged += new System.EventHandler(this.MtCheckEditCheckedChanged);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridInvoice);
            this.xtraTabPage1.Controls.Add(this.irsaliyye);
            this.xtraTabPage1.Image = global::ERP.Properties.Resources.contract_512;
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1320, 648);
            this.xtraTabPage1.Text = "Satınalma və Satış Sənədləri";
            // 
            // irsaliyye
            // 
            this.irsaliyye.Appearance.BackColor = System.Drawing.Color.Gray;
            this.irsaliyye.Appearance.Options.UseBackColor = true;
            this.irsaliyye.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.irsaliyye.Controls.Add(this.invTypes);
            this.irsaliyye.Controls.Add(this.invSearch);
            this.irsaliyye.Controls.Add(this.invBranchCmbx);
            this.irsaliyye.Controls.Add(this.invDocnoTxbx);
            this.irsaliyye.Controls.Add(this.invWhouseChbx);
            this.irsaliyye.Controls.Add(this.invDocnoChbx);
            this.irsaliyye.Controls.Add(this.invDateChbx);
            this.irsaliyye.Controls.Add(this.invInvnoTxbx);
            this.irsaliyye.Controls.Add(this.InvBegDate);
            this.irsaliyye.Controls.Add(this.invBranchChbx);
            this.irsaliyye.Controls.Add(this.InvEndDate);
            this.irsaliyye.Controls.Add(this.invInvnoChbx);
            this.irsaliyye.Controls.Add(this.invWhouseCmbx);
            this.irsaliyye.Dock = System.Windows.Forms.DockStyle.Top;
            this.irsaliyye.Location = new System.Drawing.Point(0, 0);
            this.irsaliyye.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.irsaliyye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.irsaliyye.Name = "irsaliyye";
            this.irsaliyye.Size = new System.Drawing.Size(1320, 146);
            this.irsaliyye.TabIndex = 0;
            this.irsaliyye.Text = "Axtarış";
            // 
            // invTypes
            // 
            this.invTypes.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.invTypes.Appearance.Options.UseFont = true;
            this.invTypes.HorizontalScrollbar = true;
            this.invTypes.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(1)), "Alış", System.Windows.Forms.CheckState.Checked, "1.1.4.1.1.0"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(6)), "Alış İadə", System.Windows.Forms.CheckState.Checked, "1.1.4.1.1.1"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(7)), "Satış", System.Windows.Forms.CheckState.Checked, "1.1.4.1.1.2"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(2)), "Satış İadə", System.Windows.Forms.CheckState.Checked, "1.1.4.1.1.3"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(8)), "Topdan Satış", System.Windows.Forms.CheckState.Checked, "1.1.4.1.1.4"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(3)), "Topdan Satış İadə", System.Windows.Forms.CheckState.Checked, "1.1.4.1.1.5")});
            this.invTypes.Location = new System.Drawing.Point(563, 23);
            this.invTypes.MultiColumn = true;
            this.invTypes.Name = "invTypes";
            this.invTypes.Size = new System.Drawing.Size(179, 117);
            this.invTypes.TabIndex = 22;
            // 
            // invSearch
            // 
            this.invSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invSearch.Appearance.Options.UseFont = true;
            this.invSearch.Image = ((System.Drawing.Image)(resources.GetObject("invSearch.Image")));
            this.invSearch.Location = new System.Drawing.Point(764, 34);
            this.invSearch.Name = "invSearch";
            this.invSearch.Size = new System.Drawing.Size(161, 40);
            this.invSearch.TabIndex = 21;
            this.invSearch.Text = "Axtar";
            this.invSearch.Click += new System.EventHandler(this.InvSearch);
            // 
            // invBranchCmbx
            // 
            this.invBranchCmbx.Location = new System.Drawing.Point(100, 31);
            this.invBranchCmbx.Name = "invBranchCmbx";
            this.invBranchCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.invBranchCmbx.Properties.Appearance.Options.UseFont = true;
            this.invBranchCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.invBranchCmbx.Properties.DisplayMember = "DISPLAYNAME";
            this.invBranchCmbx.Properties.ValueMember = "NR";
            this.invBranchCmbx.Size = new System.Drawing.Size(149, 22);
            this.invBranchCmbx.TabIndex = 20;
            // 
            // invDocnoTxbx
            // 
            this.invDocnoTxbx.Enabled = false;
            this.invDocnoTxbx.Location = new System.Drawing.Point(380, 58);
            this.invDocnoTxbx.Name = "invDocnoTxbx";
            this.invDocnoTxbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.invDocnoTxbx.Properties.Appearance.Options.UseFont = true;
            this.invDocnoTxbx.Size = new System.Drawing.Size(150, 22);
            this.invDocnoTxbx.TabIndex = 7;
            // 
            // invWhouseChbx
            // 
            this.invWhouseChbx.Location = new System.Drawing.Point(8, 58);
            this.invWhouseChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.invWhouseChbx.Name = "invWhouseChbx";
            this.invWhouseChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.invWhouseChbx.Properties.Appearance.Options.UseFont = true;
            this.invWhouseChbx.Properties.Caption = "Anbar";
            this.invWhouseChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.invWhouseChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.invWhouseChbx.Size = new System.Drawing.Size(87, 22);
            this.invWhouseChbx.TabIndex = 12;
            this.invWhouseChbx.Tag = "2";
            this.invWhouseChbx.CheckedChanged += new System.EventHandler(this.InvCheckEditCheckedChanged);
            // 
            // invDocnoChbx
            // 
            this.invDocnoChbx.Location = new System.Drawing.Point(268, 58);
            this.invDocnoChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.invDocnoChbx.Name = "invDocnoChbx";
            this.invDocnoChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.invDocnoChbx.Properties.Appearance.Options.UseFont = true;
            this.invDocnoChbx.Properties.Caption = "Sənəd №";
            this.invDocnoChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.invDocnoChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.invDocnoChbx.Size = new System.Drawing.Size(105, 22);
            this.invDocnoChbx.TabIndex = 5;
            this.invDocnoChbx.CheckedChanged += new System.EventHandler(this.InvCheckEditCheckedChanged);
            // 
            // invDateChbx
            // 
            this.invDateChbx.EditValue = true;
            this.invDateChbx.Location = new System.Drawing.Point(9, 89);
            this.invDateChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.invDateChbx.Name = "invDateChbx";
            this.invDateChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.invDateChbx.Properties.Appearance.Options.UseFont = true;
            this.invDateChbx.Properties.Caption = "Tarix";
            this.invDateChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.invDateChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.invDateChbx.Size = new System.Drawing.Size(70, 22);
            this.invDateChbx.TabIndex = 9;
            this.invDateChbx.Tag = "5";
            this.invDateChbx.CheckedChanged += new System.EventHandler(this.InvCheckEditCheckedChanged);
            // 
            // invInvnoTxbx
            // 
            this.invInvnoTxbx.Enabled = false;
            this.invInvnoTxbx.Location = new System.Drawing.Point(380, 31);
            this.invInvnoTxbx.Name = "invInvnoTxbx";
            this.invInvnoTxbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.invInvnoTxbx.Properties.Appearance.Options.UseFont = true;
            this.invInvnoTxbx.Properties.Mask.EditMask = "f0";
            this.invInvnoTxbx.Size = new System.Drawing.Size(150, 22);
            this.invInvnoTxbx.TabIndex = 8;
            // 
            // InvBegDate
            // 
            this.InvBegDate.EditValue = new System.DateTime(2015, 1, 22, 0, 0, 0, 0);
            this.InvBegDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InvBegDate.Location = new System.Drawing.Point(101, 87);
            this.InvBegDate.Name = "InvBegDate";
            this.InvBegDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.InvBegDate.Properties.Appearance.Options.UseFont = true;
            this.InvBegDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.InvBegDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.InvBegDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.InvBegDate.Size = new System.Drawing.Size(116, 24);
            this.InvBegDate.TabIndex = 10;
            // 
            // invBranchChbx
            // 
            this.invBranchChbx.Location = new System.Drawing.Point(8, 31);
            this.invBranchChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.invBranchChbx.Name = "invBranchChbx";
            this.invBranchChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.invBranchChbx.Properties.Appearance.Options.UseFont = true;
            this.invBranchChbx.Properties.Caption = "İş Yeri";
            this.invBranchChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.invBranchChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.invBranchChbx.Size = new System.Drawing.Size(87, 22);
            this.invBranchChbx.TabIndex = 19;
            this.invBranchChbx.Tag = "1";
            this.invBranchChbx.CheckedChanged += new System.EventHandler(this.InvCheckEditCheckedChanged);
            // 
            // InvEndDate
            // 
            this.InvEndDate.EditValue = new System.DateTime(2015, 1, 22, 0, 0, 0, 0);
            this.InvEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InvEndDate.Location = new System.Drawing.Point(229, 87);
            this.InvEndDate.Name = "InvEndDate";
            this.InvEndDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.InvEndDate.Properties.Appearance.Options.UseFont = true;
            this.InvEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.InvEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.InvEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.InvEndDate.Size = new System.Drawing.Size(117, 24);
            this.InvEndDate.TabIndex = 11;
            // 
            // invInvnoChbx
            // 
            this.invInvnoChbx.Location = new System.Drawing.Point(268, 31);
            this.invInvnoChbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.invInvnoChbx.Name = "invInvnoChbx";
            this.invInvnoChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.invInvnoChbx.Properties.Appearance.Options.UseFont = true;
            this.invInvnoChbx.Properties.Caption = "Qaimə №";
            this.invInvnoChbx.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style7;
            this.invInvnoChbx.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.invInvnoChbx.Size = new System.Drawing.Size(105, 22);
            this.invInvnoChbx.TabIndex = 6;
            this.invInvnoChbx.CheckedChanged += new System.EventHandler(this.InvCheckEditCheckedChanged);
            // 
            // invWhouseCmbx
            // 
            this.invWhouseCmbx.Location = new System.Drawing.Point(100, 58);
            this.invWhouseCmbx.Name = "invWhouseCmbx";
            this.invWhouseCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.invWhouseCmbx.Properties.Appearance.Options.UseFont = true;
            this.invWhouseCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.invWhouseCmbx.Properties.DisplayMember = "DISPLAYNAME";
            this.invWhouseCmbx.Properties.ValueMember = "NR";
            this.invWhouseCmbx.Size = new System.Drawing.Size(149, 22);
            this.invWhouseCmbx.TabIndex = 13;
            // 
            // tab
            // 
            this.tab.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tab.Appearance.Options.UseFont = true;
            this.tab.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tab.AppearancePage.Header.Options.UseFont = true;
            this.tab.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab.Name = "tab";
            this.tab.SelectedTabPage = this.xtraTabPage1;
            this.tab.Size = new System.Drawing.Size(1330, 699);
            this.tab.TabIndex = 2;
            this.tab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.InvRefreshBtn),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.InvDetailsBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.InvPrintBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.InvPrintSelectedBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.InvGridToExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.InvRequestBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.invGridPrint, true)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // InvRefreshBtn
            // 
            this.InvRefreshBtn.Caption = "Yenilə";
            this.InvRefreshBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("InvRefreshBtn.Glyph")));
            this.InvRefreshBtn.Id = 11;
            this.InvRefreshBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("InvRefreshBtn.LargeGlyph")));
            this.InvRefreshBtn.Name = "InvRefreshBtn";
            this.InvRefreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InvRefreshBtn_ItemClick);
            // 
            // InvDetailsBtn
            // 
            this.InvDetailsBtn.Caption = "Incələ";
            this.InvDetailsBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("InvDetailsBtn.Glyph")));
            this.InvDetailsBtn.Id = 0;
            this.InvDetailsBtn.ImageIndex = 5;
            this.InvDetailsBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("InvDetailsBtn.LargeGlyph")));
            this.InvDetailsBtn.Name = "InvDetailsBtn";
            this.InvDetailsBtn.Tag = ((short)(1));
            this.InvDetailsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InvDetailsBtn_ItemClick);
            // 
            // InvPrintBtn
            // 
            this.InvPrintBtn.Caption = "Çap Et";
            this.InvPrintBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("InvPrintBtn.Glyph")));
            this.InvPrintBtn.Id = 1;
            this.InvPrintBtn.ImageIndex = 4;
            this.InvPrintBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("InvPrintBtn.LargeGlyph")));
            this.InvPrintBtn.Name = "InvPrintBtn";
            this.InvPrintBtn.Tag = ((short)(2));
            this.InvPrintBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InvPrintBtn_ItemClick);
            // 
            // InvPrintSelectedBtn
            // 
            this.InvPrintSelectedBtn.Caption = "Toplu Çap Et";
            this.InvPrintSelectedBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("InvPrintSelectedBtn.Glyph")));
            this.InvPrintSelectedBtn.Id = 2;
            this.InvPrintSelectedBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("InvPrintSelectedBtn.LargeGlyph")));
            this.InvPrintSelectedBtn.Name = "InvPrintSelectedBtn";
            this.InvPrintSelectedBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InvPrintSelectedBtn_ItemClick);
            // 
            // InvGridToExcel
            // 
            this.InvGridToExcel.Caption = "Excel";
            this.InvGridToExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("InvGridToExcel.Glyph")));
            this.InvGridToExcel.Id = 5;
            this.InvGridToExcel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("InvGridToExcel.LargeGlyph")));
            this.InvGridToExcel.Name = "InvGridToExcel";
            this.InvGridToExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InvGridToExcel_ItemClick);
            // 
            // InvDeleteRequest
            // 
            this.InvDeleteRequest.Caption = "Silinmə Tələbi";
            this.InvDeleteRequest.Glyph = ((System.Drawing.Image)(resources.GetObject("InvDeleteRequest.Glyph")));
            this.InvDeleteRequest.Id = 6;
            this.InvDeleteRequest.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("InvDeleteRequest.LargeGlyph")));
            this.InvDeleteRequest.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.InvApproveRequest)});
            this.InvDeleteRequest.Name = "InvDeleteRequest";
            // 
            // InvRequestBtn
            // 
            this.InvRequestBtn.Caption = "Silinmə Tələbi";
            this.InvRequestBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("InvRequestBtn.Glyph")));
            this.InvRequestBtn.Id = 7;
            this.InvRequestBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("InvRequestBtn.LargeGlyph")));
            this.InvRequestBtn.Name = "InvRequestBtn";
            this.InvRequestBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InvNewRequestBtn_ItemClick);
            // 
            // InvCancelRequestBtn
            // 
            this.InvCancelRequestBtn.Caption = "Tələbi Ləğv Et";
            this.InvCancelRequestBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("InvCancelRequestBtn.Glyph")));
            this.InvCancelRequestBtn.Id = 8;
            this.InvCancelRequestBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("InvCancelRequestBtn.LargeGlyph")));
            this.InvCancelRequestBtn.Name = "InvCancelRequestBtn";
            // 
            // InvApproveRequest
            // 
            this.InvApproveRequest.Caption = "Təsdiqlə";
            this.InvApproveRequest.Glyph = ((System.Drawing.Image)(resources.GetObject("InvApproveRequest.Glyph")));
            this.InvApproveRequest.Id = 10;
            this.InvApproveRequest.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("InvApproveRequest.LargeGlyph")));
            this.InvApproveRequest.Name = "InvApproveRequest";
            // 
            // invGridPrint
            // 
            this.invGridPrint.Caption = "Fakruralanmamış Sənədlər";
            this.invGridPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("invGridPrint.Glyph")));
            this.invGridPrint.Id = 12;
            this.invGridPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("invGridPrint.LargeGlyph")));
            this.invGridPrint.Name = "invGridPrint";
            this.invGridPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InvGridPrint_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.InvDetailsBtn,
            this.InvPrintBtn,
            this.InvPrintSelectedBtn,
            this.barButtonItem1,
            this.barButtonItem2,
            this.InvGridToExcel,
            this.InvDeleteRequest,
            this.InvRequestBtn,
            this.InvCancelRequestBtn,
            this.InvSendToApproveBtn,
            this.InvApproveRequest,
            this.InvRefreshBtn,
            this.invGridPrint});
            this.barManager1.MaxItemId = 13;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1330, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 699);
            this.barDockControlBottom.Size = new System.Drawing.Size(1330, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 699);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1330, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 699);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Silinmə Tələbi";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Silməni Təsdiqlə";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // InvSendToApproveBtn
            // 
            this.InvSendToApproveBtn.Caption = "Təsdiqə Göndər";
            this.InvSendToApproveBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("InvSendToApproveBtn.Glyph")));
            this.InvSendToApproveBtn.Id = 9;
            this.InvSendToApproveBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("InvSendToApproveBtn.LargeGlyph")));
            this.InvSendToApproveBtn.Name = "InvSendToApproveBtn";
            // 
            // popupMenu2
            // 
            this.popupMenu2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mtRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mtDetails, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.mtPrint, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mtPrintSelected),
            new DevExpress.XtraBars.LinkPersistInfo(this.mtGridToExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.mtNewRequestBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mtGeneralReport, true)});
            this.popupMenu2.Manager = this.barManager2;
            this.popupMenu2.Name = "popupMenu2";
            // 
            // mtRefresh
            // 
            this.mtRefresh.Caption = "Yenilə";
            this.mtRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("mtRefresh.Glyph")));
            this.mtRefresh.Id = 11;
            this.mtRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mtRefresh.LargeGlyph")));
            this.mtRefresh.Name = "mtRefresh";
            this.mtRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mtRefresh_ItemClick);
            // 
            // mtDetails
            // 
            this.mtDetails.Caption = "Incələ";
            this.mtDetails.Glyph = ((System.Drawing.Image)(resources.GetObject("mtDetails.Glyph")));
            this.mtDetails.Id = 0;
            this.mtDetails.ImageIndex = 5;
            this.mtDetails.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mtDetails.LargeGlyph")));
            this.mtDetails.Name = "mtDetails";
            this.mtDetails.Tag = ((short)(1));
            this.mtDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mtDetails_ItemClick);
            // 
            // mtPrint
            // 
            this.mtPrint.Caption = "Çap Et";
            this.mtPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("mtPrint.Glyph")));
            this.mtPrint.Id = 1;
            this.mtPrint.ImageIndex = 4;
            this.mtPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mtPrint.LargeGlyph")));
            this.mtPrint.Name = "mtPrint";
            this.mtPrint.Tag = ((short)(2));
            this.mtPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mtPrint_ItemClick);
            // 
            // mtPrintSelected
            // 
            this.mtPrintSelected.Caption = "Toplu Çap Et";
            this.mtPrintSelected.Glyph = ((System.Drawing.Image)(resources.GetObject("mtPrintSelected.Glyph")));
            this.mtPrintSelected.Id = 2;
            this.mtPrintSelected.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mtPrintSelected.LargeGlyph")));
            this.mtPrintSelected.Name = "mtPrintSelected";
            this.mtPrintSelected.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mtPrintSelected_ItemClick);
            // 
            // mtGridToExcel
            // 
            this.mtGridToExcel.Caption = "Excel";
            this.mtGridToExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("mtGridToExcel.Glyph")));
            this.mtGridToExcel.Id = 5;
            this.mtGridToExcel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mtGridToExcel.LargeGlyph")));
            this.mtGridToExcel.Name = "mtGridToExcel";
            // 
            // mtRequestSub
            // 
            this.mtRequestSub.Caption = "Silinmə Tələbi";
            this.mtRequestSub.Glyph = ((System.Drawing.Image)(resources.GetObject("mtRequestSub.Glyph")));
            this.mtRequestSub.Id = 6;
            this.mtRequestSub.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mtRequestSub.LargeGlyph")));
            this.mtRequestSub.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem10)});
            this.mtRequestSub.Name = "mtRequestSub";
            // 
            // mtNewRequestBtn
            // 
            this.mtNewRequestBtn.Caption = "Silinmə Tələbi";
            this.mtNewRequestBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("mtNewRequestBtn.Glyph")));
            this.mtNewRequestBtn.Id = 7;
            this.mtNewRequestBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mtNewRequestBtn.LargeGlyph")));
            this.mtNewRequestBtn.Name = "mtNewRequestBtn";
            this.mtNewRequestBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mtNewRequestBtn_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Tələbi Ləğv Et";
            this.barButtonItem9.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.Glyph")));
            this.barButtonItem9.Id = 8;
            this.barButtonItem9.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.LargeGlyph")));
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Təsdiqlə";
            this.barButtonItem10.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.Glyph")));
            this.barButtonItem10.Id = 10;
            this.barButtonItem10.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.LargeGlyph")));
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // mtGeneralReport
            // 
            this.mtGeneralReport.Caption = "Ümumi Hesabat";
            this.mtGeneralReport.Glyph = ((System.Drawing.Image)(resources.GetObject("mtGeneralReport.Glyph")));
            this.mtGeneralReport.Id = 12;
            this.mtGeneralReport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mtGeneralReport.LargeGlyph")));
            this.mtGeneralReport.Name = "mtGeneralReport";
            this.mtGeneralReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mtGeneralReport_ItemClick);
            // 
            // barManager2
            // 
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mtDetails,
            this.mtPrint,
            this.mtPrintSelected,
            this.barButtonItem12,
            this.barButtonItem13,
            this.mtGridToExcel,
            this.mtRequestSub,
            this.mtNewRequestBtn,
            this.barButtonItem9,
            this.barButtonItem14,
            this.barButtonItem10,
            this.mtRefresh,
            this.mtGeneralReport});
            this.barManager2.MaxItemId = 13;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(1330, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 699);
            this.barDockControl2.Size = new System.Drawing.Size(1330, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Size = new System.Drawing.Size(0, 699);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1330, 0);
            this.barDockControl4.Size = new System.Drawing.Size(0, 699);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Silinmə Tələbi";
            this.barButtonItem12.Id = 3;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Silməni Təsdiqlə";
            this.barButtonItem13.Id = 4;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Təsdiqə Göndər";
            this.barButtonItem14.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.Glyph")));
            this.barButtonItem14.Id = 9;
            this.barButtonItem14.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.LargeGlyph")));
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // invREQUESTID
            // 
            this.invREQUESTID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.invREQUESTID.AppearanceHeader.Options.UseFont = true;
            this.invREQUESTID.Caption = "Müracət №";
            this.invREQUESTID.FieldName = "REQUESTID";
            this.invREQUESTID.Name = "invREQUESTID";
            this.invREQUESTID.OptionsColumn.AllowEdit = false;
            this.invREQUESTID.OptionsColumn.AllowFocus = false;
            this.invREQUESTID.OptionsColumn.ReadOnly = true;
            this.invREQUESTID.Visible = true;
            this.invREQUESTID.VisibleIndex = 14;
            // 
            // mtREQUESTID
            // 
            this.mtREQUESTID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mtREQUESTID.AppearanceHeader.Options.UseFont = true;
            this.mtREQUESTID.Caption = "Müracət №";
            this.mtREQUESTID.FieldName = "REQUESTID";
            this.mtREQUESTID.Name = "mtREQUESTID";
            this.mtREQUESTID.OptionsColumn.AllowEdit = false;
            this.mtREQUESTID.OptionsColumn.AllowFocus = false;
            this.mtREQUESTID.OptionsColumn.ReadOnly = true;
            this.mtREQUESTID.Visible = true;
            this.mtREQUESTID.VisibleIndex = 13;
            // 
            // MqFrm
            // 
            this.ActiveGlowColor = System.Drawing.Color.Gray;
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 699);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.Silver;
            this.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MqFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mal Qəbulu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.invView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaterial)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mtTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtInvNoTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtDocnoTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferInvChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferSourceWhouseChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferDocnoChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferDateChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferBegDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferBegDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferDestWhouseCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferSourceWhouseCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferDestWhouseChbx.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.irsaliyye)).EndInit();
            this.irsaliyye.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invBranchCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invDocnoTxbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invWhouseChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invDocnoChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invDateChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invInvnoTxbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvBegDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvBegDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invBranchChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invInvnoChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invWhouseCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).EndInit();
            this.tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView invView;
        private DevExpress.XtraGrid.Columns.GridColumn invLOGICALREF;
        private DevExpress.XtraGrid.Columns.GridColumn invFICHENO;
        private DevExpress.XtraGrid.Columns.GridColumn invDOCODE;
        private DevExpress.XtraGrid.Columns.GridColumn invDATE_;
        private DevExpress.XtraGrid.Columns.GridColumn invTIP;
        private DevExpress.XtraGrid.Columns.GridColumn invSOURCEINDEX;
        private DevExpress.XtraGrid.Columns.GridColumn invNAME;
        private DevExpress.XtraGrid.Columns.GridColumn invCODE;
        private DevExpress.XtraGrid.Columns.GridColumn invDEFINITION_;
        private DevExpress.XtraGrid.Columns.GridColumn invNETTOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn invTRCODE;
        private DevExpress.XtraGrid.Columns.GridColumn invBILLED;
        private DevExpress.XtraGrid.Columns.GridColumn invREQUEST;
        private DevExpress.XtraGrid.GridControl gridInvoice;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView mtView;
        private DevExpress.XtraGrid.Columns.GridColumn mtLOGICALREF;
        private DevExpress.XtraGrid.Columns.GridColumn mtFICHENO;
        private DevExpress.XtraGrid.Columns.GridColumn mtDOCODE;
        private DevExpress.XtraGrid.Columns.GridColumn mtDATE_;
        private DevExpress.XtraGrid.Columns.GridColumn mtNETTOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn mtSOURCEINDEX;
        private DevExpress.XtraGrid.Columns.GridColumn mtSOURCEWHOUSENAME;
        private DevExpress.XtraGrid.Columns.GridColumn mtTIP;
        private DevExpress.XtraGrid.Columns.GridColumn mtDESTWHOUSENAME;
        private DevExpress.XtraGrid.Columns.GridColumn mtDESTINDEX;
        private DevExpress.XtraGrid.Columns.GridColumn mtTRCODE;
        private DevExpress.XtraGrid.Columns.GridColumn mtREQUEST;
        private DevExpress.XtraGrid.GridControl gridMaterial;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl irsaliyye;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraTab.XtraTabControl tab;
        private DevExpress.XtraEditors.TextEdit invInvnoTxbx;
        private DevExpress.XtraEditors.TextEdit invDocnoTxbx;
        private DevExpress.XtraEditors.CheckEdit invInvnoChbx;
        private DevExpress.XtraEditors.CheckEdit invDocnoChbx;
        private DevExpress.XtraEditors.TextEdit mtInvNoTxt;
        private DevExpress.XtraEditors.TextEdit mtDocnoTxt;
        private DevExpress.XtraEditors.CheckEdit TransferInvChbx;
        private DevExpress.XtraEditors.CheckEdit TransferDocnoChbx;
        private DevExpress.XtraEditors.CheckedComboBoxEdit TransferDestWhouseCmbx;
        private DevExpress.XtraEditors.CheckEdit TransferDestWhouseChbx;
        private DevExpress.XtraEditors.SimpleButton mtSearch;
        private DevExpress.XtraEditors.CheckedComboBoxEdit TransferSourceWhouseCmbx;
        private DevExpress.XtraEditors.DateEdit TransferEndDate;
        private DevExpress.XtraEditors.DateEdit TransferBegDate;
        private DevExpress.XtraEditors.CheckEdit TransferDateChbx;
        private DevExpress.XtraEditors.CheckEdit TransferSourceWhouseChbx;
        private DevExpress.XtraEditors.CheckedComboBoxEdit invBranchCmbx;
        private DevExpress.XtraEditors.CheckEdit invBranchChbx;
        private DevExpress.XtraEditors.CheckedComboBoxEdit invWhouseCmbx;
        private DevExpress.XtraEditors.DateEdit InvEndDate;
        private DevExpress.XtraEditors.DateEdit InvBegDate;
        private DevExpress.XtraEditors.CheckEdit invDateChbx;
        private DevExpress.XtraEditors.CheckEdit invWhouseChbx;
        private DevExpress.XtraEditors.SimpleButton invSearch;
        private DevExpress.XtraGrid.Columns.GridColumn invBRANCHNO;
        private DevExpress.XtraGrid.Columns.GridColumn invBRANCH;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.CheckedListBoxControl invTypes;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem InvDetailsBtn;
        private DevExpress.XtraBars.BarButtonItem InvPrintBtn;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem InvPrintSelectedBtn;
        private DevExpress.XtraBars.BarButtonItem InvRefreshBtn;
        private DevExpress.XtraBars.BarButtonItem InvGridToExcel;
        private DevExpress.XtraBars.BarSubItem InvDeleteRequest;
        private DevExpress.XtraBars.BarButtonItem InvRequestBtn;
        private DevExpress.XtraBars.BarButtonItem InvCancelRequestBtn;
        private DevExpress.XtraBars.BarButtonItem InvSendToApproveBtn;
        private DevExpress.XtraBars.BarButtonItem InvApproveRequest;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem invGridPrint;
        private DevExpress.XtraGrid.Columns.GridColumn mtAPPROVED;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private DevExpress.XtraBars.BarButtonItem mtRefresh;
        private DevExpress.XtraBars.BarButtonItem mtDetails;
        private DevExpress.XtraBars.BarButtonItem mtPrint;
        private DevExpress.XtraBars.BarButtonItem mtPrintSelected;
        private DevExpress.XtraBars.BarButtonItem mtGridToExcel;
        private DevExpress.XtraBars.BarSubItem mtRequestSub;
        private DevExpress.XtraBars.BarButtonItem mtNewRequestBtn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem mtGeneralReport;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraEditors.CheckedListBoxControl mtTypes;
        private DevExpress.XtraGrid.Columns.GridColumn UGIRTRACKINGNO;
        private DevExpress.XtraGrid.Columns.GridColumn invREQUESTID;
        private DevExpress.XtraGrid.Columns.GridColumn mtREQUESTID;
    }
}

