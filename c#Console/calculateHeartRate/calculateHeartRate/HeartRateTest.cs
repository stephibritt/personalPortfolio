using System;

//Edited by: Stephen Britt
//     date: 4/24/2023

class HeartRateTest {
    static void Main() {
        // output program purpose
        Console.WriteLine("Target Heart-Rate Calculator");
        Console.WriteLine("\nWARNING: This calculation should not be used to make medical decisions.\n" +
            "Always consult a physician or qualified health professional before beginning or modifying an exercise program.");
        Console.WriteLine("\nAnswer the following questions to determine your safe heart rate for exercising.");

        string repeat = "Y";

        while (repeat.ToUpper() == "Y") {
            string name = "Not Given";
            int birthYear = DateTime.Now.Year - 1;

            // instantiate the class
            HeartRate userHeartRate = new HeartRate(name, birthYear);

            while (true) {
                try {
                    Console.Write("\nWhat is your name? ");
                    name = Console.ReadLine();

                    userHeartRate.Name = name;

                    break;
                } catch (Exception ex) {
                    Console.WriteLine($"\n{ex.Message}");
                } // end try
            } // end while

            while (true) {
                try {
                    Console.Write("\nWhat is your birth year? ");
                    birthYear = int.Parse(Console.ReadLine());

                    userHeartRate.BirthYear = birthYear;

                    break;
                } catch (FormatException ex) {
                    Console.WriteLine($"\nA year must be an integer.");
                } catch (Exception ex) {
                    Console.WriteLine($"\n{ex.Message}");
                } // end try
            } // end while

            // output calculations
            Console.WriteLine($"{userHeartRate}");

            Console.Write("\nWould you like to calculate another person's target heart rate? (Y/n): ");
            repeat = Console.ReadLine();

            while (!(repeat.ToUpper() == "Y" || repeat.ToUpper() == "N")) {
                Console.WriteLine("\nPlease enter 'Y' to continue or 'N' to quit.");

                Console.Write("\nWould you like to calculate another person's target heart rate? (Y/n): ");
                repeat = Console.ReadLine();
            } // end while
        } // end while
    } // end method
} // end class