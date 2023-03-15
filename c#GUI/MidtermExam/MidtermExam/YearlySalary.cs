namespace MidtermExam {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        } // end constructor

        private void btnCalculate_Click(object sender, EventArgs e) {
            decimal hourlyPay;
            int yearlyIncrease;
            int yearsToProject = (int)nudYearsToProject.Value;

            if (decimal.TryParse(txtHourlyPay.Text, out hourlyPay) && hourlyPay > 0) {
                if (int.TryParse(txtYearlyIncrease.Text, out yearlyIncrease)) {
                    try {
                        decimal yearlyIncreasePercent = yearlyIncrease / 100m; // to get the percentage from the input
                        
                        Wages wages = new Wages(hourlyPay);

                        string output = $"Year   Hourly    Weekly        Monthly       Yearly";

                        for (int i = 0; i <= yearsToProject; i++) {
                            output += $"\n{i,-7:N0}{wages.HourlyPay, -10:C}" +
                            $"{wages.GetWeeklyPay(),-14:C}" +
                            $"{wages.GetMonthlyPay(),-14:C}" +
                            $"{wages.GetYearlyPay():C}";

                            wages.HourlyPay += (wages.HourlyPay * yearlyIncreasePercent);
                        } // end for

                        lblOutput.Text = output;
                    } catch (Exception ex){
                        lblOutput.Text = $"I don't know how you got here, but {ex.Message}";
                    } // end try
                } else {
                    txtYearlyIncrease.Focus();
                    txtYearlyIncrease.SelectAll();
                    lblOutput.Text = "A yearly increase must be a number greater than zero.";
                } // end if
            } else {
                txtHourlyPay.Focus();
                txtHourlyPay.SelectAll();
                lblOutput.Text = "An hourly pay must be a number greater than zero.";
            } // end if
        } // end method

        private void btnReset_Click(object sender, EventArgs e) {
            txtHourlyPay.Clear();
            txtHourlyPay.Focus();
            txtYearlyIncrease.Text = "0";
            nudYearsToProject.Value = 0;
            lblOutput.Text = "";
        } // end method

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        } // end method
    } // end class
} // end namespace