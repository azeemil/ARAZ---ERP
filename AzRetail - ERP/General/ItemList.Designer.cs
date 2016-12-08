using ERP.CRM;

namespace ERP.General
{
    partial class ItemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemList));
            this.Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.OK = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ITEMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SearchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CodeRd = new System.Windows.Forms.RadioButton();
            this.nameRd = new System.Windows.Forms.RadioButton();
            this.filtrTxbx = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtrTxbx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Cancel.Appearance.Options.UseFont = true;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(481, 392);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(130, 36);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Bağla";
            // 
            // OK
            // 
            this.OK.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.OK.Appearance.Options.UseFont = true;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(345, 392);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(130, 36);
            this.OK.TabIndex = 7;
            this.OK.Text = "Seç";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 64);
            this.gridControl1.MainView = this.view;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(623, 320);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // view
            // 
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ITEMID,
            this.CODE,
            this.BARCODE,
            this.NAME,
            this.gridColumn1});
            this.view.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.view.GridControl = this.gridControl1;
            this.view.Name = "view";
            this.view.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
            this.view.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.view.OptionsView.ShowAutoFilterRow = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.DoubleClick += new System.EventHandler(this.view_DoubleClick);
            // 
            // ITEMID
            // 
            this.ITEMID.Caption = "ITEMID";
            this.ITEMID.FieldName = "ITEMID";
            this.ITEMID.Name = "ITEMID";
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
            this.CODE.VisibleIndex = 0;
            this.CODE.Width = 66;
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
            this.BARCODE.VisibleIndex = 1;
            this.BARCODE.Width = 110;
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
            this.NAME.VisibleIndex = 2;
            this.NAME.Width = 309;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "UNITSETREF";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SearchBtn.Appearance.Options.UseFont = true;
            this.SearchBtn.Location = new System.Drawing.Point(437, 16);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(130, 30);
            this.SearchBtn.TabIndex = 12;
            this.SearchBtn.Text = "Axtar";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CodeRd
            // 
            this.CodeRd.AutoSize = true;
            this.CodeRd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.CodeRd.Location = new System.Drawing.Point(12, 23);
            this.CodeRd.Name = "CodeRd";
            this.CodeRd.Size = new System.Drawing.Size(54, 21);
            this.CodeRd.TabIndex = 10;
            this.CodeRd.Text = "Kod";
            this.CodeRd.UseVisualStyleBackColor = true;
            // 
            // nameRd
            // 
            this.nameRd.AutoSize = true;
            this.nameRd.Checked = true;
            this.nameRd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.nameRd.Location = new System.Drawing.Point(84, 23);
            this.nameRd.Name = "nameRd";
            this.nameRd.Size = new System.Drawing.Size(45, 21);
            this.nameRd.TabIndex = 9;
            this.nameRd.TabStop = true;
            this.nameRd.Text = "Ad";
            this.nameRd.UseVisualStyleBackColor = true;
            // 
            // filtrTxbx
            // 
            this.filtrTxbx.Location = new System.Drawing.Point(169, 20);
            this.filtrTxbx.Name = "filtrTxbx";
            this.filtrTxbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.filtrTxbx.Properties.Appearance.Options.UseFont = true;
            this.filtrTxbx.Size = new System.Drawing.Size(222, 22);
            this.filtrTxbx.TabIndex = 13;
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 435);
            this.Controls.Add(this.filtrTxbx);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CodeRd);
            this.Controls.Add(this.nameRd);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.gridControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtrTxbx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Cancel;
        private DevExpress.XtraEditors.SimpleButton OK;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView view;
        private DevExpress.XtraGrid.Columns.GridColumn ITEMID;
        private DevExpress.XtraGrid.Columns.GridColumn CODE;
        private DevExpress.XtraGrid.Columns.GridColumn BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn NAME;
        private DevExpress.XtraEditors.SimpleButton SearchBtn;
        public System.Windows.Forms.RadioButton CodeRd;
        public System.Windows.Forms.RadioButton nameRd;
        private DevExpress.XtraEditors.TextEdit filtrTxbx;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}