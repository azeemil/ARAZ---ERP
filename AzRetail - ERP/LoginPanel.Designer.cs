using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ERP
{
    partial class LoginPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.OK = new DevExpress.XtraEditors.SimpleButton();
            this.CANCEL = new DevExpress.XtraEditors.SimpleButton();
            this.user = new DevExpress.XtraEditors.TextEdit();
            this.domain = new DevExpress.XtraEditors.TextEdit();
            this.password = new DevExpress.XtraEditors.ButtonEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.PeriodCMB = new DevExpress.XtraEditors.LookUpEdit();
            this.FirmLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.user.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodCMB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirmLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(301, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Istifadəçi Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(301, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Şifrə";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(301, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Firma";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(301, 21);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 19);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Domain";
            // 
            // OK
            // 
            this.OK.AllowFocus = false;
            this.OK.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.OK.Appearance.Options.UseFont = true;
            this.OK.Location = new System.Drawing.Point(417, 206);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(106, 38);
            this.OK.TabIndex = 1;
            this.OK.Text = "Daxil Ol";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.AllowFocus = false;
            this.CANCEL.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.CANCEL.Appearance.Options.UseFont = true;
            this.CANCEL.Location = new System.Drawing.Point(564, 206);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(103, 38);
            this.CANCEL.TabIndex = 9;
            this.CANCEL.Text = "Ləğv Et";
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(438, 51);
            this.user.Name = "user";
            this.user.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Properties.Appearance.Options.UseFont = true;
            this.user.Size = new System.Drawing.Size(229, 26);
            this.user.TabIndex = 5;
            // 
            // domain
            // 
            this.domain.Enabled = false;
            this.domain.Location = new System.Drawing.Point(438, 14);
            this.domain.Name = "domain";
            this.domain.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domain.Properties.Appearance.Options.UseFont = true;
            this.domain.Size = new System.Drawing.Size(229, 26);
            this.domain.TabIndex = 4;
            // 
            // password
            // 
            this.password.EnterMoveNextControl = true;
            this.password.Location = new System.Drawing.Point(438, 89);
            this.password.Name = "password";
            this.password.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Properties.Appearance.Options.UseFont = true;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.Transparent;
            serializableAppearanceObject1.BackColor2 = System.Drawing.Color.Transparent;
            serializableAppearanceObject1.BorderColor = System.Drawing.Color.Transparent;
            serializableAppearanceObject1.ForeColor = System.Drawing.Color.Transparent;
            serializableAppearanceObject1.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject1.Image")));
            serializableAppearanceObject1.Options.UseBackColor = true;
            serializableAppearanceObject1.Options.UseBorderColor = true;
            serializableAppearanceObject1.Options.UseForeColor = true;
            serializableAppearanceObject1.Options.UseImage = true;
            this.password.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 0, true, true, false, DevExpress.XtraEditors.ImageLocation.Default, ((System.Drawing.Image)(resources.GetObject("password.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.password.Properties.HideSelection = false;
            this.password.Properties.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(229, 26);
            this.password.TabIndex = 0;
            this.password.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.password_ButtonPressed);
            this.password.Click += new System.EventHandler(this.password_Click);
            this.password.DoubleClick += new System.EventHandler(this.password_DoubleClick);
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit1.EditValue = global::ERP.Properties.Resources._12355;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 30);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.InitialImage = global::ERP.Properties.Resources.araz_604x345;
            this.pictureEdit1.Properties.ZoomPercent = 40D;
            this.pictureEdit1.Size = new System.Drawing.Size(269, 185);
            this.pictureEdit1.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(301, 174);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 19);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Dövr";
            // 
            // PeriodCMB
            // 
            this.PeriodCMB.EnterMoveNextControl = true;
            this.PeriodCMB.Location = new System.Drawing.Point(438, 171);
            this.PeriodCMB.Name = "PeriodCMB";
            this.PeriodCMB.Properties.AllowFocused = false;
            this.PeriodCMB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PeriodCMB.Properties.Appearance.Options.UseFont = true;
            this.PeriodCMB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PeriodCMB.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NR", "Dövr"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FIRMNR", "Firma")});
            this.PeriodCMB.Properties.DisplayMember = "NR";
            this.PeriodCMB.Properties.NullText = "";
            this.PeriodCMB.Properties.ValueMember = "NR";
            this.PeriodCMB.Size = new System.Drawing.Size(229, 26);
            this.PeriodCMB.TabIndex = 2;
            // 
            // FirmLookUp
            // 
            this.FirmLookUp.EnterMoveNextControl = true;
            this.FirmLookUp.Location = new System.Drawing.Point(438, 128);
            this.FirmLookUp.Name = "FirmLookUp";
            this.FirmLookUp.Properties.AllowFocused = false;
            this.FirmLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FirmLookUp.Properties.Appearance.Options.UseFont = true;
            this.FirmLookUp.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FirmLookUp.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Gray;
            this.FirmLookUp.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.FirmLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FirmLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NR", 10, "№"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", 45, "Firma"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TITLE", 45, "Açıqlama"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DBNAME", "DBNAME", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.FirmLookUp.Properties.DisplayMember = "NR";
            this.FirmLookUp.Properties.NullText = "";
            this.FirmLookUp.Properties.PopupFormMinSize = new System.Drawing.Size(300, 0);
            this.FirmLookUp.Properties.ValueMember = "NR";
            this.FirmLookUp.Size = new System.Drawing.Size(229, 26);
            this.FirmLookUp.TabIndex = 13;
            this.FirmLookUp.EditValueChanged += new System.EventHandler(this.FirmLookUp_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(31, 234);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(0, 16);
            this.labelControl6.TabIndex = 14;
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.marqueeProgressBarControl1.EditValue = 0;
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(0, 270);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(687, 16);
            this.marqueeProgressBarControl1.TabIndex = 15;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 286);
            this.ControlBox = false;
            this.Controls.Add(this.marqueeProgressBarControl1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.FirmLookUp);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.domain);
            this.Controls.Add(this.user);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.PeriodCMB);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPanel";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARAZ - ERP";
            this.Load += new System.EventHandler(this.LoginPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodCMB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirmLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private SimpleButton OK;
        private SimpleButton CANCEL;
        private TextEdit user;
        private TextEdit domain;
        private ButtonEdit password;
        private PictureEdit pictureEdit1;
        private LabelControl labelControl5;
        private LookUpEdit PeriodCMB;
        private LookUpEdit FirmLookUp;
        private LabelControl labelControl6;
        private MarqueeProgressBarControl marqueeProgressBarControl1;
    }
}