namespace SecurityTrainerApp {
    public partial class frmSecurityTrainerApp : Form {
        // constant to hold the correct access code
        private const string ACCESS_CODE = "00000";

        // class variables
        private int failCounter;
        private readonly string[] FAKE_FILE_NAMES = { "System.Conf.InitializationData", 
            "System.Conf.SystemSettings", "System.Conf.SecurityCode", "System.Conf.EncryptionKey",
            "System.Conf.Tools", "System.Init.CoreValues", "System.Init.BIOSSettings"};

        public frmSecurityTrainerApp() {
            InitializeComponent();

            // hide the fail message labels and progress bar until it is needed
            lblFailureMessage.Hide();
            lblFakeFileNames.Hide();
            pgbFakeFileDeletion.Hide();
        } // end constructor

        private void btnVerify_Click(object sender, EventArgs e) {
            // use the wait cursor
            Cursor = Cursors.WaitCursor;

            // instantiate the needed variables
            string accessCodeTest;
            DialogResult result;

            // pull the user values
            accessCodeTest = nudFirstDigit.Text;
            accessCodeTest += nudSecondDigit.Text;
            accessCodeTest += nudThirdDigit.Text;
            accessCodeTest += nudFourthDigit.Text;
            accessCodeTest += nudFifthDigit.Text;

            if (failCounter < 4) {
                // if the user enters the correct code
                if (accessCodeTest == ACCESS_CODE) {
                    // show a success message
                    result = MessageBox.Show("Success", "Congratulations!",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    // if the user clicks ok
                    if (result == DialogResult.OK) {
                        // close the form
                        CloseForm();
                    } else { // if the user clicks cancel
                             // reset the form, but allow user interaction again
                        ResetForm();
                    } // end if
                } else { // if the code is incorrect
                         // return the cursor to default
                    Cursor = Cursors.Default;

                    // increment the fail counter
                    failCounter++;

                    // output and show the fail message
                    lblFailureMessage.Text = $"Incorrect. You have {failCounter} failed attempt(s).";
                    lblFailureMessage.Show();
                } // end if
            } else {
                lblFailureMessage.Text = "You have failed too many times. Your attempts have been " +
                    "determined to be malicious. Deleting system files to protect user privacy.";

                SimulateFileDeletion();
            } // end if 
        } // end event

        private void CloseForm() {
            ResetForm(); // reset the form before closing
            this.Close(); // close the form
        } // end method

        private void ResetForm() {
            // reset the unneeded elements of the form
            Cursor = Cursors.Default;
            failCounter = 0;
            lblFailureMessage.Text = "";
            lblFailureMessage.Hide();
        } // end method

        private void SimulateFileDeletion() {
            pgbFakeFileDeletion.Show();
            lblFakeFileNames.Show();

            int incrementValue = (100 / FAKE_FILE_NAMES.Length);

            foreach (string item in FAKE_FILE_NAMES) {
                lblFakeFileNames.Text = $"Deleting {item}";
                pgbFakeFileDeletion.Value += incrementValue;
            } // end foreach

            lblFakeFileNames.Text = "All files deleted successfully.";
            pgbFakeFileDeletion.Value = 100;

            MessageBox.Show("Please call your system administrator to unlock this computer.", "NOTICE",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    } // end class
} // end namespace