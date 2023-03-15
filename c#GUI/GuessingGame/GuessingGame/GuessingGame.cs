namespace GuessingGame {
    public partial class frmGuessingGame : Form {
        // global variables
        private static Random _rnd = new Random();
        private int _targetNumber = _rnd.Next(1, 101);
        private int _guessCounter = 0;
        
        public frmGuessingGame() {
            InitializeComponent();
        } // end method

        private void frmGuessingGame_Load(object sender, EventArgs e) {
            for (int i = 1; i < 101; i++) { // create a table of 100 numbers
                lstNumbers.Items.Add(i);
            } // end for
        } // end method

        private void lstNumbers_Click(object sender, EventArgs e) {
            // local variables
            int selectedIndex = lstNumbers.SelectedIndex;
            int selectedNumber = (lstNumbers.SelectedIndex + 1);

            // do not perform actions if the index is out of range or the number has been guessed
            if (selectedIndex >= 0 && lstNumbers.SelectedItem.ToString() != "") {
                // remove guessed number and insert blank
                lstNumbers.Items.RemoveAt(selectedIndex);
                lstNumbers.Items.Insert(selectedIndex, "");

                // increment guess counter
                _guessCounter++;

                // output lower, higher, or win scenario
                if (selectedNumber > _targetNumber) {
                    stblMain.Text = $"Lower!";
                } else if (selectedNumber < _targetNumber) {
                    stblMain.Text = $"Higher!";
                } else {
                    // output congratulatory messagebox
                    MessageBox.Show($"You won with {_guessCounter} guesses.", "Congratulations! You Win!", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // reset game
                    GuessingGameReset();
                } // end if
            } // end if

            // guess and total number labels
            lblGuessCount.Text = _guessCounter.ToString();
            lblNumTotal.Text = $"{100 - _guessCounter}";
        } // end method

        private void mnuFileExit_Click(object sender, EventArgs e) {
            this.Close(); // close the program
        } // end method

        private void mnuFileNew_Click(object sender, EventArgs e) {
            GuessingGameReset(); // generates a new game
        } // end method

        private void GuessingGameReset() {
            // form reset
            lstNumbers.Items.Clear();
            _guessCounter = 0;
            _targetNumber = _rnd.Next(1, 101);

            // output new table of numbers
            for (int i = 1; i < 101; i++) {
                lstNumbers.Items.Add(i);
            } // end for

            // label resets
            lblGuessCount.Text = _guessCounter.ToString();
            lblNumTotal.Text = $"{100 - _guessCounter}";
            stblMain.Text = "Click a number to begin guessing!";
        } // end method
    } // end class
} // end namespace