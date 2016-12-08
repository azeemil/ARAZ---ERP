namespace ERP.CRM.Lotoreya
{
    partial class Lotoreya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lotoreya));
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxCustCartNo = new DevExpress.XtraEditors.TextEdit();
            this.textBoxCartNo = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCheck = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxPresent = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BranchLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCustCartNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCartNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPresent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchLookUp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müştəri kart No.";
            // 
            // textBoxCustCartNo
            // 
            this.textBoxCustCartNo.Location = new System.Drawing.Point(161, 61);
            this.textBoxCustCartNo.Name = "textBoxCustCartNo";
            this.textBoxCustCartNo.Size = new System.Drawing.Size(265, 20);
            this.textBoxCustCartNo.TabIndex = 2;
            // 
            // textBoxCartNo
            // 
            this.textBoxCartNo.Location = new System.Drawing.Point(161, 97);
            this.textBoxCartNo.Name = "textBoxCartNo";
            this.textBoxCartNo.Size = new System.Drawing.Size(265, 20);
            this.textBoxCartNo.TabIndex = 3;
            // 
            // simpleButtonConfirm
            // 
            this.simpleButtonConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButtonConfirm.Appearance.Options.UseFont = true;
            this.simpleButtonConfirm.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonConfirm.Image")));
            this.simpleButtonConfirm.Location = new System.Drawing.Point(161, 169);
            this.simpleButtonConfirm.Name = "simpleButtonConfirm";
            this.simpleButtonConfirm.Size = new System.Drawing.Size(80, 23);
            this.simpleButtonConfirm.TabIndex = 4;
            this.simpleButtonConfirm.Text = "Təsdiqlə";
            this.simpleButtonConfirm.Click += new System.EventHandler(this.simpleButtonConfirm_Click);
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButtonClose.Appearance.Options.UseFont = true;
            this.simpleButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonClose.Image")));
            this.simpleButtonClose.Location = new System.Drawing.Point(255, 169);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(80, 23);
            this.simpleButtonClose.TabIndex = 5;
            this.simpleButtonClose.Text = "Bağla";
            this.simpleButtonClose.Click += new System.EventHandler(this.simpleButtonClose_Click);
            // 
            // simpleButtonCheck
            // 
            this.simpleButtonCheck.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButtonCheck.Appearance.Options.UseFont = true;
            this.simpleButtonCheck.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonCheck.Image")));
            this.simpleButtonCheck.Location = new System.Drawing.Point(341, 127);
            this.simpleButtonCheck.Name = "simpleButtonCheck";
            this.simpleButtonCheck.Size = new System.Drawing.Size(85, 22);
            this.simpleButtonCheck.TabIndex = 6;
            this.simpleButtonCheck.Text = "Yoxla";
            this.simpleButtonCheck.Click += new System.EventHandler(this.simpleButtonCheck_Click);
            // 
            // comboBoxPresent
            // 
            this.comboBoxPresent.Location = new System.Drawing.Point(161, 128);
            this.comboBoxPresent.Name = "comboBoxPresent";
            this.comboBoxPresent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxPresent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxPresent.Size = new System.Drawing.Size(174, 20);
            this.comboBoxPresent.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(46, 97);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 15);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Lotoreya kart No.";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(46, 131);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 15);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Hədiyyə";
            // 
            // BranchLookUp
            // 
            this.BranchLookUp.EnterMoveNextControl = true;
            this.BranchLookUp.Location = new System.Drawing.Point(161, 32);
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
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(46, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 15);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Filial";
            // 
            // Lotoreya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 219);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.BranchLookUp);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.comboBoxPresent);
            this.Controls.Add(this.simpleButtonCheck);
            this.Controls.Add(this.simpleButtonClose);
            this.Controls.Add(this.simpleButtonConfirm);
            this.Controls.Add(this.textBoxCartNo);
            this.Controls.Add(this.textBoxCustCartNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lotoreya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotoreya";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCustCartNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCartNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPresent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchLookUp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private  DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit textBoxCustCartNo;
        private DevExpress.XtraEditors.TextEdit textBoxCartNo;
        private DevExpress.XtraEditors.SimpleButton simpleButtonConfirm;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCheck;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxPresent;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit BranchLookUp;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}