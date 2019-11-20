from Account import Account
from Deck import Deck

# Check for Ace card. If Ace, prompt if user wants
# it to be a 1 or 11. If not, return card value.
def check_for_ace(card):
    if card.name == "Ace":
        while True:
            value = int(input("Would you like that to be a 1 or 11? "))
            if (value == 1 or value == 11):
                card.value = value
                break
            else:
                print("Please enter a 1 or 11.")
    return card.value

# Draw card from deck and return the value.
def draw_card(deck):
    card = deck.popCard()
    print(f"Card: {card}")
    card.value = check_for_ace(card)
    return card.value


# Get the bet from the player at the start of the match.
def get_bet(player):
    while True:
        try:
            print(f"Player's current balance: ${player.balance}")
            bet = int(input(f"What's your bet? "))
        except ValueError:
            print("Please enter a number.")
        else:
            if (bet < 0):
                print("Please enter a positive number.")
            elif (bet > player.balance):
                print("That bet is greater than your balance. Try again.")
            else:
                return bet

# Ask the player (assuming player has enough money) if we wants to play again or not.
def prompt_to_play_again(player):
    if (player.balance <= 0):
        print("You're bankrupt! Goodbye...")
        return False
    else:
        playAgain = input("\nWant to play again (y/n)? ")
        if playAgain.lower() == "n":
            print(f"Thanks for playing! Here is your ending balance: {player.balance}")
            return False
        else:
            return True

def player_wins(player, bet):
    player.deposit(bet)
    print(f"Player wins! Balance: {player.balance}")

def player_busts(player, bet):
    player.withdraw(bet)
    print(f"Player loses! Balance: {player.balance}")

def dealer_wins(player, bet):
    player.deposit(bet)
    print(f"Dealer loses! Balance: {player.balance}")

def dealer_busts(player, bet):
    player.withdraw(bet)
    print(f"Dealer wins! Balance: {player.balance}")


player = Account()
playing = True

while playing:
    deck = Deck() # instantiate new deck
    deck.shuffleDeck() # shuffle new deck
    
    # reset player and dealer card value sums
    playerSum = 0
    dealerSum = 0

    bet = get_bet(player) # get bet from player
    
    playerSum += draw_card(deck) # draw first card
    playerSum += draw_card(deck) # draw second card

    # Cycle through endlessly until player busts or passes.
    while True:
        print(f"Player sum: {playerSum}")

        # Get "hit" or "pass" input
        while True:
            response = input("Hit or pass? ")
            response.lower()
            if (response == "hit" or response == "pass"):
                break
        
        # Hit logic
        if (response == "hit"):
            playerSum += draw_card(deck)
        
        # Determine if player has won or lost out-right by hitting 21 or busting...
        if playerSum == 21:
            player_wins(player, bet)
            break
        elif playerSum > 21:
            player_busts(player, bet)
            break
        
        # Break from loop if pass is inputted
        if (response == "pass"):
            break

    # If the player hasn't busted yet, play the dealer.
    if (playerSum < 21):
        print("\nDealers turn!")
        while (dealerSum < 17):
            card = deck.popCard()
            print(f"Card: {card}")
            if (card.name == "Ace"):
                if (dealerSum < 11):
                    dealerSum += 11
                else:
                    dealerSum += 1
            else:
                dealerSum += card.value
            print(f"Dealer sum: {dealerSum}")
        
            
        if dealerSum > 21 or dealerSum < playerSum:
            dealer_wins(player, bet)
        elif dealerSum == 21 or dealerSum > playerSum:
            dealer_busts(player, bet)
        else:
            print("It's a draw! Money was not gained nor lost.")
        
    
    playing = prompt_to_play_again(player)

        


    
    
    




