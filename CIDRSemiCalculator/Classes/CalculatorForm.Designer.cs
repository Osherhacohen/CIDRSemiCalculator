namespace CIDRSemiCalculator
{
    partial class CalcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcForm));
            this.textBoxValidate = new System.Windows.Forms.TextBox();
            this.textBoxOverlapNet1 = new System.Windows.Forms.TextBox();
            this.textBoxOverlapNet2 = new System.Windows.Forms.TextBox();
            this.groupBoxValidate = new System.Windows.Forms.GroupBox();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.validationLabel = new System.Windows.Forms.Label();
            this.groupBoxRange = new System.Windows.Forms.GroupBox();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelLow = new System.Windows.Forms.Label();
            this.cidrRangeHighLabel = new System.Windows.Forms.Label();
            this.buttonRange = new System.Windows.Forms.Button();
            this.cidrRangeLowLabel = new System.Windows.Forms.Label();
            this.textBoxRange = new System.Windows.Forms.TextBox();
            this.groupBoxOverlap = new System.Windows.Forms.GroupBox();
            this.labelNet2 = new System.Windows.Forms.Label();
            this.labelNet1 = new System.Windows.Forms.Label();
            this.buttonOverlap = new System.Windows.Forms.Button();
            this.labelOverlap = new System.Windows.Forms.Label();
            this.groupBoxValidate.SuspendLayout();
            this.groupBoxRange.SuspendLayout();
            this.groupBoxOverlap.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxValidate
            // 
            this.textBoxValidate.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxValidate.Location = new System.Drawing.Point(56, 35);
            this.textBoxValidate.Name = "textBoxValidate";
            this.textBoxValidate.Size = new System.Drawing.Size(195, 20);
            this.textBoxValidate.TabIndex = 0;
            // 
            // textBoxOverlapNet1
            // 
            this.textBoxOverlapNet1.Location = new System.Drawing.Point(56, 46);
            this.textBoxOverlapNet1.Name = "textBoxOverlapNet1";
            this.textBoxOverlapNet1.Size = new System.Drawing.Size(195, 20);
            this.textBoxOverlapNet1.TabIndex = 2;
            // 
            // textBoxOverlapNet2
            // 
            this.textBoxOverlapNet2.Location = new System.Drawing.Point(56, 93);
            this.textBoxOverlapNet2.Name = "textBoxOverlapNet2";
            this.textBoxOverlapNet2.Size = new System.Drawing.Size(195, 20);
            this.textBoxOverlapNet2.TabIndex = 3;
            // 
            // groupBoxValidate
            // 
            this.groupBoxValidate.Controls.Add(this.buttonValidate);
            this.groupBoxValidate.Controls.Add(this.validationLabel);
            this.groupBoxValidate.Controls.Add(this.textBoxValidate);
            this.groupBoxValidate.Location = new System.Drawing.Point(36, 27);
            this.groupBoxValidate.Name = "groupBoxValidate";
            this.groupBoxValidate.Size = new System.Drawing.Size(380, 109);
            this.groupBoxValidate.TabIndex = 4;
            this.groupBoxValidate.TabStop = false;
            this.groupBoxValidate.Text = "Validate CIDR";
            // 
            // buttonValidate
            // 
            this.buttonValidate.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonValidate.Location = new System.Drawing.Point(257, 33);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 2;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = false;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.validationLabel.Location = new System.Drawing.Point(53, 72);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(93, 13);
            this.validationLabel.TabIndex = 1;
            this.validationLabel.Text = "No CIDR input.";
            // 
            // groupBoxRange
            // 
            this.groupBoxRange.Controls.Add(this.labelHigh);
            this.groupBoxRange.Controls.Add(this.labelLow);
            this.groupBoxRange.Controls.Add(this.cidrRangeHighLabel);
            this.groupBoxRange.Controls.Add(this.buttonRange);
            this.groupBoxRange.Controls.Add(this.cidrRangeLowLabel);
            this.groupBoxRange.Controls.Add(this.textBoxRange);
            this.groupBoxRange.Location = new System.Drawing.Point(36, 183);
            this.groupBoxRange.Name = "groupBoxRange";
            this.groupBoxRange.Size = new System.Drawing.Size(380, 124);
            this.groupBoxRange.TabIndex = 5;
            this.groupBoxRange.TabStop = false;
            this.groupBoxRange.Text = "Calculate Range";
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Location = new System.Drawing.Point(53, 95);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(84, 13);
            this.labelHigh.TabIndex = 6;
            this.labelHigh.Text = "Highest Address";
            // 
            // labelLow
            // 
            this.labelLow.AutoSize = true;
            this.labelLow.Location = new System.Drawing.Point(53, 70);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(82, 13);
            this.labelLow.TabIndex = 5;
            this.labelLow.Text = "Lowest Address";
            // 
            // cidrRangeHighLabel
            // 
            this.cidrRangeHighLabel.AutoSize = true;
            this.cidrRangeHighLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cidrRangeHighLabel.Location = new System.Drawing.Point(139, 95);
            this.cidrRangeHighLabel.Name = "cidrRangeHighLabel";
            this.cidrRangeHighLabel.Size = new System.Drawing.Size(93, 13);
            this.cidrRangeHighLabel.TabIndex = 4;
            this.cidrRangeHighLabel.Text = "No CIDR input.";
            // 
            // buttonRange
            // 
            this.buttonRange.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonRange.Location = new System.Drawing.Point(257, 37);
            this.buttonRange.Name = "buttonRange";
            this.buttonRange.Size = new System.Drawing.Size(75, 23);
            this.buttonRange.TabIndex = 3;
            this.buttonRange.Text = "Calculate";
            this.buttonRange.UseVisualStyleBackColor = false;
            this.buttonRange.Click += new System.EventHandler(this.buttonRange_Click);
            // 
            // cidrRangeLowLabel
            // 
            this.cidrRangeLowLabel.AutoSize = true;
            this.cidrRangeLowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cidrRangeLowLabel.Location = new System.Drawing.Point(139, 70);
            this.cidrRangeLowLabel.Name = "cidrRangeLowLabel";
            this.cidrRangeLowLabel.Size = new System.Drawing.Size(94, 13);
            this.cidrRangeLowLabel.TabIndex = 2;
            this.cidrRangeLowLabel.Text = "No CIDR Input.";
            // 
            // textBoxRange
            // 
            this.textBoxRange.Location = new System.Drawing.Point(56, 37);
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.Size = new System.Drawing.Size(195, 20);
            this.textBoxRange.TabIndex = 0;
            // 
            // groupBoxOverlap
            // 
            this.groupBoxOverlap.Controls.Add(this.labelNet2);
            this.groupBoxOverlap.Controls.Add(this.labelNet1);
            this.groupBoxOverlap.Controls.Add(this.buttonOverlap);
            this.groupBoxOverlap.Controls.Add(this.labelOverlap);
            this.groupBoxOverlap.Controls.Add(this.textBoxOverlapNet2);
            this.groupBoxOverlap.Controls.Add(this.textBoxOverlapNet1);
            this.groupBoxOverlap.Location = new System.Drawing.Point(36, 326);
            this.groupBoxOverlap.Name = "groupBoxOverlap";
            this.groupBoxOverlap.Size = new System.Drawing.Size(380, 164);
            this.groupBoxOverlap.TabIndex = 6;
            this.groupBoxOverlap.TabStop = false;
            this.groupBoxOverlap.Text = "Check Overlapping CIDRs";
            // 
            // labelNet2
            // 
            this.labelNet2.AutoSize = true;
            this.labelNet2.Location = new System.Drawing.Point(55, 77);
            this.labelNet2.Name = "labelNet2";
            this.labelNet2.Size = new System.Drawing.Size(88, 13);
            this.labelNet2.TabIndex = 7;
            this.labelNet2.Text = "Network 2 CIDR:";
            // 
            // labelNet1
            // 
            this.labelNet1.AutoSize = true;
            this.labelNet1.Location = new System.Drawing.Point(55, 30);
            this.labelNet1.Name = "labelNet1";
            this.labelNet1.Size = new System.Drawing.Size(88, 13);
            this.labelNet1.TabIndex = 7;
            this.labelNet1.Text = "Network 1 CIDR:";
            // 
            // buttonOverlap
            // 
            this.buttonOverlap.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonOverlap.Location = new System.Drawing.Point(257, 67);
            this.buttonOverlap.Name = "buttonOverlap";
            this.buttonOverlap.Size = new System.Drawing.Size(75, 23);
            this.buttonOverlap.TabIndex = 4;
            this.buttonOverlap.Text = "Check";
            this.buttonOverlap.UseVisualStyleBackColor = false;
            this.buttonOverlap.Click += new System.EventHandler(this.buttonOverlap_Click);
            // 
            // labelOverlap
            // 
            this.labelOverlap.AutoSize = true;
            this.labelOverlap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelOverlap.Location = new System.Drawing.Point(55, 129);
            this.labelOverlap.Name = "labelOverlap";
            this.labelOverlap.Size = new System.Drawing.Size(94, 13);
            this.labelOverlap.TabIndex = 3;
            this.labelOverlap.Text = "No CIDR Input.";
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(447, 515);
            this.Controls.Add(this.groupBoxOverlap);
            this.Controls.Add(this.groupBoxRange);
            this.Controls.Add(this.groupBoxValidate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalcForm";
            this.Text = "CIDR Semi Calculator";
            this.Load += new System.EventHandler(this.CalcForm_Load);
            this.groupBoxValidate.ResumeLayout(false);
            this.groupBoxValidate.PerformLayout();
            this.groupBoxRange.ResumeLayout(false);
            this.groupBoxRange.PerformLayout();
            this.groupBoxOverlap.ResumeLayout(false);
            this.groupBoxOverlap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValidate;
        private System.Windows.Forms.TextBox textBoxOverlapNet1;
        private System.Windows.Forms.TextBox textBoxOverlapNet2;
        private System.Windows.Forms.GroupBox groupBoxValidate;
        private System.Windows.Forms.GroupBox groupBoxRange;
        private System.Windows.Forms.TextBox textBoxRange;
        private System.Windows.Forms.GroupBox groupBoxOverlap;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Label validationLabel;
        private System.Windows.Forms.Button buttonRange;
        private System.Windows.Forms.Label cidrRangeLowLabel;
        private System.Windows.Forms.Button buttonOverlap;
        private System.Windows.Forms.Label labelOverlap;
        private System.Windows.Forms.Label cidrRangeHighLabel;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.Label labelNet2;
        private System.Windows.Forms.Label labelNet1;
    }
}

