using System;

class Deck {
    // class constant
    private const int NUMBER_OF_CARDS = 52;     // Number of cards in a deck

    // random object
    private static Random rnd = new Random();

    // private attributes
    private Card[] m_deckOfCards = new Card[NUMBER_OF_CARDS]; // array holding the deck of cards.
    private int m_currentCardIndex = NUMBER_OF_CARDS - 1;

    // get-only property
    public int NumCardsInDeck {
        get {
            return m_currentCardIndex + 1;
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
        string[] face = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        string[] color = { "Black", "Red" };
        string[] suits = { "Spades", "Diamonds", "Clubs", "Hearts" };
        int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        
        // Populate deck with Card objects
        for (int i = 0; i < m_deckOfCards.Length; i++) {
            m_deckOfCards[i] = new Card(face[i % 13], color[i % 2], suits[i % 4], values[i % 13]);
        } // end for
    } // end method
    
    public void Shuffle(int numberOfShuffles = 5) {
        while (numberOfShuffles < 1) {
            numberOfShuffles = 1;
        } // end while

        m_currentCardIndex = NUMBER_OF_CARDS - 1;

        // Shuffle x number of times
        for (int i = 0; i < numberOfShuffles; i++) {
            // For each card, pick another random Card and swap them
            for (int j = m_currentCardIndex; j >= 0; j--) {
                // Select a random index between 0 and 51
                int randomIndex = rnd.Next(NUMBER_OF_CARDS);

                // Swap current Card object with randomly selected Card
                Card tempCard = m_deckOfCards[j];
                m_deckOfCards[j] = m_deckOfCards[randomIndex];
                m_deckOfCards[randomIndex] = tempCard;
            } // end for
        } // end for
    } // end method

    public Card DealCard() {
        if (m_currentCardIndex >= 0) {
            return m_deckOfCards[m_currentCardIndex--];
        } else {
            return null;
        } // end if
    } // end method

    public override string ToString() {
        return $"{this.NumCardsInDeck} cards remaining in the deck.";
    } // end method
} // end class