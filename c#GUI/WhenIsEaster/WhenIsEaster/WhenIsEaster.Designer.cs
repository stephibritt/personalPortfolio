namespace WhenIsEaster {
    partial class frmWhenIsEaster {
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
            this.lblBorder = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblEaster = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblEasterOutput = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBorder
            // 
            this.lblBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBorder.Location = new System.Drawing.Point(14, 9);
            this.lblBorder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(446, 109);
            this.lblBorder.TabIndex = 0;
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(45, 29);
            this.lblYear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 33);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "&Year:";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEaster
            // 
            this.lblEaster.Location = new System.Drawing.Point(30, 71);
            this.lblEaster.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEaster.Name = "lblEaster";
            this.lblEaster.Size = new System.Drawing.Size(67, 33);
            this.lblEaster.TabIndex = 2;
            this.lblEaster.Text = "Easter:";
            this.lblEaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(14, 123);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 75);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(314, 123);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 75);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(105, 30);
            this.txtYear.Margin = new System.Windows.Forms.Padding(5);
            this.txtYear.Name = "txtYear";
            this.txtYear.PlaceholderText = "Enter a year";
            this.txtYear.Size = new System.Drawing.Size(346, 33);
            this.txtYear.TabIndex = 1;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // lblEasterOutput
            // 
            this.lblEasterOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEasterOutput.Location = new System.Drawing.Point(105, 71);
            this.lblEasterOutput.Name = "lblEasterOutput";
            this.lblEasterOutput.Size = new System.Drawing.Size(346, 33);
            this.lblEasterOutput.TabIndex = 7;
            this.lblEasterOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(177, 123);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 75);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmWhenIsEaster
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(474, 212);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblEasterOutput);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblEaster);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblBorder);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmWhenIsEaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "When is Easter?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBorder;
        private Label lblYear;
        private Label lblEaster;
        private Button btnCalculate;
        private Button btnExit;
        private TextBox txtYear;
        private Label lblEasterOutput;
        private Button btnReset;
    }
}