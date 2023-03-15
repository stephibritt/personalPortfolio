using System;
using System.Windows.Forms;

namespace Ch14Lab3 {
    public partial class frmBmiCalculator : Form {
        // Default constructor
        public frmBmiCalculator() {
            InitializeComponent();
        } // end method

        // Exit button Click event
        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        } // end method

        // Reset button Click event
        private void btnReset_Click(object sender, EventArgs e) {
            rdoImperial.Checked = true;     // Select Imperial radio button
            txtHeight.Clear();              // Clear Height textbox
            txtWeight.Clear();              // Clear Weight textbox
            lblResult.Text = "";            // Clear Result label
            txtHeight.Focus();              // Set focus to Height textbox
        } // end method

        // Imperial and Metric radio buttons CheckChanged event
        private void MeasurementSystem_CheckChanged(object sender, EventArgs e) {
            if (sender == rdoImperial) {        // If Imperial radio button is selected
                lblHeightUnit.Text = "in";
                lblWeightUnit.Text = "lbs";
            } else if (sender == rdoMetric) {   // If Metric radio button is selected
                lblHeightUnit.Text = "cm";
                lblWeightUnit.Text = "kg";
            } // end if

            // Select all text and set focus to Height textbox
            txtHeight.SelectAll();
            txtHeight.Focus();
        } // end method

        // Calculate button Click event
        private void btnCalculate_Click(object sender, EventArgs e) {
            double height = 0;
            double weight = 0;

            // If Height textbox value is valid
            if (double.TryParse(txtHeight.Text, out height) && height > 0) {
                // If Weight textbox value is valid
                if (double.TryParse(txtWeight.Text, out weight) && weight > 0) {
                    double bmi = 0;

                    // Determine which measurement system to use and perform calculation
                    if (rdoImperial.Checked) {  // If Imperial radio button is selected
                        bmi = weight * 703 / (height * height);
                    } else {    // If Metric radio button is selected
                        bmi = (weight / height / height) * 10000;
                    } // end if

                    // Output BMI results
                    lblResult.Text = $"Based on a height of {height}{lblHeightUnit.Text} and a " +
                        $"weight of {weight}{lblWeightUnit.Text}, your BMI is {bmi:N1}.";

                    // Output where user is overweight, underweight, or optimal
                    if (bmi < 18.5) {
                        lblResult.Text += " You are underweight.";
                    } else if (bmi > 25) {
                        lblResult.Text += " You are overweight.";
                    } else {
                        lblResult.Text += " Your weight is optimal.";
                    } // end if
                } else {    // If Weight textbox value is NOT valid
                    // Set error message for invalid weight
                    lblResult.Text = "Invalid weight. Please enter a positive numeric value for weight.";
                    txtWeight.SelectAll();
                    txtWeight.Focus();
                }// end if
            } else {    // If Height textbox value is NOT valid
                // Set error message for invalid height
                lblResult.Text = "Invalid height. Please enter a positive numeric value for height.";
                txtHeight.SelectAll();
                txtHeight.Focus();
            }// end if
        } // end method

        // Event handler to select all text of textboxes when they get the focus
        private void textBoxes_Enter(object sender, EventArgs e) {
            if (sender == txtHeight) {
                txtHeight.SelectAll();
            } else if (sender == txtWeight) {
                txtWeight.SelectAll();
            } // end if
        } // end method
    } // end class
} // end namespace