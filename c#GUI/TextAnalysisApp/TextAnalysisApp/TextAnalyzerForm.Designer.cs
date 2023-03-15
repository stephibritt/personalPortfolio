namespace TextAnalysisApp {
    partial class frmTextAnalyzerForm {
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.grpTextBox = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grpTextStatistics = new System.Windows.Forms.GroupBox();
            this.lblUniqueWords = new System.Windows.Forms.Label();
            this.lblSentenceCount = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblSentences = new System.Windows.Forms.Label();
            this.lblUniqueWordCount = new System.Windows.Forms.Label();
            this.gpbWordStatistics = new System.Windows.Forms.GroupBox();
            this.lsvWords = new System.Windows.Forms.ListView();
            this.cmhCount = new System.Windows.Forms.ColumnHeader();
            this.cmhWord = new System.Windows.Forms.ColumnHeader();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.grpTextBox.SuspendLayout();
            this.grpTextStatistics.SuspendLayout();
            this.gpbWordStatistics.SuspendLayout();
            this.grpFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(739, 78);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 36);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(649, 78);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyze.Enabled = false;
            this.btnAnalyze.Location = new System.Drawing.Point(649, 12);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(172, 58);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "&Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // grpTextBox
            // 
            this.grpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTextBox.Controls.Add(this.txtInput);
            this.grpTextBox.Location = new System.Drawing.Point(12, 77);
            this.grpTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.grpTextBox.Name = "grpTextBox";
            this.grpTextBox.Padding = new System.Windows.Forms.Padding(4);
            this.grpTextBox.Size = new System.Drawing.Size(333, 472);
            this.grpTextBox.TabIndex = 0;
            this.grpTextBox.TabStop = false;
            this.grpTextBox.Text = "Enter text to be analyzed (300,000 remaining)";
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput.Location = new System.Drawing.Point(6, 28);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.MaxLength = 300000;
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(319, 439);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // grpTextStatistics
            // 
            this.grpTextStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTextStatistics.Controls.Add(this.lblUniqueWords);
            this.grpTextStatistics.Controls.Add(this.lblSentenceCount);
            this.grpTextStatistics.Controls.Add(this.lblWords);
            this.grpTextStatistics.Controls.Add(this.lblWordCount);
            this.grpTextStatistics.Controls.Add(this.lblSentences);
            this.grpTextStatistics.Controls.Add(this.lblUniqueWordCount);
            this.grpTextStatistics.Location = new System.Drawing.Point(351, 12);
            this.grpTextStatistics.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpTextStatistics.Name = "grpTextStatistics";
            this.grpTextStatistics.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpTextStatistics.Size = new System.Drawing.Size(292, 102);
            this.grpTextStatistics.TabIndex = 5;
            this.grpTextStatistics.TabStop = false;
            this.grpTextStatistics.Text = "Text Statistics";
            // 
            // lblUniqueWords
            // 
            this.lblUniqueWords.AutoSize = true;
            this.lblUniqueWords.Location = new System.Drawing.Point(23, 74);
            this.lblUniqueWords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUniqueWords.Name = "lblUniqueWords";
            this.lblUniqueWords.Size = new System.Drawing.Size(176, 19);
            this.lblUniqueWords.TabIndex = 4;
            this.lblUniqueWords.Text = "Number of Unique Words:";
            this.lblUniqueWords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSentenceCount
            // 
            this.lblSentenceCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSentenceCount.Location = new System.Drawing.Point(203, 23);
            this.lblSentenceCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSentenceCount.Name = "lblSentenceCount";
            this.lblSentenceCount.Size = new System.Drawing.Size(78, 19);
            this.lblSentenceCount.TabIndex = 1;
            this.lblSentenceCount.Text = "0";
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(37, 49);
            this.lblWords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(162, 19);
            this.lblWords.TabIndex = 2;
            this.lblWords.Text = "Total Number of Words:";
            this.lblWords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWordCount
            // 
            this.lblWordCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWordCount.Location = new System.Drawing.Point(203, 49);
            this.lblWordCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(78, 19);
            this.lblWordCount.TabIndex = 3;
            this.lblWordCount.Text = "0";
            // 
            // lblSentences
            // 
            this.lblSentences.AutoSize = true;
            this.lblSentences.Location = new System.Drawing.Point(48, 23);
            this.lblSentences.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSentences.Name = "lblSentences";
            this.lblSentences.Size = new System.Drawing.Size(151, 19);
            this.lblSentences.TabIndex = 0;
            this.lblSentences.Text = "Number of Sentences:";
            this.lblSentences.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUniqueWordCount
            // 
            this.lblUniqueWordCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUniqueWordCount.Location = new System.Drawing.Point(203, 74);
            this.lblUniqueWordCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUniqueWordCount.Name = "lblUniqueWordCount";
            this.lblUniqueWordCount.Size = new System.Drawing.Size(78, 19);
            this.lblUniqueWordCount.TabIndex = 5;
            this.lblUniqueWordCount.Text = "0";
            // 
            // gpbWordStatistics
            // 
            this.gpbWordStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbWordStatistics.Controls.Add(this.lsvWords);
            this.gpbWordStatistics.Location = new System.Drawing.Point(352, 120);
            this.gpbWordStatistics.Name = "gpbWordStatistics";
            this.gpbWordStatistics.Size = new System.Drawing.Size(470, 401);
            this.gpbWordStatistics.TabIndex = 6;
            this.gpbWordStatistics.TabStop = false;
            this.gpbWordStatistics.Text = "Word Statistics";
            // 
            // lsvWords
            // 
            this.lsvWords.AllowColumnReorder = true;
            this.lsvWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cmhCount,
            this.cmhWord});
            this.lsvWords.Location = new System.Drawing.Point(6, 26);
            this.lsvWords.Name = "lsvWords";
            this.lsvWords.Size = new System.Drawing.Size(458, 369);
            this.lsvWords.TabIndex = 0;
            this.lsvWords.UseCompatibleStateImageBehavior = false;
            this.lsvWords.View = System.Windows.Forms.View.Details;
            // 
            // cmhCount
            // 
            this.cmhCount.Text = "Count";
            // 
            // cmhWord
            // 
            this.cmhWord.Text = "Word";
            this.cmhWord.Width = 700;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(352, 530);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(52, 19);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(410, 527);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(412, 27);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grpFile
            // 
            this.grpFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFile.Controls.Add(this.btnOpenFile);
            this.grpFile.Controls.Add(this.txtFilename);
            this.grpFile.Location = new System.Drawing.Point(12, 12);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(333, 58);
            this.grpFile.TabIndex = 1;
            this.grpFile.TabStop = false;
            this.grpFile.Text = "Specify a file to be analyzed";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Location = new System.Drawing.Point(290, 26);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(37, 27);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilename.Location = new System.Drawing.Point(6, 26);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(278, 27);
            this.txtFilename.TabIndex = 0;
            // 
            // frmTextAnalyzerForm
            // 
            this.AcceptButton = this.btnAnalyze;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.grpFile);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gpbWordStatistics);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpTextStatistics);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpTextBox);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTextAnalyzerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Analyzer";
            this.grpTextBox.ResumeLayout(false);
            this.grpTextBox.PerformLayout();
            this.grpTextStatistics.ResumeLayout(false);
            this.grpTextStatistics.PerformLayout();
            this.gpbWordStatistics.ResumeLayout(false);
            this.grpFile.ResumeLayout(false);
            this.grpFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnExit;
        private Button btnClear;
        private Button btnAnalyze;
        private GroupBox grpTextBox;
        private TextBox txtInput;
        private GroupBox grpTextStatistics;
        private Label lblUniqueWordCount;
        private Label lblSentenceCount;
        private Label lblWordCount;
        private Label lblUniqueWords;
        private Label lblWords;
        private Label lblSentences;
        private GroupBox gpbWordStatistics;
        private ListView lsvWords;
        private ColumnHeader cmhCount;
        private ColumnHeader cmhWord;
        private Label lblSearch;
        private TextBox txtSearch;
        private GroupBox grpFile;
        private Button btnOpenFile;
        private TextBox txtFilename;
    }
}