namespace ERP.Market.MQ
{
    partial class MaterialTransact
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialTransact));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSELT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MainGrid = new DevExpress.XtraGrid.GridControl();
            this.tip = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.sourceindex = new DevExpress.XtraEditors.TextEdit();
            this.total = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new DevExpress.XtraEditors.TextEdit();
            this.tarix = new System.Windows.Forms.Label();
            this.docno = new DevExpress.XtraEditors.TextEdit();
            this.doc = new System.Windows.Forms.Label();
            this.fisno = new DevExpress.XtraEditors.TextEdit();
            this.fis = new System.Windows.Forms.Label();
            this.cap = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceindex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HorzLine.BorderColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.HorzLine.Options.UseBorderColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.VertLine.BorderColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.VertLine.Options.UseBorderColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE,
            this.colBARCODE,
            this.colNAME,
            this.colAMOUNT,
            this.colSELT_NAME,
            this.colPRICE,
            this.colTOTAL});
            this.gridView1.GridControl = this.MainGrid;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // colCODE
            // 
            this.colCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colCODE.AppearanceHeader.Options.UseFont = true;
            this.colCODE.Caption = "Kod";
            this.colCODE.FieldName = "CODE";
            this.colCODE.Name = "colCODE";
            this.colCODE.OptionsColumn.AllowEdit = false;
            this.colCODE.OptionsColumn.AllowFocus = false;
            this.colCODE.OptionsColumn.ReadOnly = true;
            this.colCODE.Visible = true;
            this.colCODE.VisibleIndex = 0;
            this.colCODE.Width = 78;
            // 
            // colBARCODE
            // 
            this.colBARCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colBARCODE.AppearanceHeader.Options.UseFont = true;
            this.colBARCODE.Caption = "Barkod";
            this.colBARCODE.FieldName = "BARCODE";
            this.colBARCODE.Name = "colBARCODE";
            this.colBARCODE.OptionsColumn.AllowEdit = false;
            this.colBARCODE.OptionsColumn.AllowFocus = false;
            this.colBARCODE.OptionsColumn.ReadOnly = true;
            this.colBARCODE.Visible = true;
            this.colBARCODE.VisibleIndex = 1;
            this.colBARCODE.Width = 114;
            // 
            // colNAME
            // 
            this.colNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colNAME.AppearanceHeader.Options.UseFont = true;
            this.colNAME.Caption = "Ad";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.OptionsColumn.AllowEdit = false;
            this.colNAME.OptionsColumn.AllowFocus = false;
            this.colNAME.OptionsColumn.ReadOnly = true;
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 2;
            this.colNAME.Width = 321;
            // 
            // colAMOUNT
            // 
            this.colAMOUNT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colAMOUNT.AppearanceHeader.Options.UseFont = true;
            this.colAMOUNT.Caption = "Miqdar";
            this.colAMOUNT.FieldName = "AMOUNT";
            this.colAMOUNT.Name = "colAMOUNT";
            this.colAMOUNT.OptionsColumn.AllowEdit = false;
            this.colAMOUNT.OptionsColumn.AllowFocus = false;
            this.colAMOUNT.Visible = true;
            this.colAMOUNT.VisibleIndex = 3;
            this.colAMOUNT.Width = 66;
            // 
            // colSELT_NAME
            // 
            this.colSELT_NAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSELT_NAME.AppearanceHeader.Options.UseFont = true;
            this.colSELT_NAME.Caption = "Ö\\V";
            this.colSELT_NAME.FieldName = "SELT_NAME";
            this.colSELT_NAME.Name = "colSELT_NAME";
            this.colSELT_NAME.OptionsColumn.AllowEdit = false;
            this.colSELT_NAME.OptionsColumn.AllowFocus = false;
            this.colSELT_NAME.OptionsColumn.ReadOnly = true;
            this.colSELT_NAME.Visible = true;
            this.colSELT_NAME.VisibleIndex = 4;
            this.colSELT_NAME.Width = 55;
            // 
            // colPRICE
            // 
            this.colPRICE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colPRICE.AppearanceHeader.Options.UseFont = true;
            this.colPRICE.Caption = "Qiymət";
            this.colPRICE.FieldName = "PRICE";
            this.colPRICE.Name = "colPRICE";
            this.colPRICE.OptionsColumn.AllowEdit = false;
            this.colPRICE.OptionsColumn.AllowFocus = false;
            this.colPRICE.OptionsColumn.ReadOnly = true;
            this.colPRICE.Visible = true;
            this.colPRICE.VisibleIndex = 5;
            this.colPRICE.Width = 61;
            // 
            // colTOTAL
            // 
            this.colTOTAL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colTOTAL.AppearanceHeader.Options.UseFont = true;
            this.colTOTAL.Caption = "Toplam";
            this.colTOTAL.FieldName = "TOTAL";
            this.colTOTAL.Name = "colTOTAL";
            this.colTOTAL.OptionsColumn.AllowEdit = false;
            this.colTOTAL.OptionsColumn.AllowFocus = false;
            this.colTOTAL.OptionsColumn.ReadOnly = true;
            this.colTOTAL.Visible = true;
            this.colTOTAL.VisibleIndex = 6;
            this.colTOTAL.Width = 60;
            // 
            // MainGrid
            // 
            this.MainGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode2.RelationName = "Level1";
            this.MainGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.MainGrid.Location = new System.Drawing.Point(0, 158);
            this.MainGrid.MainView = this.gridView1;
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.Size = new System.Drawing.Size(815, 375);
            this.MainGrid.TabIndex = 4;
            this.MainGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tip
            // 
            this.tip.Enabled = false;
            this.tip.Location = new System.Drawing.Point(123, 122);
            this.tip.Name = "tip";
            this.tip.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tip.Properties.Appearance.Options.UseFont = true;
            this.tip.Size = new System.Drawing.Size(100, 22);
            this.tip.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label6.Location = new System.Drawing.Point(12, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Növ";
            // 
            // name
            // 
            this.name.Enabled = false;
            this.name.Location = new System.Drawing.Point(173, 92);
            this.name.Name = "name";
            this.name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.name.Properties.Appearance.Options.UseFont = true;
            this.name.Size = new System.Drawing.Size(161, 22);
            this.name.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Filial";
            // 
            // sourceindex
            // 
            this.sourceindex.Enabled = false;
            this.sourceindex.Location = new System.Drawing.Point(123, 92);
            this.sourceindex.Name = "sourceindex";
            this.sourceindex.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sourceindex.Properties.Appearance.Options.UseFont = true;
            this.sourceindex.Size = new System.Drawing.Size(44, 22);
            this.sourceindex.TabIndex = 16;
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Location = new System.Drawing.Point(456, 36);
            this.total.Name = "total";
            this.total.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.total.Properties.Appearance.Options.UseFont = true;
            this.total.Size = new System.Drawing.Size(100, 22);
            this.total.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(364, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Toplam";
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(456, 64);
            this.date.Name = "date";
            this.date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.date.Properties.Appearance.Options.UseFont = true;
            this.date.Size = new System.Drawing.Size(100, 22);
            this.date.TabIndex = 8;
            // 
            // tarix
            // 
            this.tarix.AutoSize = true;
            this.tarix.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tarix.Location = new System.Drawing.Point(364, 69);
            this.tarix.Name = "tarix";
            this.tarix.Size = new System.Drawing.Size(42, 17);
            this.tarix.TabIndex = 7;
            this.tarix.Text = "Tarix";
            // 
            // docno
            // 
            this.docno.Enabled = false;
            this.docno.Location = new System.Drawing.Point(123, 64);
            this.docno.Name = "docno";
            this.docno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.docno.Properties.Appearance.Options.UseFont = true;
            this.docno.Size = new System.Drawing.Size(100, 22);
            this.docno.TabIndex = 6;
            // 
            // doc
            // 
            this.doc.AutoSize = true;
            this.doc.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.doc.Location = new System.Drawing.Point(12, 68);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(72, 17);
            this.doc.TabIndex = 5;
            this.doc.Text = "Sənəd №";
            // 
            // fisno
            // 
            this.fisno.Enabled = false;
            this.fisno.Location = new System.Drawing.Point(123, 36);
            this.fisno.Name = "fisno";
            this.fisno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.fisno.Properties.Appearance.Options.UseFont = true;
            this.fisno.Size = new System.Drawing.Size(100, 22);
            this.fisno.TabIndex = 4;
            // 
            // fis
            // 
            this.fis.AutoSize = true;
            this.fis.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.fis.Location = new System.Drawing.Point(12, 39);
            this.fis.Name = "fis";
            this.fis.Size = new System.Drawing.Size(72, 17);
            this.fis.TabIndex = 3;
            this.fis.Text = "Qaimə №";
            // 
            // cap
            // 
            this.cap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Millimeter);
            this.cap.Appearance.Options.UseFont = true;
            this.cap.Image = ((System.Drawing.Image)(resources.GetObject("cap.Image")));
            this.cap.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.cap.Location = new System.Drawing.Point(700, 111);
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(103, 37);
            this.cap.TabIndex = 0;
            this.cap.Text = "Çap Et";
            this.cap.Click += new System.EventHandler(this.cap_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tip);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.name);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.sourceindex);
            this.groupControl1.Controls.Add(this.total);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.date);
            this.groupControl1.Controls.Add(this.tarix);
            this.groupControl1.Controls.Add(this.docno);
            this.groupControl1.Controls.Add(this.doc);
            this.groupControl1.Controls.Add(this.fisno);
            this.groupControl1.Controls.Add(this.fis);
            this.groupControl1.Controls.Add(this.cap);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(815, 158);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Imha";
            // 
            // MaterialTransact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 533);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaterialTransact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceindex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colBARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colAMOUNT;
        private DevExpress.XtraGrid.Columns.GridColumn colSELT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colPRICE;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL;
        private DevExpress.XtraGrid.GridControl MainGrid;
        private DevExpress.XtraEditors.TextEdit tip;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit name;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit sourceindex;
        private DevExpress.XtraEditors.TextEdit total;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit date;
        private System.Windows.Forms.Label tarix;
        private DevExpress.XtraEditors.TextEdit docno;
        private System.Windows.Forms.Label doc;
        private DevExpress.XtraEditors.TextEdit fisno;
        private System.Windows.Forms.Label fis;
        private DevExpress.XtraEditors.SimpleButton cap;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}