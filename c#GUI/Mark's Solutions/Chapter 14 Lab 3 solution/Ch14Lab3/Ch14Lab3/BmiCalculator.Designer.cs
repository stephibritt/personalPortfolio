
namespace Ch14Lab3 {
    partial class frmBmiCalculator {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grpMeasurementSystem = new System.Windows.Forms.GroupBox();
            this.rdoMetric = new System.Windows.Forms.RadioButton();
            this.rdoImperial = new System.Windows.Forms.RadioButton();
            this.grpMeasurements = new System.Windows.Forms.GroupBox();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblHeightUnit = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpMeasurementSystem.SuspendLayout();
            this.grpMeasurements.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMeasurementSystem
            // 
            this.grpMeasurementSystem.Controls.Add(this.rdoMetric);
            this.grpMeasurementSystem.Controls.Add(this.rdoImperial);
            this.grpMeasurementSystem.Location = new System.Drawing.Point(12, 12);
            this.grpMeasurementSystem.Name = "grpMeasurementSystem";
            this.grpMeasurementSystem.Size = new System.Drawing.Size(224, 69);
            this.grpMeasurementSystem.TabIndex = 0;
            this.grpMeasurementSystem.TabStop = false;
            this.grpMeasurementSystem.Text = "Measurement System";
            // 
            // rdoMetric
            // 
            this.rdoMetric.AutoSize = true;
            this.rdoMetric.Location = new System.Drawing.Point(142, 26);
            this.rdoMetric.Name = "rdoMetric";
            this.rdoMetric.Size = new System.Drawing.Size(69, 23);
            this.rdoMetric.TabIndex = 1;
            this.rdoMetric.Text = "&Metric";
            this.rdoMetric.UseVisualStyleBackColor = true;
            this.rdoMetric.CheckedChanged += new System.EventHandler(this.MeasurementSystem_CheckChanged);
            // 
            // rdoImperial
            // 
            this.rdoImperial.AutoSize = true;
            this.rdoImperial.Checked = true;
            this.rdoImperial.Location = new System.Drawing.Point(15, 26);
            this.rdoImperial.Name = "rdoImperial";
            this.rdoImperial.Size = new System.Drawing.Size(80, 23);
            this.rdoImperial.TabIndex = 0;
            this.rdoImperial.TabStop = true;
            this.rdoImperial.Text = "&Imperial";
            this.rdoImperial.UseVisualStyleBackColor = true;
            this.rdoImperial.CheckedChanged += new System.EventHandler(this.MeasurementSystem_CheckChanged);
            // 
            // grpMeasurements
            // 
            this.grpMeasurements.Controls.Add(this.lblWeightUnit);
            this.grpMeasurements.Controls.Add(this.lblWeight);
            this.grpMeasurements.Controls.Add(this.txtWeight);
            this.grpMeasurements.Controls.Add(this.lblHeightUnit);
            this.grpMeasurements.Controls.Add(this.txtHeight);
            this.grpMeasurements.Controls.Add(this.lblHeight);
            this.grpMeasurements.Location = new System.Drawing.Point(12, 87);
            this.grpMeasurements.Name = "grpMeasurements";
            this.grpMeasurements.Size = new System.Drawing.Size(224, 99);
            this.grpMeasurements.TabIndex = 1;
            this.grpMeasurements.TabStop = false;
            this.grpMeasurements.Text = "Measurements";
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.AutoSize = true;
            this.lblWeightUnit.Location = new System.Drawing.Point(183, 60);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(28, 19);
            this.lblWeightUnit.TabIndex = 5;
            this.lblWeightUnit.Text = "lbs";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 60);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(59, 19);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "&Weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(77, 57);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 27);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.Enter += new System.EventHandler(this.textBoxes_Enter);
            // 
            // lblHeightUnit
            // 
            this.lblHeightUnit.AutoSize = true;
            this.lblHeightUnit.Location = new System.Drawing.Point(183, 27);
            this.lblHeightUnit.Name = "lblHeightUnit";
            this.lblHeightUnit.Size = new System.Drawing.Size(21, 19);
            this.lblHeightUnit.TabIndex = 2;
            this.lblHeightUnit.Text = "in";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(77, 24);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 27);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.Enter += new System.EventHandler(this.textBoxes_Enter);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(15, 27);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(56, 19);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "&Height:";
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblResult);
            this.grpResult.Location = new System.Drawing.Point(12, 192);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(224, 126);
            this.grpResult.TabIndex = 2;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(11, 23);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(200, 88);
            this.lblResult.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(178, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 48);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(114, 324);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(58, 48);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 324);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(96, 48);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmBmiCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(248, 384);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpMeasurements);
            this.Controls.Add(this.grpMeasurementSystem);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmBmiCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.grpMeasurementSystem.ResumeLayout(false);
            this.grpMeasurementSystem.PerformLayout();
            this.grpMeasurements.ResumeLayout(false);
            this.grpMeasurements.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMeasurementSystem;
        private System.Windows.Forms.RadioButton rdoMetric;
        private System.Windows.Forms.RadioButton rdoImperial;
        private System.Windows.Forms.GroupBox grpMeasurements;
        private System.Windows.Forms.Label lblWeightUnit;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblHeightUnit;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
    }
}

