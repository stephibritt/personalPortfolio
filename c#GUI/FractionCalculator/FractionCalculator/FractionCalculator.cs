namespace FractionCalculator {
    public partial class frmFractionCalculator : Form {
        public frmFractionCalculator() {
            InitializeComponent();
        } // end method

        private void frmFractionCalculator_Load(object sender, EventArgs e) {
            cboOperator.Items.Add("+");
            cboOperator.Items.Add("-");
            cboOperator.Items.Add("*");
            cboOperator.Items.Add("/");

            cboOperator.SelectedIndex = 0;
        } // end method

        private void btnCalculate_Click(object sender, EventArgs e) {
            int leftNumerator;
            int leftDenominator;
            int rightNumerator;
            int rightDenominator;

            // if left numerator is valid
            if (int.TryParse(txtLeftNumerator.Text, out leftNumerator)) {
                // if left denominator is valid
                if (int.TryParse(txtLeftDenominator.Text, out leftDenominator) && leftDenominator != 0) {
                    // if right numerator is valid
                    if (int.TryParse(txtRightNumerator.Text, out rightNumerator)) {
                        // if right denominator is valid
                        if (int.TryParse(txtRightDenominator.Text, out rightDenominator) && rightDenominator != 0) {
                            // instantiate the fractions
                            Fraction leftFraction = new Fraction(leftNumerator, leftDenominator);
                            Fraction rightFraction = new Fraction(rightNumerator, rightDenominator);
                            Fraction outputFraction = new Fraction();

                            // decide which operation to perform
                            if (cboOperator.SelectedIndex == 0) {
                                outputFraction = leftFraction + rightFraction;
                            } else if (cboOperator.SelectedIndex == 1) {
                                outputFraction = leftFraction - rightFraction;
                            } else if (cboOperator.SelectedIndex == 2) {
                                outputFraction = leftFraction * rightFraction;
                            } else if (cboOperator.SelectedIndex == 3) {
                                outputFraction = leftFraction / rightFraction;
                            } // end if

                            lblOutput.Text = outputFraction.ToString();
                            stblMain.Text = outputFraction.ToDoubleString();
                        } else {
                            stblMain.Text = "Invalid right denominator. Denominator must be a valid integer not equal to zero.";
                            txtRightDenominator.Focus();
                            txtRightDenominator.SelectAll();
                        } // end if
                    } else {
                        stblMain.Text = "Invalid right numerator. Numerator must be a valid integer.";
                        txtRightNumerator.Focus();
                        txtRightNumerator.SelectAll();
                    } // end if
                } else {
                    stblMain.Text = "Invalid left denominator. Denominator must be a valid integer not equal to zero.";
                    txtLeftDenominator.Focus();
                    txtLeftDenominator.SelectAll();
                } // end if
            } else {
                stblMain.Text = "Invalid left numerator. Numerator must be a valid integer.";
                txtLeftNumerator.Focus();
                txtLeftNumerator.SelectAll();
            } // end if
        } // end method

        private void textBoxes_Enter(object sender, EventArgs e) {
            if (sender == txtLeftNumerator) {
                txtLeftNumerator.SelectAll();
            } else if (sender == txtLeftDenominator) {
                txtLeftDenominator.SelectAll();
            } else if (sender == txtRightNumerator) {
                txtRightNumerator.SelectAll();
            } else if (sender == txtRightDenominator) {
                txtRightDenominator.SelectAll();
            } // end if
        } // end method

        private void btnClear_Click(object sender, EventArgs e) {
            txtLeftNumerator.Clear();
            txtLeftNumerator.Focus();
            txtLeftDenominator.Clear();
            txtRightNumerator.Clear();
            txtRightDenominator.Clear();

            cboOperator.SelectedIndex = 0;

            lblOutput.Text = "";
            stblMain.Text = "Calculate a fraction.";
        } // end method

        private void textBoxes_Click(object sender, EventArgs e) {
            if (sender == txtLeftNumerator) {
                txtLeftNumerator.SelectAll();
            } else if (sender == txtLeftDenominator) {
                txtLeftDenominator.SelectAll();
            } else if (sender == txtRightNumerator) {
                txtRightNumerator.SelectAll();
            } else if (sender == txtRightDenominator) {
                txtRightDenominator.SelectAll();
            } // end if
        } // end method
    } // end class
} // end namespace