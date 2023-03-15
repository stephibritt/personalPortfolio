using System;

//Edited by: Stephen Britt
//     Date: 2/5/2022

class PrimesTest {
    static void Main() {
        Console.WriteLine("Prime Number Operations");
        Console.WriteLine("Enter the number of the operation to perform that operation.\n");

        Primes primeNumber = new Primes();

        // making a menu
        Console.WriteLine("Operations");
        Console.WriteLine("1: Check if number is prime");
        Console.WriteLine("2: View first x prime numbers");
        Console.WriteLine("3: View all prime numbers in a range of numbers");
        Console.WriteLine("4: View xth prime number");
        Console.WriteLine("5: Exit");

        Console.Write("\nChoice: ");
        int choice = int.Parse(Console.ReadLine());
        while (choice < 1 || choice > 5) {
            Console.Write("Enter a choice between 1 and 5: ");
            choice = int.Parse(Console.ReadLine());
        } // end while

        switch (choice) {
            case 1: // user chose 1
                Console.WriteLine("\nOperation 1: Check if number is prime");

                Console.Write("Enter a non-negative integer value: ");
                int numberToTest = int.Parse(Console.ReadLine());
                while (numberToTest < 0) {
                    Console.WriteLine("The specified value cannot be negative.");
                    Console.Write("Enter a non-negative integer value: ");
                    numberToTest = int.Parse(Console.ReadLine());
                } // end while

                if (primeNumber.IsPrime(numberToTest) == true) {
                    Console.WriteLine($"\n{numberToTest} is a prime number.");
                } else {
                    Console.WriteLine($"\n{numberToTest} is not a prime number.");
                } // end if              

                break;
            case 2: // user chose 2
                Console.WriteLine("\nOperation 2: View first x prime numbers");

                Console.Write("Enter a non-negative integer value: ");
                int numberOfPrimes = int.Parse(Console.ReadLine());
                while (numberOfPrimes < 0) {
                    Console.WriteLine("The specified value cannot be negative.");
                    Console.Write("Enter a non-negative integer value: ");
                    numberOfPrimes = int.Parse(Console.ReadLine());
                } // end while

                Console.WriteLine($"\nFirst {numberOfPrimes} prime numbers: {primeNumber.GetPrimes(numberOfPrimes)}");

                break;
            case 3: // user choice 3
                Console.WriteLine("\nOperation 3: View all prime numbers in a range of numbers");

                Console.Write("Enter a non-negative integer value for the beginning range: ");
                long startRange = long.Parse(Console.ReadLine());
                while (startRange < 0) {
                    Console.WriteLine("The specified value cannot be negative.");
                    Console.Write("Enter a non-negative integer value: ");
                    startRange = long.Parse(Console.ReadLine());
                } // end while

                Console.Write("Enter a non-negative integer value for the ending range: ");
                long endRange = long.Parse(Console.ReadLine());
                while (endRange < 0) {
                    Console.WriteLine("The specified value cannot be negative.");
                    Console.Write("Enter a non-negative integer value: ");
                    endRange = long.Parse(Console.ReadLine());
                } // end while
                while (endRange < startRange) {
                    Console.WriteLine("The ending value cannot be less than the starting value.");
                    Console.Write("Enter a non-negative integer value: ");
                    endRange = long.Parse(Console.ReadLine());
                } // end while

                Console.WriteLine($"\nPrime numbers between {startRange} and {endRange}: {primeNumber.GetPrimes(startRange, endRange)}");
                break;
            case 4:
                Console.WriteLine("\nOperation 4: View xth prime number");

                Console.Write("Enter an integer value greater than zero: ");
                short primeToGet = short.Parse(Console.ReadLine());
                while (primeToGet <= 0) {
                    Console.WriteLine("The specified value must be more than zero.");
                    Console.Write("Enter an integer value greater than zero: ");
                    primeToGet = short.Parse(Console.ReadLine());
                } // end while

                string ordinalString = primeToGet.ToString();

                if (ordinalString.Substring(ordinalString.Length - 1) == "1") {
                    Console.WriteLine($"\n{primeNumber.GetSpecificPrime(primeToGet)} is the {primeToGet}st prime number.");
                } else if (ordinalString.Substring(ordinalString.Length - 1) == "2") {
                    Console.WriteLine($"\n{primeNumber.GetSpecificPrime(primeToGet)} is the {primeToGet}nd prime number.");
                } else if (ordinalString.Substring(ordinalString.Length - 1) == "3") {
                    Console.WriteLine($"\n{primeNumber.GetSpecificPrime(primeToGet)} is the {primeToGet}rd prime number.");
                } else {
                    Console.WriteLine($"\n{primeNumber.GetSpecificPrime(primeToGet)} is the {primeToGet}th prime number.");
                } // end if

                break;
            default: // catch all
                break;
        } // end switch        
    } // end method
} // end class