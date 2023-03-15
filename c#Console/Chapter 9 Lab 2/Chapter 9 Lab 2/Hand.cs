using System;
using System.Collections.Generic;
using System.Linq;

class Hand {
    // private member variable
    private List<Card> m_handOfCards = new List<Card>();

    // public enum
    public enum HandValue {
        HighCard = 0,
        OnePair = 1,
        TwoPair = 2,
        ThreeOfAKind = 3,
        Straight = 4,
        Flush = 5,
        FullHouse = 6,
        FourOfAKind = 7,
        StraightFlush = 8
    } // end enum

    // get-only properties
    public HandValue ValueOfHand {
        get {
            // query can be used for all except Flush and half of StraightFlush
            IEnumerable<dynamic> groupCardsByFaceAndValueQuery =
                from card in this.GetCards()
                group card by new { card.Face, card.Value } into cardFaceAndValueGroup
                orderby cardFaceAndValueGroup.Key.Value
                select new {
                    Face = cardFaceAndValueGroup.Key.Face,
                    Value = cardFaceAndValueGroup.Key.Value,
                    Count = cardFaceAndValueGroup.Count()
                };
            // Test if hand has StraightFlush

            // Test if hand has FourOfAKind

            // Test if hand has FullHouse

            // Test if hand has Flush

            // Test if hand has Straight

            // Test if hand has ThreeOfAKind
            foreach (var card in groupCardsByFaceAndValueQuery) {
                if (card.Face >= 2) {
                    return HandValue.ThreeOfAKind;
                } // end if
            } // end foreach

            // Test if hand has TwoPair
            bool isOnePair = false;
            foreach (var card in groupCardsByFaceAndValueQuery) {
                for (int i = 0; i <=1; i++) {
                    if (card.Count >= 2) {
                        return HandValue.TwoPair;
                    } // end if
                } // end for
                
            } // end foreach

            // Test if hand has OnePair
            foreach (var card in groupCardsByFaceAndValueQuery) {
                if (card.Count >= 2) {
                    return HandValue.OnePair;
                } // end if
            } // end foreach

            // IF we reach this statement, the hand is crap
            return HandValue.HighCard;
        } // end get
    } // end property
    public int NumCardsInHand {
        get {
            return m_handOfCards.Count;
        } // end get
    } // end property

    // class constructor
    public Hand() {
        m_handOfCards = new List<Card>();
    } // end constructor

    // class method
    public void AddCard(Card card) {
        m_handOfCards.Add(card);

        SortHand();
    } // end method

    public List<Card> GetCards() {
        SortHand();

        return m_handOfCards;
    } // end method

    private void SortHand() {
        //List<Card> sortedHand = new List<Card>(); // create a temporary list for the sorted hand

        //var sortQuery =
        //    from card in m_handOfCards
        //    orderby card.Value, card.Suit // sort cards by value within sorted suits
        //    select card;

        //foreach (var card in sortQuery) { // add the cards to the list in sorted order
        //    sortedHand.Add(card);
        //} // end foreach

        //m_handOfCards = sortedHand; // replace the original hand wiht the sorted one

        m_handOfCards = m_handOfCards.OrderBy(card => card.Value).ThenBy(card => card.Suit).ToList();
    } // end method

    public override string ToString() {
        SortHand();

        string output = "";
        foreach (Card c in m_handOfCards) {
            output += $"{c}\n";
        } // end foreach

        return output;
    } // end method
} // end class
