using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TextAnalysisApp {
    public partial class frmTextAnalyzerForm : Form {
        // class constants
        private const int CHARACTER_LIMIT = 300000;

        private readonly string[] WORDS_TO_IGNORE;

        // class member variables
        public StreamWriter m_fileWriter;

        public frmTextAnalyzerForm() {
            InitializeComponent();

            WORDS_TO_IGNORE = PopulateWordsToIgnore();
        } // end constructor

        private void btnAnalyze_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor; // shows the wait cursor

            try {
                using (TextAnalyzer stats = new TextAnalyzer(txtInput.Text)) {
                    lsvWords.Items.Clear(); // ensures that the listView is clear before adding statistics

                    // output stats
                    lblSentenceCount.Text = $"{stats.NumberOfSentences:N0}";
                    lblWordCount.Text = $"{stats.TotalNumberOfWords:N0}";
                    lblUniqueWordCount.Text = $"{stats.NumberOfUniqueWords:N0}";

                    // Populate ListView with words and their counts
                    foreach (KeyValuePair<string, int> word in stats.WordDictionary.OrderByDescending(key => key.Value)) {
                        lsvWords.Items.Add(new ListViewItem(new string[] { $"{word.Value:N0}", $"{word.Key}" }));
                    } // end foreach

                    // write the results of the analysis to a csv
                    DialogResult result;
                    string saveFileName;

                    // create and show a save file dialog box
                    using (SaveFileDialog filePicker = new SaveFileDialog()) {
                        filePicker.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        result = filePicker.ShowDialog();
                        saveFileName = filePicker.FileName;
                    } // end using

                    // if the user clicks ok
                    if (result == DialogResult.OK) {
                        try {
                            FileStream outputStream;
                            if (File.Exists(saveFileName)) {
                                // open the file in append mode if file is a .csv
                                if (saveFileName.Substring(saveFileName.Length - 4) == ".csv") {
                                    outputStream = new FileStream(saveFileName, FileMode.Append,
                                        FileAccess.Write);
                                } else {
                                    // if the file is not a .csv, append the extension
                                    outputStream = new FileStream(saveFileName + ".csv", FileMode.Append,
                                        FileAccess.Write);
                                } // end if
                            } else {
                                // open the file in OpenOrCreate mode
                                outputStream = new FileStream(saveFileName + ".csv", FileMode.OpenOrCreate,
                                    FileAccess.Write);
                            } // end if

                            // create the object for the file
                            m_fileWriter = new StreamWriter(outputStream);

                            // write the statistics to the file
                            foreach (KeyValuePair<string, int> word in stats.WordDictionary.OrderByDescending(key => key.Value)) {
                                // if word is not in WORDS_TO_IGNORE
                                if (!WORDS_TO_IGNORE.Contains(word.Key)) {
                                    // write the word and number of occurrences to a csv
                                    m_fileWriter.WriteLine($"{word.Key},{word.Value}");
                                } // end if
                            } // end foreach

                            // close the file to save it.
                            m_fileWriter?.Close();
                        } catch (IOException) {
                            // notify user if file does not exist/ is invalid
                            MessageBox.Show("Error opening file.", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        } catch (ArgumentException) {
                            // user closed the dialog without selecting a file
                        } // end try
                    } else { // show an error message
                        if (string.IsNullOrWhiteSpace(saveFileName)) {
                            MessageBox.Show("Invalid file name.", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        } // end if
                    } // end if
                } // end using

                // enable the search bar
                txtSearch.Enabled = true;
            } catch (EmptyStringException ese) {
                MessageBox.Show(ese.Message, "Text Analyzer",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
            } finally {
                this.Cursor = Cursors.Default;  // Show the default cursor
            }// end try
        } // end event

        private void btnClear_Click(object sender, EventArgs e) {
            // reset the form
            txtInput.Clear();
            lblSentenceCount.Text = "0";
            lblWordCount.Text = "0";
            lblUniqueWordCount.Text = "0";
            lsvWords.Items.Clear();
            txtSearch.Clear();
            txtSearch.Enabled = false;
            txtSearch.BackColor = Color.White;
            txtFilename.Clear();
            btnAnalyze.Enabled = false;
            m_fileWriter?.Close();

            txtInput.Focus(); // returns focuse to the input textbox
        } // end event

        private void btnExit_Click(object sender, EventArgs e) {
            m_fileWriter?.Close();
            this.Close();
        } // end event

        private void txtInput_TextChanged(object sender, EventArgs e) {
            // clear the search box
            txtSearch.Clear();

            // if there is text
            if (!string.IsNullOrEmpty(txtInput.Text)) {
                btnAnalyze.Enabled = true;
            } else { // if there is not text
                btnAnalyze.Enabled = false;
            }// end if

            // keep track of remaining characters for the user
            int characterCounter = 0;

            foreach (char c in txtInput.Text) {
                characterCounter++;
            } // end foreach

            grpTextBox.Text = $"Enter text to be analyzed ({(CHARACTER_LIMIT - characterCounter):N0} remaining)";
        } // end event

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            // loop over each item
            for (int i = 0; i < lsvWords.Items.Count; i++) {
                // if the item at the index of i is equal to the text in the search bar 
                if (lsvWords.Items[i].SubItems[1].Text.ToUpper().StartsWith(txtSearch.Text.ToUpper())) {
                    lsvWords.Items[i].Selected = true;
                    txtSearch.BackColor = Color.White;
                    lsvWords.EnsureVisible(i);  // scrolls to the item if needed
                    break;
                } else { // if the search does not return results
                    lsvWords.Items[i].Selected = false;
                    txtSearch.BackColor = Color.LightCoral;
                } // end if
            } // end for

            if (txtSearch.Text == string.Empty) {
                lsvWords.SelectedItems.Clear();
            } // end if
        } // end event

        private void btnOpenFile_Click(object sender, EventArgs e) {
            // create an instance of the OpenFileDialog class
            OpenFileDialog ofd = new OpenFileDialog();

            // set properties
            ofd.Filter = "Text files | *.txt";
            // set the initial directory to the user's desktop
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // if the user clicks OK, set the path to what is chosen
            if (ofd.ShowDialog() == DialogResult.OK) {
                // assigne the chosen file path to a variable
                txtFilename.Text = ofd.FileName;
            } // end if

            // release resources for object
            ofd.Dispose();

            // open the file for reading
            txtInput.Text = ReadFileContent(txtFilename.Text);
        } // end event

        private string ReadFileContent(string filePath) {
            // read text from file
            string textFromFile = System.IO.File.ReadAllText(filePath);

            return textFromFile;
        } // end method

        private string[] PopulateWordsToIgnore() {
            // retrieve file path for WordsToIgnore.dat
            string ignoreFilePath;

            ignoreFilePath = Application.StartupPath;
            ignoreFilePath += "WordsToIgnore.dat";

            // read text from WordsToIgnore.dat
            string wordsToIgnore = System.IO.File.ReadAllText(ignoreFilePath);

            //string[] ignoreArray = wordsToIgnore.Split();
            //WORDS_TO_IGNORE = ignoreArray;

            return wordsToIgnore.Split();
        } // end method
    } // end class
} // end namespace