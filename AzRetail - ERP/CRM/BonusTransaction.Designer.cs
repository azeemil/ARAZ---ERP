namespace ERP.CRM
{
    partial class BonusTransaction
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BonusTransaction));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BonusAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ExplanationTxt = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.SaveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Logicalref = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.Position = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.ContactCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BDayText = new DevExpress.XtraEditors.DateEdit();
            this.ContactTxbx = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.SexRadio = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.MaritialRadio = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.FNameTxbx = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.SNameTxbx = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.NameTxbx = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.CartNo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BonusAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplanationTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logicalref.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDayText.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDayText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactTxbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexRadio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaritialRadio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FNameTxbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNameTxbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTxbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(336, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Bonus";
            // 
            // BonusAmount
            // 
            this.BonusAmount.Location = new System.Drawing.Point(411, 58);
            this.BonusAmount.Name = "BonusAmount";
            this.BonusAmount.Properties.Mask.EditMask = "f0";
            this.BonusAmount.Size = new System.Drawing.Size(60, 20);
            this.BonusAmount.TabIndex = 1;
            this.BonusAmount.TextChanged += new System.EventHandler(this.BonusAmount_TextChanged);
            this.BonusAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BonusAmount_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(336, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Səbəb";
            // 
            // ExplanationTxt
            // 
            this.ExplanationTxt.Location = new System.Drawing.Point(411, 98);
            this.ExplanationTxt.Name = "ExplanationTxt";
            this.ExplanationTxt.Properties.MaxLength = 51;
            this.ExplanationTxt.Size = new System.Drawing.Size(299, 146);
            this.ExplanationTxt.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl3.Location = new System.Drawing.Point(336, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(135, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Hazırki bonus miqdarı:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.Appearance.Options.UseFont = true;
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.Location = new System.Drawing.Point(456, 256);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(111, 23);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Yadda saxla";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.CancelBtn.Appearance.Options.UseFont = true;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("CancelBtn.Image")));
            this.CancelBtn.Location = new System.Drawing.Point(599, 256);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(111, 23);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Ləğv Et";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.CartNo);
            this.groupControl1.Controls.Add(this.Logicalref);
            this.groupControl1.Controls.Add(this.labelControl17);
            this.groupControl1.Controls.Add(this.Position);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.ContactCode);
            this.groupControl1.Controls.Add(this.BDayText);
            this.groupControl1.Controls.Add(this.ContactTxbx);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.SexRadio);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.MaritialRadio);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.FNameTxbx);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.SNameTxbx);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.NameTxbx);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(324, 322);
            this.groupControl1.TabIndex = 7;
            // 
            // Logicalref
            // 
            this.Logicalref.Enabled = false;
            this.Logicalref.Location = new System.Drawing.Point(131, 469);
            this.Logicalref.Name = "Logicalref";
            this.Logicalref.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Logicalref.Properties.Appearance.Options.UseFont = true;
            this.Logicalref.Properties.Mask.EditMask = "[A-Z]{1}[a-z]+";
            this.Logicalref.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Logicalref.Properties.Mask.ShowPlaceHolders = false;
            this.Logicalref.Size = new System.Drawing.Size(155, 20);
            this.Logicalref.TabIndex = 89;
            this.Logicalref.Visible = false;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl17.Location = new System.Drawing.Point(31, 33);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(45, 14);
            this.labelControl17.TabIndex = 69;
            this.labelControl17.Text = "Kart №";
            // 
            // Position
            // 
            this.Position.Enabled = false;
            this.Position.Location = new System.Drawing.Point(131, 288);
            this.Position.Name = "Position";
            this.Position.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Position.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Vəzifə")});
            this.Position.Properties.DisplayMember = "NAME";
            this.Position.Properties.NullText = "";
            this.Position.Properties.ValueMember = "NAME";
            this.Position.Size = new System.Drawing.Size(155, 20);
            this.Position.TabIndex = 68;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Location = new System.Drawing.Point(31, 290);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(36, 14);
            this.labelControl12.TabIndex = 67;
            this.labelControl12.Text = "Vəzifə";
            // 
            // ContactCode
            // 
            this.ContactCode.Enabled = false;
            this.ContactCode.Location = new System.Drawing.Point(131, 255);
            this.ContactCode.Name = "ContactCode";
            this.ContactCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ContactCode.Properties.Items.AddRange(new object[] {
            "012",
            "040",
            "050",
            "051",
            "055",
            "070",
            "077"});
            this.ContactCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ContactCode.Size = new System.Drawing.Size(46, 20);
            this.ContactCode.TabIndex = 59;
            // 
            // BDayText
            // 
            this.BDayText.EditValue = null;
            this.BDayText.Enabled = false;
            this.BDayText.Location = new System.Drawing.Point(131, 156);
            this.BDayText.Name = "BDayText";
            this.BDayText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BDayText.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BDayText.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.BDayText.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.BDayText.Size = new System.Drawing.Size(155, 20);
            this.BDayText.TabIndex = 58;
            // 
            // ContactTxbx
            // 
            this.ContactTxbx.Enabled = false;
            this.ContactTxbx.Location = new System.Drawing.Point(183, 255);
            this.ContactTxbx.Name = "ContactTxbx";
            this.ContactTxbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ContactTxbx.Properties.Appearance.Options.UseFont = true;
            this.ContactTxbx.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.ContactTxbx.Properties.Mask.BeepOnError = true;
            this.ContactTxbx.Properties.Mask.EditMask = "f0";
            this.ContactTxbx.Properties.Mask.IgnoreMaskBlank = false;
            this.ContactTxbx.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ContactTxbx.Properties.Mask.SaveLiteral = false;
            this.ContactTxbx.Properties.MaxLength = 7;
            this.ContactTxbx.Size = new System.Drawing.Size(103, 20);
            this.ContactTxbx.TabIndex = 57;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Location = new System.Drawing.Point(31, 261);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(53, 14);
            this.labelControl9.TabIndex = 56;
            this.labelControl9.Text = "Əlaqə №";
            // 
            // SexRadio
            // 
            this.SexRadio.Enabled = false;
            this.SexRadio.Location = new System.Drawing.Point(131, 223);
            this.SexRadio.Name = "SexRadio";
            this.SexRadio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.SexRadio.Properties.Appearance.Options.UseFont = true;
            this.SexRadio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Kişi"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Qadın")});
            this.SexRadio.Size = new System.Drawing.Size(155, 21);
            this.SexRadio.TabIndex = 55;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Location = new System.Drawing.Point(31, 230);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 14);
            this.labelControl7.TabIndex = 54;
            this.labelControl7.Text = "Cinsi";
            // 
            // MaritialRadio
            // 
            this.MaritialRadio.Enabled = false;
            this.MaritialRadio.Location = new System.Drawing.Point(131, 188);
            this.MaritialRadio.Name = "MaritialRadio";
            this.MaritialRadio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.MaritialRadio.Properties.Appearance.Options.UseFont = true;
            this.MaritialRadio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Evli"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Subay")});
            this.MaritialRadio.Size = new System.Drawing.Size(155, 21);
            this.MaritialRadio.TabIndex = 53;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(31, 195);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 14);
            this.labelControl6.TabIndex = 52;
            this.labelControl6.Text = "Ailə Vəziyyəti";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(31, 162);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 14);
            this.labelControl4.TabIndex = 49;
            this.labelControl4.Text = "Doğum Tarixi";
            // 
            // FNameTxbx
            // 
            this.FNameTxbx.Enabled = false;
            this.FNameTxbx.Location = new System.Drawing.Point(131, 124);
            this.FNameTxbx.Name = "FNameTxbx";
            this.FNameTxbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FNameTxbx.Properties.Appearance.Options.UseFont = true;
            this.FNameTxbx.Properties.Mask.EditMask = "[A-Z]{1}[a-z]+";
            this.FNameTxbx.Size = new System.Drawing.Size(155, 20);
            this.FNameTxbx.TabIndex = 48;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Location = new System.Drawing.Point(31, 130);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 14);
            this.labelControl8.TabIndex = 47;
            this.labelControl8.Text = "Ata adı";
            // 
            // SNameTxbx
            // 
            this.SNameTxbx.Enabled = false;
            this.SNameTxbx.Location = new System.Drawing.Point(131, 92);
            this.SNameTxbx.Name = "SNameTxbx";
            this.SNameTxbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SNameTxbx.Properties.Appearance.Options.UseFont = true;
            this.SNameTxbx.Properties.Mask.EditMask = "[A-Z]{1}[a-z]+";
            this.SNameTxbx.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.SNameTxbx.Properties.Mask.ShowPlaceHolders = false;
            this.SNameTxbx.Size = new System.Drawing.Size(155, 20);
            this.SNameTxbx.TabIndex = 46;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Location = new System.Drawing.Point(31, 98);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(38, 14);
            this.labelControl10.TabIndex = 45;
            this.labelControl10.Text = "Soyad";
            // 
            // NameTxbx
            // 
            this.NameTxbx.Enabled = false;
            this.NameTxbx.EnterMoveNextControl = true;
            this.NameTxbx.Location = new System.Drawing.Point(131, 60);
            this.NameTxbx.Name = "NameTxbx";
            this.NameTxbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.NameTxbx.Properties.Appearance.Options.UseFont = true;
            this.NameTxbx.Properties.Mask.BeepOnError = true;
            this.NameTxbx.Properties.Mask.EditMask = "([A-Z]{1,1}[a-z]{2,}).{3,}";
            this.NameTxbx.Properties.Mask.IgnoreMaskBlank = false;
            this.NameTxbx.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.NameTxbx.Properties.Mask.ShowPlaceHolders = false;
            this.NameTxbx.Size = new System.Drawing.Size(155, 20);
            this.NameTxbx.TabIndex = 44;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Location = new System.Drawing.Point(31, 66);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(17, 14);
            this.labelControl11.TabIndex = 43;
            this.labelControl11.Text = "Ad";
            // 
            // CartNo
            // 
            this.CartNo.Enabled = false;
            this.CartNo.EnterMoveNextControl = true;
            this.CartNo.Location = new System.Drawing.Point(131, 27);
            this.CartNo.Name = "CartNo";
            this.CartNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.CartNo.Properties.Appearance.Options.UseFont = true;
            this.CartNo.Properties.Mask.BeepOnError = true;
            this.CartNo.Properties.Mask.EditMask = "([A-Z]{1,1}[a-z]{2,}).{3,}";
            this.CartNo.Properties.Mask.IgnoreMaskBlank = false;
            this.CartNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.CartNo.Properties.Mask.ShowPlaceHolders = false;
            this.CartNo.Size = new System.Drawing.Size(155, 20);
            this.CartNo.TabIndex = 90;
            // 
            // BonusTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 322);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.ExplanationTxt);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.BonusAmount);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BonusTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.BonusAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplanationTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logicalref.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDayText.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDayText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactTxbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexRadio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaritialRadio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FNameTxbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNameTxbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTxbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton SaveBtn;
        private DevExpress.XtraEditors.SimpleButton CancelBtn;
        public DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.MemoEdit ExplanationTxt;
        public DevExpress.XtraEditors.TextEdit BonusAmount;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraEditors.TextEdit Logicalref;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        public DevExpress.XtraEditors.LookUpEdit Position;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        public DevExpress.XtraEditors.ComboBoxEdit ContactCode;
        public DevExpress.XtraEditors.DateEdit BDayText;
        public DevExpress.XtraEditors.TextEdit ContactTxbx;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.RadioGroup SexRadio;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.RadioGroup MaritialRadio;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.TextEdit FNameTxbx;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        public DevExpress.XtraEditors.TextEdit SNameTxbx;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.TextEdit NameTxbx;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        public DevExpress.XtraEditors.TextEdit CartNo;
    }
}