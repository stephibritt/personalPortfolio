using System;
using System.Windows.Forms;

namespace Ch10Lab1 {
    public partial class frmHeartRateCalculator : Form {
        public frmHeartRateCalculator() {
            InitializeComponent();
        } // end method

        private void frmHeartRateCalculator_Load(object sender, EventArgs e) {
            // Set birth date to today by default
            dtpBirthDate.Value = DateTime.Today;
        } // end method

        private void btnCalculate_Click(object sender, EventArgs e) {
            // Create object of HeartRate class
            HeartRate hr = new HeartRate(dtpBirthDate.Value);

            // Output results
            lblOutput.Text = hr.ToString();
        } // end method
    } // end class
} // end namespace