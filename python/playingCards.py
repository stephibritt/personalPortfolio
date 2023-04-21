#!/c/Users/steph/AppData/Local/Programs/Python/Python311/python.exe
# the location of the python.exe

#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  EDITED: 10/14/2021
#================================================================================#

class Card:
    def __init__(self, rank, color, suit, value):
        self.__rank = rank
        self.__color = color
        self.__suit = suit
        self.__value = value
    # end method

    def getRank(self):
        return self.__rank
    # end method

    def getColor(self):
        return self.__color
    # end method

    def getSuit(self):
        return self.__suit
    # end method

    def getValue(self):
        return self.__value
    # end method

    def __str__(self):
        return f"{self.getRank()} of {self.getSuit()}"
    # end method
# end class

class Deck:
    def __init__(self, numberOfShuffles):
        self.__cards = []

        self.__buildDeck()
        
        for i in range(numberOfShuffles):
            self.shuffle()
        # end for
    # end method

    # Accessors (getters)
    def getNumberOfCards(self):
        return len(self.__cards)
    # end get

    # Mutators (setters)
    def __buildDeck(self):
        value = 2

        for _ in range(13):

            if value >= 2 and value <= 10:
                rank = value
            elif value == 11:
                rank = "Jack"
            elif value == 12:
                rank = "Queen"
            elif value == 13:
                rank = "King"
            elif value == 14:
                rank = "Ace"
            # end if

            self.__cards.append(Card(rank, "Red", "Hearts", value))
            self.__cards.append(Card(rank, "Black", "Clubs", value))
            self.__cards.append(Card(rank, "Red", "Diamonds", value))
            self.__cards.append(Card(rank, "Black", "Spades", value))
            
            value += 1
        # end for
    # end method

    def shuffle(self):
        from random import shuffle

        return shuffle(self.__cards)
    # end method

    def drawCard(self):
        from random import choice

        if len(self.__cards) > 0:
            topCard = (self.__cards[-1])

            self.__cards.remove(topCard)

            return topCard
        else:
            raise Exception("No cards remain in the deck.")
        # end if
    # end method

    def __str__(self):
        return f"There are {self.getNumberOfCards()} cards remaining in the deck."
    # end method
# end class

def main():
    print(f"Playing Cards Test Program")
    
    while True:
        try:
            numberOfShuffles = int(input("\nEnter a number of times to shuffle the deck: "))
            
            while numberOfShuffles < 0:
                numberOfShuffles = int(input("\nA number of shuffles must be equal to or greater than zero: "))
            # end while

            break
        except:
            print("\nThe entered value must be a number.")
        # end try
    # end while

    myDeckObj = Deck(numberOfShuffles)

    print(f"\nA deck of {myDeckObj.getNumberOfCards()} was generated and shuffled {numberOfShuffles} times.")
    
    while True:
        try:
            cardsToDeal = int(input("\nHow many cards would you like to deal? "))
            
            while cardsToDeal <= 0:
                cardsToDeal = int(input("\nAt least one card must be dealt. Please enter a number of cards: "))
            # end while

            break
        except:
            print("\nThe entered value must be a number.")
        # end try
    # end while
    
    count = 1

    for _ in range(cardsToDeal):
        try:
            print(f"\nCard {count}: {myDeckObj.drawCard()}")
            print(f"    {myDeckObj}")

            count += 1
        except:
            break
        # end try
    # end for
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if