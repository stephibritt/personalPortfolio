using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RPS {
    // class constants
    private const int ROCK = 0;
    private const int PAPER = 1;
    private const int SCISSORS = 2;

    // class member variables
    private int m_player1;
    private int m_player2;
    
    // class properties
    public int Player1 {
        get {
            return m_player1;
        } // end get

        set {
            m_player1 = value;
        } // end set
    } // end property

    public int Player2 {
        get {
            return m_player2;
        } // end get

        set {
            m_player2 = value;
        } // end set
    } // end property

    // class constructor
    public RPS(int player1Choice, int player2Choice) {
        Player1 = player1Choice;
        Player2 = player2Choice;
    } // end constructor

    public string GetWinner() {
        if (Player1 == Player2) {
            return "Draw.";
        } else if (Player1 == ROCK && Player2 == SCISSORS) {
            return "Player 1 wins!";
        } else if (Player1 == PAPER && Player2 == ROCK) {
            return "Player 1 wins!";
        } else if (Player1 == SCISSORS && Player2 == PAPER) {
            return "Player 1 wins!";
        } else {
            return "Player 2 wins!";
        } // end if
    } // end method
} // end class