namespace ERP.CRM
{
    partial class CrmLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrmLogs));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ToExcelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SearchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRANCH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CRMCARD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EXPLANATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ToExcelBtn);
            this.groupControl1.Controls.Add(this.SearchBtn);
            this.groupControl1.Controls.Add(this.dateEdit2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dateEdit1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(854, 86);
            this.groupControl1.TabIndex = 0;
            // 
            // ToExcelBtn
            // 
            this.ToExcelBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ToExcelBtn.Appearance.Options.UseFont = true;
            this.ToExcelBtn.Image = ((System.Drawing.Image)(resources.GetObject("ToExcelBtn.Image")));
            this.ToExcelBtn.Location = new System.Drawing.Point(696, 39);
            this.ToExcelBtn.Name = "ToExcelBtn";
            this.ToExcelBtn.Size = new System.Drawing.Size(146, 33);
            this.ToExcelBtn.TabIndex = 4;
            this.ToExcelBtn.Text = "Excele Göndər";
            this.ToExcelBtn.Click += new System.EventHandler(this.ToExcelBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.SearchBtn.Appearance.Options.UseFont = true;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.Location = new System.Drawing.Point(412, 36);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(146, 33);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Axtar";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(242, 43);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(133, 20);
            this.dateEdit2.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(22, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tarix";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(84, 43);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(133, 20);
            this.dateEdit1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 86);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(854, 384);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.USERNAME,
            this.BRANCH,
            this.CRMCARD,
            this.TYPE,
            this.DESCRIPTION,
            this.EXPLANATION,
            this.DATE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // USERNAME
            // 
            this.USERNAME.Caption = "İstifadəçi";
            this.USERNAME.FieldName = "USERNAME";
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.OptionsColumn.AllowEdit = false;
            this.USERNAME.OptionsColumn.AllowFocus = false;
            this.USERNAME.Visible = true;
            this.USERNAME.VisibleIndex = 0;
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
            // 
            // CRMCARD
            // 
            this.CRMCARD.Caption = "Kart №";
            this.CRMCARD.FieldName = "CRMCARD";
            this.CRMCARD.Name = "CRMCARD";
            this.CRMCARD.OptionsColumn.AllowEdit = false;
            this.CRMCARD.OptionsColumn.AllowFocus = false;
            this.CRMCARD.Visible = true;
            this.CRMCARD.VisibleIndex = 2;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.Caption = "Açıqlama";
            this.DESCRIPTION.FieldName = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.OptionsColumn.AllowEdit = false;
            this.DESCRIPTION.OptionsColumn.AllowFocus = false;
            this.DESCRIPTION.Visible = true;
            this.DESCRIPTION.VisibleIndex = 4;
            // 
            // EXPLANATION
            // 
            this.EXPLANATION.Caption = "Qeyd";
            this.EXPLANATION.FieldName = "EXPLANATION";
            this.EXPLANATION.Name = "EXPLANATION";
            this.EXPLANATION.OptionsColumn.AllowEdit = false;
            this.EXPLANATION.OptionsColumn.AllowFocus = false;
            this.EXPLANATION.Visible = true;
            this.EXPLANATION.VisibleIndex = 5;
            // 
            // DATE
            // 
            this.DATE.Caption = "Tarix";
            this.DATE.FieldName = "RECORDDATE";
            this.DATE.Name = "DATE";
            this.DATE.OptionsColumn.AllowEdit = false;
            this.DATE.OptionsColumn.AllowFocus = false;
            this.DATE.Visible = true;
            this.DATE.VisibleIndex = 6;
            // 
            // TYPE
            // 
            this.TYPE.Caption = "Əməliyyat";
            this.TYPE.FieldName = "TYPE";
            this.TYPE.Name = "TYPE";
            this.TYPE.OptionsColumn.AllowEdit = false;
            this.TYPE.OptionsColumn.AllowFocus = false;
            this.TYPE.Visible = true;
            this.TYPE.VisibleIndex = 3;
            // 
            // CrmLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 470);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrmLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kart Əməliyyatları";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.SimpleButton ToExcelBtn;
        private DevExpress.XtraEditors.SimpleButton SearchBtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn BRANCH;
        private DevExpress.XtraGrid.Columns.GridColumn CRMCARD;
        private DevExpress.XtraGrid.Columns.GridColumn DESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn EXPLANATION;
        private DevExpress.XtraGrid.Columns.GridColumn DATE;
        private DevExpress.XtraGrid.Columns.GridColumn TYPE;
    }
}