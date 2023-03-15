using System;
class HandValueTest {
    // Sample Card objects for testing
    private static readonly Card ACE_OF_CLUBS = new Card("Ace", "Red", "Clubs", 14);
    private static readonly Card ACE_OF_DIAMONDS = new Card("Ace", "Red", "Diamonds", 14);
    private static readonly Card ACE_OF_HEARTS = new Card("Ace", "Red", "Hearts", 14);
    private static readonly Card ACE_OF_SPADES = new Card("Ace", "Red", "Spades", 14);
    private static readonly Card TWO_OF_HEARTS = new Card("2", "Red", "Hearts", 2);
    private static readonly Card TWO_OF_SPADES = new Card("2", "Black", "Spades", 2);
    private static readonly Card THREE_OF_HEARTS = new Card("3", "Red", "Hearts", 3);
    private static readonly Card FOUR_OF_HEARTS = new Card("4", "Red", "Hearts", 4);
    private static readonly Card FIVE_OF_HEARTS = new Card("5", "Red", "Hearts", 5);
    private static readonly Card FIVE_OF_CLUBS = new Card("5", "Black", "Clubs", 5);
    private static readonly Card SIX_OF_HEARTS = new Card("6", "Red", "Hearts", 6);
    private static readonly Card TEN_OF_CLUBS = new Card("10", "Black", "Clubs", 10);
    private static readonly Card KING_OF_HEARTS = new Card("King", "Red", "Hearts", 13);
    static void Main() {
        Hand h;
        // Test: High Card
        Console.WriteLine("Test: High Card");
        h = new Hand(); // Instantiate new Hand object
        h.AddCard(ACE_OF_HEARTS); // Add cards...
        h.AddCard(FIVE_OF_CLUBS);
        h.AddCard(TWO_OF_SPADES);
        h.AddCard(KING_OF_HEARTS);
        h.AddCard(TEN_OF_CLUBS);
        Console.WriteLine(h); // Call ToString() method
                              // Test: One Pair
        Console.WriteLine("\nTest: One Pair");
        h = new Hand(); // Instantiate new Hand object
        h.AddCard(ACE_OF_HEARTS); // Add cards...
        h.AddCard(FIVE_OF_CLUBS);
        h.AddCard(ACE_OF_DIAMONDS);
        h.AddCard(KING_OF_HEARTS);
        h.AddCard(TEN_OF_CLUBS);
        Console.WriteLine(h); // Call ToString() method
                              // Test: Two Pair
        Console.WriteLine("\nTest: Two Pair");
        h = new Hand(); // Instantiate new Hand object
        h.AddCard(ACE_OF_HEARTS); // Add cards...
        h.AddCard(TWO_OF_SPADES);
        h.AddCard(ACE_OF_DIAMONDS);
        h.AddCard(KING_OF_HEARTS);
        h.AddCard(TWO_OF_HEARTS);
        Console.WriteLine(h); // Call ToString() method
                              // Test: Three of a Kind
        Console.WriteLine("\nTest: Three of a Kind");
        h = new Hand(); // Instantiate new Hand object
        h.AddCard(ACE_OF_HEARTS); // Add cards...
        h.AddCard(ACE_OF_SPADES);
        h.AddCard(TWO_OF_HEARTS);
        h.AddCard(KING_OF_HEARTS);
        h.AddCard(ACE_OF_CLUBS);
        Console.WriteLine(h); // Call ToString() method

    // HandValueTest.cs (cont'd)
    // Test: Straight
        Console.WriteLine("\nTest: Straight");
        h = new Hand(); // Instantiate new Hand object
        h.AddCard(FIVE_OF_HEARTS); // Add cards...
        h.AddCard(TWO_OF_SPADES);
        h.AddCard(FOUR_OF_HEARTS);
        h.AddCard(THREE_OF_HEARTS);
        h.AddCard(SIX_OF_HEARTS);
        Console.WriteLine(h); // Call ToString() method
                              // Test: Flush
        Console.WriteLine("\nTest: Flush");
        h = new Hand(); // Instantiate new Hand object
        h.AddCard(ACE_OF_HEARTS); // Add cards...
        h.AddCard(FIVE_OF_HEARTS);
        h.AddCard(KING_OF_HEARTS);
        h.AddCard(FOUR_OF_HEARTS);
        h.AddCard(THREE_OF_HEARTS);
        Console.WriteLine(h); // Call ToString() method
                              // Test: Full House
        Console.WriteLine("\nTest: Full House");
        h = new Hand(); // Instantiate new Hand object
        h.AddCard(ACE_OF_HEARTS); // Add cards...
        h.AddCard(ACE_OF_SPADES);
        h.AddCard(TWO_OF_HEARTS);
        h.AddCard(TWO_OF_SPADES);
        h.AddCard(ACE_OF_CLUBS);
        Console.WriteLine(h); // Call ToString() method
                              // Test: Four of a Kind
        Console.WriteLine("\nTest: Four of a Kind");
        h = new Hand(); // Instantiate new Hand object
        h.AddCard(ACE_OF_HEARTS); // Add cards...
        h.AddCard(ACE_OF_SPADES);
        h.AddCard(ACE_OF_DIAMONDS);
        h.AddCard(KING_OF_HEARTS);
        h.AddCard(ACE_OF_CLUBS);
        Console.WriteLine(h); // Call ToString() method
                              // Test: Straight Flush 1
        Console.WriteLine("\nTest: Straight Flush 1");
        h = new Hand(); // Instantiate new Hand object
        h.AddCard(FIVE_OF_HEARTS); // Add cards...
        h.AddCard(TWO_OF_HEARTS);
        h.AddCard(FOUR_OF_HEARTS);
        h.AddCard(THREE_OF_HEARTS);
        h.AddCard(SIX_OF_HEARTS);
        Console.WriteLine(h); // Call ToString() method
                              // Test: Straight Flush 2
        Console.WriteLine("\nTest: Straight Flush 2");
        h = new Hand(); // Instantiate new Hand object
        h.AddCard(ACE_OF_HEARTS); // Add cards...
        h.AddCard(FIVE_OF_HEARTS);
        h.AddCard(TWO_OF_HEARTS);
        h.AddCard(FOUR_OF_HEARTS);
        h.AddCard(THREE_OF_HEARTS);
        Console.WriteLine(h); // Call ToString() method
    } // end method
} // end class