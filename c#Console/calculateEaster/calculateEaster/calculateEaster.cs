using Microsoft.VisualBasic;
using System;

//Edited by: Stephen Britt
//     Date: 4/24/2023

class calculateEaster {
	static void Main() {
        Console.WriteLine("This program calculates what day Easter falls on for a given year.");

        string repeat = "Y";

        while (repeat.ToUpper() == "Y") {
            int year;

            while (true) {
                try {
                    Console.Write("\nEnter a year to calculate the date of Easter: ");
                    year = int.Parse(Console.ReadLine());

                    while (year < 1) {
                        throw new Exception();
                    } // end while

                    break;
                } catch {
                    Console.WriteLine("\nA year must be a positive integer.");
                } // end try
            } // end while
            string easter = CalculateEasterDate(year);

            Console.WriteLine($"\nIn {year}, Easter falls on {easter}.");

            Console.Write("\nWould you like to calculate another Easter? (Y/n): ");
            repeat = Console.ReadLine();

            while (!(repeat.ToUpper() == "Y" || repeat.ToUpper() == "N")) {
                Console.WriteLine("\nPlease enter 'Y' to continue or 'N' to quit.");

                Console.Write("\nWould you like to calculate another Easter? (Y/n): ");
                repeat = Console.ReadLine();
            } // end while
        } // end while
    } // end method

    private static string CalculateEasterDate(double year) {
        // Anonymous Gregorian Computus algorithm 
        double a = year % 19;
        double b = Math.Floor(year / 100);
        double c = year % 100;
        double d = Math.Floor(b / 4);
        double e = b % 4;
        double f = Math.Floor((b + 8) / 25);
        double g = Math.Floor((b - f + 1) / 3);
        double h = (19 * a + b - d - g + 15) % 30;
        double i = Math.Floor(c / 4);
        double k = c % 4;
        double l = (32 + 2 * e + 2 * i - h - k) % 7;
        double m = Math.Floor((a + 11 * h + 22 * l) / 451);
        double month = Math.Floor((h + l - 7 * m + 114) / 31);
        double day = 1 + ((h + l - 7 * m + 114) % 31);

        string monthString;

        if (month == 3) {
            monthString = "March";
        } else {
            monthString = "April";
        } // end if

        string ordinalDay = ConvertToOrdinal(day);

        return $"{monthString} {ordinalDay}";
    } // end method

    private static string ConvertToOrdinal(double num) {
        string ordinalString;

        try {
            // truncate the day into an integer
            num = (int)num;

            // ensure that the value is positive
            num = Math.Abs(num);
        } catch {
            throw new Exception("An error occurred while converting the value to a positive integer.");
        } // end try

        double testVal = Math.Truncate((num % 100) / 10);

        if (testVal != 1) {
            if ((num % 10) == 1) {
                ordinalString = $"{num}st";
            } else if (num % 10 == 2) {
                ordinalString = $"{num}nd";
            } else if (num % 10 == 3) {
                ordinalString = $"{num}rd";
            } else {
                ordinalString = $"{num}th";
            } // end if
        } else {
            ordinalString = $"{num}th";
        } // end if

        return ordinalString;
    } // end method
} // end class 