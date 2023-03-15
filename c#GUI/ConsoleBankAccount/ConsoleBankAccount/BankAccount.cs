using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

class BankAccount {
    // class member variables
    private decimal m_balance;

    // class properties
    public decimal Balance {
        get {
            return m_balance;
        } // end get

        private set {
            if (value < 0) {
                throw new Exception("Invalid balance: an account's initial balance cannot be less than zero.");
            } else {
                m_balance = value;
            } // end if
        } // end set
    } // end property

    // class constructor
    public BankAccount(decimal initialBalance = 0.0m) {
        if (initialBalance < 0) {
            throw new Exception("Invalid balance: an account's initial balance cannot be less than zero.");
        } else {
            this.Balance = initialBalance;
        } // end if
    } // end constructor

    // class methods
    public bool Deposit(decimal amount) {
        if (amount < 0) {
            throw new Exception("Invalid amount: an account deposit cannot be less than zero.");
        } else {
            try {
                this.Balance += amount;
                return true;
            } catch {
                return false;
            } // end try
        } // end if
    } // end method

    public virtual bool Withdraw(decimal amount) {
        if (amount >= this.Balance) {
            throw new Exception($"Invalid amount: an account withdrawal cannot be greater than or equal to its balance ({this.Balance:C}).");
        } else {
            try {
                this.Balance -= amount;
                return true;
            } catch {
                return false;
            } // end try
        } // end if
    } // end method

    public override string ToString() {
        return $"Account balance: {this.Balance:C}";
    } // end method
} // end class