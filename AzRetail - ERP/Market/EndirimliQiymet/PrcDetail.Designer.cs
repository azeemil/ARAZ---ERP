namespace ERP.Market.EndirimliQiymet
{
    partial class PrcDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrcDetail));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.SaveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.BranchLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.CommentMemo = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BUYPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.APPROVEDPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COMMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.APPROVEDAMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CANCELLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranchLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentMemo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.SaveBtn);
            this.groupControl1.Controls.Add(this.BranchLookUp);
            this.groupControl1.Controls.Add(this.CommentMemo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(949, 126);
            this.groupControl1.TabIndex = 0;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.Appearance.Options.UseFont = true;
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.Location = new System.Drawing.Point(770, 39);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(174, 41);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "Yadda Saxla";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BranchLookUp
            // 
            this.BranchLookUp.EnterMoveNextControl = true;
            this.BranchLookUp.Location = new System.Drawing.Point(75, 27);
            this.BranchLookUp.Name = "BranchLookUp";
            this.BranchLookUp.Properties.AllowFocused = false;
            this.BranchLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.BranchLookUp.Properties.Appearance.Options.UseFont = true;
            this.BranchLookUp.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BranchLookUp.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Gray;
            this.BranchLookUp.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.BranchLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BranchLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NR", "№"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Ad")});
            this.BranchLookUp.Properties.DisplayMember = "NR";
            this.BranchLookUp.Properties.NullText = "";
            this.BranchLookUp.Properties.PopupFormMinSize = new System.Drawing.Size(300, 0);
            this.BranchLookUp.Properties.ValueMember = "NR";
            this.BranchLookUp.Size = new System.Drawing.Size(192, 20);
            this.BranchLookUp.TabIndex = 16;
            // 
            // CommentMemo
            // 
            this.CommentMemo.Location = new System.Drawing.Point(75, 52);
            this.CommentMemo.Name = "CommentMemo";
            this.CommentMemo.Properties.ReadOnly = true;
            this.CommentMemo.Size = new System.Drawing.Size(428, 68);
            this.CommentMemo.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(22, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Rəy";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(22, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Filial";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Hint = "Əlavə et";
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Hint = "Sil";
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "Material {0} of {1}";
            this.gridControl1.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControl1_EmbeddedNavigator_ButtonClick);
            this.gridControl1.Location = new System.Drawing.Point(0, 126);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(949, 340);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BARCODE,
            this.CODE,
            this.NAME,
            this.AMOUNT,
            this.BUYPRICE,
            this.PRICE,
            this.APPROVEDPRICE,
            this.COMMENT,
            this.ITEMID,
            this.APPROVEDAMOUNT,
            this.CANCELLED});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.AutoMoveRowFocus = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
          
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // BARCODE
            // 
            this.BARCODE.Caption = "Barkod";
            this.BARCODE.FieldName = "BARCODE";
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.OptionsColumn.AllowEdit = false;
            this.BARCODE.OptionsColumn.AllowFocus = false;
            this.BARCODE.OptionsColumn.ReadOnly = true;
            this.BARCODE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.BARCODE.Visible = true;
            this.BARCODE.VisibleIndex = 0;
            this.BARCODE.Width = 47;
            // 
            // CODE
            // 
            this.CODE.Caption = "Kod";
            this.CODE.FieldName = "CODE";
            this.CODE.Name = "CODE";
            this.CODE.OptionsColumn.AllowEdit = false;
            this.CODE.OptionsColumn.AllowFocus = false;
            this.CODE.OptionsColumn.ReadOnly = true;
            this.CODE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.CODE.Visible = true;
            this.CODE.VisibleIndex = 1;
            this.CODE.Width = 40;
            // 
            // NAME
            // 
            this.NAME.Caption = "Ad";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowFocus = false;
            this.NAME.OptionsColumn.ReadOnly = true;
            this.NAME.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 2;
            this.NAME.Width = 176;
            // 
            // AMOUNT
            // 
            this.AMOUNT.Caption = "Miqdar";
            this.AMOUNT.FieldName = "AMOUNT";
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.Visible = true;
            this.AMOUNT.VisibleIndex = 4;
            this.AMOUNT.Width = 42;
            // 
            // BUYPRICE
            // 
            this.BUYPRICE.Caption = "Satış qiyməti";
            this.BUYPRICE.FieldName = "BUYPRICE";
            this.BUYPRICE.Name = "BUYPRICE";
            this.BUYPRICE.OptionsColumn.AllowEdit = false;
            this.BUYPRICE.OptionsColumn.AllowFocus = false;
            this.BUYPRICE.OptionsColumn.ReadOnly = true;
            this.BUYPRICE.Visible = true;
            this.BUYPRICE.VisibleIndex = 3;
            this.BUYPRICE.Width = 70;
            // 
            // PRICE
            // 
            this.PRICE.Caption = "Qiymet";
            this.PRICE.FieldName = "PRICE";
            this.PRICE.Name = "PRICE";
            this.PRICE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.PRICE.Visible = true;
            this.PRICE.VisibleIndex = 6;
            this.PRICE.Width = 42;
            // 
            // APPROVEDPRICE
            // 
            this.APPROVEDPRICE.Caption = "Təsdiqlənəcək qiymət";
            this.APPROVEDPRICE.FieldName = "APPROVEDPRICE";
            this.APPROVEDPRICE.Name = "APPROVEDPRICE";
            this.APPROVEDPRICE.OptionsColumn.AllowEdit = false;
            this.APPROVEDPRICE.OptionsColumn.AllowFocus = false;
            this.APPROVEDPRICE.OptionsColumn.ReadOnly = true;
            this.APPROVEDPRICE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.APPROVEDPRICE.Visible = true;
            this.APPROVEDPRICE.VisibleIndex = 7;
            this.APPROVEDPRICE.Width = 110;
            // 
            // COMMENT
            // 
            this.COMMENT.Caption = "Rəy";
            this.COMMENT.FieldName = "COMMENT";
            this.COMMENT.Name = "COMMENT";
            this.COMMENT.OptionsColumn.AllowEdit = false;
            this.COMMENT.OptionsColumn.AllowFocus = false;
            this.COMMENT.OptionsColumn.ReadOnly = true;
            this.COMMENT.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.COMMENT.Visible = true;
            this.COMMENT.VisibleIndex = 8;
            this.COMMENT.Width = 193;
            // 
            // ITEMID
            // 
            this.ITEMID.Caption = "ITEMID";
            this.ITEMID.FieldName = "ITEMID";
            this.ITEMID.Name = "ITEMID";
            this.ITEMID.OptionsColumn.AllowEdit = false;
            this.ITEMID.OptionsColumn.AllowFocus = false;
            this.ITEMID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // APPROVEDAMOUNT
            // 
            this.APPROVEDAMOUNT.Caption = "Təsdiqlənəcək miqdar";
            this.APPROVEDAMOUNT.FieldName = "APPROVEDAMOUNT";
            this.APPROVEDAMOUNT.Name = "APPROVEDAMOUNT";
            this.APPROVEDAMOUNT.OptionsColumn.AllowEdit = false;
            this.APPROVEDAMOUNT.OptionsColumn.AllowFocus = false;
            this.APPROVEDAMOUNT.OptionsColumn.ReadOnly = true;
            this.APPROVEDAMOUNT.Visible = true;
            this.APPROVEDAMOUNT.VisibleIndex = 5;
            this.APPROVEDAMOUNT.Width = 111;
            // 
            // CANCELLED
            // 
            this.CANCELLED.Caption = "Ləğv Olunma";
            this.CANCELLED.FieldName = "CANCELLED";
            this.CANCELLED.Name = "CANCELLED";
            this.CANCELLED.OptionsColumn.AllowEdit = false;
            this.CANCELLED.OptionsColumn.AllowFocus = false;
            this.CANCELLED.OptionsColumn.ReadOnly = true;
            this.CANCELLED.Visible = true;
            this.CANCELLED.VisibleIndex = 9;
            this.CANCELLED.Width = 100;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // PrcDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 466);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrcDetail";
            this.Load += new System.EventHandler(this.PrcDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranchLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentMemo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn NAME;
        private DevExpress.XtraGrid.Columns.GridColumn AMOUNT;
        private DevExpress.XtraGrid.Columns.GridColumn BUYPRICE;
        private DevExpress.XtraGrid.Columns.GridColumn PRICE;
        private DevExpress.XtraGrid.Columns.GridColumn APPROVEDPRICE;
        private DevExpress.XtraGrid.Columns.GridColumn COMMENT;
        public DevExpress.XtraEditors.MemoEdit CommentMemo;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraEditors.LookUpEdit BranchLookUp;
        private DevExpress.XtraGrid.Columns.GridColumn ITEMID;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn CODE;
        private DevExpress.XtraEditors.SimpleButton SaveBtn;
        private DevExpress.XtraGrid.Columns.GridColumn APPROVEDAMOUNT;
        private DevExpress.XtraGrid.Columns.GridColumn CANCELLED;
    }
}