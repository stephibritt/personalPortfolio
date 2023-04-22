using System;

//Edited by: Stephen Britt
//     Date: 4/21/2023

class BMITest {
    static void Main() {
        Console.WriteLine("This program calculates your BMI and informs you of your weight category.");

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
    } // end method
} // end class