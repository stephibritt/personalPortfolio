using System;
using System.Windows.Forms;

namespace Ch14Lab1 {
    // Class that builds the form and handles control interaction
    public partial class frmWhenIsEaster : Form {
        // Default constructor
        public frmWhenIsEaster() {
            InitializeComponent();
        } // end method

        // btnExit Click event method
        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();     // Terminate program
        } // end method

        // btnCalculate Click event method
        private void btnCalculate_Click(object sender, EventArgs ea) {
            double year = 0;

            // If textbox value is an integer and greater than zero...
            if (double.TryParse(txtYear.Text, out year) && year > 0) {
                // Anonymous Gregorian Computus algorithm
                double a = year % 19;
                double b = Math.Floor(year / 100);
                double c = year % 100;
                double d = Math.Floor(b / 4);
                double e = b % 4;
                double f = Math.Floor((b + 8) / 25);
                double g = Math.Floor((b - f + 1) / 3);
                double h = (19 * a + b - d - g + 15) % 30;
                double i = Math.Floor(c / 4);
                double k = c % 4;
                double l = (32 + 2 * e + 2 * i - h - k) % 7;
                double m = Math.Floor((a + 11 * h + 22 * l) / 451);

                // Calculate the month and day of Easter
                double month = Math.Floor((h + l + 7 * m + 114) / 31);
                double day = 1 + (h + l - 7 * m + 114) % 31;

                // Output results
                lblEasterDate.Text = $"In {year}, Easter falls on {(month == 3 ? "March" : "April")} {day}.";              
            } else {    // If textbox value is NOT an integer
                MessageBox.Show("Please specify a valid year value.", "Invalid Year", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYear.SelectAll();    // Select all text in textbox
                txtYear.Focus();        // Set focus to textbox
            } // end if
        } // end method
    } // end class
} // end namespace