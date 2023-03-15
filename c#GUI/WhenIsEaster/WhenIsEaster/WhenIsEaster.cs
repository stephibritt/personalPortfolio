using System.Security.Cryptography.X509Certificates;

namespace WhenIsEaster {
    public partial class frmWhenIsEaster : Form {
        public frmWhenIsEaster() {
            InitializeComponent();
        } // end method

        private void btnCalculate_Click(object sender, EventArgs e) {
            try {
                double year = int.Parse(txtYear.Text);

                if (year < 1) {
                    throw new Exception("Please enter a valid year greater than 0.");
                } // end if

                // Anonymous Gregorian Computus algorithm 
                double a = year % 19;
                double b = Math.Floor(year / 100);
                double c = year % 100;
                double d = Math.Floor(b / 4);
                double echo = b % 4;
                double f = Math.Floor((b + 8) / 25);
                double g = Math.Floor((b - f + 1) / 3);
                double h = (19 * a + b - d - g + 15) % 30;
                double i = Math.Floor(c / 4);
                double k = c % 4;
                double l = (32 + 2 * echo + 2 * i - h - k) % 7;
                double m = Math.Floor((a + 11 * h + 22 * l) / 451);
                double month = Math.Floor((h + l - 7 * m + 114) / 31);
                double day = 1 + ((h + l - 7 * m + 114) % 31);

                if (month == 3) {
                    lblEasterOutput.Text = $"In {year}, Easter falls on March {day}.";
                } else if (month == 4) {
                    lblEasterOutput.Text = $"In {year}, Easter falls on April {day}.";
                } else {
                    lblEasterOutput.Text = "An unknown error has occurred.";
                } // end if

            } catch (FormatException) {
                lblEasterOutput.Text = "Please enter a valid year.";
                //MessageBox.Show($"Please enter a valid year.", "When is Easter?", 
                //                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYear.Clear();
                txtYear.Focus();
            } catch (Exception ex) {
                lblEasterOutput.Text = ex.Message;
                //MessageBox.Show(ex.Message, "When is Easter?",
                //    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtYear.Clear();
                txtYear.Focus();
            } // end try
        } // end method
        
        private void txtYear_TextChanged(object sender, EventArgs e) {            
            if (string.IsNullOrWhiteSpace(txtYear.Text)) {
                btnCalculate.Enabled = false;
            } else {
                btnCalculate.Enabled = true;
            } // end if
        } // end method

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        } // end method

        private void btnReset_Click(object sender, EventArgs e) {
            txtYear.Clear();
            txtYear.Focus();
        } // end method
    } // end class
} // end namespace