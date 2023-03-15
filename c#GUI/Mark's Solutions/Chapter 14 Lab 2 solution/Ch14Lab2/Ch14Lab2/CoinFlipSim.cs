using System;
using System.Windows.Forms;

namespace Ch14Lab2 {
    public partial class frmCoinFlipSim : Form {
        public frmCoinFlipSim() {
            InitializeComponent();
        } // end method

        private void btnFlip_Click(object sender, EventArgs e) {
            Random rnd = new Random();  // Use to generate random values

            int heads = 0;  // Holds number of flips that land on heads
            int tails = 0;  // Holds number of flips that land on tails
            int sideUp = 0; // Holds randomly generated value

            for (int i = 0; i < nudFlips.Value; i++) {
                sideUp = rnd.Next(2);   // Generate random number between 0 and 1

                if (sideUp == 0) {  // If the flip lands on heads
                    heads++;    // Increment heads by 1
                } else {            // If the flip lands on tails
                    tails++;    // Increment tails by 1
                } // end if
            } // end for

            // Output results
            lblHeads.Text = $"{heads}\n({heads / nudFlips.Value:P1})";
            lblTails.Text = $"{tails}\n({tails / nudFlips.Value:P1})";

            // Select all text in numericUpDown and set focus to it
            nudFlips.Select(0, nudFlips.Value.ToString().Length);
            nudFlips.Focus();

            rnd = null;
        } // end method
    } // end class
} // end namespace