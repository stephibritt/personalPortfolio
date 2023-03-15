namespace CoinFlipSimulator {
    partial class frmCoinFlipSimulator {
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
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblResultTails = new System.Windows.Forms.Label();
            this.lblResultHeads = new System.Windows.Forms.Label();
            this.picTails = new System.Windows.Forms.PictureBox();
            this.picHeads = new System.Windows.Forms.PictureBox();
            this.btnFlip = new System.Windows.Forms.Button();
            this.nudFlips = new System.Windows.Forms.NumericUpDown();
            this.grpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlips)).BeginInit();
            this.SuspendLayout();
            // 
            // grpResults
            // 
            this.grpResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResults.Controls.Add(this.lblResultTails);
            this.grpResults.Controls.Add(this.lblResultHeads);
            this.grpResults.Controls.Add(this.picTails);
            this.grpResults.Controls.Add(this.picHeads);
            this.grpResults.Location = new System.Drawing.Point(12, 12);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(372, 264);
            this.grpResults.TabIndex = 0;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // lblResultTails
            // 
            this.lblResultTails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultTails.Location = new System.Drawing.Point(206, 185);
            this.lblResultTails.Name = "lblResultTails";
            this.lblResultTails.Size = new System.Drawing.Size(150, 60);
            this.lblResultTails.TabIndex = 3;
            this.lblResultTails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultHeads
            // 
            this.lblResultHeads.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultHeads.Location = new System.Drawing.Point(25, 185);
            this.lblResultHeads.Name = "lblResultHeads";
            this.lblResultHeads.Size = new System.Drawing.Size(150, 60);
            this.lblResultHeads.TabIndex = 2;
            this.lblResultHeads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picTails
            // 
            this.picTails.Image = global::CoinFlipSimulator.Properties.Resources.tails;
            this.picTails.Location = new System.Drawing.Point(206, 32);
            this.picTails.Name = "picTails";
            this.picTails.Size = new System.Drawing.Size(150, 150);
            this.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTails.TabIndex = 1;
            this.picTails.TabStop = false;
            // 
            // picHeads
            // 
            this.picHeads.Image = global::CoinFlipSimulator.Properties.Resources.heads;
            this.picHeads.Location = new System.Drawing.Point(25, 32);
            this.picHeads.Name = "picHeads";
            this.picHeads.Size = new System.Drawing.Size(150, 150);
            this.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeads.TabIndex = 0;
            this.picHeads.TabStop = false;
            // 
            // btnFlip
            // 
            this.btnFlip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFlip.Location = new System.Drawing.Point(12, 289);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(255, 46);
            this.btnFlip.TabIndex = 1;
            this.btnFlip.Text = "&Flip";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // nudFlips
            // 
            this.nudFlips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFlips.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudFlips.Location = new System.Drawing.Point(284, 289);
            this.nudFlips.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudFlips.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlips.Name = "nudFlips";
            this.nudFlips.Size = new System.Drawing.Size(100, 46);
            this.nudFlips.TabIndex = 2;
            this.nudFlips.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // frmCoinFlipSimulator
            // 
            this.AcceptButton = this.btnFlip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 347);
            this.Controls.Add(this.nudFlips);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.grpResults);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmCoinFlipSimulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coin Flip Simulator";
            this.grpResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlips)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpResults;
        private Button btnFlip;
        private PictureBox picHeads;
        private NumericUpDown nudFlips;
        private PictureBox picTails;
        private Label lblResultTails;
        private Label lblResultHeads;
    }
}