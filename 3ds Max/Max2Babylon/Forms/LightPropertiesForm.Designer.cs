namespace Max2Babylon
{
    partial class LightPropertiesForm
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
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpAutoAnimate = new System.Windows.Forms.GroupBox();
            this.chkLoop = new System.Windows.Forms.CheckBox();
            this.nupTo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nupFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAutoAnimate = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tagInput = new System.Windows.Forms.TextBox();
            this.tagLabel = new System.Windows.Forms.Label();
            this.chkNoExport = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckForceBackFaces = new System.Windows.Forms.CheckBox();
            this.grpBlurInfo = new System.Windows.Forms.GroupBox();
            this.nupBlurBoxOffset = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nupBlurScale = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nupBias = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCameraType = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.grpAutoAnimate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFrom)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBlurInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBlurBoxOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBlurScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBias)).BeginInit();
            this.SuspendLayout();
            // 
            // butOK
            // 
            this.butOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOK.Location = new System.Drawing.Point(93, 447);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 21);
            this.butOK.TabIndex = 100;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancel
            // 
            this.butCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.Location = new System.Drawing.Point(174, 447);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 21);
            this.butCancel.TabIndex = 101;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grpAutoAnimate);
            this.groupBox3.Controls.Add(this.chkAutoAnimate);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(12, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 144);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Animations";
            // 
            // grpAutoAnimate
            // 
            this.grpAutoAnimate.Controls.Add(this.chkLoop);
            this.grpAutoAnimate.Controls.Add(this.nupTo);
            this.grpAutoAnimate.Controls.Add(this.label4);
            this.grpAutoAnimate.Controls.Add(this.nupFrom);
            this.grpAutoAnimate.Controls.Add(this.label5);
            this.grpAutoAnimate.Enabled = false;
            this.grpAutoAnimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpAutoAnimate.Location = new System.Drawing.Point(21, 47);
            this.grpAutoAnimate.Name = "grpAutoAnimate";
            this.grpAutoAnimate.Size = new System.Drawing.Size(292, 91);
            this.grpAutoAnimate.TabIndex = 32;
            this.grpAutoAnimate.TabStop = false;
            // 
            // chkLoop
            // 
            this.chkLoop.AutoSize = true;
            this.chkLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkLoop.Location = new System.Drawing.Point(9, 61);
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(45, 16);
            this.chkLoop.TabIndex = 37;
            this.chkLoop.Text = "Loop";
            this.chkLoop.ThreeState = true;
            this.chkLoop.UseVisualStyleBackColor = true;
            // 
            // nupTo
            // 
            this.nupTo.Location = new System.Drawing.Point(47, 37);
            this.nupTo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupTo.Name = "nupTo";
            this.nupTo.Size = new System.Drawing.Size(120, 21);
            this.nupTo.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 35;
            this.label4.Text = "To:";
            // 
            // nupFrom
            // 
            this.nupFrom.Location = new System.Drawing.Point(47, 13);
            this.nupFrom.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupFrom.Name = "nupFrom";
            this.nupFrom.Size = new System.Drawing.Size(120, 21);
            this.nupFrom.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "From:";
            // 
            // chkAutoAnimate
            // 
            this.chkAutoAnimate.AutoSize = true;
            this.chkAutoAnimate.Location = new System.Drawing.Point(21, 26);
            this.chkAutoAnimate.Name = "chkAutoAnimate";
            this.chkAutoAnimate.Size = new System.Drawing.Size(96, 16);
            this.chkAutoAnimate.TabIndex = 31;
            this.chkAutoAnimate.Text = "Auto animate";
            this.chkAutoAnimate.ThreeState = true;
            this.chkAutoAnimate.UseVisualStyleBackColor = true;
            this.chkAutoAnimate.CheckedChanged += new System.EventHandler(this.chkAutoAnimate_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tagInput);
            this.groupBox4.Controls.Add(this.tagLabel);
            this.groupBox4.Controls.Add(this.chkNoExport);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(12, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 54);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Misc.";
            // 
            // tagInput
            // 
            this.tagInput.Location = new System.Drawing.Point(194, 23);
            this.tagInput.Name = "tagInput";
            this.tagInput.Size = new System.Drawing.Size(100, 21);
            this.tagInput.TabIndex = 0;
            // 
            // tagLabel
            // 
            this.tagLabel.AutoSize = true;
            this.tagLabel.Location = new System.Drawing.Point(159, 26);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(29, 12);
            this.tagLabel.TabIndex = 2;
            this.tagLabel.Text = "Tag:";
            // 
            // chkNoExport
            // 
            this.chkNoExport.AutoSize = true;
            this.chkNoExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNoExport.Location = new System.Drawing.Point(21, 26);
            this.chkNoExport.Name = "chkNoExport";
            this.chkNoExport.Size = new System.Drawing.Size(99, 16);
            this.chkNoExport.TabIndex = 1;
            this.chkNoExport.Text = "Do not export";
            this.chkNoExport.ThreeState = true;
            this.chkNoExport.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckForceBackFaces);
            this.groupBox1.Controls.Add(this.grpBlurInfo);
            this.groupBox1.Controls.Add(this.nupBias);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbCameraType);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 218);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shadows";
            // 
            // ckForceBackFaces
            // 
            this.ckForceBackFaces.AutoSize = true;
            this.ckForceBackFaces.Location = new System.Drawing.Point(24, 56);
            this.ckForceBackFaces.Name = "ckForceBackFaces";
            this.ckForceBackFaces.Size = new System.Drawing.Size(150, 16);
            this.ckForceBackFaces.TabIndex = 13;
            this.ckForceBackFaces.Text = "Force Back Faces only";
            this.ckForceBackFaces.ThreeState = true;
            this.ckForceBackFaces.UseVisualStyleBackColor = true;
            // 
            // grpBlurInfo
            // 
            this.grpBlurInfo.Controls.Add(this.nupBlurBoxOffset);
            this.grpBlurInfo.Controls.Add(this.label3);
            this.grpBlurInfo.Controls.Add(this.nupBlurScale);
            this.grpBlurInfo.Controls.Add(this.label2);
            this.grpBlurInfo.Enabled = false;
            this.grpBlurInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBlurInfo.Location = new System.Drawing.Point(18, 133);
            this.grpBlurInfo.Name = "grpBlurInfo";
            this.grpBlurInfo.Size = new System.Drawing.Size(292, 80);
            this.grpBlurInfo.TabIndex = 20;
            this.grpBlurInfo.TabStop = false;
            this.grpBlurInfo.Text = "Blur info";
            // 
            // nupBlurBoxOffset
            // 
            this.nupBlurBoxOffset.Location = new System.Drawing.Point(110, 46);
            this.nupBlurBoxOffset.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nupBlurBoxOffset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupBlurBoxOffset.Name = "nupBlurBoxOffset";
            this.nupBlurBoxOffset.Size = new System.Drawing.Size(120, 21);
            this.nupBlurBoxOffset.TabIndex = 24;
            this.nupBlurBoxOffset.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "Blur box offset:";
            // 
            // nupBlurScale
            // 
            this.nupBlurScale.Location = new System.Drawing.Point(110, 22);
            this.nupBlurScale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupBlurScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupBlurScale.Name = "nupBlurScale";
            this.nupBlurScale.Size = new System.Drawing.Size(120, 21);
            this.nupBlurScale.TabIndex = 22;
            this.nupBlurScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "Blur scale:";
            // 
            // nupBias
            // 
            this.nupBias.DecimalPlaces = 5;
            this.nupBias.Location = new System.Drawing.Point(57, 24);
            this.nupBias.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupBias.Name = "nupBias";
            this.nupBias.Size = new System.Drawing.Size(120, 21);
            this.nupBias.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bias:";
            // 
            // cbCameraType
            // 
            this.cbCameraType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCameraType.FormattingEnabled = true;
            this.cbCameraType.Items.AddRange(new object[] {
            "Hard shadows",
            "Poisson Sampling",
            "ESM",
            "Blurred ESM"});
            this.cbCameraType.Location = new System.Drawing.Point(21, 100);
            this.cbCameraType.Name = "cbCameraType";
            this.cbCameraType.Size = new System.Drawing.Size(289, 20);
            this.cbCameraType.TabIndex = 15;
            this.cbCameraType.SelectedIndexChanged += new System.EventHandler(this.cbCameraType_SelectedIndexChanged);
            // 
            // LightPropertiesForm
            // 
            this.AcceptButton = this.butOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(343, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LightPropertiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Babylon.js - Light Properties";
            this.Load += new System.EventHandler(this.LightPropertiesForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpAutoAnimate.ResumeLayout(false);
            this.grpAutoAnimate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFrom)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBlurInfo.ResumeLayout(false);
            this.grpBlurInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBlurBoxOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBlurScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpAutoAnimate;
        private System.Windows.Forms.CheckBox chkLoop;
        private System.Windows.Forms.NumericUpDown nupTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAutoAnimate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkNoExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCameraType;
        private System.Windows.Forms.NumericUpDown nupBlurScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupBias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBlurInfo;
        private System.Windows.Forms.NumericUpDown nupBlurBoxOffset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckForceBackFaces;
        private System.Windows.Forms.Label tagLabel;
        private System.Windows.Forms.TextBox tagInput;
    }
}