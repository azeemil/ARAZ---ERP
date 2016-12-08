namespace ERP.Finance
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
            this.docTypeTxt = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.whouse2Txt = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.whouse1Txt = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.docNoTxt = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.invoiceNoTxt = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Excel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barkodTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockCbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTypeTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whouse2Txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whouse1Txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docNoTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceNoTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod :";
            // 
            // barkodTxt
            // 
            this.barkodTxt.Location = new System.Drawing.Point(82, 29);
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
            this.searchBtn.Location = new System.Drawing.Point(291, 25);
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
            this.ControlledBtn.Location = new System.Drawing.Point(428, 25);
            this.ControlledBtn.Name = "ControlledBtn";
            this.ControlledBtn.Size = new System.Drawing.Size(106, 30);
            this.ControlledBtn.TabIndex = 16;
            this.ControlledBtn.Text = "Yoxlanıldı";
            this.ControlledBtn.Click += new System.EventHandler(this.ControlledBtn_Click);
            // 
            // lockCbx
            // 
            this.lockCbx.EditValue = true;
            this.lockCbx.Location = new System.Drawing.Point(675, 27);
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
            this.clearBtn.Location = new System.Drawing.Point(575, 25);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(85, 30);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "Təmizlə";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 149);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(946, 418);
            this.grid.TabIndex = 19;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HorzLine.BorderColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.HorzLine.Options.UseBorderColor = true;
            this.gridView1.Appearance.VertLine.BorderColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.VertLine.Options.UseBorderColor = true;
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
            this.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            // 
            // LOGICALREF
            // 
            this.LOGICALREF.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.LOGICALREF.AppearanceHeader.Options.UseFont = true;
            this.LOGICALREF.Caption = "ID";
            this.LOGICALREF.FieldName = "LOGICALREF";
            this.LOGICALREF.Name = "LOGICALREF";
            // 
            // TRCODE
            // 
            this.TRCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.TRCODE.AppearanceHeader.Options.UseFont = true;
            this.TRCODE.Caption = "TRCODE";
            this.TRCODE.FieldName = "TRCODE";
            this.TRCODE.Name = "TRCODE";
            // 
            // INVTYPE
            // 
            this.INVTYPE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.INVTYPE.AppearanceHeader.Options.UseFont = true;
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
            this.FICHENO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.FICHENO.AppearanceHeader.Options.UseFont = true;
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
            this.DOCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DOCODE.AppearanceHeader.Options.UseFont = true;
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
            this.SOURCEINDEX.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.SOURCEINDEX.AppearanceHeader.Options.UseFont = true;
            this.SOURCEINDEX.Caption = "Anbar(1) №";
            this.SOURCEINDEX.FieldName = "SOURCEINDEX";
            this.SOURCEINDEX.Name = "SOURCEINDEX";
            this.SOURCEINDEX.OptionsColumn.AllowEdit = false;
            this.SOURCEINDEX.OptionsColumn.AllowFocus = false;
            this.SOURCEINDEX.Visible = true;
            this.SOURCEINDEX.VisibleIndex = 3;
            // 
            // DESTINDEX
            // 
            this.DESTINDEX.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DESTINDEX.AppearanceHeader.Options.UseFont = true;
            this.DESTINDEX.Caption = "Anbar(2) №";
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
            this.checkEdit1.Location = new System.Drawing.Point(675, 52);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Avtomatik Yoxlanılsın";
            this.checkEdit1.Size = new System.Drawing.Size(163, 19);
            this.checkEdit1.TabIndex = 20;
            // 
            // docTypeTxt
            // 
            this.docTypeTxt.Enabled = false;
            this.docTypeTxt.Location = new System.Drawing.Point(130, 66);
            this.docTypeTxt.Name = "docTypeTxt";
            this.docTypeTxt.Size = new System.Drawing.Size(181, 20);
            this.docTypeTxt.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Sənəd növü";
            // 
            // whouse2Txt
            // 
            this.whouse2Txt.Enabled = false;
            this.whouse2Txt.Location = new System.Drawing.Point(406, 88);
            this.whouse2Txt.Name = "whouse2Txt";
            this.whouse2Txt.Size = new System.Drawing.Size(181, 20);
            this.whouse2Txt.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Anbar (2)";
            // 
            // whouse1Txt
            // 
            this.whouse1Txt.Enabled = false;
            this.whouse1Txt.Location = new System.Drawing.Point(406, 66);
            this.whouse1Txt.Name = "whouse1Txt";
            this.whouse1Txt.Size = new System.Drawing.Size(181, 20);
            this.whouse1Txt.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Anbar (1)";
            // 
            // docNoTxt
            // 
            this.docNoTxt.Enabled = false;
            this.docNoTxt.Location = new System.Drawing.Point(130, 110);
            this.docNoTxt.Name = "docNoTxt";
            this.docNoTxt.Size = new System.Drawing.Size(181, 20);
            this.docNoTxt.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sənəd Nömrəsi";
            // 
            // invoiceNoTxt
            // 
            this.invoiceNoTxt.Enabled = false;
            this.invoiceNoTxt.Location = new System.Drawing.Point(130, 88);
            this.invoiceNoTxt.Name = "invoiceNoTxt";
            this.invoiceNoTxt.Size = new System.Drawing.Size(181, 20);
            this.invoiceNoTxt.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Qaimə Nömrəsi";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(605, 89);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 21;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Excel);
            this.groupControl1.Controls.Add(this.docTypeTxt);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.barkodTxt);
            this.groupControl1.Controls.Add(this.whouse2Txt);
            this.groupControl1.Controls.Add(this.searchBtn);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.ControlledBtn);
            this.groupControl1.Controls.Add(this.whouse1Txt);
            this.groupControl1.Controls.Add(this.lockCbx);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.clearBtn);
            this.groupControl1.Controls.Add(this.docNoTxt);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.invoiceNoTxt);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(946, 149);
            this.groupControl1.TabIndex = 32;
            // 
            // Excel
            // 
            this.Excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Excel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excel.Appearance.Options.UseFont = true;
            this.Excel.Image = ((System.Drawing.Image)(resources.GetObject("Excel.Image")));
            this.Excel.Location = new System.Drawing.Point(769, 114);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(164, 30);
            this.Excel.TabIndex = 32;
            this.Excel.Text = "Excelə göndər";
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // DocumentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 567);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sənəd Yoxlama";
            ((System.ComponentModel.ISupportInitialize)(this.barkodTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockCbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTypeTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whouse2Txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whouse1Txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docNoTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceNoTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

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
        private DevExpress.XtraEditors.TextEdit docTypeTxt;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.TextEdit whouse2Txt;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.TextEdit whouse1Txt;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.TextEdit docNoTxt;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.TextEdit invoiceNoTxt;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Excel;
    }
}

