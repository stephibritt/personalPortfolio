namespace TargetHeartRate {
    partial class frmTargetHeartRateCalc {
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
            this.dtpMain = new System.Windows.Forms.DateTimePicker();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblHealthWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpMain
            // 
            this.dtpMain.Checked = false;
            this.dtpMain.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMain.Location = new System.Drawing.Point(118, 14);
            this.dtpMain.Margin = new System.Windows.Forms.Padding(5);
            this.dtpMain.Name = "dtpMain";
            this.dtpMain.Size = new System.Drawing.Size(170, 33);
            this.dtpMain.TabIndex = 1;
            this.dtpMain.ValueChanged += new System.EventHandler(this.dtpMain_ValueChanged);
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.Location = new System.Drawing.Point(14, 14);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(94, 33);
            this.lblBirthdate.TabIndex = 0;
            this.lblBirthdate.Text = "&Birthdate:";
            this.lblBirthdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(370, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(156, 33);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(12, 56);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(514, 202);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Enter your birthdate and click the \"Calculate\" button to calculate your taget hea" +
    "rt rate.";
            // 
            // lblHealthWarning
            // 
            this.lblHealthWarning.BackColor = System.Drawing.Color.Red;
            this.lblHealthWarning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHealthWarning.Location = new System.Drawing.Point(14, 268);
            this.lblHealthWarning.Name = "lblHealthWarning";
            this.lblHealthWarning.Size = new System.Drawing.Size(514, 85);
            this.lblHealthWarning.TabIndex = 4;
            this.lblHealthWarning.Text = "Always consult a physician or qualified health professional before beginning or m" +
    "odifying an exercise program.";
            this.lblHealthWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTargetHeartRateCalc
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 365);
            this.Controls.Add(this.lblHealthWarning);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.dtpMain);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmTargetHeartRateCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Target Heart Rate Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dtpMain;
        private Label lblBirthdate;
        private Button btnCalculate;
        private Label lblOutput;
        private Label lblHealthWarning;
    }
}