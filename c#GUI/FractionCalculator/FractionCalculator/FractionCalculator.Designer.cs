//namespace FractionCalculator {
//    partial class frmFractionCalculator {
//        /// <summary>
//        ///  Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        ///  Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing) {
//            if (disposing && (components != null)) {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        ///  Required method for Designer support - do not modify
//        ///  the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent() {
//            this.SuspendLayout();
//            // 
//            // frmFractionCalculator
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Name = "frmFractionCalculator";
//            this.Text = "Fraction Calculator";
//            this.Load += new System.EventHandler(this.Form1_Load);
//            this.ResumeLayout(false);

//        }

//        #endregion
//    }
//}

namespace FractionCalculator {
    partial class frmFractionCalculator {
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
            this.stbMain = new System.Windows.Forms.StatusStrip();
            this.stblMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEqualsSign = new System.Windows.Forms.Label();
            this.lblThickBorder1 = new System.Windows.Forms.Label();
            this.txtLeftNumerator = new System.Windows.Forms.TextBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.txtLeftDenominator = new System.Windows.Forms.TextBox();
            this.txtRightDenominator = new System.Windows.Forms.TextBox();
            this.txtRightNumerator = new System.Windows.Forms.TextBox();
            this.lblThickBorder2 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblSep = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.stbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stbMain
            // 
            this.stbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stblMain});
            this.stbMain.Location = new System.Drawing.Point(0, 202);
            this.stbMain.Name = "stbMain";
            this.stbMain.Size = new System.Drawing.Size(546, 22);
            this.stbMain.TabIndex = 12;
            // 
            // stblMain
            // 
            this.stblMain.Name = "stblMain";
            this.stblMain.Size = new System.Drawing.Size(531, 17);
            this.stblMain.Spring = true;
            this.stblMain.Text = "Calculate a fraction.";
            this.stblMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEqualsSign
            // 
            this.lblEqualsSign.AutoSize = true;
            this.lblEqualsSign.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEqualsSign.Location = new System.Drawing.Point(279, 50);
            this.lblEqualsSign.Name = "lblEqualsSign";
            this.lblEqualsSign.Size = new System.Drawing.Size(43, 45);
            this.lblEqualsSign.TabIndex = 7;
            this.lblEqualsSign.Text = "=";
            this.lblEqualsSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThickBorder1
            // 
            this.lblThickBorder1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblThickBorder1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThickBorder1.Location = new System.Drawing.Point(12, 65);
            this.lblThickBorder1.Name = "lblThickBorder1";
            this.lblThickBorder1.Size = new System.Drawing.Size(90, 4);
            this.lblThickBorder1.TabIndex = 1;
            // 
            // txtLeftNumerator
            // 
            this.txtLeftNumerator.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLeftNumerator.Location = new System.Drawing.Point(22, 12);
            this.txtLeftNumerator.Name = "txtLeftNumerator";
            this.txtLeftNumerator.Size = new System.Drawing.Size(70, 43);
            this.txtLeftNumerator.TabIndex = 0;
            this.txtLeftNumerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLeftNumerator.Click += new System.EventHandler(this.textBoxes_Click);
            this.txtLeftNumerator.Enter += new System.EventHandler(this.frmFractionCalculator_Load);
            // 
            // cboOperator
            // 
            this.cboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperator.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Location = new System.Drawing.Point(108, 42);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(57, 53);
            this.cboOperator.TabIndex = 3;
            // 
            // txtLeftDenominator
            // 
            this.txtLeftDenominator.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLeftDenominator.Location = new System.Drawing.Point(22, 83);
            this.txtLeftDenominator.Name = "txtLeftDenominator";
            this.txtLeftDenominator.Size = new System.Drawing.Size(70, 43);
            this.txtLeftDenominator.TabIndex = 2;
            this.txtLeftDenominator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLeftDenominator.Click += new System.EventHandler(this.textBoxes_Click);
            this.txtLeftDenominator.Enter += new System.EventHandler(this.frmFractionCalculator_Load);
            // 
            // txtRightDenominator
            // 
            this.txtRightDenominator.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRightDenominator.Location = new System.Drawing.Point(188, 83);
            this.txtRightDenominator.Name = "txtRightDenominator";
            this.txtRightDenominator.Size = new System.Drawing.Size(70, 43);
            this.txtRightDenominator.TabIndex = 6;
            this.txtRightDenominator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRightDenominator.Click += new System.EventHandler(this.textBoxes_Click);
            this.txtRightDenominator.Enter += new System.EventHandler(this.frmFractionCalculator_Load);
            // 
            // txtRightNumerator
            // 
            this.txtRightNumerator.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRightNumerator.Location = new System.Drawing.Point(188, 12);
            this.txtRightNumerator.Name = "txtRightNumerator";
            this.txtRightNumerator.Size = new System.Drawing.Size(70, 43);
            this.txtRightNumerator.TabIndex = 4;
            this.txtRightNumerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRightNumerator.Click += new System.EventHandler(this.textBoxes_Click);
            this.txtRightNumerator.Enter += new System.EventHandler(this.frmFractionCalculator_Load);
            // 
            // lblThickBorder2
            // 
            this.lblThickBorder2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblThickBorder2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThickBorder2.Location = new System.Drawing.Point(178, 65);
            this.lblThickBorder2.Name = "lblThickBorder2";
            this.lblThickBorder2.Size = new System.Drawing.Size(90, 4);
            this.lblThickBorder2.TabIndex = 5;
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Location = new System.Drawing.Point(328, 12);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(206, 114);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSep
            // 
            this.lblSep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSep.Location = new System.Drawing.Point(12, 142);
            this.lblSep.Name = "lblSep";
            this.lblSep.Size = new System.Drawing.Size(522, 2);
            this.lblSep.TabIndex = 9;
            this.lblSep.Text = "label3";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(279, 147);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(145, 51);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(435, 147);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 51);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmFractionCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 224);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSep);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtRightDenominator);
            this.Controls.Add(this.txtRightNumerator);
            this.Controls.Add(this.lblThickBorder2);
            this.Controls.Add(this.txtLeftDenominator);
            this.Controls.Add(this.cboOperator);
            this.Controls.Add(this.txtLeftNumerator);
            this.Controls.Add(this.lblThickBorder1);
            this.Controls.Add(this.lblEqualsSign);
            this.Controls.Add(this.stbMain);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmFractionCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fraction Calculator";
            this.Load += new System.EventHandler(this.frmFractionCalculator_Load);
            this.Enter += new System.EventHandler(this.textBoxes_Enter);
            this.stbMain.ResumeLayout(false);
            this.stbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip stbMain;
        private ToolStripStatusLabel stblMain;
        private Label lblEqualsSign;
        private Label lblThickBorder1;
        private TextBox txtLeftNumerator;
        private ComboBox cboOperator;
        private TextBox txtLeftDenominator;
        private TextBox txtRightDenominator;
        private TextBox txtRightNumerator;
        private Label lblThickBorder2;
        private Label lblOutput;
        private Label lblSep;
        private Button btnCalculate;
        private Button btnClear;
    }
}