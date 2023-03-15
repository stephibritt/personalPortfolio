using System;
class HandOfPlayingCards {
    static void Main() {
        const int HAND_SIZE = 5;
        const int NUMBER_OF_PLAYERS = 4;
        Deck d = new Deck();
        // Player hand objects
        Hand[] playerHands = new Hand[NUMBER_OF_PLAYERS];
        // Initialize each array element
        for (int i = 0; i < NUMBER_OF_PLAYERS; i++) {
            playerHands[i] = new Hand();
        } // end for
          // Deal-out each hand, one card at a time
        for (int i = 0; i < HAND_SIZE; i++) {
            playerHands[0].AddCard(d.DealCard()); // Deal card to Player 1
            playerHands[1].AddCard(d.DealCard()); // Deal card to Player 2
            playerHands[2].AddCard(d.DealCard()); // Deal card to Player 3
            playerHands[3].AddCard(d.DealCard()); // Deal card to Player 4
        } // end for
          // Output header
        Console.WriteLine("Shuffle-up and deal!\n");
        // Output each hand
        for (int i = 0; i < NUMBER_OF_PLAYERS; i++) {
            Console.WriteLine($"Player {i + 1}", -19);
            Console.WriteLine($"{"=================",-19}");
            Console.WriteLine($"{playerHands[i]}");
        } // end for
    } // end method
} // end class