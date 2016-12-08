namespace ERP.Logistcs
{
    partial class MinMaxStokLevelControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinMaxStokLevelControl));
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.WAREHOUSE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WAREHOUSENAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEMCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAXLEVEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.searchTxt = new DevExpress.XtraEditors.TextEdit();
            this.searchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.LOGICALREF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP.General.Wait), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid.Location = new System.Drawing.Point(0, 65);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(985, 389);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.WAREHOUSE,
            this.WAREHOUSENAME,
            this.ITEMNAME,
            this.ITEMCODE,
            this.MAXLEVEL,
            this.LOGICALREF});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // WAREHOUSE
            // 
            this.WAREHOUSE.Caption = "Anbar №";
            this.WAREHOUSE.FieldName = "WAREHOUSE";
            this.WAREHOUSE.Name = "WAREHOUSE";
            this.WAREHOUSE.OptionsColumn.AllowEdit = false;
            this.WAREHOUSE.OptionsColumn.AllowFocus = false;
            this.WAREHOUSE.Visible = true;
            this.WAREHOUSE.VisibleIndex = 0;
            this.WAREHOUSE.Width = 57;
            // 
            // WAREHOUSENAME
            // 
            this.WAREHOUSENAME.Caption = "Anbar";
            this.WAREHOUSENAME.FieldName = "WAREHOUSENAME";
            this.WAREHOUSENAME.Name = "WAREHOUSENAME";
            this.WAREHOUSENAME.OptionsColumn.AllowEdit = false;
            this.WAREHOUSENAME.OptionsColumn.AllowFocus = false;
            this.WAREHOUSENAME.Visible = true;
            this.WAREHOUSENAME.VisibleIndex = 1;
            this.WAREHOUSENAME.Width = 192;
            // 
            // ITEMNAME
            // 
            this.ITEMNAME.Caption = "Material";
            this.ITEMNAME.FieldName = "ITEMNAME";
            this.ITEMNAME.Name = "ITEMNAME";
            this.ITEMNAME.OptionsColumn.AllowEdit = false;
            this.ITEMNAME.OptionsColumn.AllowFocus = false;
            this.ITEMNAME.Visible = true;
            this.ITEMNAME.VisibleIndex = 3;
            this.ITEMNAME.Width = 486;
            // 
            // ITEMCODE
            // 
            this.ITEMCODE.Caption = "Kod";
            this.ITEMCODE.FieldName = "ITEMCODE";
            this.ITEMCODE.Name = "ITEMCODE";
            this.ITEMCODE.OptionsColumn.AllowEdit = false;
            this.ITEMCODE.OptionsColumn.AllowFocus = false;
            this.ITEMCODE.Visible = true;
            this.ITEMCODE.VisibleIndex = 2;
            this.ITEMCODE.Width = 77;
            // 
            // MAXLEVEL
            // 
            this.MAXLEVEL.Caption = "Maxsimum";
            this.MAXLEVEL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.MAXLEVEL.FieldName = "MAXLEVEL";
            this.MAXLEVEL.Name = "MAXLEVEL";
            this.MAXLEVEL.Visible = true;
            this.MAXLEVEL.VisibleIndex = 4;
            this.MAXLEVEL.Width = 89;
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = ((short)(0));
            this.radioGroup1.Location = new System.Drawing.Point(12, 12);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Kod"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Ad")});
            this.radioGroup1.Size = new System.Drawing.Size(133, 36);
            this.radioGroup1.TabIndex = 1;
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(191, 20);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.searchTxt.Properties.Appearance.Options.UseFont = true;
            this.searchTxt.Size = new System.Drawing.Size(211, 22);
            this.searchTxt.TabIndex = 2;
            this.searchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxt_KeyDown);
            // 
            // searchBtn
            // 
            this.searchBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.searchBtn.Appearance.Options.UseFont = true;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(438, 11);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(136, 35);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Axtar";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Appearance.Options.UseFont = true;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(611, 13);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(136, 33);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Yadda saxla";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // LOGICALREF
            // 
            this.LOGICALREF.Caption = "LOGICALREF";
            this.LOGICALREF.FieldName = "LOGICALREF";
            this.LOGICALREF.Name = "LOGICALREF";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // MinMaxStokLevelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 454);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MinMaxStokLevelControl";
            this.Text = "Stok səviyyə";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn WAREHOUSE;
        private DevExpress.XtraGrid.Columns.GridColumn WAREHOUSENAME;
        private DevExpress.XtraGrid.Columns.GridColumn ITEMNAME;
        private DevExpress.XtraGrid.Columns.GridColumn ITEMCODE;
        private DevExpress.XtraGrid.Columns.GridColumn MAXLEVEL;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.TextEdit searchTxt;
        private DevExpress.XtraEditors.SimpleButton searchBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraGrid.Columns.GridColumn LOGICALREF;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}