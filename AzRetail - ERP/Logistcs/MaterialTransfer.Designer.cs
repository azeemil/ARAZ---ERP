namespace ERP.Logistcs
{
    partial class MaterialTransfer
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialTransfer));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colROWNR = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.destindex = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.destindex_code = new DevExpress.XtraEditors.TextEdit();
            this.total = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceindex = new DevExpress.XtraEditors.TextEdit();
            this.sourceindex_code = new DevExpress.XtraEditors.TextEdit();
            this.s_anbar1 = new System.Windows.Forms.Label();
            this.date = new DevExpress.XtraEditors.TextEdit();
            this.tarix = new System.Windows.Forms.Label();
            this.fisno = new DevExpress.XtraEditors.TextEdit();
            this.fis = new System.Windows.Forms.Label();
            this.capIrsaliyye = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destindex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destindex_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceindex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceindex_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colROWNR,
            this.colCODE,
            this.colBARCODE,
            this.colNAME,
            this.colAMOUNT,
            this.colSELT_NAME,
            this.colPRICE,
            this.colTOTAL});
            this.gridView1.GridControl = this.MainGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colROWNR
            // 
            this.colROWNR.Caption = "№";
            this.colROWNR.FieldName = "ROWNR";
            this.colROWNR.Name = "colROWNR";
            this.colROWNR.OptionsColumn.AllowEdit = false;
            this.colROWNR.OptionsColumn.AllowFocus = false;
            this.colROWNR.OptionsColumn.AllowSize = false;
            this.colROWNR.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colROWNR.OptionsColumn.ReadOnly = true;
            this.colROWNR.Visible = true;
            this.colROWNR.VisibleIndex = 0;
            this.colROWNR.Width = 42;
            // 
            // colCODE
            // 
            this.colCODE.Caption = "Kod";
            this.colCODE.FieldName = "CODE";
            this.colCODE.Name = "colCODE";
            this.colCODE.OptionsColumn.AllowEdit = false;
            this.colCODE.OptionsColumn.AllowFocus = false;
            this.colCODE.OptionsColumn.ReadOnly = true;
            this.colCODE.Visible = true;
            this.colCODE.VisibleIndex = 1;
            this.colCODE.Width = 78;
            // 
            // colBARCODE
            // 
            this.colBARCODE.Caption = "Barkod";
            this.colBARCODE.FieldName = "BARCODE";
            this.colBARCODE.Name = "colBARCODE";
            this.colBARCODE.OptionsColumn.AllowEdit = false;
            this.colBARCODE.OptionsColumn.AllowFocus = false;
            this.colBARCODE.OptionsColumn.ReadOnly = true;
            this.colBARCODE.Visible = true;
            this.colBARCODE.VisibleIndex = 2;
            this.colBARCODE.Width = 114;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "Ad";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.OptionsColumn.AllowEdit = false;
            this.colNAME.OptionsColumn.AllowFocus = false;
            this.colNAME.OptionsColumn.ReadOnly = true;
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 3;
            this.colNAME.Width = 321;
            // 
            // colAMOUNT
            // 
            this.colAMOUNT.Caption = "Miqdar";
            this.colAMOUNT.FieldName = "AMOUNT";
            this.colAMOUNT.Name = "colAMOUNT";
            this.colAMOUNT.OptionsColumn.AllowEdit = false;
            this.colAMOUNT.OptionsColumn.AllowFocus = false;
            this.colAMOUNT.Visible = true;
            this.colAMOUNT.VisibleIndex = 4;
            this.colAMOUNT.Width = 66;
            // 
            // colSELT_NAME
            // 
            this.colSELT_NAME.Caption = "Ö\\V";
            this.colSELT_NAME.FieldName = "SELT_NAME";
            this.colSELT_NAME.Name = "colSELT_NAME";
            this.colSELT_NAME.OptionsColumn.AllowEdit = false;
            this.colSELT_NAME.OptionsColumn.AllowFocus = false;
            this.colSELT_NAME.OptionsColumn.ReadOnly = true;
            this.colSELT_NAME.Visible = true;
            this.colSELT_NAME.VisibleIndex = 5;
            this.colSELT_NAME.Width = 55;
            // 
            // colPRICE
            // 
            this.colPRICE.Caption = "Qiymət";
            this.colPRICE.FieldName = "PRICE";
            this.colPRICE.Name = "colPRICE";
            this.colPRICE.OptionsColumn.AllowEdit = false;
            this.colPRICE.OptionsColumn.AllowFocus = false;
            this.colPRICE.OptionsColumn.ReadOnly = true;
            this.colPRICE.Visible = true;
            this.colPRICE.VisibleIndex = 6;
            this.colPRICE.Width = 61;
            // 
            // colTOTAL
            // 
            this.colTOTAL.Caption = "Toplam";
            this.colTOTAL.FieldName = "TOTAL";
            this.colTOTAL.Name = "colTOTAL";
            this.colTOTAL.OptionsColumn.AllowEdit = false;
            this.colTOTAL.OptionsColumn.AllowFocus = false;
            this.colTOTAL.OptionsColumn.ReadOnly = true;
            this.colTOTAL.Visible = true;
            this.colTOTAL.VisibleIndex = 7;
            this.colTOTAL.Width = 60;
            // 
            // MainGrid
            // 
            this.MainGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode1.RelationName = "Level1";
            this.MainGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
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
            this.tip.Size = new System.Drawing.Size(211, 22);
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
            // destindex
            // 
            this.destindex.Enabled = false;
            this.destindex.Location = new System.Drawing.Point(173, 92);
            this.destindex.Name = "destindex";
            this.destindex.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.destindex.Properties.Appearance.Options.UseFont = true;
            this.destindex.Size = new System.Drawing.Size(161, 22);
            this.destindex.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Anbar (2)";
            // 
            // destindex_code
            // 
            this.destindex_code.Enabled = false;
            this.destindex_code.Location = new System.Drawing.Point(123, 92);
            this.destindex_code.Name = "destindex_code";
            this.destindex_code.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.destindex_code.Properties.Appearance.Options.UseFont = true;
            this.destindex_code.Size = new System.Drawing.Size(44, 22);
            this.destindex_code.TabIndex = 16;
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Location = new System.Drawing.Point(464, 36);
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
            this.label1.Location = new System.Drawing.Point(372, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Toplam";
            // 
            // sourceindex
            // 
            this.sourceindex.Enabled = false;
            this.sourceindex.Location = new System.Drawing.Point(173, 65);
            this.sourceindex.Name = "sourceindex";
            this.sourceindex.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sourceindex.Properties.Appearance.Options.UseFont = true;
            this.sourceindex.Size = new System.Drawing.Size(161, 22);
            this.sourceindex.TabIndex = 12;
            // 
            // sourceindex_code
            // 
            this.sourceindex_code.Enabled = false;
            this.sourceindex_code.Location = new System.Drawing.Point(123, 64);
            this.sourceindex_code.Name = "sourceindex_code";
            this.sourceindex_code.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sourceindex_code.Properties.Appearance.Options.UseFont = true;
            this.sourceindex_code.Size = new System.Drawing.Size(44, 22);
            this.sourceindex_code.TabIndex = 10;
            // 
            // s_anbar1
            // 
            this.s_anbar1.AutoSize = true;
            this.s_anbar1.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.s_anbar1.Location = new System.Drawing.Point(12, 68);
            this.s_anbar1.Name = "s_anbar1";
            this.s_anbar1.Size = new System.Drawing.Size(75, 17);
            this.s_anbar1.TabIndex = 9;
            this.s_anbar1.Text = "Anbar (1)";
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(464, 118);
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
            this.tarix.Location = new System.Drawing.Point(372, 123);
            this.tarix.Name = "tarix";
            this.tarix.Size = new System.Drawing.Size(42, 17);
            this.tarix.TabIndex = 7;
            this.tarix.Text = "Tarix";
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
            // capIrsaliyye
            // 
            this.capIrsaliyye.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Millimeter);
            this.capIrsaliyye.Appearance.Options.UseFont = true;
            this.capIrsaliyye.Image = ((System.Drawing.Image)(resources.GetObject("capIrsaliyye.Image")));
            this.capIrsaliyye.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.capIrsaliyye.Location = new System.Drawing.Point(700, 111);
            this.capIrsaliyye.Name = "capIrsaliyye";
            this.capIrsaliyye.Size = new System.Drawing.Size(103, 37);
            this.capIrsaliyye.TabIndex = 0;
            this.capIrsaliyye.Text = "Çap Et";
            this.capIrsaliyye.Click += new System.EventHandler(this.capIrsaliyye_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tip);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.destindex);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.destindex_code);
            this.groupControl1.Controls.Add(this.total);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.sourceindex);
            this.groupControl1.Controls.Add(this.sourceindex_code);
            this.groupControl1.Controls.Add(this.s_anbar1);
            this.groupControl1.Controls.Add(this.date);
            this.groupControl1.Controls.Add(this.tarix);
            this.groupControl1.Controls.Add(this.fisno);
            this.groupControl1.Controls.Add(this.fis);
            this.groupControl1.Controls.Add(this.capIrsaliyye);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(815, 158);
            this.groupControl1.TabIndex = 3;
            // 
            // MaterialTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 533);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaterialTransfer";
            this.Load += new System.EventHandler(this.Sevk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destindex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destindex_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceindex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceindex_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colROWNR;
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
        private DevExpress.XtraEditors.TextEdit destindex;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit destindex_code;
        private DevExpress.XtraEditors.TextEdit total;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit sourceindex;
        private DevExpress.XtraEditors.TextEdit sourceindex_code;
        private System.Windows.Forms.Label s_anbar1;
        private DevExpress.XtraEditors.TextEdit date;
        private System.Windows.Forms.Label tarix;
        private DevExpress.XtraEditors.TextEdit fisno;
        private System.Windows.Forms.Label fis;
        private DevExpress.XtraEditors.SimpleButton capIrsaliyye;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}