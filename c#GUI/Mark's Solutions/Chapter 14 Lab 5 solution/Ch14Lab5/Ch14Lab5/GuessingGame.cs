using System;
using System.Windows.Forms;

namespace Ch14Lab5 {
    public partial class frmGuessingGame : Form {
        private const int FIRST_NUMBER = 1;
        private const int LAST_NUMBER = 100;

        private int m_incorrectGuesses = 0;
        private int m_numbersRemaining = 100;
        private int m_numberToGuess;            // Game win condition

        public frmGuessingGame() {
            InitializeComponent();
        } // end method

        private void frmGuessingGame_Load(object sender, EventArgs e) {
            lstNumbers.ColumnWidth = 40;    // Spacing between list item columns

            this.NewGame();   // Set up game board
        } // end method

        // Method sets-up/resets game board
        private void NewGame() {
            // Generate the random number to be guessed
            Random rnd = new Random();
            this.m_numberToGuess = rnd.Next(FIRST_NUMBER, LAST_NUMBER + 1);
            rnd = null;

            lstNumbers.Items.Clear();   // Ensure listbox is empty

            // Add number 1 through 100 to list box
            for (int i = FIRST_NUMBER; i <= LAST_NUMBER; i++) {
                lstNumbers.Items.Add(i);
            } // end for

            // Reset stats
            sblHint.Text = "Click a number to guess that number!";
            m_incorrectGuesses = 0;
            m_numbersRemaining = LAST_NUMBER;

            this.UpdateScore();         // Update guess/numbers info
        } // end method

        // Method updates Incorrect Guesses and Numbers Remaining info
        private void UpdateScore() {
            lblIncorrectGuessesValue.Text = m_incorrectGuesses.ToString();
            lblNumbersRemainingValue.Text = m_numbersRemaining.ToString();
        } // end method

        // Event handler for interacting with numbers listbox
        private void lstNumbers_Click(object sender, EventArgs e) {
            // Ensure a list item is selected
            if (lstNumbers.SelectedIndex != -1) {
                // Get the clicked number and its index
                string number = lstNumbers.SelectedItem.ToString();
                int index = lstNumbers.SelectedIndex;

                // Ensure the clicked number hasn't already been used
                if (number != string.Empty) {
                    // If the clicked number is the number to guess
                    if (int.Parse(number) == m_numberToGuess) {
                        MessageBox.Show($"You found the hidden number in {m_incorrectGuesses + 1} guesses.", "Congratulations! You win!");
                        this.NewGame();
                    } else {    // Otherwise, inform user if they need to go higher or lower
                        if (int.Parse(number) > m_numberToGuess) {
                            sblHint.Text = "Lower!";
                        } else {
                            sblHint.Text = "Higher!";
                        } // end if

                        // Hide number
                        lstNumbers.Items.RemoveAt(index);
                        lstNumbers.Items.Insert(index, string.Empty);

                        // Increase incorrect guesses and decrease remaining numbers
                        m_incorrectGuesses++;
                        m_numbersRemaining--;

                        this.UpdateScore();     // Update score labels
                    } // end if
                } // end if
            } // end if

            // Make sure no item is selected in listbox
            lstNumbers.SelectedIndex = -1;
        } // end method

        // Event handler for file menu
        private void fileMenu_Click(object sender, EventArgs e) {
            if (sender == mnuFileNewGame) {
                this.NewGame();
            } else if (sender == mnuFileExit) {
                Application.Exit();
            } // end if
        } // end method
    } // end class
} // end namespace