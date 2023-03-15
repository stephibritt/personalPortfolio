using System;
using System.Linq;
using System.Collections.Generic;

class LINQStatements {
    static void Main() {
        Deck d;
        Hand h;

        for (int i = 0; i <= 1000; i++) {
            d = new Deck();
            h = new Hand();

            h.AddCard(d.DealCard());
            h.AddCard(d.DealCard());
            h.AddCard(d.DealCard());
            h.AddCard(d.DealCard());
            h.AddCard(d.DealCard());

            Console.WriteLine(h);
            Console.WriteLine(h.ValueOfHand);
            Console.WriteLine();
        }

    } // end method
    //static void Main() {
    //    const int HAND_SIZE = 10;

    //    Deck d = new Deck();
    //    Hand playerHand = new Hand();

    //    // Output header
    //    Console.WriteLine("Cards in Hand");
    //    Console.WriteLine("=================================");

    //    // Add Cards to player's hand and output the results
    //    for (int i = 0; i < HAND_SIZE; i++) {
    //        Card thisCard = d.DealCard();
    //        playerHand.AddCard(thisCard);   // Add Card to hand

    //        // Output Cards in two columns
    //        Console.Write($"{thisCard,-18}");
    //        if (i % 2 != 0) {
    //            Console.WriteLine();
    //        } // end if
    //    } // end for

    //    #region LINQ Example
    //    //// Example LINQ statement 1:
    //    //// 1. Using playerHand.GetCards() method as the data source,
    //    ////    write a LINQ statement to return all "Jack", "Queen", and "King" Card objects.
    //    //// Sort cards based on suit, then by value

    //    //IEnumerable<Card> faceCardsOnlyQuery =
    //    //    from card in playerHand.GetCards()
    //    //    where card.Value >= 11 && card.Value <= 13
    //    //    //where card.Face == "Jack" || card.Face == "Queen" || card.Face == "King"
    //    //    orderby card.Suit, card.Value
    //    //    select card;

    //    //ExecuteCardQuery(faceCardsOnlyQuery, "Faced cards in hand:",
    //    //    "There are no faced cards in hand.");
    //    #endregion

    //    #region LINQ Statement 1  
    //    /////////////////////////////////////////////////////////////////
    //    // 1. Using playerHand.GetCards() method as the data source,   //
    //    //    write a LINQ statement to return all "Red" Card objects. //
    //    /////////////////////////////////////////////////////////////////
    //    IEnumerable< Card > redCardsOnlyQuery =
    //        from card in playerHand.GetCards()
    //        where card.Color == "Red"
    //        orderby card.Value, card.Suit
    //        select card;

    //    // UNCOMMENT TO EXECUTE QUERY
    //    ExecuteCardQuery(redCardsOnlyQuery, "Red cards in hand:",
    //        "There are no red cards in hand.");
    //    #endregion

    //    #region LINQ Statement 2  
    //    /////////////////////////////////////////////////////////////////////////////////
    //    // 2. Using playerHand.GetCards() method as the data source,                   //
    //    //    write a LINQ statement to return all Card objects with the "Clubs" suit. //
    //    //    Sort the results based on a Card object's Value property.                //
    //    /////////////////////////////////////////////////////////////////////////////////
    //    IEnumerable<Card> clubCardsOnlyQuery =
    //        from card in playerHand.GetCards()
    //        where card.Suit == "Clubs"
    //        orderby card.Value
    //        select card;

    //    // UNCOMMENT TO EXECUTE QUERY
    //    ExecuteCardQuery(clubCardsOnlyQuery, "Club cards in hand:",
    //        "There are no Club cards in hand.");
    //    #endregion

    //    #region LINQ Statement 3  
    //    ///////////////////////////////////////////////////////////////////////////////////
    //    // 3. Using playerHand.GetCards() method as the data source,                     //
    //    //    write a LINQ statement to return all Card objects with faces 2 through 10. //
    //    //    Sort the results based on a Card object's Value property first,            //
    //    //        then by the Color property, and finally by Suit property.              //
    //    ///////////////////////////////////////////////////////////////////////////////////
    //    IEnumerable<Card> faces2to10OnlyQuery =
    //        from card in playerHand.GetCards()
    //        where card.Value >= 2 && card.Value <= 10
    //        orderby card.Value, card.Color, card.Suit
    //        select card;

    //    // UNCOMMENT TO EXECUTE QUERY
    //    ExecuteCardQuery(faces2to10OnlyQuery, "Faces 2 to 10 cards in hand:",
    //        "There are no cards with faces 2 to 10 in hand.");
    //    #endregion

    //    #region LINQ Statement 4  
    //    ///////////////////////////////////////////////////////////////////////////////////////////
    //    // 4. Research how to use the "group" clause in LINQ.                                    //
    //    //    Using playerHand.GetCards() method as the data source,                             //
    //    //    write a LINQ statement to group all Card objects based on their Color.             //
    //    //        The query returns a new anonymous type that assigns the group's "Key" property //
    //    //        to "Color" and assigns the result of the group's "Count()" method to "Count".  //
    //    //    Sort the results based on the anonymous type's Color (i.e., the "Key" property).   //
    //    ///////////////////////////////////////////////////////////////////////////////////////////
    //    IEnumerable<dynamic> groupCardsByColorQuery =
    //        from card in playerHand.GetCards()
    //        group card by card.Color into cardColorGroup
    //        orderby cardColorGroup.Key
    //        select new {
    //            Color = cardColorGroup.Key,
    //            Count = cardColorGroup.Count()
    //        };

