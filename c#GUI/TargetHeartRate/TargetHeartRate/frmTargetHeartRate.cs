namespace TargetHeartRate {
    public partial class frmTargetHeartRateCalc : Form {
        DateTime m_birthDate;

        public frmTargetHeartRateCalc() {
            InitializeComponent();
        } // end method

        private void btnCalculate_Click(object sender, EventArgs e) {
            // instantiate a new object of class HeartRate
            HeartRate userHeartRate = new HeartRate(m_birthDate);

            // output calculations
            lblOutput.Text = userHeartRate.ToString();
        } // end event

        private void dtpMain_ValueChanged(object sender, EventArgs e) {
            try {
                if (dtpMain.Value.Year <= (DateTime.Now.Year - 125) || (dtpMain.Value.Year >= DateTime.Now.Year)) {
                    throw new Exception();
                } else {
                    m_birthDate = dtpMain.Value;
                    btnCalculate.Enabled = true;
                } // end if
            } catch {
                dtpMain.Focus();
                btnCalculate.Enabled = false;
                lblOutput.Text = $"Invalid birth year. Year must be between {DateTime.Now.Year - 125} and {DateTime.Now.Year}.";
            } // end try
        } // end event
    } // end class
} // end namespace