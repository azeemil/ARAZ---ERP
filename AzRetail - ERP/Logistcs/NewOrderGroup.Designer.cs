namespace ERP.Logistcs
{
    partial class NewOrderGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrderGroup));
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SourceWhouseCmbx = new DevExpress.XtraEditors.LookUpEdit();
            this.SourceBranchCmbx = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.DestWhouseLookUp = new DevExpress.XtraEditors.LookUpEdit();
            this.DestBranchLookUp = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceWhouseCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceBranchCmbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestWhouseLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestBranchLookUp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.Appearance.Options.UseFont = true;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Image")));
            this.cancelBtn.Location = new System.Drawing.Point(447, 91);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 33);
            this.cancelBtn.TabIndex = 31;
            this.cancelBtn.Text = "Ləğv Et";
            // 
            // saveBtn
            // 
            this.saveBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Appearance.Options.UseFont = true;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(323, 91);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(118, 33);
            this.saveBtn.TabIndex = 30;
            this.saveBtn.Text = "Yadda Saxla";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(8, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 16);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "(Aralıq) İş Yeri";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(8, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 16);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "(Aralıq) Anbar";
            // 
            // SourceWhouseCmbx
            // 
            this.SourceWhouseCmbx.EnterMoveNextControl = true;
            this.SourceWhouseCmbx.Location = new System.Drawing.Point(114, 45);
            this.SourceWhouseCmbx.Name = "SourceWhouseCmbx";
            this.SourceWhouseCmbx.Properties.AllowFocused = false;
            this.SourceWhouseCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SourceWhouseCmbx.Properties.Appearance.Options.UseFont = true;
            this.SourceWhouseCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SourceWhouseCmbx.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NR", "№"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Ad"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DIVISNR", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.SourceWhouseCmbx.Properties.DisplayMember = "NR";
            this.SourceWhouseCmbx.Properties.NullText = "";
            this.SourceWhouseCmbx.Properties.ValueMember = "NR";
            this.SourceWhouseCmbx.Size = new System.Drawing.Size(192, 20);
            this.SourceWhouseCmbx.TabIndex = 38;
            // 
            // SourceBranchCmbx
            // 
            this.SourceBranchCmbx.EnterMoveNextControl = true;
            this.SourceBranchCmbx.Location = new System.Drawing.Point(114, 8);
            this.SourceBranchCmbx.Name = "SourceBranchCmbx";
            this.SourceBranchCmbx.Properties.AllowFocused = false;
            this.SourceBranchCmbx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SourceBranchCmbx.Properties.Appearance.Options.UseFont = true;
            this.SourceBranchCmbx.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SourceBranchCmbx.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Gray;
            this.SourceBranchCmbx.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.SourceBranchCmbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SourceBranchCmbx.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NR", "№"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Ad")});
            this.SourceBranchCmbx.Properties.DisplayMember = "NR";
            this.SourceBranchCmbx.Properties.NullText = "";
            this.SourceBranchCmbx.Properties.PopupFormMinSize = new System.Drawing.Size(300, 0);
            this.SourceBranchCmbx.Properties.ValueMember = "NR";
            this.SourceBranchCmbx.Size = new System.Drawing.Size(192, 20);
            this.SourceBranchCmbx.TabIndex = 39;
            this.SourceBranchCmbx.EditValueChanged += new System.EventHandler(this.SourceBranchCmbx_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(311, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 16);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "(Ç) İş Yeri";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(311, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 16);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "(Ç) Anbar";
            // 
            // DestWhouseLookUp
            // 
            this.DestWhouseLookUp.EnterMoveNextControl = true;
            this.DestWhouseLookUp.Location = new System.Drawing.Point(385, 45);
            this.DestWhouseLookUp.Name = "DestWhouseLookUp";
            this.DestWhouseLookUp.Properties.AllowFocused = false;
            this.DestWhouseLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.DestWhouseLookUp.Properties.Appearance.Options.UseFont = true;
            this.DestWhouseLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DestWhouseLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NR", "№"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Ad"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DIVISNR", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.DestWhouseLookUp.Properties.DisplayMember = "NR";
            this.DestWhouseLookUp.Properties.NullText = "";
            this.DestWhouseLookUp.Properties.ValueMember = "NR";
            this.DestWhouseLookUp.Size = new System.Drawing.Size(192, 20);
            this.DestWhouseLookUp.TabIndex = 34;
            // 
            // DestBranchLookUp
            // 
            this.DestBranchLookUp.EnterMoveNextControl = true;
            this.DestBranchLookUp.Location = new System.Drawing.Point(385, 8);
            this.DestBranchLookUp.Name = "DestBranchLookUp";
            this.DestBranchLookUp.Properties.AllowFocused = false;
            this.DestBranchLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.DestBranchLookUp.Properties.Appearance.Options.UseFont = true;
            this.DestBranchLookUp.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DestBranchLookUp.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Gray;
            this.DestBranchLookUp.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.DestBranchLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DestBranchLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NR", "№"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Ad")});
            this.DestBranchLookUp.Properties.DisplayMember = "NR";
            this.DestBranchLookUp.Properties.NullText = "";
            this.DestBranchLookUp.Properties.PopupFormMinSize = new System.Drawing.Size(300, 0);
            this.DestBranchLookUp.Properties.ValueMember = "NR";
            this.DestBranchLookUp.Size = new System.Drawing.Size(192, 20);
            this.DestBranchLookUp.TabIndex = 35;
            this.DestBranchLookUp.EditValueChanged += new System.EventHandler(this.DestBranchLookUp_EditValueChanged);
            // 
            // NewOrderGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(592, 146);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.SourceWhouseCmbx);
            this.Controls.Add(this.SourceBranchCmbx);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.DestWhouseLookUp);
            this.Controls.Add(this.DestBranchLookUp);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewOrderGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.SourceWhouseCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceBranchCmbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestWhouseLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestBranchLookUp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LookUpEdit SourceWhouseCmbx;
        public DevExpress.XtraEditors.LookUpEdit SourceBranchCmbx;
        public DevExpress.XtraEditors.LookUpEdit DestWhouseLookUp;
        public DevExpress.XtraEditors.LookUpEdit DestBranchLookUp;

    }
}