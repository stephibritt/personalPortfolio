using System;
using System.Collections.Generic;
using System.Linq;

class Hand {
    // private member variable
    private List<Card> m_handOfCards = new List<Card>();

    // get-only property
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