    //    // UNCOMMENT TO EXECUTE QUERY
    //    ExecuteGroupQuery1(groupCardsByColorQuery, "Number of cards based on color:",
    //        "There are no cards with any color in hand.");
    //    #endregion

    //    #region LINQ Statement 5  
    //    ///////////////////////////////////////////////////////////////////////////////////////////
    //    // 5. Research how to use the "group" clause in LINQ.                                    //
    //    //    Using playerHand.GetCards() method as the data source,                             //
    //    //    write a LINQ statement to group all Card objects based on their Suit.              //
    //    //        The query returns a new anonymous type that assigns the group's "Key" property //
    //    //        to "Suit" and assigns the result of the group's "Count()" method to "Count".   //
    //    //    Sort the results based on the anonymous type's Suit (i.e., the "Key" property).    //
    //    ///////////////////////////////////////////////////////////////////////////////////////////
    //    IEnumerable<dynamic> groupCardsBySuitQuery =
    //        from card in playerHand.GetCards()
    //        group card by card.Suit into cardSuitGroup
    //        orderby cardSuitGroup.Key
    //        select new {
    //            Suit = cardSuitGroup.Key,
    //            Count = cardSuitGroup.Count()
    //        };

    //    // UNCOMMENT TO EXECUTE QUERY
    //    ExecuteGroupQuery2(groupCardsBySuitQuery, "Number of cards based on suit:",
    //        "There are no cards with any suit in hand.");
    //    #endregion

    //    #region LINQ Statement 6  
    //    ///////////////////////////////////////////////////////////////////////////////////////////
    //    // 6. Research how to group by multiple values in the "group" clause in LINQ.            //
    //    //    Using playerHand.GetCards() method as the data source,                             //
    //    //    write a LINQ statement to group all Card objects based on their Face and Value.    //
    //    //        The query returns a new anonymous type that assigns the group's "Key.Face"     //
    //    //        property to "Face", the group's "Key.Value" property to "Value", and assigns   //
    //    //        the result of the group's "Count()" method to "Count".                         //
    //    //    Sort the results based on the anonymous type's Value (i.e., the "Key.Value"        //
    //    //        property).                                                                     //
    //    ///////////////////////////////////////////////////////////////////////////////////////////
    //    IEnumerable<dynamic> groupCardsByFaceAndValueQuery =
    //        from card in playerHand.GetCards()
    //        group card by new { card.Face, card.Value} into cardFaceAndValueGroup
    //        orderby cardFaceAndValueGroup.Key.Value
    //        select new {
    //            Face = cardFaceAndValueGroup.Key.Face,
    //            Value = cardFaceAndValueGroup.Key.Value,
    //            Count = cardFaceAndValueGroup.Count()
    //        };

    //    // UNCOMMENT TO EXECUTE QUERY
    //    ExecuteGroupQuery3(groupCardsByFaceAndValueQuery, "Number of cards based face and value:",
    //        "There are no cards with any face or value in hand.");
    //    #endregion
    //} // end method

    // Method is used to execute LINQ Statement 1, 2, and 3
    static void ExecuteCardQuery(IEnumerable<dynamic> cardArray, string header, string noResult) {
        // If any card objects are returns, execute query...
        if (cardArray.Any()) {
            Console.WriteLine($"\n{header}");
            foreach (Card card in cardArray) {
                Console.WriteLine($"  {card.ToLongString()}");
            } // end foreach
        } else {
            Console.WriteLine($"\n{noResult}");
        } // end if
    } // end method

    // Method is used to execute LINQ Statement 4
    static void ExecuteGroupQuery1(IEnumerable<dynamic> cardGroup, string header, string noResult) {
        // If any card objects are return, execute query...
        if (cardGroup.Any()) {
            Console.WriteLine($"\n{header}");
            foreach (var cardColor in cardGroup) {
                Console.WriteLine($"  {cardColor.Count} {cardColor.Color} " +
                    $"{(cardColor.Count == 1 ? "card" : "cards")}");
            } // end foreach
        } else {
            Console.WriteLine($"\n{noResult}");
        } // end if
    } // end method

    // Method is used to execute LINQ Statement 5
    static void ExecuteGroupQuery2(IEnumerable<dynamic> cardGroup, string header, string noResult) {
        // If any card objects are return, execute query...
        if (cardGroup.Any()) {
            Console.WriteLine($"\n{header}");
            foreach (var cardColor in cardGroup) {
                Console.WriteLine($"  {cardColor.Count} {cardColor.Suit} " +
                    $"{(cardColor.Count == 1 ? "card" : "cards")}");
            } // end foreach
        } else {
            Console.WriteLine($"\n{noResult}");
        } // end if
    } // end method

    // Method is used to execute LINQ Statement 6
    static void ExecuteGroupQuery3(IEnumerable<dynamic> cardGroup, string header, string noResult) {
        // If any card objects are return, execute query...
        if (cardGroup.Any()) {
            Console.WriteLine($"\n{header}");
            foreach (var cardFaceAndVal in cardGroup) {
                Console.WriteLine($"  {cardFaceAndVal.Count} {cardFaceAndVal.Face} " +
                    $"({cardFaceAndVal.Value}) " + $"{(cardFaceAndVal.Count == 1 ? "card" : "cards")}");
            } // end foreach
        } else {
            Console.WriteLine($"\n{noResult}");
        } // end if
    } // end method
} // end class