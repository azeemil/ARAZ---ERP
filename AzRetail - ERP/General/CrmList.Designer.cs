namespace ERP.General
{
    partial class CrmList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrmList));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.progress = new DevExpress.XtraWaitForm.ProgressPanel();
            this.SearchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CardNoTxbx = new DevExpress.XtraEditors.TextEdit();
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
            this.EditBtn = new DevExpress.XtraBars.BarButtonItem();
            this.TransactionBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Bonus = new DevExpress.XtraBars.BarSubItem();
            this.BonusArtir = new DevExpress.XtraBars.BarButtonItem();
            this.BonusAzalt = new DevExpress.XtraBars.BarButtonItem();
            this.TransferBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardNoTxbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.progress);
            this.groupControl1.Controls.Add(this.SearchBtn);
            this.groupControl1.Controls.Add(this.CardNoTxbx);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(949, 99);
            this.groupControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(789, 27);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(148, 26);
            this.simpleButton1.TabIndex = 24;
            this.simpleButton1.Text = "Seç";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(12, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 16);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Kart №";
            // 
            // progress
            // 
            this.progress.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progress.Appearance.Options.UseBackColor = true;
            this.progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progress.Location = new System.Drawing.Point(2, 69);
            this.progress.Name = "progress";
            this.progress.ShowCaption = false;
            this.progress.ShowDescription = false;
            this.progress.Size = new System.Drawing.Size(945, 28);
            this.progress.TabIndex = 22;
            this.progress.Text = "progressPanel1";
            this.progress.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SearchBtn.Appearance.Options.UseFont = true;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.Location = new System.Drawing.Point(264, 31);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(148, 26);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Text = "Axtar";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CardNoTxbx
            // 
            this.CardNoTxbx.Location = new System.Drawing.Point(91, 33);
            this.CardNoTxbx.Name = "CardNoTxbx";
            this.CardNoTxbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.CardNoTxbx.Properties.Appearance.Options.UseFont = true;
            this.CardNoTxbx.Properties.Mask.BeepOnError = true;
            this.CardNoTxbx.Properties.Mask.EditMask = "f0";
            this.CardNoTxbx.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CardNoTxbx.Properties.MaxLength = 16;
            this.CardNoTxbx.Size = new System.Drawing.Size(167, 22);
            this.CardNoTxbx.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 99);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(949, 406);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
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
            this.PUAN});
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
            this.NAME.VisibleIndex = 0;
            this.NAME.Width = 110;
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
            this.SURNAME.VisibleIndex = 1;
            this.SURNAME.Width = 114;
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
            this.FATHERNAME.VisibleIndex = 2;
            this.FATHERNAME.Width = 87;
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
            this.BIRTHDATE.VisibleIndex = 3;
            this.BIRTHDATE.Width = 73;
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
            this.CARTNO.VisibleIndex = 4;
            this.CARTNO.Width = 168;
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
            this.TCNUMBER.VisibleIndex = 5;
            this.TCNUMBER.Width = 82;
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
            this.MARRIED.VisibleIndex = 6;
            this.MARRIED.Width = 74;
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
            this.ADDRESS.VisibleIndex = 10;
            this.ADDRESS.Width = 182;
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
            this.MOBILTEL.VisibleIndex = 7;
            this.MOBILTEL.Width = 70;
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
            this.SEX.VisibleIndex = 8;
            this.SEX.Width = 58;
            // 
            // STATUS
            // 
            this.STATUS.Caption = "Status";
            this.STATUS.FieldName = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.OptionsColumn.AllowEdit = false;
            this.STATUS.OptionsColumn.AllowFocus = false;
            this.STATUS.Visible = true;
            this.STATUS.VisibleIndex = 9;
            this.STATUS.Width = 60;
            // 
            // POSITION
            // 
            this.POSITION.Caption = "Vəzifə";
            this.POSITION.FieldName = "COMPANYDEF";
            this.POSITION.Name = "POSITION";
            this.POSITION.OptionsColumn.AllowEdit = false;
            this.POSITION.OptionsColumn.AllowFocus = false;
            this.POSITION.Visible = true;
            this.POSITION.VisibleIndex = 11;
            // 
            // PUAN
            // 
            this.PUAN.Caption = "Bonus";
            this.PUAN.FieldName = "PUAN";
            this.PUAN.Name = "PUAN";
            this.PUAN.OptionsColumn.AllowEdit = false;
            this.PUAN.OptionsColumn.AllowFocus = false;
            this.PUAN.Visible = true;
            this.PUAN.VisibleIndex = 12;
            // 
            // EditBtn
            // 
            this.EditBtn.Caption = "Dəyiş";
            this.EditBtn.Id = 0;
            this.EditBtn.Name = "EditBtn";
            // 
            // TransactionBtn
            // 
            this.TransactionBtn.Caption = "Hərəkətlər";
            this.TransactionBtn.Id = 1;
            this.TransactionBtn.Name = "TransactionBtn";
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
            // 
            // BonusAzalt
            // 
            this.BonusAzalt.Caption = "Azalt";
            this.BonusAzalt.Id = 4;
            this.BonusAzalt.Name = "BonusAzalt";
            // 
            // TransferBtn
            // 
            this.TransferBtn.Caption = "Transfer";
            this.TransferBtn.Id = 5;
            this.TransferBtn.Name = "TransferBtn";
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
            this.TransferBtn});
            this.barManager1.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(949, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 505);
            this.barDockControlBottom.Size = new System.Drawing.Size(949, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(949, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 505);
            // 
            // CrmList
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 505);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CrmList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müştərilər";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardNoTxbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton SearchBtn;
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
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraEditors.TextEdit CardNoTxbx;
    }
}