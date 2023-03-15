namespace BMICalculator {
    partial class frmBMICalculator {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grpMeasurementSystem = new System.Windows.Forms.GroupBox();
            this.rdoMetric = new System.Windows.Forms.RadioButton();
            this.rdoImperial = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMeasurements = new System.Windows.Forms.GroupBox();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.lblHeightUnit = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpMeasurementSystem.SuspendLayout();
            this.grpMeasurements.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMeasurementSystem
            // 
            this.grpMeasurementSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMeasurementSystem.Controls.Add(this.rdoMetric);
            this.grpMeasurementSystem.Controls.Add(this.rdoImperial);
            this.grpMeasurementSystem.Location = new System.Drawing.Point(14, 14);
            this.grpMeasurementSystem.Margin = new System.Windows.Forms.Padding(5);
            this.grpMeasurementSystem.Name = "grpMeasurementSystem";
            this.grpMeasurementSystem.Padding = new System.Windows.Forms.Padding(5);
            this.grpMeasurementSystem.Size = new System.Drawing.Size(298, 79);
            this.grpMeasurementSystem.TabIndex = 0;
            this.grpMeasurementSystem.TabStop = false;
            this.grpMeasurementSystem.Text = "Measurement System";
            // 
            // rdoMetric
            // 
            this.rdoMetric.AutoSize = true;
            this.rdoMetric.Location = new System.Drawing.Point(179, 34);
            this.rdoMetric.Name = "rdoMetric";
            this.rdoMetric.Size = new System.Drawing.Size(84, 29);
            this.rdoMetric.TabIndex = 2;
            this.rdoMetric.TabStop = true;
            this.rdoMetric.Text = "&Metric";
            this.rdoMetric.UseVisualStyleBackColor = true;
            this.rdoMetric.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // rdoImperial
            // 
            this.rdoImperial.AutoSize = true;
            this.rdoImperial.Checked = true;
            this.rdoImperial.Location = new System.Drawing.Point(8, 34);
            this.rdoImperial.Name = "rdoImperial";
            this.rdoImperial.Size = new System.Drawing.Size(99, 29);
            this.rdoImperial.TabIndex = 1;
            this.rdoImperial.TabStop = true;
            this.rdoImperial.Text = "&Imperial";
            this.rdoImperial.UseVisualStyleBackColor = true;
            this.rdoImperial.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 468);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 50);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(138, 468);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 50);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(231, 468);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 50);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpMeasurements
            // 
            this.grpMeasurements.Controls.Add(this.lblWeightUnit);
            this.grpMeasurements.Controls.Add(this.lblHeightUnit);
            this.grpMeasurements.Controls.Add(this.txtWeight);
            this.grpMeasurements.Controls.Add(this.txtHeight);
            this.grpMeasurements.Controls.Add(this.lblWeight);
            this.grpMeasurements.Controls.Add(this.lblHeight);
            this.grpMeasurements.Location = new System.Drawing.Point(12, 101);
            this.grpMeasurements.Name = "grpMeasurements";
            this.grpMeasurements.Size = new System.Drawing.Size(302, 142);
            this.grpMeasurements.TabIndex = 3;
            this.grpMeasurements.TabStop = false;
            this.grpMeasurements.Text = "Measurements";
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.Location = new System.Drawing.Point(238, 74);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(41, 33);
            this.lblWeightUnit.TabIndex = 9;
            this.lblWeightUnit.Text = "lbs";
            this.lblWeightUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeightUnit
            // 
            this.lblHeightUnit.Location = new System.Drawing.Point(238, 37);
            this.lblHeightUnit.Name = "lblHeightUnit";
            this.lblHeightUnit.Size = new System.Drawing.Size(41, 33);
            this.lblHeightUnit.TabIndex = 6;
            this.lblHeightUnit.Text = "in";
            this.lblHeightUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(105, 78);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(127, 33);
            this.txtWeight.TabIndex = 8;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(105, 38);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(127, 33);
            this.txtHeight.TabIndex = 5;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(23, 78);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(76, 25);
            this.lblWeight.TabIndex = 7;
            this.lblWeight.Text = "&Weight:";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(27, 41);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(72, 25);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "&Height:";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblResult);
            this.grpResults.Location = new System.Drawing.Point(10, 249);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(304, 213);
            this.grpResults.TabIndex = 10;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(12, 29);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(275, 170);
            this.lblResult.TabIndex = 11;
            // 
            // frmBMICalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(326, 530);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpMeasurements);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpMeasurementSystem);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmBMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.grpMeasurementSystem.ResumeLayout(false);
            this.grpMeasurementSystem.PerformLayout();
            this.grpMeasurements.ResumeLayout(false);
            this.grpMeasurements.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpMeasurementSystem;
        private RadioButton rdoMetric;
        private RadioButton rdoImperial;
        private Button btnCalculate;
        private Button btnReset;
        private Button btnExit;
        private GroupBox grpMeasurements;
        private TextBox txtHeight;
        private Label lblWeight;
        private Label lblHeight;
        private TextBox txtWeight;
        private Label lblHeightUnit;
        private Label lblWeightUnit;
        private GroupBox grpResults;
        private Label lblResult;
    }
}