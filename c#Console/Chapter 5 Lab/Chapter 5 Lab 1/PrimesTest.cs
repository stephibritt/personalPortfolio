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
        Console.WriteLine("3: Exit");

        Console.Write("\nChoice: ");
        int choice = int.Parse(Console.ReadLine());
        while (choice < 1 || choice > 3) {
            Console.WriteLine("Enter a choice between 1 and 3.");
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
            default: // catch all
                break;
        } // end switch        
    } // end method
} // end class