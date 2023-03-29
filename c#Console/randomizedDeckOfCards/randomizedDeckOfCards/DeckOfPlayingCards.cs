using System;
class DeckOfPlayingCards {
    static void Main() {
        Deck d = new Deck();
        int index = 1; // Keeps track of the number of cards dealt
        int numCardsInDeck = d.NumCardsInDeck; // Total number of cards in the deck
                                               // Column headers
        Console.WriteLine($"{"Cd#",-4}{"Card",-27}{"Cards Remaining"}");
        Console.WriteLine($"{"===",-4}{"==========================",-27}{"========================"}");
        // Output all cards in deck
        for (int i = 0; i < numCardsInDeck; i++) {
            Console.WriteLine($"{index++ + ".",-4}{d.DealCard().ToLongString(),-27}{d}");
        } // end for
    } // end method
} // end class