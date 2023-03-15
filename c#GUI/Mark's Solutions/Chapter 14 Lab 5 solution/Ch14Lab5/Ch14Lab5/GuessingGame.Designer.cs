
namespace Ch14Lab5 {
    partial class frmGuessingGame {
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSep = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.stbMain = new System.Windows.Forms.StatusStrip();
            this.sblHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblIncorrectGuesses = new System.Windows.Forms.Label();
            this.lblIncorrectGuessesValue = new System.Windows.Forms.Label();
            this.lblNumbersRemaining = new System.Windows.Forms.Label();
            this.lblNumbersRemainingValue = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.stbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(428, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNewGame,
            this.mnuFileSep,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNewGame
            // 
            this.mnuFileNewGame.Name = "mnuFileNewGame";
            this.mnuFileNewGame.Size = new System.Drawing.Size(180, 22);
            this.mnuFileNewGame.Text = "&New Game";
            this.mnuFileNewGame.Click += new System.EventHandler(this.fileMenu_Click);
            // 
            // mnuFileSep
            // 
            this.mnuFileSep.Name = "mnuFileSep";
            this.mnuFileSep.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.fileMenu_Click);
            // 
            // stbMain
            // 
            this.stbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sblHint});
            this.stbMain.Location = new System.Drawing.Point(0, 400);
            this.stbMain.Name = "stbMain";
            this.stbMain.Size = new System.Drawing.Size(428, 22);
            this.stbMain.SizingGrip = false;
            this.stbMain.TabIndex = 1;
            // 
            // sblHint
            // 
            this.sblHint.Name = "sblHint";
            this.sblHint.Size = new System.Drawing.Size(413, 17);
            this.sblHint.Spring = true;
            this.sblHint.Text = "Click a number to guess that number!";
            this.sblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstNumbers
            // 
            this.lstNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstNumbers.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 29;
            this.lstNumbers.Location = new System.Drawing.Point(12, 57);
            this.lstNumbers.MultiColumn = true;
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(404, 294);
            this.lstNumbers.TabIndex = 2;
            this.lstNumbers.TabStop = false;
            this.lstNumbers.Click += new System.EventHandler(this.lstNumbers_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Location = new System.Drawing.Point(12, 34);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(404, 20);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Guess a number between 1 and 100!";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIncorrectGuesses
            // 
            this.lblIncorrectGuesses.AutoSize = true;
            this.lblIncorrectGuesses.Location = new System.Drawing.Point(8, 364);
            this.lblIncorrectGuesses.Name = "lblIncorrectGuesses";
            this.lblIncorrectGuesses.Size = new System.Drawing.Size(129, 19);
            this.lblIncorrectGuesses.TabIndex = 4;
            this.lblIncorrectGuesses.Text = "Incorrect Guesses:";
            // 
            // lblIncorrectGuessesValue
            // 
            this.lblIncorrectGuessesValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIncorrectGuessesValue.Location = new System.Drawing.Point(143, 358);
            this.lblIncorrectGuessesValue.Name = "lblIncorrectGuessesValue";
            this.lblIncorrectGuessesValue.Size = new System.Drawing.Size(36, 30);
            this.lblIncorrectGuessesValue.TabIndex = 6;
            this.lblIncorrectGuessesValue.Text = "0";
            this.lblIncorrectGuessesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumbersRemaining
            // 
            this.lblNumbersRemaining.AutoSize = true;
            this.lblNumbersRemaining.Location = new System.Drawing.Point(230, 364);
            this.lblNumbersRemaining.Name = "lblNumbersRemaining";
            this.lblNumbersRemaining.Size = new System.Drawing.Size(144, 19);
            this.lblNumbersRemaining.TabIndex = 7;
            this.lblNumbersRemaining.Text = "Numbers Remaining:";
            // 
            // lblNumbersRemainingValue
            // 
            this.lblNumbersRemainingValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumbersRemainingValue.Location = new System.Drawing.Point(380, 358);
            this.lblNumbersRemainingValue.Name = "lblNumbersRemainingValue";
            this.lblNumbersRemainingValue.Size = new System.Drawing.Size(36, 30);
            this.lblNumbersRemainingValue.TabIndex = 8;
            this.lblNumbersRemainingValue.Text = "100";
            this.lblNumbersRemainingValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 422);
            this.Controls.Add(this.lblNumbersRemainingValue);
            this.Controls.Add(this.lblNumbersRemaining);
            this.Controls.Add(this.lblIncorrectGuessesValue);
            this.Controls.Add(this.lblIncorrectGuesses);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.stbMain);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmGuessingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.frmGuessingGame_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.stbMain.ResumeLayout(false);
            this.stbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNewGame;
        private System.Windows.Forms.ToolStripSeparator mnuFileSep;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.StatusStrip stbMain;
        private System.Windows.Forms.ToolStripStatusLabel sblHint;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblIncorrectGuesses;
        private System.Windows.Forms.Label lblIncorrectGuessesValue;
        private System.Windows.Forms.Label lblNumbersRemaining;
        private System.Windows.Forms.Label lblNumbersRemainingValue;
    }
}

