#================================================================================#
#  AUTHOR: Stephen Britt 
#  E-MAIL: sdbritt@senators.ws.edu
#  EDITED: 02/08/2022
#================================================================================#
from random import * 

class Card:
    def __init__(self, rank, color, suit, value):
        self.__rank = ""
        self.__color = ""
        self.__suit = ""
        self.__value = 0
        
        self.setRank(rank)
        self.setColor(color)
        self.setSuit(suit)
        self.setValue(value)
    
    # Accessors 
    def getRank(self): return self.__rank
    def getColor(self): return self.__color
    def getsuit(self): return self.__suit 
    def getValue(self): return self.__value

    def setRank(self, rank):
        if len(rank) >= 1:
            self.__rank = rank
        else:
            raise Exception("A Rank as to be one or more characters.")

    def setColor(self, color):
            if len(color) >= 1:
                self.__color = color
            else:
                raise Exception("A color as to be one or more characters.")

    def setSuit(self, suit):
            self.__suit = suit
    
    def setValue(self, value):
        if value >= 2:
            self.__value = value
        else:
            raise Exception("A Vaule as to be one or more characters.")

    def __str__(self):
        return f"{self.__rank} of {self.__suit}"

class Deck:
    def __init__(self):
        self.__cards = []

        self.__buildDeck()
        self.shuffle()
    
    def __buildDeck(self): 
        for color in range(1,3):
            if color == 1:
                color = "Red"
                for suits in range(1, 3): 
                    if suits == 1 : 
                        suits = "Spades"
                        for value in range(2,15):
                                if value <= 10: 
                                    rank =  str(value)
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 11: 
                                    rank = "Jack"
                                    self.__cards.append(Card(rank, color, suits, value))                               
                                elif value == 12:
                                    rank = "Queen"
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 13:
                                    rank = "King"
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 14:
                                    rank = "Ace" 
                                    self.__cards.append(Card(rank, color, suits, value))
                    else: 
                        suits = "Clubs"
                        for value in range(2,15):
                                if value <= 10: 
                                    rank =  str(value)
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 11: 
                                    rank = "Jack"
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 12:
                                    rank = "Queen"
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 13:
                                    rank = "King"
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 14:
                                    rank = "Ace" 
                                    self.__cards.append(Card(rank, color, suits, value))
            else: 
                color = "Black"
                for suits in range(1,3): 
                    if suits == 1: 
                        suits = "Hearts"
                        for value in range(2,15):
                                if value <= 10: 
                                    rank =  str(value)
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 11: 
                                    rank = "Jack"
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 12:
                                    rank = "Queen"
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 13:
                                    rank = "King"
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 14:
                                    rank = "Ace" 
                                    self.__cards.append(Card(rank, color, suits, value))                        
                    else: 
                        suits = "Diamonds"
                        for value in range(2,15):
                                if value <= 10: 
                                    rank =  str(value)
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 11: 
                                    rank = "Jack"
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 12:
                                    rank = "Queen"
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 13:
                                    rank = "King"
                                    self.__cards.append(Card(rank, color, suits, value))
                                elif value == 14:
                                    rank = "Ace" 
                                    self.__cards.append(Card(rank, color, suits, value))

    def shuffle(self): 
        return shuffle(self.__cards)
    
    def drawCard(self):
        if len(self.__cards) > 0:
            thisCard = self.__cards[-1]

            self.__cards.remove(thisCard)

            return thisCard

    def __str__(self):
        return(f"There are {len(self.__cards)} cards remaining in the deck")



def main():
    print("Playing Cards Test Program\n")

    myDeck = Deck()
    
    for cards in range(1,11):
        print(f"Card {cards}: {myDeck.drawCard()}")
        print(myDeck)


if __name__ == "__main__":
    main()