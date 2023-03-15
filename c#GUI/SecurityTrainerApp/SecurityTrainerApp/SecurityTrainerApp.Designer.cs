namespace SecurityTrainerApp {
    partial class frmSecurityTrainerApp {
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
            this.lblFailureMessage = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.nudFourthDigit = new System.Windows.Forms.NumericUpDown();
            this.nudSecondDigit = new System.Windows.Forms.NumericUpDown();
            this.nudThirdDigit = new System.Windows.Forms.NumericUpDown();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.nudFirstDigit = new System.Windows.Forms.NumericUpDown();
            this.nudFifthDigit = new System.Windows.Forms.NumericUpDown();
            this.pgbFakeFileDeletion = new System.Windows.Forms.ProgressBar();
            this.lblFakeFileNames = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFourthDigit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondDigit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThirdDigit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstDigit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFifthDigit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFailureMessage
            // 
            this.lblFailureMessage.BackColor = System.Drawing.SystemColors.Window;
            this.lblFailureMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFailureMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFailureMessage.Location = new System.Drawing.Point(0, 356);
            this.lblFailureMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFailureMessage.Name = "lblFailureMessage";
            this.lblFailureMessage.Size = new System.Drawing.Size(867, 46);
            this.lblFailureMessage.TabIndex = 9;
            this.lblFailureMessage.Text = "Fail case message here";
            this.lblFailureMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVerify.BackColor = System.Drawing.SystemColors.Window;
            this.btnVerify.Location = new System.Drawing.Point(406, 236);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(96, 49);
            this.btnVerify.TabIndex = 6;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // nudFourthDigit
            // 
            this.nudFourthDigit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nudFourthDigit.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudFourthDigit.Location = new System.Drawing.Point(614, 130);
            this.nudFourthDigit.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudFourthDigit.Name = "nudFourthDigit";
            this.nudFourthDigit.Size = new System.Drawing.Size(65, 65);
            this.nudFourthDigit.TabIndex = 4;
            // 
            // nudSecondDigit
            // 
            this.nudSecondDigit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nudSecondDigit.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudSecondDigit.Location = new System.Drawing.Point(240, 130);
            this.nudSecondDigit.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudSecondDigit.Name = "nudSecondDigit";
            this.nudSecondDigit.Size = new System.Drawing.Size(65, 65);
            this.nudSecondDigit.TabIndex = 2;
            // 
            // nudThirdDigit
            // 
            this.nudThirdDigit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nudThirdDigit.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudThirdDigit.Location = new System.Drawing.Point(424, 130);
            this.nudThirdDigit.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudThirdDigit.Name = "nudThirdDigit";
            this.nudThirdDigit.Size = new System.Drawing.Size(65, 65);
            this.nudThirdDigit.TabIndex = 3;
            // 
            // lblInstructions
            // 
            this.lblInstructions.BackColor = System.Drawing.SystemColors.Window;
            this.lblInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstructions.Location = new System.Drawing.Point(0, 0);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(867, 30);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Input the passcode that was provided to you by your computer admin to verify your" +
    " identity.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudFirstDigit
            // 
            this.nudFirstDigit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nudFirstDigit.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudFirstDigit.Location = new System.Drawing.Point(47, 130);
            this.nudFirstDigit.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudFirstDigit.Name = "nudFirstDigit";
            this.nudFirstDigit.Size = new System.Drawing.Size(65, 65);
            this.nudFirstDigit.TabIndex = 1;
            // 
            // nudFifthDigit
            // 
            this.nudFifthDigit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nudFifthDigit.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudFifthDigit.Location = new System.Drawing.Point(766, 130);
            this.nudFifthDigit.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudFifthDigit.Name = "nudFifthDigit";
            this.nudFifthDigit.Size = new System.Drawing.Size(65, 65);
            this.nudFifthDigit.TabIndex = 5;
            // 
            // pgbFakeFileDeletion
            // 
            this.pgbFakeFileDeletion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgbFakeFileDeletion.Location = new System.Drawing.Point(0, 333);
            this.pgbFakeFileDeletion.Name = "pgbFakeFileDeletion";
            this.pgbFakeFileDeletion.Size = new System.Drawing.Size(867, 23);
            this.pgbFakeFileDeletion.TabIndex = 8;
            // 
            // lblFakeFileNames
            // 
            this.lblFakeFileNames.AutoSize = true;
            this.lblFakeFileNames.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFakeFileNames.Location = new System.Drawing.Point(0, 312);
            this.lblFakeFileNames.Name = "lblFakeFileNames";
            this.lblFakeFileNames.Size = new System.Drawing.Size(151, 21);
            this.lblFakeFileNames.TabIndex = 7;
            this.lblFakeFileNames.Text = "Fake file names here";
            // 
            // frmSecurityTrainerApp
            // 
            this.AcceptButton = this.btnVerify;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(867, 402);
            this.Controls.Add(this.lblFakeFileNames);
            this.Controls.Add(this.pgbFakeFileDeletion);
            this.Controls.Add(this.nudFifthDigit);
            this.Controls.Add(this.lblFailureMessage);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.nudFourthDigit);
            this.Controls.Add(this.nudSecondDigit);
            this.Controls.Add(this.nudThirdDigit);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.nudFirstDigit);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSecurityTrainerApp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Trainer App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudFourthDigit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondDigit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThirdDigit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstDigit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFifthDigit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFailureMessage;
        private Button btnVerify;
        private NumericUpDown nudFourthDigit;
        private NumericUpDown nudSecondDigit;
        private NumericUpDown nudThirdDigit;
        private Label lblInstructions;
        private NumericUpDown nudFirstDigit;
        private NumericUpDown nudFifthDigit;
        private ProgressBar pgbFakeFileDeletion;
        private Label lblFakeFileNames;
    }
}