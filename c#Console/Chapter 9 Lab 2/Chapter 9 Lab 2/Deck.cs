using System;
using System.Linq;
using System.Collections.Generic;

class Deck {
    // class constant
    private const int NUMBER_OF_CARDS = 52;     // Number of cards in a deck

    // random object
    private static Random rnd = new Random();

    // private attributes
    private List<Card> m_deckOfCards = new List<Card>();

    // get-only property
    public int NumCardsInDeck {
        get {
            //return m_currentCardIndex + 1;
            return m_deckOfCards.Count;
        } // end get
    } //  end property

    // class constructor
    public Deck(bool buildDeck = true) {
        if (buildDeck) {
            this.BuildDeck();

            this.Shuffle();
        } // end if        
    } // end constructor

    // class methods
    private void BuildDeck() {
        if (m_deckOfCards.Any()) {
            m_deckOfCards.Clear();
        } else {
            string[] face = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            string[] color = { "Black", "Red" };
            string[] suits = { "Spades", "Diamonds", "Clubs", "Hearts" };
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            // Populate deck with Card objects
            for (int i = 0; i < NUMBER_OF_CARDS; i++) {
                m_deckOfCards.Add(new Card(face[i % 13], color[i % 2], suits[i % 4], values[i % 13]));
            } // end for
        } // end if
    } // end method
    
    public void Shuffle(int numberOfShuffles = 5) {
        while (numberOfShuffles < 1) {
            numberOfShuffles = 1;
        } // end while

        // Shuffle x number of times
        for (int i = 0; i < numberOfShuffles; i++) {
            // For each card, pick another random Card and swap them
            for (int thisIndex = 0; thisIndex < m_deckOfCards.Count(); thisIndex++) {
                // Select a random index between 0 and 51
                int randomIndex = rnd.Next(NUMBER_OF_CARDS);

                // Swap current Card object with randomly selected Card
                Card tempCard = m_deckOfCards[thisIndex];
                m_deckOfCards[thisIndex] = m_deckOfCards[randomIndex];
                m_deckOfCards[randomIndex] = tempCard;
            } // end for
        } // end for
    } // end method

    public Card DealCard() {
        if (m_deckOfCards.Any()) {
            Card cardToDeal = m_deckOfCards[m_deckOfCards.Count - 1];
            m_deckOfCards.RemoveAt(m_deckOfCards.Count - 1);
            return cardToDeal;
        } else {
            throw new Exception();
        } // end if
    } // end method

    public override string ToString() {
        return $"{this.NumCardsInDeck} cards remaining in the deck.";
    } // end method
} // end class