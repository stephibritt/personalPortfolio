using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SavingsAccount : BankAccount { 
    // class member variables
    private decimal m_interestRate;
    private const int MONTHS_IN_YEAR = 12;

    // class properties
    public decimal InterestRate {
        get {
            return m_interestRate;
        } // end get

        set {
            if (value < 0) {
                throw new Exception($"Invalid rate: the interest rate cannot be less than zero.");
            } else {
                m_interestRate = value;
            }
        } // end set
    } // end property

    // class constructor
    public SavingsAccount(decimal initialBalance, decimal interestRate) : 
                            base(initialBalance) {
        if (interestRate < 0) {
            throw new Exception($"Invalid rate: a savings account's interest rate cannot be less than zero.");
        } else {
            this.InterestRate = interestRate;
        } // end if
    } // end constructor

    // class methods
    public decimal CalculateMonthlyInterest() {
        decimal interestAmount = (this.InterestRate / MONTHS_IN_YEAR) * base.Balance;

        if (!base.Deposit(interestAmount)) {
            throw new Exception("There was an error compounding the interest.");
        } else {
            return interestAmount;
        } // end if
    } // end method

    public decimal CalculateAnnualInterest() {
        decimal interestAmount = (this.InterestRate) * base.Balance;

        if (!base.Deposit(interestAmount)) {
            throw new Exception("There was an error compounding the interest.");
        } else {
            return interestAmount;
        } // end if
    } // end method

    public override string ToString() {
        return $"Savings {base.ToString().ToLower()}\n" +
               $"{"Interest rate:", -24} {this.InterestRate:P2}";
    } // end method
} // end class