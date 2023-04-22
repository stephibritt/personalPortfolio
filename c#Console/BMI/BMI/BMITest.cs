using System;

//Edited by: Stephen Britt
//     Date: 4/21/2023

class BMITest {
    static void Main() {
        Console.WriteLine("This program calculates your BMI and informs you of your weight category.");

        string repeat = "Y";

        while (repeat.ToUpper() == "Y") {
            BMI bmi = new BMI();

            while (true) {
                try {
                    Console.Write("\nPlease enter your weight in pounds: ");
                    bmi.UserWeightInPounds = double.Parse(Console.ReadLine());

                    break;
                } catch {
                    Console.WriteLine("\nA user weight must be a positive number.");
                } // end try
            } // end while

            while (true) {
                try {
                    Console.Write("\nPlease enter your height in inches: ");
                    bmi.UserHeightInInches = double.Parse(Console.ReadLine());

                    break;
                } catch {
                    Console.WriteLine("\nA user height must be a positive number.");
                } // end try
            } // end while

            Console.WriteLine($"\n{bmi}");

            Console.Write("\nWould you like to calculate another person's BMI? (Y/n): ");
            repeat = Console.ReadLine();

            while (!(repeat.ToUpper() == "Y" || repeat.ToUpper() == "N")) {
                Console.WriteLine("\nPlease enter 'Y' to continue or 'N' to quit.");

                Console.Write("\nWould you like to calculate another person's BMI? (Y/n): ");
                repeat = Console.ReadLine();
            } // end while
        } // end while
    } // end method
} // end class