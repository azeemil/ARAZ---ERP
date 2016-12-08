namespace ERP.Administrator.Properties.ApproveSystem
{
    partial class ApproveSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveSystem));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.EditSystem = new DevExpress.XtraEditors.SimpleButton();
            this.typeCmbx = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.EditSystem);
            this.groupControl1.Controls.Add(this.typeCmbx);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 400);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(918, 66);
            this.groupControl1.TabIndex = 1;
            // 
            // EditSystem
            // 
            this.EditSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditSystem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.EditSystem.Appearance.Options.UseFont = true;
            this.EditSystem.Location = new System.Drawing.Point(801, 27);
            this.EditSystem.Name = "EditSystem";
            this.EditSystem.Size = new System.Drawing.Size(105, 31);
            this.EditSystem.TabIndex = 5;
            this.EditSystem.Text = "Dəyiş";
            this.EditSystem.Click += new System.EventHandler(this.EditSystem_Click);
            // 
            // typeCmbx
            // 
            this.typeCmbx.EditValue = "İrsaliyələr";
            this.typeCmbx.Location = new System.Drawing.Point(12, 24);
            this.typeCmbx.Name = "typeCmbx";
            this.typeCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.typeCmbx.Properties.Appearance.Options.UseFont = true;
            this.typeCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typeCmbx.Properties.Items.AddRange(new object[] {
            "İrsaliyələr",
            "Fakturalar",
            "Materiallar"});
            this.typeCmbx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.typeCmbx.Size = new System.Drawing.Size(303, 22);
            this.typeCmbx.TabIndex = 4;
            this.typeCmbx.SelectedIndexChanged += new System.EventHandler(this.typeCmbx_SelectedIndexChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "Istifadəçilər {0} of {1}";
            this.gridControl1.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.grid_EmbeddedNavigator_ButtonClick);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(918, 400);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3,
            this.gridView4});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.AppearancePrint.OddRow.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.AppearancePrint.OddRow.Options.UseBorderColor = true;
            this.gridView1.AppearancePrint.Row.BorderColor = System.Drawing.Color.Black;
            this.gridView1.AppearancePrint.Row.Options.UseBorderColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.USER,
            this.TYPE,
            this.USERID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.True;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // USER
            // 
            this.USER.Caption = "Istifadəçi";
            this.USER.FieldName = "USERNAME";
            this.USER.Name = "USER";
            this.USER.OptionsColumn.AllowEdit = false;
            this.USER.OptionsColumn.AllowFocus = false;
            this.USER.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.USER.Visible = true;
            this.USER.VisibleIndex = 1;
            // 
            // TYPE
            // 
            this.TYPE.Caption = "TYPE";
            this.TYPE.FieldName = "TYPE";
            this.TYPE.Name = "TYPE";
            this.TYPE.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // USERID
            // 
            this.USERID.Caption = "USERID";
            this.USERID.FieldName = "USERID";
            this.USERID.Name = "USERID";
            this.USERID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn17,
            this.gridColumn18});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "№";
            this.gridColumn17.FieldName = "ROW";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 0;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "gridColumn1";
            this.gridColumn18.FieldName = "CODE";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 1;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22});
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "ROWNR";
            this.gridColumn19.FieldName = "ROWNR";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 0;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "CODE";
            this.gridColumn20.FieldName = "CODE";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 1;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "BARCODE";
            this.gridColumn21.FieldName = "BARCODE";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 2;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "NAME";
            this.gridColumn22.FieldName = "NAME";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 3;
            // 
            // ApproveSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 466);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApproveSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Təsdiq ";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typeCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit typeCmbx;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn USER;
        private DevExpress.XtraGrid.Columns.GridColumn TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn USERID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraEditors.SimpleButton EditSystem;
    }
}