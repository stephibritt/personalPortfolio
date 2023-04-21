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
        return f"{self.__rank} of {self.__suit}"
    # end method
# end class

class Deck:
    def __init__(self):
        self.__cards = []

        self.__buildDeck()

        self.shuffle()
    # end method

    # Mutator Methods

    def __buildDeck(self):
        value = 2
        rank = value
        
        for value in range(13):
            value += 1

            if value >= 2 and value <= 10:
                rank = value
            elif value == 11:
                rank = "Jack"
            elif value == 12:
                rank = "Queen"
            elif value == 13:
                rank = "King"
            else: # value == 14:
                rank = "Ace"
            # end if

            self.__cards.append(Card(rank, "Black", "Spades", value))
            self.__cards.append(Card(rank, "Red", "Diamonds", value))
            self.__cards.append(Card(rank, "Black", "Clubs", value))
            self.__cards.append(Card(rank, "Red", "Hearts", value))
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
    # end method

    def __str__(self):
        return f"There are {len(self.__cards)} cards remaining in the deck."
    # end method
# end class

def main():
    print("Playing Cards Test Program\n")
    
    count = 1
    myDeckObj = Deck()
    for _ in range(10):
        print(f"Card {count}: {myDeckObj.drawCard()}")
        print(f"  {myDeckObj}")
        count += 1
    # end for
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if