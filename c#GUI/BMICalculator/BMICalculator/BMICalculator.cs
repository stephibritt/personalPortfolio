namespace BMICalculator {
    public partial class frmBMICalculator : Form {
        public frmBMICalculator() {
            InitializeComponent();
        } // end method

        private void btnCalculate_Click(object sender, EventArgs e) {
            double height;
            double weight;

            if (double.TryParse(txtHeight.Text, out height) && height > 0) {
                if (double.TryParse(txtWeight.Text, out weight) && weight > 0) {
                    double bmi;

                    if (rdoImperial.Checked) {  // If Imperial radio button is selected
                        bmi = weight * 703 / (height * height);
                    } else {    // If Metric radio button is selected
                        bmi = (weight / height / height) * 10000;
                    } // end if

                    // Output bmi results
                    lblResult.Text = $"Based on a height of {height}{lblHeightUnit.Text} and a " +
                        $"weight of {weight}{lblWeightUnit.Text}, your BMI is {bmi:N1}.";

                    // output the user's bmi rating
                    if (bmi < 18.5) {
                        lblResult.Text += " You are underweight.";
                    } else if (bmi >= 18.5 && bmi <= 24.9) {
                        lblResult.Text += " Your weight is optimal.";
                    } else if (bmi >= 25 && bmi <= 29.9) {
                        lblResult.Text += " You are overweight.";
                    } else {
                        lblResult.Text += " You are obese.";
                    } // end if
                } else {
                    txtWeight.SelectAll();
                    txtWeight.Focus();
                    lblResult.Text = "Invalid weight. Please enter a positive numeric value for weight.";
                } // end if
            } else {
                txtHeight.SelectAll();
                txtHeight.Focus();
                lblResult.Text = "Invalid height. Please enter a positive numeric value for height.";
            } // end if
        } // end method

        private void RadioButtons_CheckedChanged(object sender, EventArgs e) {
            if (sender == rdoImperial) {
                lblHeightUnit.Text = "in";
                lblWeightUnit.Text = "lbs";
                txtHeight.Clear();
                txtHeight.Focus();
                txtWeight.Clear();
                lblResult.Text = "";
            } else if (sender == rdoMetric) {
                lblHeightUnit.Text = "cm";
                lblWeightUnit.Text = "kg";
                txtHeight.Clear();
                txtHeight.Focus();
                txtWeight.Clear();
                lblResult.Text = "";
            } // end if
        } // end method

        private void btnReset_Click(object sender, EventArgs e) {
            rdoImperial.Checked = true;
            txtHeight.Clear();
            txtHeight.Focus();
            txtWeight.Clear();
            lblResult.Text = "";
        } // end method

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        } // end method
    } // end class
} // end namespace