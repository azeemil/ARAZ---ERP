namespace ERP.General
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.DeleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.EditBtn = new DevExpress.XtraEditors.SimpleButton();
            this.NewBtn = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EXPLANATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOCUMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EXTENSION = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.DeleteBtn);
            this.groupControl1.Controls.Add(this.EditBtn);
            this.groupControl1.Controls.Add(this.NewBtn);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 311);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(744, 60);
            this.groupControl1.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.Appearance.Options.UseFont = true;
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.Location = new System.Drawing.Point(184, 25);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(80, 30);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Sil";
            // 
            // EditBtn
            // 
            this.EditBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.EditBtn.Appearance.Options.UseFont = true;
            this.EditBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditBtn.Image")));
            this.EditBtn.Location = new System.Drawing.Point(98, 25);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(80, 30);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Dəyiş";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.NewBtn.Appearance.Options.UseFont = true;
            this.NewBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewBtn.Image")));
            this.NewBtn.Location = new System.Drawing.Point(12, 25);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(80, 30);
            this.NewBtn.TabIndex = 0;
            this.NewBtn.Text = "Yeni";
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(744, 311);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.NAME,
            this.EXPLANATION,
            this.DOCUMENT,
            this.EXTENSION});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            // 
            // ID
            // 
            this.ID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ID.AppearanceCell.Options.UseFont = true;
            this.ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ID.AppearanceHeader.Options.UseFont = true;
            this.ID.Caption = "№";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // NAME
            // 
            this.NAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.NAME.AppearanceCell.Options.UseFont = true;
            this.NAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.NAME.AppearanceHeader.Options.UseFont = true;
            this.NAME.Caption = "Ad";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowFocus = false;
            this.NAME.OptionsColumn.ReadOnly = true;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 1;
            // 
            // EXPLANATION
            // 
            this.EXPLANATION.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.EXPLANATION.AppearanceCell.Options.UseFont = true;
            this.EXPLANATION.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.EXPLANATION.AppearanceHeader.Options.UseFont = true;
            this.EXPLANATION.Caption = "Açıqlama";
            this.EXPLANATION.FieldName = "EXPLANATION";
            this.EXPLANATION.Name = "EXPLANATION";
            this.EXPLANATION.OptionsColumn.AllowEdit = false;
            this.EXPLANATION.OptionsColumn.AllowFocus = false;
            this.EXPLANATION.OptionsColumn.ReadOnly = true;
            this.EXPLANATION.Visible = true;
            this.EXPLANATION.VisibleIndex = 2;
            // 
            // DOCUMENT
            // 
            this.DOCUMENT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.DOCUMENT.AppearanceCell.Options.UseFont = true;
            this.DOCUMENT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DOCUMENT.AppearanceHeader.Options.UseFont = true;
            this.DOCUMENT.Caption = "DOCUMENT";
            this.DOCUMENT.FieldName = "DOCUMENT";
            this.DOCUMENT.Name = "DOCUMENT";
            this.DOCUMENT.OptionsColumn.AllowEdit = false;
            this.DOCUMENT.OptionsColumn.AllowFocus = false;
            this.DOCUMENT.OptionsColumn.ReadOnly = true;
            this.DOCUMENT.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // EXTENSION
            // 
            this.EXTENSION.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.EXTENSION.AppearanceCell.Options.UseFont = true;
            this.EXTENSION.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.EXTENSION.AppearanceHeader.Options.UseFont = true;
            this.EXTENSION.Caption = "EXTENSION";
            this.EXTENSION.FieldName = "EXTENSION";
            this.EXTENSION.Name = "EXTENSION";
            this.EXTENSION.OptionsColumn.AllowEdit = false;
            this.EXTENSION.OptionsColumn.AllowFocus = false;
            this.EXTENSION.OptionsColumn.ReadOnly = true;
            this.EXTENSION.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 371);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kömək";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton DeleteBtn;
        private DevExpress.XtraEditors.SimpleButton EditBtn;
        private DevExpress.XtraEditors.SimpleButton NewBtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn NAME;
        private DevExpress.XtraGrid.Columns.GridColumn EXPLANATION;
        private DevExpress.XtraGrid.Columns.GridColumn DOCUMENT;
        private DevExpress.XtraGrid.Columns.GridColumn EXTENSION;
    }
}