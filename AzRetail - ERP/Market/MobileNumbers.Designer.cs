namespace ERP.Market
{
    partial class MobileNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MobileNumbers));
            this.gb1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.CommentMemo = new DevExpress.XtraEditors.MemoEdit();
            this.IsActiveChbx = new DevExpress.XtraEditors.CheckEdit();
            this.RefreshDt = new DevExpress.XtraEditors.DateEdit();
            this.PurchaseDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.filial = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Label1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.OperatorCmbx = new DevExpress.XtraEditors.ComboBoxEdit();
            this.NumberEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.context = new System.Windows.Forms.ContextMenuStrip();
            this.əlavəEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dəyişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniləToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FIRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIVREF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OPERATOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PURCHASEDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REFRESHDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISACTIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COMMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gb1)).BeginInit();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommentMemo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveChbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshDt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshDt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.context.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.simpleButton2);
            this.gb1.Controls.Add(this.simpleButton1);
            this.gb1.Controls.Add(this.groupControl1);
            this.gb1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb1.Enabled = false;
            this.gb1.Location = new System.Drawing.Point(0, 275);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(942, 177);
            this.gb1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(755, 87);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(159, 49);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Ləğv Et";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(755, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(159, 49);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Yadda Saxla";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.CommentMemo);
            this.groupControl1.Controls.Add(this.IsActiveChbx);
            this.groupControl1.Controls.Add(this.RefreshDt);
            this.groupControl1.Controls.Add(this.PurchaseDateEdit);
            this.groupControl1.Controls.Add(this.filial);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.Label1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.OperatorCmbx);
            this.groupControl1.Controls.Add(this.NumberEdit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(2, 20);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(723, 155);
            this.groupControl1.TabIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelControl6.Location = new System.Drawing.Point(558, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(33, 16);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "Qeyd";
            // 
            // CommentMemo
            // 
            this.CommentMemo.Location = new System.Drawing.Point(558, 54);
            this.CommentMemo.Name = "CommentMemo";
            this.CommentMemo.Size = new System.Drawing.Size(146, 93);
            this.CommentMemo.TabIndex = 20;
            // 
            // IsActiveChbx
            // 
            this.IsActiveChbx.EditValue = true;
            this.IsActiveChbx.Location = new System.Drawing.Point(264, 99);
            this.IsActiveChbx.Name = "IsActiveChbx";
            this.IsActiveChbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.IsActiveChbx.Properties.Appearance.Options.UseFont = true;
            this.IsActiveChbx.Properties.Caption = "Status";
            this.IsActiveChbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IsActiveChbx.Size = new System.Drawing.Size(72, 21);
            this.IsActiveChbx.TabIndex = 19;
            // 
            // RefreshDt
            // 
            this.RefreshDt.EditValue = null;
            this.RefreshDt.Location = new System.Drawing.Point(391, 64);
            this.RefreshDt.Name = "RefreshDt";
            this.RefreshDt.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshDt.Properties.Appearance.Options.UseFont = true;
            this.RefreshDt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RefreshDt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RefreshDt.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.RefreshDt.Properties.Mask.EditMask = "dd.MM.yyyy";
            this.RefreshDt.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.RefreshDt.Size = new System.Drawing.Size(121, 20);
            this.RefreshDt.TabIndex = 18;
            // 
            // PurchaseDateEdit
            // 
            this.PurchaseDateEdit.EditValue = null;
            this.PurchaseDateEdit.Location = new System.Drawing.Point(391, 32);
            this.PurchaseDateEdit.Name = "PurchaseDateEdit";
            this.PurchaseDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseDateEdit.Properties.Appearance.Options.UseFont = true;
            this.PurchaseDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PurchaseDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PurchaseDateEdit.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.PurchaseDateEdit.Properties.Mask.EditMask = "dd.MM.yyyy";
            this.PurchaseDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.PurchaseDateEdit.Size = new System.Drawing.Size(121, 20);
            this.PurchaseDateEdit.TabIndex = 17;
            // 
            // filial
            // 
            this.filial.EnterMoveNextControl = true;
            this.filial.Location = new System.Drawing.Point(87, 33);
            this.filial.Name = "filial";
            this.filial.Properties.AllowFocused = false;
            this.filial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.filial.Properties.Appearance.Options.UseFont = true;
            this.filial.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.filial.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Gray;
            this.filial.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.filial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.filial.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NR", "№"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Ad")});
            this.filial.Properties.DisplayMember = "NR";
            this.filial.Properties.NullText = "";
            this.filial.Properties.PopupFormMinSize = new System.Drawing.Size(300, 0);
            this.filial.Properties.ValueMember = "NR";
            this.filial.Size = new System.Drawing.Size(160, 20);
            this.filial.TabIndex = 16;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelControl5.Location = new System.Drawing.Point(272, 68);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(104, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Yenilənmə Tarixi";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelControl4.Location = new System.Drawing.Point(10, 68);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Operator";
            // 
            // Label1
            // 
            this.Label1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Label1.Location = new System.Drawing.Point(272, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 16);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Alınma Tarixi";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelControl2.Location = new System.Drawing.Point(10, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Nömrə";
            // 
            // OperatorCmbx
            // 
            this.OperatorCmbx.EditValue = "050";
            this.OperatorCmbx.Location = new System.Drawing.Point(87, 68);
            this.OperatorCmbx.Name = "OperatorCmbx";
            this.OperatorCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OperatorCmbx.Properties.Items.AddRange(new object[] {
            "050",
            "051",
            "055",
            "Sazz"});
            this.OperatorCmbx.Properties.Sorted = true;
            this.OperatorCmbx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.OperatorCmbx.Size = new System.Drawing.Size(130, 20);
            this.OperatorCmbx.TabIndex = 3;
            // 
            // NumberEdit
            // 
            this.NumberEdit.Location = new System.Drawing.Point(87, 102);
            this.NumberEdit.Name = "NumberEdit";
            this.NumberEdit.Size = new System.Drawing.Size(160, 20);
            this.NumberEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelControl1.Location = new System.Drawing.Point(10, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Filial";
            // 
            // grid
            // 
            this.grid.ContextMenuStrip = this.context;
            this.grid.Cursor = System.Windows.Forms.Cursors.Default;
            this.grid.DataSource = this.dtBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(942, 275);
            this.grid.TabIndex = 1;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid.Click += new System.EventHandler(this.grid_Click);
            // 
            // context
            // 
            this.context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.əlavəEtToolStripMenuItem,
            this.dəyişToolStripMenuItem,
            this.yeniləToolStripMenuItem,
            this.toolStripMenuItem1});
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(153, 114);
            // 
            // əlavəEtToolStripMenuItem
            // 
            this.əlavəEtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("əlavəEtToolStripMenuItem.Image")));
            this.əlavəEtToolStripMenuItem.Name = "əlavəEtToolStripMenuItem";
            this.əlavəEtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.əlavəEtToolStripMenuItem.Text = "Əlavə et";
            this.əlavəEtToolStripMenuItem.Click += new System.EventHandler(this.əlavəEtToolStripMenuItem_Click);
            // 
            // dəyişToolStripMenuItem
            // 
            this.dəyişToolStripMenuItem.Name = "dəyişToolStripMenuItem";
            this.dəyişToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dəyişToolStripMenuItem.Text = "Dəyiş";
            this.dəyişToolStripMenuItem.Click += new System.EventHandler(this.dəyişToolStripMenuItem_Click);
            // 
            // yeniləToolStripMenuItem
            // 
            this.yeniləToolStripMenuItem.Name = "yeniləToolStripMenuItem";
            this.yeniləToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yeniləToolStripMenuItem.Text = "Yenilə";
            this.yeniləToolStripMenuItem.Click += new System.EventHandler(this.yeniləToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.FIRM,
            this.colDIVREF,
            this.OPERATOR,
            this.NUMBER,
            this.PURCHASEDATE,
            this.REFRESHDATE,
            this.ISACTIV,
            this.COMMENT});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "LOGICALREF";
            this.ID.Name = "ID";
            this.ID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // FIRM
            // 
            this.FIRM.Caption = "FIRM";
            this.FIRM.FieldName = "FIRM";
            this.FIRM.Name = "FIRM";
            this.FIRM.OptionsColumn.AllowEdit = false;
            this.FIRM.OptionsColumn.AllowFocus = false;
            this.FIRM.Width = 64;
            // 
            // colDIVREF
            // 
            this.colDIVREF.Caption = "Filial";
            this.colDIVREF.FieldName = "DIVREF";
            this.colDIVREF.Name = "colDIVREF";
            this.colDIVREF.OptionsColumn.AllowEdit = false;
            this.colDIVREF.OptionsColumn.AllowFocus = false;
            this.colDIVREF.Visible = true;
            this.colDIVREF.VisibleIndex = 0;
            this.colDIVREF.Width = 206;
            // 
            // OPERATOR
            // 
            this.OPERATOR.Caption = "Operator";
            this.OPERATOR.FieldName = "OPERATOR";
            this.OPERATOR.Name = "OPERATOR";
            this.OPERATOR.OptionsColumn.AllowEdit = false;
            this.OPERATOR.OptionsColumn.AllowFocus = false;
            this.OPERATOR.Visible = true;
            this.OPERATOR.VisibleIndex = 1;
            this.OPERATOR.Width = 288;
            // 
            // NUMBER
            // 
            this.NUMBER.Caption = "Nömrə";
            this.NUMBER.FieldName = "NUMBER";
            this.NUMBER.Name = "NUMBER";
            this.NUMBER.OptionsColumn.AllowEdit = false;
            this.NUMBER.OptionsColumn.AllowFocus = false;
            this.NUMBER.Visible = true;
            this.NUMBER.VisibleIndex = 2;
            this.NUMBER.Width = 126;
            // 
            // PURCHASEDATE
            // 
            this.PURCHASEDATE.Caption = "Alınma Tarixi";
            this.PURCHASEDATE.FieldName = "PURCHASEDATE";
            this.PURCHASEDATE.Name = "PURCHASEDATE";
            this.PURCHASEDATE.OptionsColumn.AllowEdit = false;
            this.PURCHASEDATE.OptionsColumn.AllowFocus = false;
            this.PURCHASEDATE.Visible = true;
            this.PURCHASEDATE.VisibleIndex = 3;
            this.PURCHASEDATE.Width = 54;
            // 
            // REFRESHDATE
            // 
            this.REFRESHDATE.Caption = "Yenilənmə Tarixi";
            this.REFRESHDATE.FieldName = "REFRESHDATE";
            this.REFRESHDATE.Name = "REFRESHDATE";
            this.REFRESHDATE.OptionsColumn.AllowEdit = false;
            this.REFRESHDATE.OptionsColumn.AllowFocus = false;
            this.REFRESHDATE.Visible = true;
            this.REFRESHDATE.VisibleIndex = 4;
            this.REFRESHDATE.Width = 92;
            // 
            // ISACTIV
            // 
            this.ISACTIV.Caption = "Aktiv";
            this.ISACTIV.FieldName = "ISACTIV";
            this.ISACTIV.Name = "ISACTIV";
            this.ISACTIV.OptionsColumn.AllowEdit = false;
            this.ISACTIV.OptionsColumn.AllowFocus = false;
            this.ISACTIV.Visible = true;
            this.ISACTIV.VisibleIndex = 5;
            // 
            // COMMENT
            // 
            this.COMMENT.Caption = "Qeyd";
            this.COMMENT.FieldName = "COMMENT";
            this.COMMENT.Name = "COMMENT";
            this.COMMENT.OptionsColumn.AllowEdit = false;
            this.COMMENT.OptionsColumn.AllowFocus = false;
            this.COMMENT.Visible = true;
            this.COMMENT.VisibleIndex = 6;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Excel";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MobileNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 452);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.gb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MobileNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data kart";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gb1)).EndInit();
            this.gb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommentMemo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveChbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshDt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshDt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.context.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gb1;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ContextMenuStrip context;
        private System.Windows.Forms.ToolStripMenuItem əlavəEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dəyişToolStripMenuItem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl Label1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit OperatorCmbx;
        private DevExpress.XtraEditors.TextEdit NumberEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource dtBindingSource;
     
        private DevExpress.XtraGrid.Columns.GridColumn colDIVREF;
        private DevExpress.XtraGrid.Columns.GridColumn FIRM;
        private DevExpress.XtraGrid.Columns.GridColumn OPERATOR;
        private DevExpress.XtraGrid.Columns.GridColumn NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn PURCHASEDATE;
        private DevExpress.XtraGrid.Columns.GridColumn REFRESHDATE;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private System.Windows.Forms.ToolStripMenuItem yeniləToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LookUpEdit filial;
        private DevExpress.XtraGrid.Columns.GridColumn ISACTIV;
        private DevExpress.XtraGrid.Columns.GridColumn COMMENT;
        public DevExpress.XtraEditors.DateEdit PurchaseDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit CommentMemo;
        private DevExpress.XtraEditors.CheckEdit IsActiveChbx;
        public DevExpress.XtraEditors.DateEdit RefreshDt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

