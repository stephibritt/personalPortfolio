using System;

//Edited by: Stephen Britt
//     date: 2/02/2022

class HeartRateTest {
    static void Main() {

        // output program purpose
        Console.WriteLine("Target Heart-Rate Calculator");
        Console.WriteLine("\nAnswer the following questions to determine your safe heart rate for exercising.");

        string repeat = "Y";
        while (repeat == "Y") {
            // User input for name with validation
            string name = "";
        
            while (true) {
                try {
                    Console.Write("\nWhat is your name? ");
                    name = Console.ReadLine();

                    if (name == string.Empty) {
                        throw new Exception();
                    } // end if

                    break;
                } catch (Exception) {
                    Console.WriteLine("Invalid name: a name must have one or more characters.");
                } // end try
            } // end while

            // User input for year of birth with validation
            string birthYearString = "";
            int birthYear = 0;

            while (true) {
                try {
                    Console.Write("\nWhat is your birth year? ");
                    birthYearString = Console.ReadLine();

                    if (birthYearString.Length != 4) {
                        throw new Exception();
                    } else {
                        birthYear = int.Parse(birthYearString);
                    } // end if

                    if (birthYear < (DateTime.Now.Year - 125) || birthYear > DateTime.Now.Year - 1) {
                        throw new Exception();
                    }

                    break;
                } catch (Exception) {
                    Console.WriteLine("Invalid birth year: a birth year must be 4 digits, less than the current year, and reasonable.");
                } // end try
            } // end while

            // instantiate the class
            HeartRate userHeartRate = new HeartRate(name, birthYear);

            // output calculations
            Console.WriteLine($"\nHeart Rate Information for {name}:");
            Console.WriteLine($"\t{"Age:",-30}{userHeartRate.GetAge()} years old");
            Console.WriteLine($"\t{"Maximum heart rate:",-30}{userHeartRate.GetMaxHeartRate()} beats/minute");
            Console.WriteLine($"\t{"Minimum target heart rate:",-30}{userHeartRate.GetMinTargetHeartRate():F0} beats/minute");
            Console.WriteLine($"\t{"Maximum target heart rate:",-30}{userHeartRate.GetMaxTargetHeartRate():F0} beats/minute");

            // does the user wish to do another calculation
            Console.Write("\nWould you like to calculate another target heart rate? (Y/n): ");
            repeat = Console.ReadLine().ToUpper();
            while (!(repeat == "Y" || repeat == "N")) {
                Console.WriteLine("\nEnter 'Y' to perform another calculation or 'N' to exit.");
                Console.Write("Would you like to calculate another target heart rate? (Y/n): ");
                repeat = Console.ReadLine().ToUpper();
            } // end while
        } // end while        
    } // end method
} // end class