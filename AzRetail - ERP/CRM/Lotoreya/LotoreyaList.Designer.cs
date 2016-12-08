namespace ERP.CRM.Lotoreya
{
    partial class LotoreyaList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LotoreyaList));
            this.simpleButtonNew = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButtonRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonNew
            // 
            this.simpleButtonNew.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonNew.Appearance.Options.UseFont = true;
            this.simpleButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonNew.Image")));
            this.simpleButtonNew.Location = new System.Drawing.Point(33, 281);
            this.simpleButtonNew.Name = "simpleButtonNew";
            this.simpleButtonNew.Size = new System.Drawing.Size(125, 23);
            this.simpleButtonNew.TabIndex = 1;
            this.simpleButtonNew.Text = "Yeni hədiyyə";
            this.simpleButtonNew.Click += new System.EventHandler(this.simpleButtonNew_Click);
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonClose.Appearance.Options.UseFont = true;
            this.simpleButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonClose.Image")));
            this.simpleButtonClose.Location = new System.Drawing.Point(438, 281);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(125, 23);
            this.simpleButtonClose.TabIndex = 2;
            this.simpleButtonClose.Text = "Bağla";
            this.simpleButtonClose.Click += new System.EventHandler(this.simpleButtonClose_Click);
            // 
            // gridControlList
            // 
            this.gridControlList.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlList.Location = new System.Drawing.Point(0, 0);
            this.gridControlList.MainView = this.gridView1;
            this.gridControlList.Name = "gridControlList";
            this.gridControlList.Size = new System.Drawing.Size(583, 247);
            this.gridControlList.TabIndex = 3;
            this.gridControlList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControlList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Müştəri kart No.";
            this.gridColumn1.FieldName = "CUSTOMERCARD";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 109;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Hədiyyə kart No.";
            this.gridColumn2.FieldName = "BILETNO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 111;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Təqdim edən";
            this.gridColumn3.FieldName = "MODIFIEDBY";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 88;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Verilmə tarixi";
            this.gridColumn4.FieldName = "MODDIFYDATE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 110;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "Hədiyyə";
            this.gridColumn5.FieldName = "NAME";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.Caption = "Filial";
            this.gridColumn6.FieldName = "BRANCH";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // simpleButtonRefresh
            // 
            this.simpleButtonRefresh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonRefresh.Appearance.Options.UseFont = true;
            this.simpleButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonRefresh.Image")));
            this.simpleButtonRefresh.Location = new System.Drawing.Point(168, 281);
            this.simpleButtonRefresh.Name = "simpleButtonRefresh";
            this.simpleButtonRefresh.Size = new System.Drawing.Size(125, 23);
            this.simpleButtonRefresh.TabIndex = 4;
            this.simpleButtonRefresh.Text = "Yenilə";
            this.simpleButtonRefresh.Click += new System.EventHandler(this.simpleButtonRefresh_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(303, 281);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(125, 23);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Excele göndər";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // LotoreyaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 339);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.simpleButtonRefresh);
            this.Controls.Add(this.gridControlList);
            this.Controls.Add(this.simpleButtonClose);
            this.Controls.Add(this.simpleButtonNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LotoreyaList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hədiyyələr siyahısı";
            this.Load += new System.EventHandler(this.LotoreyaList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButtonNew;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private DevExpress.XtraGrid.GridControl gridControlList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
    }
}