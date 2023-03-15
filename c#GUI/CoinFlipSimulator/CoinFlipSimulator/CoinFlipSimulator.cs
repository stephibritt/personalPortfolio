namespace CoinFlipSimulator {
    public partial class frmCoinFlipSimulator : Form {
        public frmCoinFlipSimulator() {
            InitializeComponent();
        } // end method

        private void btnFlip_Click(object sender, EventArgs e) {
            int numberOfFlips = (int)nudFlips.Value;

            Random rnd = new Random();
            double headsCounter = 0;
            double tailsCounter = 0;

            for (int i = 0; i < numberOfFlips; i++) {
                int coinValue = rnd.Next(2);
                
                if (coinValue == 1) {
                    headsCounter++;
                } else {
                    tailsCounter++;
                } // end if
            } // end for

            lblResultHeads.Text = $"{headsCounter:n0}\n({(headsCounter / numberOfFlips):p1})";
            lblResultTails.Text = $"{tailsCounter:n0}\n({(tailsCounter / numberOfFlips):p1})";

        } // end method
    } // end class
} // end namespace