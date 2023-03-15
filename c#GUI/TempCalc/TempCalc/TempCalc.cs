namespace TempCalc {
    public partial class frmTempCalc : Form {
        public frmTempCalc() {
            InitializeComponent();
        } // end method

        private void btnExit_Click(object sender, EventArgs e) {
            //this.Close();
            Application.Exit();
        } // end method

        private void btnCalculate_Click(object sender, EventArgs e) {
            // calculate and output Fahrenheit to Celsius
            double fahrTempInput;
            if (double.TryParse(txtFahrenheitTemp.Text, out fahrTempInput)) {
                // calculate fahrenheit to celsius
                double celTempOutput = ((fahrTempInput - 32) * 5) / 9;

                lblCelsiusTempOutput.Text = $"{celTempOutput:N1}";
            } else {
                txtFahrenheitTemp.SelectAll();
            } // end if

            double celTempInput;
            if (double.TryParse(txtCelsiusTemp.Text, out celTempInput)) {

                // calculate and output Fahrenheit to Celsius
                double fahrTempOutput = celTempInput * 9 / 5 + 32;

                lblFahrenheitOutput.Text = $"{fahrTempOutput:N1}";
            } else {
                txtCelsiusTemp.SelectAll();
            } // end if
        } // end method
    } // end class
} // end namespace