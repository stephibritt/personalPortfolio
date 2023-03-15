using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckingAccount : BankAccount {
    // class member variables
    private decimal m_transactionFee;

    // class properties
    public decimal TransactionFee {
        get {
            return m_transactionFee;
        } // end get

        set {
            if (value < 0) {
                throw new Exception("Invalid fee: an account's transaction fee cannot be less than zero.");
            } else {
                m_transactionFee = value;
            }
        } // end set
    } // end property

    // class constructor
    public CheckingAccount(decimal initialBalance, decimal transactionFee) :
                            base(initialBalance) {
        if (transactionFee < 0) {
            throw new Exception("Invalid fee: a checking account's transaction fee cannot be less than zero.");
        } else {
            this.TransactionFee = transactionFee;
        } // end if
    } // end constructor

    // class methods
    public override bool Withdraw(decimal amount) {
        if ((amount + this.TransactionFee) >= this.Balance) {
            throw new Exception($"Invalid amount: an account withdrawal - plus the transaction fee - cannot be greater than or equal to its balance ({this.Balance:C}).");
        } else {
            try {
                base.Withdraw(amount + TransactionFee);
                return true;
            } catch {
                return false;
            } // end try
        } // end if
    } // end method

    public override string ToString() {
        return $"Checking {base.ToString().ToLower()}\n" +
               $"{"Transaction fee:", -25} {this.TransactionFee:C}";
    } // end method
} // end class