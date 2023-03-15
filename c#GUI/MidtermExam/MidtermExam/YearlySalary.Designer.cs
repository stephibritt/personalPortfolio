namespace MidtermExam {
    partial class Form1 {
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
            this.lblHourlyPay = new System.Windows.Forms.Label();
            this.txtHourlyPay = new System.Windows.Forms.TextBox();
            this.lblYearlyIncrease = new System.Windows.Forms.Label();
            this.txtYearlyIncrease = new System.Windows.Forms.TextBox();
            this.lblYearsToProject = new System.Windows.Forms.Label();
            this.nudYearsToProject = new System.Windows.Forms.NumericUpDown();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Lablel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearsToProject)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHourlyPay
            // 
            this.lblHourlyPay.AutoSize = true;
            this.lblHourlyPay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHourlyPay.Location = new System.Drawing.Point(56, 15);
            this.lblHourlyPay.Name = "lblHourlyPay";
            this.lblHourlyPay.Size = new System.Drawing.Size(107, 25);
            this.lblHourlyPay.TabIndex = 0;
            this.lblHourlyPay.Text = "&Hourly pay:";
            // 
            // txtHourlyPay
            // 
            this.txtHourlyPay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHourlyPay.Location = new System.Drawing.Point(169, 12);
            this.txtHourlyPay.Name = "txtHourlyPay";
            this.txtHourlyPay.Size = new System.Drawing.Size(250, 33);
            this.txtHourlyPay.TabIndex = 1;
            // 
            // lblYearlyIncrease
            // 
            this.lblYearlyIncrease.AutoSize = true;
            this.lblYearlyIncrease.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYearlyIncrease.Location = new System.Drawing.Point(22, 54);
            this.lblYearlyIncrease.Name = "lblYearlyIncrease";
            this.lblYearlyIncrease.Size = new System.Drawing.Size(141, 25);
            this.lblYearlyIncrease.TabIndex = 2;
            this.lblYearlyIncrease.Text = "Yearly &increase:";
            // 
            // txtYearlyIncrease
            // 
            this.txtYearlyIncrease.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYearlyIncrease.Location = new System.Drawing.Point(169, 51);
            this.txtYearlyIncrease.Name = "txtYearlyIncrease";
            this.txtYearlyIncrease.Size = new System.Drawing.Size(104, 33);
            this.txtYearlyIncrease.TabIndex = 3;
            this.txtYearlyIncrease.Text = "0";
            // 
            // lblYearsToProject
            // 
            this.lblYearsToProject.AutoSize = true;
            this.lblYearsToProject.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYearsToProject.Location = new System.Drawing.Point(15, 94);
            this.lblYearsToProject.Name = "lblYearsToProject";
            this.lblYearsToProject.Size = new System.Drawing.Size(146, 25);
            this.lblYearsToProject.TabIndex = 5;
            this.lblYearsToProject.Text = "Years to &project:";
            // 
            // nudYearsToProject
            // 
            this.nudYearsToProject.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudYearsToProject.Location = new System.Drawing.Point(169, 92);
            this.nudYearsToProject.Margin = new System.Windows.Forms.Padding(5);
            this.nudYearsToProject.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudYearsToProject.Name = "nudYearsToProject";
            this.nudYearsToProject.Size = new System.Drawing.Size(104, 33);
            this.nudYearsToProject.TabIndex = 6;
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblOutput.Location = new System.Drawing.Point(12, 138);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(407, 201);
            this.lblOutput.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(12, 353);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(209, 43);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(227, 353);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 43);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(326, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 43);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lablel3
            // 
            this.Lablel3.AutoSize = true;
            this.Lablel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lablel3.Location = new System.Drawing.Point(279, 54);
            this.Lablel3.Name = "Lablel3";
            this.Lablel3.Size = new System.Drawing.Size(28, 25);
            this.Lablel3.TabIndex = 4;
            this.Lablel3.Text = "%";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(431, 408);
            this.Controls.Add(this.Lablel3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.nudYearsToProject);
            this.Controls.Add(this.lblYearsToProject);
            this.Controls.Add(this.txtYearlyIncrease);
            this.Controls.Add(this.lblYearlyIncrease);
            this.Controls.Add(this.txtHourlyPay);
            this.Controls.Add(this.lblHourlyPay);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yearly Salary Over Time";
            ((System.ComponentModel.ISupportInitialize)(this.nudYearsToProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHourlyPay;
        private TextBox txtHourlyPay;
        private Label lblYearlyIncrease;
        private TextBox txtYearlyIncrease;
        private Label lblYearsToProject;
        private NumericUpDown nudYearsToProject;
        private Label lblOutput;
        private Button btnCalculate;
        private Button btnReset;
        private Button btnExit;
        private Label Lablel3;
    }
}