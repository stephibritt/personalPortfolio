namespace Examples {
    public partial class frmHelloWorld : Form {
        public frmHelloWorld() {
            InitializeComponent();
        } // end method

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit(); // terminate application
        } // end method

        private void btnShow_Click(object sender, EventArgs e) {
            MessageBox.Show("Hello, world!", "HelloWorld", 
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        } // end method
    } // end class
} // end namespace