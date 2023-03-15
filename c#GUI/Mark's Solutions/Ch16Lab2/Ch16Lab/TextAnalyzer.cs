using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Ch16Lab {
    public partial class frmTextAnalyzer : Form {
        private int SortColumn { get; set; } = -1;

        public frmTextAnalyzer() {
            InitializeComponent();
        } // end constructor

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        } // end method

        private void btnAnalyzeText_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;   // Show the wait cursor
            
            try {
                using (TextStats stats = new TextStats(txtText.Text)) {
                    lsvWords.Items.Clear();

                    // Output sentence and word statistics
                    lblNumberOfSentencesValue.Text = $"{stats.NumberOfSentences:N0}";
                    lblTotalNumberOfWordsValue.Text = $"{stats.TotalNumberOfWords:N0}";
                    lblNumberOfUniqueWordsValue.Text = $"{stats.NumberOfUniqueWords:N0}";

                    // Populate ListView with words and their counts
                    foreach (KeyValuePair<string, int> pair in stats.WordDictionary.OrderByDescending(key => key.Value)) {
                        lsvWords.Items.Add(new ListViewItem(new string[] { $"{pair.Value:N0}", $"{pair.Key}" }));
                    } // end foreach
                } // end using

                txtSearch.Enabled = true;
                txtSearch.Focus();
            } catch (EmptyStringException ese) {
                MessageBox.Show(ese.Message, "Text Analyzer",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtText.Focus();
            } finally {
                this.Cursor = Cursors.Default;  // Show the default cursor
            }// end try
        } // end method

        private void txtText_TextChanged(object sender, EventArgs e) {
            txtSearch.Clear();

            // If there is text to be analyzed...
            if (txtText.Text.Length > 0) {
                btnAnalyzeText.Enabled = true;
                btnClear.Enabled = true;
            } else { // If there is NOT text to be analyzed...
                btnAnalyzeText.Enabled = false;
                btnClear.Enabled = false;
            } // end if
        } // end method

        private void btnClear_Click(object sender, EventArgs e) {
            // Clear all the inputs and outputs
            txtText.Clear();
            lblNumberOfSentencesValue.Text = "0";
            lblNumberOfUniqueWordsValue.Text = "0";
            lblTotalNumberOfWordsValue.Text = "0";
            lsvWords.Items.Clear();
            txtSearch.Clear();
            txtSearch.Enabled = false;
            txtSearch.BackColor = Color.White;
        } // end method

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            for (int i = 0; i < lsvWords.Items.Count; i++) {
                if (lsvWords.Items[i].SubItems[1].Text.ToUpper().StartsWith(txtSearch.Text.ToUpper())) {
                    lsvWords.Items[i].Selected = true;
                    txtSearch.BackColor = Color.White;
                    lsvWords.EnsureVisible(i);  // Scrolls to the item if needed
                    break;
                } else {
                    lsvWords.Items[i].Selected = false;
                    txtSearch.BackColor = Color.LightCoral;
                } // end if
            } // end for

            if (txtSearch.Text == string.Empty) {
                lsvWords.SelectedItems.Clear();
            } // end if
        } // end method

        private void lsvWords_ColumnClick(object sender, ColumnClickEventArgs e) {
            this.Cursor = Cursors.WaitCursor;   // Show the wait cursor

            // If the clicked column is the same as the last column clicked...
            if (e.Column != this.SortColumn) {
                // Set the sort column to the new column
                this.SortColumn = e.Column;
                // Set the sort order to asecending by default
                lsvWords.Sorting = SortOrder.Ascending;
            } else { // If the clicked column is NOT the same as the last column clicked...
                // If the current sort order is Ascending, switch it to Descending
                if (lsvWords.Sorting == SortOrder.Ascending) {
                    lsvWords.Sorting = SortOrder.Descending;
                } else { // If the current sort order is Descending, switch it to Ascending
                    lsvWords.Sorting = SortOrder.Ascending;
                } // end if
            } // end of

            lsvWords.Sort();    // Sort the listview
            this.lsvWords.ListViewItemSorter = new ListViewItemComparer(e.Column, lsvWords.Sorting);

            this.Cursor = Cursors.Default;   // Show the default cursor
        } // end method

        #region Code for maintaining window size between execution
        private void RestoreWindowSize() {
            this.Size = Properties.Settings.Default.WindowSize;
        } // end method

        private void SaveWindowSize() {
            Properties.Settings.Default.WindowSize = this.Size;
            Properties.Settings.Default.Save();
        } // end method

        private void frmTextAnalyzer_Load(object sender, EventArgs e) {
            this.RestoreWindowSize();
        } // end method

        private void frmTextAnalyzer_FormClosing(object sender, FormClosingEventArgs e) {
            this.SaveWindowSize();
        } // end method
        #endregion
    } // end class


    public class ListViewItemComparer : IComparer {
        private int ColumnNumber { get; set; }
        private SortOrder SortOrder { get; set; }
        
        public ListViewItemComparer() {
            this.ColumnNumber = 0;
            this.SortOrder = SortOrder.Ascending;
        } // end constructor

        public ListViewItemComparer(int columnNumber, SortOrder sortOrder) {
            this.ColumnNumber = columnNumber;
            this.SortOrder = sortOrder;
        } // end constructor

        public int Compare(object x, object y) {
            int returnValue = -1;

            returnValue = String.Compare(((ListViewItem)x).SubItems[this.ColumnNumber].Text,
                                         ((ListViewItem)y).SubItems[this.ColumnNumber].Text);
            
            // If the sort order is descending...
            if (this.SortOrder == SortOrder.Descending) {
                // Invert the ordering
                returnValue *= -1;
            } // end if

            return returnValue;
        } // end method
    } // end class
} // end namespace