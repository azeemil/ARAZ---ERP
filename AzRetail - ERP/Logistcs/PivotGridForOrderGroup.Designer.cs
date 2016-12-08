namespace ERP.Logistcs
{
    partial class PivotGridForOrderGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PivotGridForOrderGroup));
            this.pivotGrid = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.colBARCOD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colNAME = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colAMOUNT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colWHOUSE = new DevExpress.XtraPivotGrid.PivotGridField();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.PrintBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ExcelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DesignBtn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGrid
            // 
            this.pivotGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGrid.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.colBARCOD,
            this.colNAME,
            this.colAMOUNT,
            this.colWHOUSE});
            this.pivotGrid.Location = new System.Drawing.Point(0, 0);
            this.pivotGrid.Name = "pivotGrid";
            this.pivotGrid.OptionsPrint.PageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.pivotGrid.OptionsPrint.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.pivotGrid.OptionsPrint.PrintHeadersOnEveryPage = true;
            this.pivotGrid.Size = new System.Drawing.Size(897, 459);
            this.pivotGrid.TabIndex = 0;
            this.pivotGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pivotGrid_MouseClick);
            // 
            // colBARCOD
            // 
            this.colBARCOD.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colBARCOD.AreaIndex = 0;
            this.colBARCOD.Caption = "Barkod";
            this.colBARCOD.FieldName = "BARCODE";
            this.colBARCOD.GrandTotalText = "Toplam";
            this.colBARCOD.Name = "colBARCOD";
            this.colBARCOD.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            // 
            // colNAME
            // 
            this.colNAME.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colNAME.AreaIndex = 1;
            this.colNAME.Caption = "Ad";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            // 
            // colAMOUNT
            // 
            this.colAMOUNT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colAMOUNT.AreaIndex = 0;
            this.colAMOUNT.Caption = "Miqdar";
            this.colAMOUNT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAMOUNT.EmptyCellText = "0";
            this.colAMOUNT.EmptyValueText = "0";
            this.colAMOUNT.FieldName = "AMOUNT";
            this.colAMOUNT.Name = "colAMOUNT";
            // 
            // colWHOUSE
            // 
            this.colWHOUSE.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.colWHOUSE.AreaIndex = 0;
            this.colWHOUSE.Caption = "Filial";
            this.colWHOUSE.FieldName = "WHOUSE";
            this.colWHOUSE.Name = "colWHOUSE";
            this.colWHOUSE.Width = 74;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.PrintBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.ExcelBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.DesignBtn)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // PrintBtn
            // 
            this.PrintBtn.Caption = "Çap Et";
            this.PrintBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("PrintBtn.Glyph")));
            this.PrintBtn.Id = 0;
            this.PrintBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("PrintBtn.LargeGlyph")));
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintBtn_ItemClick);
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Caption = "Excel";
            this.ExcelBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("ExcelBtn.Glyph")));
            this.ExcelBtn.Id = 1;
            this.ExcelBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ExcelBtn.LargeGlyph")));
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExcelBtn_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.PrintBtn,
            this.ExcelBtn,
            this.DesignBtn});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(897, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 459);
            this.barDockControlBottom.Size = new System.Drawing.Size(897, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 459);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(897, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 459);
            // 
            // DesignBtn
            // 
            this.DesignBtn.Caption = "Dizayn";
            this.DesignBtn.Id = 2;
            this.DesignBtn.Name = "DesignBtn";
            this.DesignBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DesignBtn_ItemClick);
            // 
            // PivotGridForOrderGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 459);
            this.Controls.Add(this.pivotGrid);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PivotGridForOrderGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PivotGridForOrderGroup";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraPivotGrid.PivotGridControl pivotGrid;
        private DevExpress.XtraPivotGrid.PivotGridField colBARCOD;
        private DevExpress.XtraPivotGrid.PivotGridField colNAME;
        private DevExpress.XtraPivotGrid.PivotGridField colAMOUNT;
        private DevExpress.XtraPivotGrid.PivotGridField colWHOUSE;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem PrintBtn;
        private DevExpress.XtraBars.BarButtonItem ExcelBtn;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem DesignBtn;
    }
}