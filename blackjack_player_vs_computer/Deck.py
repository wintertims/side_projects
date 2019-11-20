'''
    "Deck.py" - contains a "Deck" and "Card" class. When a new deck is made, 
    the deck will be filled with 52 unique "Card" class objects. Each card 
    contains a "name", "value", and "suit" attribute. An example of a card:

    "card.name = "Jack"
    "card.value = "10"
    "card.suit" = "Diamonds"

    A deck class has the ability to be shuffled by calling deck.shuffle().
'''
from random import shuffle

SUITS = ["Hearts", "Diamonds", "Spades", "Clubs"]
VALUES = {
    "Ace": "1 or 11",
    "1": 1,
    "2": 2,
    "3": 3,
    "4": 4,
    "5": 5,
    "6": 6,
    "7": 7,
    "8": 8,
    "9": 9,
    "Jack": 10,
    "Queen": 10,
    "King": 10
}

class Deck():
    def __init__(self):
        self.deck = self.createDeck()
        
    def createDeck(self):
        deck = []
        for s in SUITS:
            for n, v in VALUES.items():
                deck.append(Card(s, n, v))
        return deck

    def shuffleDeck(self):
        shuffle(self.deck)

    def popCard(self):
        return self.deck.pop()

    def printDeck(self):
        for card in self.deck:
            index = str(self.deck.index(card) + 1)
            print(f"Card #{index} - {card}")



class Card():
    def __init__(self, suit, name, value):
        self.suit = suit
        self.name = name
        self.value = value

    def __str__(self):
        return f"{self.name} of {self.suit} with a value of {str(self.value)}."
    

if __name__ == "__main__":
    deck = Deck()
    deck.shuffleDeck()
    deck.printDeck()