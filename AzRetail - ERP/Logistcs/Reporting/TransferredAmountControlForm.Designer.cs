namespace ERP.Logistcs.Reporting
{
    partial class TransferredAmountControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferredAmountControlForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.PrintBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SearchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.EndDate = new DevExpress.XtraEditors.DateEdit();
            this.BegDate = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LOGICALREF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ORDERREF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESTINDEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOURCEINDEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.PrintBtn);
            this.groupControl1.Controls.Add(this.SearchBtn);
            this.groupControl1.Controls.Add(this.EndDate);
            this.groupControl1.Controls.Add(this.BegDate);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(897, 82);
            this.groupControl1.TabIndex = 0;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.Appearance.Options.UseFont = true;
            this.PrintBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrintBtn.Image")));
            this.PrintBtn.Location = new System.Drawing.Point(359, 23);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(139, 40);
            this.PrintBtn.TabIndex = 22;
            this.PrintBtn.Text = "Excel";
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Appearance.Options.UseFont = true;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.Location = new System.Drawing.Point(214, 23);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(139, 40);
            this.SearchBtn.TabIndex = 21;
            this.SearchBtn.Text = "Axtar";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // EndDate
            // 
            this.EndDate.EditValue = new System.DateTime(2015, 1, 22, 0, 0, 0, 0);
            this.EndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EndDate.Location = new System.Drawing.Point(107, 31);
            this.EndDate.Name = "EndDate";
            this.EndDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.EndDate.Properties.Appearance.Options.UseFont = true;
            this.EndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.EndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDate.Size = new System.Drawing.Size(88, 24);
            this.EndDate.TabIndex = 20;
            // 
            // BegDate
            // 
            this.BegDate.EditValue = new System.DateTime(2015, 1, 22, 0, 0, 0, 0);
            this.BegDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BegDate.Location = new System.Drawing.Point(16, 31);
            this.BegDate.Name = "BegDate";
            this.BegDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BegDate.Properties.Appearance.Options.UseFont = true;
            this.BegDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.BegDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BegDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BegDate.Size = new System.Drawing.Size(86, 24);
            this.BegDate.TabIndex = 19;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 82);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(897, 365);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LOGICALREF,
            this.ORDERREF,
            this.DESTINDEX,
            this.SOURCEINDEX,
            this.AMOUNT,
            this.NAME,
            this.BARCODE,
            this.CODE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // LOGICALREF
            // 
            this.LOGICALREF.Caption = "Sifariş №";
            this.LOGICALREF.FieldName = "LOGICALREF";
            this.LOGICALREF.Name = "LOGICALREF";
            this.LOGICALREF.OptionsColumn.AllowEdit = false;
            this.LOGICALREF.OptionsColumn.AllowFocus = false;
            this.LOGICALREF.OptionsColumn.ReadOnly = true;
            this.LOGICALREF.Visible = true;
            this.LOGICALREF.VisibleIndex = 1;
            this.LOGICALREF.Width = 109;
            // 
            // ORDERREF
            // 
            this.ORDERREF.Caption = "Qrup №";
            this.ORDERREF.FieldName = "ORDERREF";
            this.ORDERREF.Name = "ORDERREF";
            this.ORDERREF.OptionsColumn.AllowEdit = false;
            this.ORDERREF.OptionsColumn.AllowFocus = false;
            this.ORDERREF.OptionsColumn.ReadOnly = true;
            this.ORDERREF.Visible = true;
            this.ORDERREF.VisibleIndex = 0;
            this.ORDERREF.Width = 109;
            // 
            // DESTINDEX
            // 
            this.DESTINDEX.Caption = "Çıxış Anbar";
            this.DESTINDEX.FieldName = "DESTINDEX";
            this.DESTINDEX.Name = "DESTINDEX";
            this.DESTINDEX.OptionsColumn.AllowEdit = false;
            this.DESTINDEX.OptionsColumn.AllowFocus = false;
            this.DESTINDEX.OptionsColumn.ReadOnly = true;
            this.DESTINDEX.Visible = true;
            this.DESTINDEX.VisibleIndex = 2;
            this.DESTINDEX.Width = 71;
            // 
            // SOURCEINDEX
            // 
            this.SOURCEINDEX.Caption = "Giriş Anbar";
            this.SOURCEINDEX.FieldName = "SOURCEINDEX";
            this.SOURCEINDEX.Name = "SOURCEINDEX";
            this.SOURCEINDEX.OptionsColumn.AllowEdit = false;
            this.SOURCEINDEX.OptionsColumn.AllowFocus = false;
            this.SOURCEINDEX.OptionsColumn.ReadOnly = true;
            this.SOURCEINDEX.Visible = true;
            this.SOURCEINDEX.VisibleIndex = 3;
            this.SOURCEINDEX.Width = 90;
            // 
            // AMOUNT
            // 
            this.AMOUNT.Caption = "Miqdar";
            this.AMOUNT.FieldName = "AMOUNT";
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.OptionsColumn.AllowEdit = false;
            this.AMOUNT.OptionsColumn.AllowFocus = false;
            this.AMOUNT.OptionsColumn.ReadOnly = true;
            this.AMOUNT.Visible = true;
            this.AMOUNT.VisibleIndex = 7;
            this.AMOUNT.Width = 78;
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
            this.NAME.VisibleIndex = 6;
            this.NAME.Width = 178;
            // 
            // BARCODE
            // 
            this.BARCODE.Caption = "Barkod";
            this.BARCODE.FieldName = "BARCODE";
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.OptionsColumn.AllowEdit = false;
            this.BARCODE.OptionsColumn.AllowFocus = false;
            this.BARCODE.OptionsColumn.ReadOnly = true;
            this.BARCODE.Visible = true;
            this.BARCODE.VisibleIndex = 5;
            this.BARCODE.Width = 122;
            // 
            // CODE
            // 
            this.CODE.Caption = "Kod";
            this.CODE.FieldName = "CODE";
            this.CODE.Name = "CODE";
            this.CODE.OptionsColumn.AllowEdit = false;
            this.CODE.OptionsColumn.AllowFocus = false;
            this.CODE.OptionsColumn.ReadOnly = true;
            this.CODE.Visible = true;
            this.CODE.VisibleIndex = 4;
            this.CODE.Width = 122;
            // 
            // TransferredAmountControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 447);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferredAmountControlForm";
            this.Text = "TransferredAmountControlForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BegDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton SearchBtn;
        private DevExpress.XtraEditors.DateEdit EndDate;
        private DevExpress.XtraEditors.DateEdit BegDate;
        private DevExpress.XtraGrid.Columns.GridColumn LOGICALREF;
        private DevExpress.XtraGrid.Columns.GridColumn ORDERREF;
        private DevExpress.XtraGrid.Columns.GridColumn DESTINDEX;
        private DevExpress.XtraGrid.Columns.GridColumn SOURCEINDEX;
        private DevExpress.XtraGrid.Columns.GridColumn AMOUNT;
        private DevExpress.XtraGrid.Columns.GridColumn NAME;
        private DevExpress.XtraGrid.Columns.GridColumn BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn CODE;
        private DevExpress.XtraEditors.SimpleButton PrintBtn;
    }
}