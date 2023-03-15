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

    public int NumCardsInHand {
        get {
            return m_handOfCards.Count;
        } // end get
    } // end property

    // get-only properties
    public HandValue ValueOfHand {
        get {
            this.SortHand();

            #region FaceAndValue LINQ
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
            #endregion

            #region Suit LINQ
            // query can be used for all except Flush and half of StraightFlush
            IEnumerable<dynamic> groupCardsBySuitQuery =
                from card in this.GetCards()
                group card by new { card.Suit } into cardSuitGroup
                orderby cardSuitGroup.Key.Suit
                select new {
                    Suit = cardSuitGroup.Key.Suit,
                    Count = cardSuitGroup.Count()
                };
            #endregion

            if (this.NumCardsInHand > 0) {
                // Test for Straight Flush
                bool isStraight = false;
                bool isFlush = false;

                int consecutiveCounter = 1; // How many consecutive cards there are
                int previousCardValue = groupCardsByFaceAndValueQuery.First().Value;
                int thisCardValue = 0;
                int cardsInHand = groupCardsByFaceAndValueQuery.Count();

                for (int i = 0; i < cardsInHand; i++) {
                    if (i != 0) {
                        thisCardValue = groupCardsByFaceAndValueQuery.ElementAt(i).Value;
                        if (thisCardValue - previousCardValue == 1) {
                            consecutiveCounter++;

                            // If 4 consecutive cards have appeared, test for Ace-leading straight edge-case
                            if (consecutiveCounter == 4) {
                                // If the first card's value is 2 and the last card's value is 14...
                                if (groupCardsByFaceAndValueQuery.First().Value == 2 &&
                                        groupCardsByFaceAndValueQuery.Last().Value == 14) {
                                    isStraight = true;
                                    break;      // Break out of loop
                                } // end if
                            } // end if

                            // If 5 consecutive cards have appeared, the hand is a straight
                            if (consecutiveCounter == 5) {
                                isStraight = true;
                                break;      // Break out of loop
                            } // end if

                            // Set the previous card value to the current card value
                            previousCardValue = thisCardValue;
                        } else {
                            // Reset consecutive counter if the current card is not consecutive
                            consecutiveCounter = 1;
                        } // end if
                    } // end if
                } // end for

                foreach (var card in groupCardsBySuitQuery) {
                    if (card.Count == 5) {
                        isFlush = true;
                        break;
                    } // end if
                } // end foreach

                // Test if both flag values are true
                if (isFlush == true && isStraight == true) {
                    return HandValue.StraightFlush;
                } // end if

                // Test if hand has FourOfAKind
                foreach (var card in groupCardsByFaceAndValueQuery) {
                    if (card.Count == 4) {
                        return HandValue.FourOfAKind;
                    } // end if
                } // end foreach

                // Test if hand has FullHouse
                int onePairCount = 0;
                int threeOfAKindCount = 0;
                foreach (var card in groupCardsByFaceAndValueQuery) {
                    if (card.Count == 2) {
                        onePairCount++;
                    } else if (card.Count == 3) {
                        threeOfAKindCount++;
                    } // end if
                } // end foreach

                // return full house if there are 2 and 3 of any card rank
                if (onePairCount >= 1 && threeOfAKindCount >= 1) {
                    return HandValue.FullHouse;
                } // end if

                // Test if hand has Flush
                foreach (var card in groupCardsBySuitQuery) {
                    if (card.Count >= 5) {
                        return HandValue.Flush;
                    } // end if
                } // end foreach

                // Test if hand has Straight
                consecutiveCounter = 1;     // Holds how many consecutive cards in a row have appeared
                previousCardValue = groupCardsByFaceAndValueQuery.First().Value;
                thisCardValue = 0;
                cardsInHand = groupCardsByFaceAndValueQuery.Count();
                for (int i = 0; i < cardsInHand; i++) {
                    if (i != 0) {   // Skip the first iteration
                        thisCardValue = groupCardsByFaceAndValueQuery.ElementAt(i).Value;
                        if (thisCardValue - previousCardValue == 1) {
                            consecutiveCounter++;

                            // If 4 consecutive cards have appeared, test for Ace-leading straight edge-case
                            if (consecutiveCounter == 4) {
                                // If the first card's value is 2 and the last card's value is 14...
                                if (groupCardsByFaceAndValueQuery.First().Value == 2 &&
                                        groupCardsByFaceAndValueQuery.Last().Value == 14) {
                                    return HandValue.Straight;     // Break out of loop
                                } // end if
                            } // end if

                            // If 5 consecutive cards have appeared, the hand is a straight
                            if (consecutiveCounter == 5) {
                                return HandValue.Straight;
                            } // end if

                            // Set the previous card value to the current card value
                            previousCardValue = thisCardValue;
                        } else {
                            // Reset consecutive counter if the current card is not consecutive
                            consecutiveCounter = 1;
                        } // end if
                    } // end if
                } // end for

                // Test if hand has ThreeOfAKind
                foreach (var card in groupCardsByFaceAndValueQuery) {
                    if (card.Count == 3) {
                        return HandValue.ThreeOfAKind;
                    } // end if
                } // end foreach

                // Test if hand has TwoPair
                int pairCounter = 0;
                foreach (var card in groupCardsByFaceAndValueQuery) {
                    if (card.Count == 2) {
                        pairCounter++;
                    } // end if
                } // end foreach

                if (pairCounter >= 2) {
                    return HandValue.TwoPair;
                } // end if

                // Test if hand has OnePair
                foreach (var card in groupCardsByFaceAndValueQuery) {
                    if (card.Count == 2) {
                        return HandValue.OnePair;
                    } // end if
                } // end foreach

                // IF we reach this statement, the hand is crap
                return HandValue.HighCard;
            } else {
                throw new NoCardsInHandException();
            } // end if
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
        m_handOfCards = m_handOfCards.OrderBy(card => card.Value).ThenBy(card => card.Suit).ToList();
    } // end method

    public override string ToString() {
        SortHand();

        string output = "";
        foreach (Card c in m_handOfCards) {
            output += $"{c}\n";
        } // end foreach
        
        if (ValueOfHand == HandValue.HighCard) {
            output += $"Hand value: High card\n";
        } else if (ValueOfHand == HandValue.OnePair) {
            output += $"Hand value: One pair\n";
        } else if (ValueOfHand == HandValue.TwoPair) {
            output += $"Hand value: Two pair\n";
        } else if (ValueOfHand == HandValue.ThreeOfAKind) {
            output += $"Hand value: Three of a kind\n";
        } else if (ValueOfHand == HandValue.Straight) {
            output += $"Hand value: Straight\n";
        } else if (ValueOfHand == HandValue.Flush) {
            output += $"Hand value: Flush\n";
        } else if (ValueOfHand == HandValue.FullHouse) {
            output += $"Hand value: Full house\n";
        } else if (ValueOfHand == HandValue.FourOfAKind) {
            output += $"Hand value: Four of a kind\n";
        } else {
            output += $"Hand value: Straight flush\n";
        } // end if

        return output;
    } // end method
} // end class

// Custom Exception class for no cards in hand
public class NoCardsInHandException : Exception {
    public NoCardsInHandException() : base("There are no cards currently in hand.") { }
    public NoCardsInHandException(string message) : base(message) { }
    public NoCardsInHandException(string message, Exception inner) : base(message, inner) { }
} // end class