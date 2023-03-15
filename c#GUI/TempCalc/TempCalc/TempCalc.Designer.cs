namespace TempCalc {
    partial class frmTempCalc {
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
            this.lblFahrenheitTemp = new System.Windows.Forms.Label();
            this.txtFahrenheitTemp = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSep = new System.Windows.Forms.Label();
            this.lblCelsiusTempOutput = new System.Windows.Forms.Label();
            this.lblEquals1 = new System.Windows.Forms.Label();
            this.lblCelsiusMarker = new System.Windows.Forms.Label();
            this.lblFahrenheitMarker = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFahrenheitOutput = new System.Windows.Forms.Label();
            this.txtCelsiusTemp = new System.Windows.Forms.TextBox();
            this.lblCelsiusTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFahrenheitTemp
            // 
            this.lblFahrenheitTemp.Location = new System.Drawing.Point(12, 14);
            this.lblFahrenheitTemp.Name = "lblFahrenheitTemp";
            this.lblFahrenheitTemp.Size = new System.Drawing.Size(216, 30);
            this.lblFahrenheitTemp.TabIndex = 0;
            this.lblFahrenheitTemp.Text = "Fahrenheit Temperature:";
            this.lblFahrenheitTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFahrenheitTemp
            // 
            this.txtFahrenheitTemp.Location = new System.Drawing.Point(234, 11);
            this.txtFahrenheitTemp.Name = "txtFahrenheitTemp";
            this.txtFahrenheitTemp.Size = new System.Drawing.Size(68, 33);
            this.txtFahrenheitTemp.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 141);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 45);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(336, 136);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSep
            // 
            this.lblSep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSep.Location = new System.Drawing.Point(9, 59);
            this.lblSep.Name = "lblSep";
            this.lblSep.Size = new System.Drawing.Size(420, 2);
            this.lblSep.TabIndex = 4;
            // 
            // lblCelsiusTempOutput
            // 
            this.lblCelsiusTempOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCelsiusTempOutput.Location = new System.Drawing.Point(337, 14);
            this.lblCelsiusTempOutput.Name = "lblCelsiusTempOutput";
            this.lblCelsiusTempOutput.Size = new System.Drawing.Size(65, 30);
            this.lblCelsiusTempOutput.TabIndex = 5;
            this.lblCelsiusTempOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEquals1
            // 
            this.lblEquals1.Location = new System.Drawing.Point(308, 11);
            this.lblEquals1.Name = "lblEquals1";
            this.lblEquals1.Size = new System.Drawing.Size(23, 33);
            this.lblEquals1.TabIndex = 6;
            this.lblEquals1.Text = "=";
            this.lblEquals1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCelsiusMarker
            // 
            this.lblCelsiusMarker.Location = new System.Drawing.Point(408, 14);
            this.lblCelsiusMarker.Name = "lblCelsiusMarker";
            this.lblCelsiusMarker.Size = new System.Drawing.Size(31, 30);
            this.lblCelsiusMarker.TabIndex = 7;
            this.lblCelsiusMarker.Text = "C";
            this.lblCelsiusMarker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFahrenheitMarker
            // 
            this.lblFahrenheitMarker.Location = new System.Drawing.Point(408, 83);
            this.lblFahrenheitMarker.Name = "lblFahrenheitMarker";
            this.lblFahrenheitMarker.Size = new System.Drawing.Size(31, 30);
            this.lblFahrenheitMarker.TabIndex = 12;
            this.lblFahrenheitMarker.Text = "F";
            this.lblFahrenheitMarker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(308, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFahrenheitOutput
            // 
            this.lblFahrenheitOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFahrenheitOutput.Location = new System.Drawing.Point(337, 83);
            this.lblFahrenheitOutput.Name = "lblFahrenheitOutput";
            this.lblFahrenheitOutput.Size = new System.Drawing.Size(65, 30);
            this.lblFahrenheitOutput.TabIndex = 10;
            this.lblFahrenheitOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCelsiusTemp
            // 
            this.txtCelsiusTemp.Location = new System.Drawing.Point(234, 80);
            this.txtCelsiusTemp.Name = "txtCelsiusTemp";
            this.txtCelsiusTemp.Size = new System.Drawing.Size(68, 33);
            this.txtCelsiusTemp.TabIndex = 9;
            // 
            // lblCelsiusTemp
            // 
            this.lblCelsiusTemp.Location = new System.Drawing.Point(12, 83);
            this.lblCelsiusTemp.Name = "lblCelsiusTemp";
            this.lblCelsiusTemp.Size = new System.Drawing.Size(216, 30);
            this.lblCelsiusTemp.TabIndex = 8;
            this.lblCelsiusTemp.Text = "Celsius Temperature:";
            this.lblCelsiusTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmTempCalc
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(438, 198);
            this.Controls.Add(this.lblFahrenheitMarker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFahrenheitOutput);
            this.Controls.Add(this.txtCelsiusTemp);
            this.Controls.Add(this.lblCelsiusTemp);
            this.Controls.Add(this.lblCelsiusMarker);
            this.Controls.Add(this.lblEquals1);
            this.Controls.Add(this.lblCelsiusTempOutput);
            this.Controls.Add(this.lblSep);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFahrenheitTemp);
            this.Controls.Add(this.lblFahrenheitTemp);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTempCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TempCalc 3000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFahrenheitTemp;
        private TextBox txtFahrenheitTemp;
        private Button btnCalculate;
        private Button btnExit;
        private Label lblSep;
        private Label lblCelsiusTempOutput;
        private Label lblEquals1;
        private Label lblCelsiusMarker;
        private Label lblFahrenheitMarker;
        private Label label3;
        private Label lblFahrenheitOutput;
        private TextBox txtCelsiusTemp;
        private Label lblCelsiusTemp;
    }
}