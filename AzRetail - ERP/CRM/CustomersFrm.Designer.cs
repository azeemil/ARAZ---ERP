namespace ERP.CRM
{
    partial class CustomersFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersFrm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.progress = new DevExpress.XtraWaitForm.ProgressPanel();
            this.BDayText = new System.Windows.Forms.DateTimePicker();
            this.FNameTxbx = new DevExpress.XtraEditors.TextEdit();
            this.FNameChbx = new DevExpress.XtraEditors.CheckEdit();
            this.BDayChbx = new DevExpress.XtraEditors.CheckEdit();
            this.SearchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CardNoChbx = new DevExpress.XtraEditors.CheckEdit();
            this.CardNoTxbx = new DevExpress.XtraEditors.TextEdit();
            this.SNameChbx = new DevExpress.XtraEditors.CheckEdit();
            this.NameChbx = new DevExpress.XtraEditors.CheckEdit();
            this.SNameTxbx = new DevExpress.XtraEditors.TextEdit();
            this.NameTxbx = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LOGICALREF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SURNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATHERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BIRTHDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TCNUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MARRIED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MOBILTEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.POSITION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PUAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.EditBtn = new DevExpress.XtraBars.BarButtonItem();
            this.TransactionBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Bonus = new DevExpress.XtraBars.BarSubItem();
            this.BonusArtir = new DevExpress.XtraBars.BarButtonItem();
            this.BonusAzalt = new DevExpress.XtraBars.BarButtonItem();
            this.TransferBtn = new DevExpress.XtraBars.BarButtonItem();
            this.SendToExcelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FNameTxbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FNameChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDayChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardNoChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardNoTxbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNameChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNameTxbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTxbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.progress);
            this.groupControl1.Controls.Add(this.BDayText);
            this.groupControl1.Controls.Add(this.FNameTxbx);
            this.groupControl1.Controls.Add(this.FNameChbx);
            this.groupControl1.Controls.Add(this.BDayChbx);
            this.groupControl1.Controls.Add(this.SearchBtn);
            this.groupControl1.Controls.Add(this.CardNoChbx);
            this.groupControl1.Controls.Add(this.CardNoTxbx);
            this.groupControl1.Controls.Add(this.SNameChbx);
            this.groupControl1.Controls.Add(this.NameChbx);
            this.groupControl1.Controls.Add(this.SNameTxbx);
            this.groupControl1.Controls.Add(this.NameTxbx);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(973, 153);
            this.groupControl1.TabIndex = 0;
            // 
            // progress
            // 
            this.progress.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progress.Appearance.Options.UseBackColor = true;
            this.progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progress.Location = new System.Drawing.Point(2, 123);
            this.progress.Name = "progress";
            this.progress.ShowCaption = false;
            this.progress.ShowDescription = false;
            this.progress.Size = new System.Drawing.Size(969, 28);
            this.progress.TabIndex = 22;
            this.progress.Text = "progressPanel1";
            this.progress.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // BDayText
            // 
            this.BDayText.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BDayText.Location = new System.Drawing.Point(469, 61);
            this.BDayText.Name = "BDayText";
            this.BDayText.Size = new System.Drawing.Size(167, 21);
            this.BDayText.TabIndex = 9;
            // 
            // FNameTxbx
            // 
            this.FNameTxbx.Location = new System.Drawing.Point(469, 27);
            this.FNameTxbx.Name = "FNameTxbx";
            this.FNameTxbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FNameTxbx.Properties.Appearance.Options.UseFont = true;
            this.FNameTxbx.Size = new System.Drawing.Size(167, 20);
            this.FNameTxbx.TabIndex = 7;
            // 
            // FNameChbx
            // 
            this.FNameChbx.Location = new System.Drawing.Point(329, 28);
            this.FNameChbx.Name = "FNameChbx";
            this.FNameChbx.Properties.AllowFocused = false;
            this.FNameChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.FNameChbx.Properties.Appearance.Options.UseFont = true;
            this.FNameChbx.Properties.Caption = "Ata adı";
            this.FNameChbx.Size = new System.Drawing.Size(104, 20);
            this.FNameChbx.TabIndex = 6;
            this.FNameChbx.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // BDayChbx
            // 
            this.BDayChbx.Location = new System.Drawing.Point(329, 64);
            this.BDayChbx.Name = "BDayChbx";
            this.BDayChbx.Properties.AllowFocused = false;
            this.BDayChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BDayChbx.Properties.Appearance.Options.UseFont = true;
            this.BDayChbx.Properties.Caption = "Doğum Tarixi";
            this.BDayChbx.Size = new System.Drawing.Size(104, 20);
            this.BDayChbx.TabIndex = 8;
            this.BDayChbx.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SearchBtn.Appearance.Options.UseFont = true;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.Location = new System.Drawing.Point(762, 43);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(148, 42);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Text = "Axtar";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CardNoChbx
            // 
            this.CardNoChbx.Location = new System.Drawing.Point(17, 28);
            this.CardNoChbx.Name = "CardNoChbx";
            this.CardNoChbx.Properties.AllowFocused = false;
            this.CardNoChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.CardNoChbx.Properties.Appearance.Options.UseFont = true;
            this.CardNoChbx.Properties.Caption = "Kart №";
            this.CardNoChbx.Size = new System.Drawing.Size(83, 20);
            this.CardNoChbx.TabIndex = 0;
            this.CardNoChbx.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // CardNoTxbx
            // 
            this.CardNoTxbx.Location = new System.Drawing.Point(118, 28);
            this.CardNoTxbx.Name = "CardNoTxbx";
            this.CardNoTxbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.CardNoTxbx.Properties.Appearance.Options.UseFont = true;
            this.CardNoTxbx.Properties.Mask.BeepOnError = true;
            this.CardNoTxbx.Properties.Mask.EditMask = "f0";
            this.CardNoTxbx.Size = new System.Drawing.Size(167, 20);
            this.CardNoTxbx.TabIndex = 1;
            // 
            // SNameChbx
            // 
            this.SNameChbx.Location = new System.Drawing.Point(17, 97);
            this.SNameChbx.Name = "SNameChbx";
            this.SNameChbx.Properties.AllowFocused = false;
            this.SNameChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SNameChbx.Properties.Appearance.Options.UseFont = true;
            this.SNameChbx.Properties.Caption = "Soyad";
            this.SNameChbx.Size = new System.Drawing.Size(83, 20);
            this.SNameChbx.TabIndex = 4;
            this.SNameChbx.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // NameChbx
            // 
            this.NameChbx.Location = new System.Drawing.Point(17, 63);
            this.NameChbx.Name = "NameChbx";
            this.NameChbx.Properties.AllowFocused = false;
            this.NameChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.NameChbx.Properties.Appearance.Options.UseFont = true;
            this.NameChbx.Properties.Caption = "Ad";
            this.NameChbx.Size = new System.Drawing.Size(83, 20);
            this.NameChbx.TabIndex = 2;
            this.NameChbx.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // SNameTxbx
            // 
            this.SNameTxbx.Location = new System.Drawing.Point(118, 97);
            this.SNameTxbx.Name = "SNameTxbx";
            this.SNameTxbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SNameTxbx.Properties.Appearance.Options.UseFont = true;
            this.SNameTxbx.Size = new System.Drawing.Size(167, 20);
            this.SNameTxbx.TabIndex = 5;
            // 
            // NameTxbx
            // 
            this.NameTxbx.Location = new System.Drawing.Point(118, 63);
            this.NameTxbx.Name = "NameTxbx";
            this.NameTxbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.NameTxbx.Properties.Appearance.Options.UseFont = true;
            this.NameTxbx.Size = new System.Drawing.Size(167, 20);
            this.NameTxbx.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 153);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(973, 352);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LOGICALREF,
            this.NAME,
            this.SURNAME,
            this.FATHERNAME,
            this.BIRTHDATE,
            this.CARTNO,
            this.TCNUMBER,
            this.MARRIED,
            this.ADDRESS,
            this.MOBILTEL,
            this.SEX,
            this.STATUS,
            this.POSITION,
            this.PUAN,
            this.MAIL});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // LOGICALREF
            // 
            this.LOGICALREF.Caption = "LOGICALREF";
            this.LOGICALREF.FieldName = "LOGICALREF";
            this.LOGICALREF.Name = "LOGICALREF";
            // 
            // NAME
            // 
            this.NAME.Caption = "Ad";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowFocus = false;
            this.NAME.OptionsColumn.ReadOnly = true;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 1;
            this.NAME.Width = 78;
            // 
            // SURNAME
            // 
            this.SURNAME.Caption = "Soyad";
            this.SURNAME.FieldName = "SURNAME";
            this.SURNAME.Name = "SURNAME";
            this.SURNAME.OptionsColumn.AllowEdit = false;
            this.SURNAME.OptionsColumn.AllowFocus = false;
            this.SURNAME.OptionsColumn.ReadOnly = true;
            this.SURNAME.Visible = true;
            this.SURNAME.VisibleIndex = 2;
            this.SURNAME.Width = 81;
            // 
            // FATHERNAME
            // 
            this.FATHERNAME.Caption = "Ata adı";
            this.FATHERNAME.FieldName = "FATHERNAME";
            this.FATHERNAME.Name = "FATHERNAME";
            this.FATHERNAME.OptionsColumn.AllowEdit = false;
            this.FATHERNAME.OptionsColumn.AllowFocus = false;
            this.FATHERNAME.OptionsColumn.ReadOnly = true;
            this.FATHERNAME.Visible = true;
            this.FATHERNAME.VisibleIndex = 3;
            this.FATHERNAME.Width = 61;
            // 
            // BIRTHDATE
            // 
            this.BIRTHDATE.Caption = "Doğum Tarixi";
            this.BIRTHDATE.DisplayFormat.FormatString = "d";
            this.BIRTHDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.BIRTHDATE.FieldName = "BIRTHDATE";
            this.BIRTHDATE.Name = "BIRTHDATE";
            this.BIRTHDATE.OptionsColumn.AllowEdit = false;
            this.BIRTHDATE.OptionsColumn.AllowFocus = false;
            this.BIRTHDATE.OptionsColumn.ReadOnly = true;
            this.BIRTHDATE.Visible = true;
            this.BIRTHDATE.VisibleIndex = 4;
            this.BIRTHDATE.Width = 77;
            // 
            // CARTNO
            // 
            this.CARTNO.Caption = "Kart №";
            this.CARTNO.FieldName = "CARTNO";
            this.CARTNO.Name = "CARTNO";
            this.CARTNO.OptionsColumn.AllowEdit = false;
            this.CARTNO.OptionsColumn.AllowFocus = false;
            this.CARTNO.OptionsColumn.ReadOnly = true;
            this.CARTNO.Visible = true;
            this.CARTNO.VisibleIndex = 5;
            this.CARTNO.Width = 110;
            // 
            // TCNUMBER
            // 
            this.TCNUMBER.Caption = "Sənəd №";
            this.TCNUMBER.FieldName = "TCNUMBER";
            this.TCNUMBER.Name = "TCNUMBER";
            this.TCNUMBER.OptionsColumn.AllowEdit = false;
            this.TCNUMBER.OptionsColumn.AllowFocus = false;
            this.TCNUMBER.OptionsColumn.ReadOnly = true;
            this.TCNUMBER.Visible = true;
            this.TCNUMBER.VisibleIndex = 6;
            this.TCNUMBER.Width = 55;
            // 
            // MARRIED
            // 
            this.MARRIED.Caption = "Aile Vəziyyəti";
            this.MARRIED.FieldName = "MARRIED";
            this.MARRIED.Name = "MARRIED";
            this.MARRIED.OptionsColumn.AllowEdit = false;
            this.MARRIED.OptionsColumn.AllowFocus = false;
            this.MARRIED.OptionsColumn.ReadOnly = true;
            this.MARRIED.Visible = true;
            this.MARRIED.VisibleIndex = 7;
            this.MARRIED.Width = 77;
            // 
            // ADDRESS
            // 
            this.ADDRESS.Caption = "Ünvan";
            this.ADDRESS.FieldName = "ADDRESS";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.OptionsColumn.AllowEdit = false;
            this.ADDRESS.OptionsColumn.AllowFocus = false;
            this.ADDRESS.OptionsColumn.ReadOnly = true;
            this.ADDRESS.Visible = true;
            this.ADDRESS.VisibleIndex = 11;
            this.ADDRESS.Width = 69;
            // 
            // MOBILTEL
            // 
            this.MOBILTEL.Caption = "Telefon №";
            this.MOBILTEL.FieldName = "MOBILTEL";
            this.MOBILTEL.Name = "MOBILTEL";
            this.MOBILTEL.OptionsColumn.AllowEdit = false;
            this.MOBILTEL.OptionsColumn.AllowFocus = false;
            this.MOBILTEL.OptionsColumn.ReadOnly = true;
            this.MOBILTEL.Visible = true;
            this.MOBILTEL.VisibleIndex = 8;
            this.MOBILTEL.Width = 61;
            // 
            // SEX
            // 
            this.SEX.Caption = "Cins";
            this.SEX.FieldName = "SEX";
            this.SEX.Name = "SEX";
            this.SEX.OptionsColumn.AllowEdit = false;
            this.SEX.OptionsColumn.AllowFocus = false;
            this.SEX.OptionsColumn.ReadOnly = true;
            this.SEX.Visible = true;
            this.SEX.VisibleIndex = 9;
            this.SEX.Width = 38;
            // 
            // STATUS
            // 
            this.STATUS.Caption = "Status";
            this.STATUS.FieldName = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.OptionsColumn.AllowEdit = false;
            this.STATUS.OptionsColumn.AllowFocus = false;
            this.STATUS.Visible = true;
            this.STATUS.VisibleIndex = 10;
            this.STATUS.Width = 52;
            // 
            // POSITION
            // 
            this.POSITION.Caption = "Vəzifə";
            this.POSITION.FieldName = "COMPANYDEF";
            this.POSITION.Name = "POSITION";
            this.POSITION.OptionsColumn.AllowEdit = false;
            this.POSITION.OptionsColumn.AllowFocus = false;
            this.POSITION.Visible = true;
            this.POSITION.VisibleIndex = 12;
            this.POSITION.Width = 57;
            // 
            // PUAN
            // 
            this.PUAN.Caption = "Bonus";
            this.PUAN.FieldName = "PUAN";
            this.PUAN.Name = "PUAN";
            this.PUAN.OptionsColumn.AllowEdit = false;
            this.PUAN.OptionsColumn.AllowFocus = false;
            this.PUAN.Visible = true;
            this.PUAN.VisibleIndex = 0;
            this.PUAN.Width = 53;
            // 
            // MAIL
            // 
            this.MAIL.Caption = "E-Mail";
            this.MAIL.FieldName = "EMAIL";
            this.MAIL.Name = "MAIL";
            this.MAIL.OptionsColumn.AllowEdit = false;
            this.MAIL.OptionsColumn.AllowFocus = false;
            this.MAIL.Visible = true;
            this.MAIL.VisibleIndex = 13;
            this.MAIL.Width = 86;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.EditBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.TransactionBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.Bonus),
            new DevExpress.XtraBars.LinkPersistInfo(this.TransferBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.SendToExcelBtn)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // EditBtn
            // 
            this.EditBtn.Caption = "Dəyiş";
            this.EditBtn.Id = 0;
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditBtn_ItemClick);
            // 
            // TransactionBtn
            // 
            this.TransactionBtn.Caption = "Hərəkətlər";
            this.TransactionBtn.Id = 1;
            this.TransactionBtn.Name = "TransactionBtn";
            this.TransactionBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TransactionBtn_ItemClick);
            // 
            // Bonus
            // 
            this.Bonus.Caption = "Bonus";
            this.Bonus.Id = 2;
            this.Bonus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BonusArtir),
            new DevExpress.XtraBars.LinkPersistInfo(this.BonusAzalt)});
            this.Bonus.Name = "Bonus";
            // 
            // BonusArtir
            // 
            this.BonusArtir.Caption = "Əlavə et";
            this.BonusArtir.Id = 3;
            this.BonusArtir.Name = "BonusArtir";
            this.BonusArtir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BonusArtir_ItemClick);
            // 
            // BonusAzalt
            // 
            this.BonusAzalt.Caption = "Azalt";
            this.BonusAzalt.Id = 4;
            this.BonusAzalt.Name = "BonusAzalt";
            this.BonusAzalt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BonusAzalt_ItemClick);
            // 
            // TransferBtn
            // 
            this.TransferBtn.Caption = "Transfer";
            this.TransferBtn.Id = 5;
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TransferBtn_ItemClick);
            // 
            // SendToExcelBtn
            // 
            this.SendToExcelBtn.Caption = "Excele göndər";
            this.SendToExcelBtn.Id = 6;
            this.SendToExcelBtn.Name = "SendToExcelBtn";
            this.SendToExcelBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SendToExcelBtn_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.EditBtn,
            this.TransactionBtn,
            this.Bonus,
            this.BonusArtir,
            this.BonusAzalt,
            this.TransferBtn,
            this.SendToExcelBtn});
            this.barManager1.MaxItemId = 7;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(973, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 505);
            this.barDockControlBottom.Size = new System.Drawing.Size(973, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 505);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(973, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 505);
            // 
            // CustomersFrm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 505);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomersFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müştərilər";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FNameTxbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FNameChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDayChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardNoChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardNoTxbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNameChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNameTxbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTxbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit NameChbx;
        private DevExpress.XtraEditors.TextEdit SNameTxbx;
        private DevExpress.XtraEditors.TextEdit NameTxbx;
        private DevExpress.XtraEditors.CheckEdit CardNoChbx;
        private DevExpress.XtraEditors.TextEdit CardNoTxbx;
        private DevExpress.XtraEditors.CheckEdit SNameChbx;
        private DevExpress.XtraEditors.CheckEdit FNameChbx;
        private DevExpress.XtraEditors.CheckEdit BDayChbx;
        private DevExpress.XtraEditors.SimpleButton SearchBtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DateTimePicker BDayText;
        private DevExpress.XtraEditors.TextEdit FNameTxbx;
        private DevExpress.XtraGrid.Columns.GridColumn LOGICALREF;
        private DevExpress.XtraGrid.Columns.GridColumn NAME;
        private DevExpress.XtraGrid.Columns.GridColumn SURNAME;
        private DevExpress.XtraGrid.Columns.GridColumn FATHERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn BIRTHDATE;
        private DevExpress.XtraGrid.Columns.GridColumn CARTNO;
        private DevExpress.XtraGrid.Columns.GridColumn TCNUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn MARRIED;
        private DevExpress.XtraGrid.Columns.GridColumn ADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn MOBILTEL;
        private DevExpress.XtraGrid.Columns.GridColumn SEX;
        private DevExpress.XtraWaitForm.ProgressPanel progress;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem EditBtn;
        private DevExpress.XtraBars.BarButtonItem TransactionBtn;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn STATUS;
        private DevExpress.XtraBars.BarSubItem Bonus;
        private DevExpress.XtraBars.BarButtonItem BonusArtir;
        private DevExpress.XtraBars.BarButtonItem BonusAzalt;
        private DevExpress.XtraGrid.Columns.GridColumn POSITION;
        private DevExpress.XtraGrid.Columns.GridColumn PUAN;
        private DevExpress.XtraBars.BarButtonItem TransferBtn;
        private DevExpress.XtraBars.BarButtonItem SendToExcelBtn;
        private DevExpress.XtraGrid.Columns.GridColumn MAIL;
    }
}