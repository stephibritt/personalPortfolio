using System;
class BankAccountTest {
    static void Main() {
        //Console.WriteLine("Successful test of SavingsAccount object with a deposit and a withdrawal.");
        //Console.WriteLine("Create a savings account with an initial balance of $1,000.00 and an interest rate of 5%.");
        //SavingsAccount sa1 = new SavingsAccount(1000.00m, 0.05m);
        //Console.WriteLine($"Savings account balance: {sa1.Balance:C}");
        //Console.WriteLine($"Savings account interest rate: {sa1.InterestRate:P}");
        //Console.WriteLine("Deposit $500.00 into savings account.");
        //sa1.Deposit(500.00m);
        //Console.WriteLine($"Savings account balance: {sa1.Balance:C}");
        //Console.WriteLine("Withdraw $250.00 from savings account.");
        //sa1.Withdraw(250.00m);
        //Console.WriteLine($"Savings account balance: {sa1.Balance:C}");
        //Console.WriteLine("Calculate monthly interest.");
        //Console.WriteLine($"Savings account interest for this month: {sa1.CalculateInterest():C}");
        //Console.WriteLine($"Savings account balance: {sa1.Balance:C}");
        //Console.WriteLine("\nSuccessful test of CheckingAccount object with a deposit and a withdrawal.");
        //Console.WriteLine("Create a checking account with an initial balance of $1,000.00 and withdrawal transaction fee of $1.50.");
        //CheckingAccount ca1 = new CheckingAccount(1000.00m, 1.50m);
        //Console.WriteLine($"Checking account balance: {ca1.Balance:C}");
        //Console.WriteLine($"Checking account transaction fee: {ca1.TransactionFee:C}");
        //Console.WriteLine("Deposit $500.00 into checking account.");
        //ca1.Deposit(500.00m);
        //Console.WriteLine($"Checking account balance: {ca1.Balance:C}");
        //Console.WriteLine("Withdraw $250.00 from checking account.");
        //ca1.Withdraw(250.00m);
        //Console.WriteLine($"Checking account balance: {ca1.Balance:C}");
        //Console.WriteLine("\nUnsuccessful test of SavingsAccount object.");
        //Console.WriteLine("Create a savings account with an initial balance of -$1,000.00 and an interest rate of 0%.");
        //try {
        //    SavingsAccount sa2 = new SavingsAccount(-1000.00m, 0.00m);
        //} catch (Exception ex) {
        //    Console.WriteLine(ex.Message);
        //} // end try
        //Console.WriteLine("\nUnsuccessful test of SavingsAccount object.");
        //Console.WriteLine("Create a savings account with an initial balance of $1,000.00 and an interest rate of -5%.");
        //try {
        //    SavingsAccount sa2 = new SavingsAccount(1000.00m, -0.05m);
        //} catch (Exception ex) {
        //    Console.WriteLine(ex.Message);
        //} // end try
        //Console.WriteLine("\nUnsuccessful test of CheckingAccount object.");
        //Console.WriteLine("Create a checking account with an initial balance of -$1,000.00 and a transaction fee of $0.");
        //try {
        //    CheckingAccount sa2 = new CheckingAccount(-1000.00m, 0.00m);
        //} catch (Exception ex) {
        //    Console.WriteLine(ex.Message);
        //} // end try
        //Console.WriteLine("\nUnsuccessful test of CheckingAccount object.");
        //Console.WriteLine("Create a checking account with an initial balance of $1,000.00 and a transaction fee of -$1.50.");
        //try {
        //    CheckingAccount sa2 = new CheckingAccount(1000.00m, -1.50m);
        //} catch (Exception ex) {
        //    Console.WriteLine(ex.Message);
        //} // end try
        //Console.WriteLine("\nSuccessful test of SavingsAccount object with an unsuccessful deposit.");
        //Console.WriteLine("Create a savings account with an initial balance of $1,000.00 and an interest rate of 5%.");
        //SavingsAccount sa3 = new SavingsAccount(1000.00m, 0.05m);
        //Console.WriteLine($"Savings account balance: {sa3.Balance:C}");
        //Console.WriteLine($"Savings account interest rate: {sa3.InterestRate:P}");
        //Console.WriteLine("Deposit -$500.00 into savings account.");
        //try {
        //    sa3.Deposit(-500.00m);
        //} catch (Exception ex) {
        //    Console.WriteLine(ex.Message);
        //} // end try
        //Console.WriteLine($"Savings account balance: {sa3.Balance:C}");
        //Console.WriteLine("\nSuccessful test of SavingsAccount object with an unsuccessful withdrawal.");
        //Console.WriteLine("Create a savings account with an initial balance of $1,000.00 and an interest rate of 5%.");
        //SavingsAccount sa4 = new SavingsAccount(1000.00m, 0.05m);
        //Console.WriteLine($"Savings account balance: {sa4.Balance:C}");
        //Console.WriteLine($"Savings account interest rate: {sa4.InterestRate:P}");
        //Console.WriteLine("Withdraw $2,000.00 from savings account.");
        //try {
        //    sa4.Withdraw(2000.00m);
        //} catch (Exception ex) {
        //    Console.WriteLine(ex.Message);
        //} // end try
        //Console.WriteLine($"Savings account balance: {sa4.Balance:C}");
        //Console.WriteLine("\nSuccessful test of CheckingAccount object with an unsuccessful deposit.");
        //Console.WriteLine("Create a checking account with an initial balance of $1,000.00 and a transaction fee of 5%.");
        //CheckingAccount ca3 = new CheckingAccount(1000.00m, 1.50m);
        //Console.WriteLine($"Checking account balance: {ca3.Balance:C}");
        //Console.WriteLine($"Checking account transaction fee: {ca3.TransactionFee:C}");
        //Console.WriteLine("Deposit -$500.00 into checking account.");
        //try {
        //    ca3.Deposit(-500.00m);
        //} catch (Exception ex) {
        //    Console.WriteLine(ex.Message);
        //} // end try
        //Console.WriteLine($"Checking account balance: {ca3.Balance:C}");
        //Console.WriteLine("\nSuccessful test of CheckingAccount object with an unsuccessful withdrawal.");
        //Console.WriteLine("Create a checking account with an initial balance of $1,000.00 and a transaction fee of 5%.");
        //CheckingAccount ca4 = new CheckingAccount(1000.00m, 1.50m);
        //Console.WriteLine($"Checking account balance: {ca4.Balance:C}");
        //Console.WriteLine($"Checking account transaction fee: {ca4.TransactionFee:C}");
        //Console.WriteLine("Withdraw $1,500.00 from checking account.");
        //try {
        //    ca4.Withdraw(1500.00m);
        //} catch (Exception ex) {
        //    Console.WriteLine(ex.Message);
        //} // end try
        //Console.WriteLine($"Checking account balance: {ca4.Balance:C}");

        // testing of a savings account.
        const int MONTHS_IN_YEAR = 12;
        decimal balance;
        decimal interestRate;
        int years;
        decimal monthlyDeposit;
        decimal annualDeposit;

        while (true) {
            try {
                Console.Write("Initial Balance: ");
                if (decimal.TryParse(Console.ReadLine(), out balance) && balance >= 0) {

                } else {
                    throw new Exception("Invalid initial balance. An initial balance must be greater than or equal to zero.");
                } // end if

                break;
            } catch (Exception ex) {
                Console.WriteLine($"{ex.Message}\n");
            } // end try
        } // end while

        while (true) {
            try {
                Console.Write("Interest Rate: ");
                if (decimal.TryParse(Console.ReadLine(), out interestRate) && interestRate >= 0) {
                    interestRate /= 100m; // to convert the interest rate to its decimal equivalent
                } else {
                    throw new Exception("Invalid initial balance. An initial balance must be greater than or equal to zero.");
                } // end if

                break;
            } catch (Exception ex) {
                Console.WriteLine($"{ex.Message}\n");
            } // end try
        } // end while

        while (true) {
            try {
                Console.Write("Monthly Deposit: ");
                if (decimal.TryParse(Console.ReadLine(), out monthlyDeposit) && interestRate >= 0) {
                    annualDeposit = monthlyDeposit * MONTHS_IN_YEAR; 
                } else {
                    throw new Exception("Invalid initial balance. An initial balance must be greater than or equal to zero.");
                } // end if

                break;
            } catch (Exception ex) {
                Console.WriteLine($"{ex.Message}\n");
            } // end try
        } // end while

        while (true) {
            try {
                Console.Write("Years: ");
                if (int.TryParse(Console.ReadLine(), out years) && years > 0) {

                } else {
                    throw new Exception("Invalid initial balance. An initial balance must be greater than or equal to zero.");
                } // end if

                break;
            } catch (Exception ex) {
                Console.WriteLine($"{ex.Message}\n");
            } // end try
        } // end while

        SavingsAccount testAccount = new SavingsAccount(balance, interestRate);

        Console.WriteLine($"With a starting balance of {balance:C}, over {years} years " +
        $"the interest will compound as follows with an interest rate of {interestRate:P} and with a monthly deposit of {monthlyDeposit:C}.\n");

        

        for (int i = 0; i <= years; i++) {
            Console.WriteLine($"Year: {i,-8}Balance: {testAccount.Balance:C}");

            testAccount.CalculateAnnualInterest();
            testAccount.Deposit(annualDeposit);
        } // end for
    } // end method
} // end class