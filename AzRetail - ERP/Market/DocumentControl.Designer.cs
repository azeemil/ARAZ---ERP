namespace ERP.Market
{
    partial class DocumentControl
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentControl));
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.barkodTxt = new DevExpress.XtraEditors.TextEdit();
            this.searchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ControlledBtn = new DevExpress.XtraEditors.SimpleButton();
            this.lockCbx = new DevExpress.XtraEditors.CheckEdit();
            this.clearBtn = new DevExpress.XtraEditors.SimpleButton();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LOGICALREF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.INVTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FICHENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOURCEINDEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESTINDEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barkodTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockCbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod :";
            // 
            // barkodTxt
            // 
            this.barkodTxt.Location = new System.Drawing.Point(87, 15);
            this.barkodTxt.Name = "barkodTxt";
            this.barkodTxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.barkodTxt.Properties.Appearance.Options.UseFont = true;
            this.barkodTxt.Size = new System.Drawing.Size(191, 26);
            this.barkodTxt.TabIndex = 2;
            this.barkodTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barkodTxt_KeyDown);
            // 
            // searchBtn
            // 
            this.searchBtn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Appearance.Options.UseFont = true;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(296, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(105, 30);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Axtar";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // ControlledBtn
            // 
            this.ControlledBtn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlledBtn.Appearance.Options.UseFont = true;
            this.ControlledBtn.Enabled = false;
            this.ControlledBtn.Image = ((System.Drawing.Image)(resources.GetObject("ControlledBtn.Image")));
            this.ControlledBtn.Location = new System.Drawing.Point(433, 12);
            this.ControlledBtn.Name = "ControlledBtn";
            this.ControlledBtn.Size = new System.Drawing.Size(106, 30);
            this.ControlledBtn.TabIndex = 16;
            this.ControlledBtn.Text = "Yoxlanıldı";
            this.ControlledBtn.Click += new System.EventHandler(this.ControlledBtn_Click);
            // 
            // lockCbx
            // 
            this.lockCbx.EditValue = true;
            this.lockCbx.Location = new System.Drawing.Point(23, 47);
            this.lockCbx.Name = "lockCbx";
            this.lockCbx.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockCbx.Properties.Appearance.Options.UseFont = true;
            this.lockCbx.Properties.Caption = "Kilidlənsin";
            this.lockCbx.Size = new System.Drawing.Size(94, 19);
            this.lockCbx.TabIndex = 17;
            // 
            // clearBtn
            // 
            this.clearBtn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Appearance.Options.UseFont = true;
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.Location = new System.Drawing.Point(580, 12);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(85, 30);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "Təmizlə";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid.Location = new System.Drawing.Point(0, 94);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(946, 473);
            this.grid.TabIndex = 19;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LOGICALREF,
            this.TRCODE,
            this.INVTYPE,
            this.FICHENO,
            this.DOCODE,
            this.SOURCEINDEX,
            this.DESTINDEX});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // LOGICALREF
            // 
            this.LOGICALREF.Caption = "ID";
            this.LOGICALREF.FieldName = "LOGICALREF";
            this.LOGICALREF.Name = "LOGICALREF";
            // 
            // TRCODE
            // 
            this.TRCODE.Caption = "TRCODE";
            this.TRCODE.FieldName = "TRCODE";
            this.TRCODE.Name = "TRCODE";
            // 
            // INVTYPE
            // 
            this.INVTYPE.Caption = "Tip";
            this.INVTYPE.FieldName = "INVTYPE";
            this.INVTYPE.Name = "INVTYPE";
            this.INVTYPE.OptionsColumn.AllowEdit = false;
            this.INVTYPE.OptionsColumn.AllowFocus = false;
            this.INVTYPE.Visible = true;
            this.INVTYPE.VisibleIndex = 0;
            // 
            // FICHENO
            // 
            this.FICHENO.Caption = "Qaimə №";
            this.FICHENO.FieldName = "FICHENO";
            this.FICHENO.Name = "FICHENO";
            this.FICHENO.OptionsColumn.AllowEdit = false;
            this.FICHENO.OptionsColumn.AllowFocus = false;
            this.FICHENO.Visible = true;
            this.FICHENO.VisibleIndex = 1;
            // 
            // DOCODE
            // 
            this.DOCODE.Caption = "Sənəd №";
            this.DOCODE.FieldName = "DOCODE";
            this.DOCODE.Name = "DOCODE";
            this.DOCODE.OptionsColumn.AllowEdit = false;
            this.DOCODE.OptionsColumn.AllowFocus = false;
            this.DOCODE.Visible = true;
            this.DOCODE.VisibleIndex = 2;
            // 
            // SOURCEINDEX
            // 
            this.SOURCEINDEX.Caption = "Giriş Anbar №";
            this.SOURCEINDEX.FieldName = "SOURCEINDEX";
            this.SOURCEINDEX.Name = "SOURCEINDEX";
            this.SOURCEINDEX.OptionsColumn.AllowEdit = false;
            this.SOURCEINDEX.OptionsColumn.AllowFocus = false;
            this.SOURCEINDEX.Visible = true;
            this.SOURCEINDEX.VisibleIndex = 3;
            // 
            // DESTINDEX
            // 
            this.DESTINDEX.Caption = "Giriş Anbar №";
            this.DESTINDEX.FieldName = "DESTINDEX";
            this.DESTINDEX.Name = "DESTINDEX";
            this.DESTINDEX.OptionsColumn.AllowEdit = false;
            this.DESTINDEX.OptionsColumn.AllowFocus = false;
            this.DESTINDEX.Visible = true;
            this.DESTINDEX.VisibleIndex = 4;
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(168, 47);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Avtomatik Yoxlanılsın";
            this.checkEdit1.Size = new System.Drawing.Size(163, 19);
            this.checkEdit1.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(350, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 21;
            // 
            // DocumentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 567);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.lockCbx);
            this.Controls.Add(this.ControlledBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.barkodTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sənəd Yoxlama";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barkodTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockCbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit barkodTxt;
        private DevExpress.XtraEditors.SimpleButton searchBtn;
        private DevExpress.XtraEditors.SimpleButton ControlledBtn;
        private DevExpress.XtraEditors.CheckEdit lockCbx;
        private DevExpress.XtraEditors.SimpleButton clearBtn;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn LOGICALREF;
        private DevExpress.XtraGrid.Columns.GridColumn TRCODE;
        private DevExpress.XtraGrid.Columns.GridColumn INVTYPE;
        private DevExpress.XtraGrid.Columns.GridColumn FICHENO;
        private DevExpress.XtraGrid.Columns.GridColumn DOCODE;
        private DevExpress.XtraGrid.Columns.GridColumn SOURCEINDEX;
        private DevExpress.XtraGrid.Columns.GridColumn DESTINDEX;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

