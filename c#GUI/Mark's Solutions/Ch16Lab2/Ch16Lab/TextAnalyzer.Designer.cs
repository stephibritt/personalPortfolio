
namespace Ch16Lab {
    partial class frmTextAnalyzer {
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnAnalyzeText = new System.Windows.Forms.Button();
            this.grpText = new System.Windows.Forms.GroupBox();
            this.grpTextStats = new System.Windows.Forms.GroupBox();
            this.lblNumberOfUniqueWordsValue = new System.Windows.Forms.Label();
            this.lblNumberOfUniqueWords = new System.Windows.Forms.Label();
            this.lblTotalNumberOfWordsValue = new System.Windows.Forms.Label();
            this.lblTotalNumberOfWords = new System.Windows.Forms.Label();
            this.lblNumberOfSentencesValue = new System.Windows.Forms.Label();
            this.lblNumberOfSentences = new System.Windows.Forms.Label();
            this.grpWordStats = new System.Windows.Forms.GroupBox();
            this.lsvWords = new System.Windows.Forms.ListView();
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpText.SuspendLayout();
            this.grpTextStats.SuspendLayout();
            this.grpWordStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(7, 27);
            this.txtText.Margin = new System.Windows.Forms.Padding(4);
            this.txtText.MaxLength = 10000000;
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtText.Size = new System.Drawing.Size(319, 503);
            this.txtText.TabIndex = 0;
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // btnAnalyzeText
            // 
            this.btnAnalyzeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyzeText.Enabled = false;
            this.btnAnalyzeText.Location = new System.Drawing.Point(671, 12);
            this.btnAnalyzeText.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalyzeText.Name = "btnAnalyzeText";
            this.btnAnalyzeText.Size = new System.Drawing.Size(150, 75);
            this.btnAnalyzeText.TabIndex = 2;
            this.btnAnalyzeText.Text = "&Analyze Text";
            this.btnAnalyzeText.UseVisualStyleBackColor = true;
            this.btnAnalyzeText.Click += new System.EventHandler(this.btnAnalyzeText_Click);
            // 
            // grpText
            // 
            this.grpText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpText.Controls.Add(this.txtText);
            this.grpText.Location = new System.Drawing.Point(12, 12);
            this.grpText.Name = "grpText";
            this.grpText.Size = new System.Drawing.Size(333, 537);
            this.grpText.TabIndex = 0;
            this.grpText.TabStop = false;
            this.grpText.Text = "Enter text to be analyzed";
            // 
            // grpTextStats
            // 
            this.grpTextStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTextStats.Controls.Add(this.lblNumberOfUniqueWordsValue);
            this.grpTextStats.Controls.Add(this.lblNumberOfUniqueWords);
            this.grpTextStats.Controls.Add(this.lblTotalNumberOfWordsValue);
            this.grpTextStats.Controls.Add(this.lblTotalNumberOfWords);
            this.grpTextStats.Controls.Add(this.lblNumberOfSentencesValue);
            this.grpTextStats.Controls.Add(this.lblNumberOfSentences);
            this.grpTextStats.Location = new System.Drawing.Point(351, 12);
            this.grpTextStats.Name = "grpTextStats";
            this.grpTextStats.Size = new System.Drawing.Size(313, 162);
            this.grpTextStats.TabIndex = 1;
            this.grpTextStats.TabStop = false;
            this.grpTextStats.Text = "Text statistics";
            // 
            // lblNumberOfUniqueWordsValue
            // 
            this.lblNumberOfUniqueWordsValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberOfUniqueWordsValue.Location = new System.Drawing.Point(193, 108);
            this.lblNumberOfUniqueWordsValue.Name = "lblNumberOfUniqueWordsValue";
            this.lblNumberOfUniqueWordsValue.Size = new System.Drawing.Size(97, 27);
            this.lblNumberOfUniqueWordsValue.TabIndex = 5;
            this.lblNumberOfUniqueWordsValue.Text = "0";
            this.lblNumberOfUniqueWordsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumberOfUniqueWords
            // 
            this.lblNumberOfUniqueWords.AutoSize = true;
            this.lblNumberOfUniqueWords.Location = new System.Drawing.Point(15, 112);
            this.lblNumberOfUniqueWords.Name = "lblNumberOfUniqueWords";
            this.lblNumberOfUniqueWords.Size = new System.Drawing.Size(172, 19);
            this.lblNumberOfUniqueWords.TabIndex = 4;
            this.lblNumberOfUniqueWords.Text = "Number of unique words:";
            // 
            // lblTotalNumberOfWordsValue
            // 
            this.lblTotalNumberOfWordsValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalNumberOfWordsValue.Location = new System.Drawing.Point(193, 72);
            this.lblTotalNumberOfWordsValue.Name = "lblTotalNumberOfWordsValue";
            this.lblTotalNumberOfWordsValue.Size = new System.Drawing.Size(97, 27);
            this.lblTotalNumberOfWordsValue.TabIndex = 3;
            this.lblTotalNumberOfWordsValue.Text = "0";
            this.lblTotalNumberOfWordsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalNumberOfWords
            // 
            this.lblTotalNumberOfWords.AutoSize = true;
            this.lblTotalNumberOfWords.Location = new System.Drawing.Point(29, 76);
            this.lblTotalNumberOfWords.Name = "lblTotalNumberOfWords";
            this.lblTotalNumberOfWords.Size = new System.Drawing.Size(158, 19);
            this.lblTotalNumberOfWords.TabIndex = 2;
            this.lblTotalNumberOfWords.Text = "Total number of words:";
            // 
            // lblNumberOfSentencesValue
            // 
            this.lblNumberOfSentencesValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberOfSentencesValue.Location = new System.Drawing.Point(193, 36);
            this.lblNumberOfSentencesValue.Name = "lblNumberOfSentencesValue";
            this.lblNumberOfSentencesValue.Size = new System.Drawing.Size(97, 27);
            this.lblNumberOfSentencesValue.TabIndex = 1;
            this.lblNumberOfSentencesValue.Text = "0";
            this.lblNumberOfSentencesValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumberOfSentences
            // 
            this.lblNumberOfSentences.AutoSize = true;
            this.lblNumberOfSentences.Location = new System.Drawing.Point(36, 40);
            this.lblNumberOfSentences.Name = "lblNumberOfSentences";
            this.lblNumberOfSentences.Size = new System.Drawing.Size(151, 19);
            this.lblNumberOfSentences.TabIndex = 0;
            this.lblNumberOfSentences.Text = "Number of sentences:";
            // 
            // grpWordStats
            // 
            this.grpWordStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWordStats.Controls.Add(this.lsvWords);
            this.grpWordStats.Location = new System.Drawing.Point(351, 180);
            this.grpWordStats.Name = "grpWordStats";
            this.grpWordStats.Size = new System.Drawing.Size(470, 336);
            this.grpWordStats.TabIndex = 5;
            this.grpWordStats.TabStop = false;
            this.grpWordStats.Text = "Word statistics";
            // 
            // lsvWords
            // 
            this.lsvWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCount,
            this.colWord});
            this.lsvWords.FullRowSelect = true;
            this.lsvWords.HideSelection = false;
            this.lsvWords.Location = new System.Drawing.Point(6, 26);
            this.lsvWords.MultiSelect = false;
            this.lsvWords.Name = "lsvWords";
            this.lsvWords.Size = new System.Drawing.Size(458, 304);
            this.lsvWords.TabIndex = 0;
            this.lsvWords.UseCompatibleStateImageBehavior = false;
            this.lsvWords.View = System.Windows.Forms.View.Details;
            this.lsvWords.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lsvWords_ColumnClick);
            // 
            // colCount
            // 
            this.colCount.Text = "Count";
            // 
            // colWord
            // 
            this.colWord.Text = "Word";
            this.colWord.Width = 375;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(671, 133);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Enabled = false;
            this.txtSearch.Location = new System.Drawing.Point(413, 522);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(409, 27);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(351, 525);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(56, 19);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search:";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(671, 90);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmTextAnalyzer
            // 
            this.AcceptButton = this.btnAnalyzeText;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpWordStats);
            this.Controls.Add(this.grpTextStats);
            this.Controls.Add(this.grpText);
            this.Controls.Add(this.btnAnalyzeText);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "frmTextAnalyzer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Analyzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTextAnalyzer_FormClosing);
            this.Load += new System.EventHandler(this.frmTextAnalyzer_Load);
            this.grpText.ResumeLayout(false);
            this.grpText.PerformLayout();
            this.grpTextStats.ResumeLayout(false);
            this.grpTextStats.PerformLayout();
            this.grpWordStats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnAnalyzeText;
        private System.Windows.Forms.GroupBox grpText;
        private System.Windows.Forms.GroupBox grpTextStats;
        private System.Windows.Forms.Label lblNumberOfUniqueWordsValue;
        private System.Windows.Forms.Label lblNumberOfUniqueWords;
        private System.Windows.Forms.Label lblTotalNumberOfWordsValue;
        private System.Windows.Forms.Label lblTotalNumberOfWords;
        private System.Windows.Forms.Label lblNumberOfSentencesValue;
        private System.Windows.Forms.Label lblNumberOfSentences;
        private System.Windows.Forms.GroupBox grpWordStats;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ListView lsvWords;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ColumnHeader colWord;
        private System.Windows.Forms.ColumnHeader colCount;
    }
}

