
namespace Ch14Lab2 {
    partial class frmCoinFlipSim {
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
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.picHeads = new System.Windows.Forms.PictureBox();
            this.picTails = new System.Windows.Forms.PictureBox();
            this.lblHeads = new System.Windows.Forms.Label();
            this.lblTails = new System.Windows.Forms.Label();
            this.nudFlips = new System.Windows.Forms.NumericUpDown();
            this.btnFlip = new System.Windows.Forms.Button();
            this.grpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlips)).BeginInit();
            this.SuspendLayout();
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblTails);
            this.grpResults.Controls.Add(this.lblHeads);
            this.grpResults.Controls.Add(this.picTails);
            this.grpResults.Controls.Add(this.picHeads);
            this.grpResults.Location = new System.Drawing.Point(12, 12);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(300, 210);
            this.grpResults.TabIndex = 0;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // picHeads
            // 
            this.picHeads.Image = global::Ch14Lab2.Properties.Resources.heads;
            this.picHeads.Location = new System.Drawing.Point(30, 35);
            this.picHeads.Name = "picHeads";
            this.picHeads.Size = new System.Drawing.Size(100, 100);
            this.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeads.TabIndex = 0;
            this.picHeads.TabStop = false;
            // 
            // picTails
            // 
            this.picTails.Image = global::Ch14Lab2.Properties.Resources.tails;
            this.picTails.Location = new System.Drawing.Point(170, 35);
            this.picTails.Name = "picTails";
            this.picTails.Size = new System.Drawing.Size(100, 100);
            this.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTails.TabIndex = 1;
            this.picTails.TabStop = false;
            // 
            // lblHeads
            // 
            this.lblHeads.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeads.Location = new System.Drawing.Point(30, 138);
            this.lblHeads.Name = "lblHeads";
            this.lblHeads.Size = new System.Drawing.Size(100, 44);
            this.lblHeads.TabIndex = 2;
            this.lblHeads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTails
            // 
            this.lblTails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTails.Location = new System.Drawing.Point(170, 138);
            this.lblTails.Name = "lblTails";
            this.lblTails.Size = new System.Drawing.Size(100, 44);
            this.lblTails.TabIndex = 3;
            this.lblTails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudFlips
            // 
            this.nudFlips.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFlips.Location = new System.Drawing.Point(213, 228);
            this.nudFlips.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudFlips.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFlips.Name = "nudFlips";
            this.nudFlips.Size = new System.Drawing.Size(99, 53);
            this.nudFlips.TabIndex = 1;
            this.nudFlips.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnFlip
            // 
            this.btnFlip.Location = new System.Drawing.Point(12, 227);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(195, 54);
            this.btnFlip.TabIndex = 2;
            this.btnFlip.Text = "&Flip";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // frmCoinFlipSim
            // 
            this.AcceptButton = this.btnFlip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 294);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.nudFlips);
            this.Controls.Add(this.grpResults);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmCoinFlipSim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coin Flip Simulator";
            this.grpResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlips)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.PictureBox picHeads;
        private System.Windows.Forms.Label lblTails;
        private System.Windows.Forms.Label lblHeads;
        private System.Windows.Forms.PictureBox picTails;
        private System.Windows.Forms.NumericUpDown nudFlips;
        private System.Windows.Forms.Button btnFlip;
    }
}

