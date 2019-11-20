'''
    "Account.py" - Sets up a simple deposit-withdrawl account system
    for someone.
'''

class Account():
    def __init__(self):
        self.balance = 1000
    
    def withdraw(self, amount):
        if (amount > self.balance or amount < 0):
            return False
        else:
            self.balance -= amount
            return True

    def deposit(self, amount):
        if amount < 0:
            return False
        else:
            self.balance += amount
            return True

    def __str__(self):
        return f"Current balance: ${self.balance}"


if __name__ ==  "__main__":
    acc = Account()
    acc.withdraw(500)
    print(acc)
    acc.deposit(700)
    print(acc)