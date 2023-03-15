namespace GuessingGame {
    partial class frmGuessingGame {
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
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.stbMain = new System.Windows.Forms.StatusStrip();
            this.stblMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGuessCount = new System.Windows.Forms.Label();
            this.lblIncorrectGuesses = new System.Windows.Forms.Label();
            this.lblNumbersRemaining = new System.Windows.Forms.Label();
            this.lblNumTotal = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.stbMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.ColumnWidth = 38;
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 25;
            this.lstNumbers.Location = new System.Drawing.Point(15, 59);
            this.lstNumbers.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lstNumbers.MultiColumn = true;
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(390, 254);
            this.lstNumbers.TabIndex = 1;
            this.lstNumbers.Click += new System.EventHandler(this.lstNumbers_Click);
            // 
            // stbMain
            // 
            this.stbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stblMain});
            this.stbMain.Location = new System.Drawing.Point(0, 361);
            this.stbMain.Name = "stbMain";
            this.stbMain.Padding = new System.Windows.Forms.Padding(1, 0, 22, 0);
            this.stbMain.Size = new System.Drawing.Size(421, 25);
            this.stbMain.SizingGrip = false;
            this.stbMain.TabIndex = 1;
            this.stbMain.Text = "statusStrip1";
            // 
            // stblMain
            // 
            this.stblMain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stblMain.Name = "stblMain";
            this.stblMain.Size = new System.Drawing.Size(398, 20);
            this.stblMain.Spring = true;
            this.stblMain.Text = "Click a number to begin guessing!";
            this.stblMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(421, 29);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.toolStripMenuItem1,
            this.mnuFileExit});
            this.mnuFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 25);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(112, 26);
            this.mnuFileNew.Text = "&New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(112, 26);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // lblGuessCount
            // 
            this.lblGuessCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGuessCount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGuessCount.Location = new System.Drawing.Point(148, 318);
            this.lblGuessCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuessCount.Name = "lblGuessCount";
            this.lblGuessCount.Size = new System.Drawing.Size(48, 33);
            this.lblGuessCount.TabIndex = 3;
            this.lblGuessCount.Text = "0";
            this.lblGuessCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIncorrectGuesses
            // 
            this.lblIncorrectGuesses.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncorrectGuesses.Location = new System.Drawing.Point(15, 318);
            this.lblIncorrectGuesses.Name = "lblIncorrectGuesses";
            this.lblIncorrectGuesses.Size = new System.Drawing.Size(126, 33);
            this.lblIncorrectGuesses.TabIndex = 2;
            this.lblIncorrectGuesses.Text = "Incorrect Guesses:";
            this.lblIncorrectGuesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumbersRemaining
            // 
            this.lblNumbersRemaining.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumbersRemaining.Location = new System.Drawing.Point(203, 318);
            this.lblNumbersRemaining.Name = "lblNumbersRemaining";
            this.lblNumbersRemaining.Size = new System.Drawing.Size(148, 33);
            this.lblNumbersRemaining.TabIndex = 4;
            this.lblNumbersRemaining.Text = "Numbers Remaining:";
            this.lblNumbersRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumTotal
            // 
            this.lblNumTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumTotal.Location = new System.Drawing.Point(358, 318);
            this.lblNumTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumTotal.Name = "lblNumTotal";
            this.lblNumTotal.Size = new System.Drawing.Size(48, 33);
            this.lblNumTotal.TabIndex = 5;
            this.lblNumTotal.Text = "100";
            this.lblNumTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(59, 29);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(312, 25);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Guess a number between 1 and 100";
            // 
            // frmGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 386);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblNumbersRemaining);
            this.Controls.Add(this.lblNumTotal);
            this.Controls.Add(this.lblIncorrectGuesses);
            this.Controls.Add(this.lblGuessCount);
            this.Controls.Add(this.stbMain);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.lstNumbers);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmGuessingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.frmGuessingGame_Load);
            this.stbMain.ResumeLayout(false);
            this.stbMain.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstNumbers;
        private StatusStrip stbMain;
        private ToolStripStatusLabel stblMain;
        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileNew;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuFileExit;
        private Label lblGuessCount;
        private Label lblIncorrectGuesses;
        private Label lblNumbersRemaining;
        private Label lblNumTotal;
        private Label lblInstructions;
    }
}