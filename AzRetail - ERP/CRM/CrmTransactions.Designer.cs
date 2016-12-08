namespace ERP.CRM
{
    partial class CrmTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrmTransactions));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FILIALNR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRANCH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Belge_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Puan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kasa_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATECREATED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu();
            this.toExcelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(892, 471);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FILIALNR,
            this.BRANCH,
            this.Belge_no,
            this.Puan,
            this.ToplamTutar,
            this.Kasa_No,
            this.DATECREATED,
            this.Aciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FILIALNR
            // 
            this.FILIALNR.Caption = "Filial №";
            this.FILIALNR.FieldName = "NR";
            this.FILIALNR.Name = "FILIALNR";
            this.FILIALNR.OptionsColumn.AllowEdit = false;
            this.FILIALNR.OptionsColumn.AllowFocus = false;
            this.FILIALNR.Visible = true;
            this.FILIALNR.VisibleIndex = 0;
            this.FILIALNR.Width = 48;
            // 
            // BRANCH
            // 
            this.BRANCH.Caption = "Filial";
            this.BRANCH.FieldName = "BRANCH";
            this.BRANCH.Name = "BRANCH";
            this.BRANCH.OptionsColumn.AllowEdit = false;
            this.BRANCH.OptionsColumn.AllowFocus = false;
            this.BRANCH.Visible = true;
            this.BRANCH.VisibleIndex = 1;
            this.BRANCH.Width = 122;
            // 
            // Belge_no
            // 
            this.Belge_no.Caption = "Sənəd №";
            this.Belge_no.FieldName = "Belge_no";
            this.Belge_no.Name = "Belge_no";
            this.Belge_no.OptionsColumn.AllowEdit = false;
            this.Belge_no.OptionsColumn.AllowFocus = false;
            this.Belge_no.Visible = true;
            this.Belge_no.VisibleIndex = 3;
            this.Belge_no.Width = 54;
            // 
            // Puan
            // 
            this.Puan.Caption = "Bonus";
            this.Puan.FieldName = "Puan";
            this.Puan.Name = "Puan";
            this.Puan.OptionsColumn.AllowEdit = false;
            this.Puan.OptionsColumn.AllowFocus = false;
            this.Puan.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Puan", "Toplam={0:0}")});
            this.Puan.Visible = true;
            this.Puan.VisibleIndex = 4;
            this.Puan.Width = 79;
            // 
            // ToplamTutar
            // 
            this.ToplamTutar.Caption = "Məbləğ";
            this.ToplamTutar.FieldName = "ToplamTutar";
            this.ToplamTutar.Name = "ToplamTutar";
            this.ToplamTutar.OptionsColumn.AllowEdit = false;
            this.ToplamTutar.OptionsColumn.AllowFocus = false;
            this.ToplamTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ToplamTutar", "Toplam={0:0}")});
            this.ToplamTutar.Visible = true;
            this.ToplamTutar.VisibleIndex = 5;
            this.ToplamTutar.Width = 97;
            // 
            // Kasa_No
            // 
            this.Kasa_No.Caption = "Kassa №";
            this.Kasa_No.FieldName = "Kasa_No";
            this.Kasa_No.Name = "Kasa_No";
            this.Kasa_No.OptionsColumn.AllowEdit = false;
            this.Kasa_No.OptionsColumn.AllowFocus = false;
            this.Kasa_No.Visible = true;
            this.Kasa_No.VisibleIndex = 2;
            this.Kasa_No.Width = 61;
            // 
            // DATECREATED
            // 
            this.DATECREATED.Caption = "Tarix";
            this.DATECREATED.DisplayFormat.FormatString = "dd.MM.yyyy hh:MM";
            this.DATECREATED.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DATECREATED.FieldName = "DATECREATED";
            this.DATECREATED.Name = "DATECREATED";
            this.DATECREATED.OptionsColumn.AllowEdit = false;
            this.DATECREATED.OptionsColumn.AllowFocus = false;
            this.DATECREATED.Visible = true;
            this.DATECREATED.VisibleIndex = 6;
            this.DATECREATED.Width = 120;
            // 
            // Aciklama
            // 
            this.Aciklama.Caption = "Açıqlama";
            this.Aciklama.FieldName = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.OptionsColumn.AllowEdit = false;
            this.Aciklama.OptionsColumn.AllowFocus = false;
            this.Aciklama.Visible = true;
            this.Aciklama.VisibleIndex = 7;
            this.Aciklama.Width = 293;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.toExcelBtn)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // toExcelBtn
            // 
            this.toExcelBtn.Caption = "Excelə Göndər";
            this.toExcelBtn.Id = 0;
            this.toExcelBtn.Name = "toExcelBtn";
            this.toExcelBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.toExcelBtn_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.toExcelBtn});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(892, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 471);
            this.barDockControlBottom.Size = new System.Drawing.Size(892, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 471);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(892, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 471);
            // 
            // CrmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 471);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn FILIALNR;
        private DevExpress.XtraGrid.Columns.GridColumn BRANCH;
        private DevExpress.XtraGrid.Columns.GridColumn Belge_no;
        private DevExpress.XtraGrid.Columns.GridColumn Puan;
        private DevExpress.XtraGrid.Columns.GridColumn ToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn Kasa_No;
        private DevExpress.XtraGrid.Columns.GridColumn DATECREATED;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem toExcelBtn;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}