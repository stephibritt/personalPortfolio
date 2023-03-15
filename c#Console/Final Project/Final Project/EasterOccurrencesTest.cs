using System;
using System.Linq;
using System.Collections.Generic;

class EasterOccurrencesTest {
    static void Main() {
        // output program purpose
        Console.WriteLine("Easter Occurrences");
        Console.WriteLine("This program outputs a bar graph of what days Easter occurs on for a given range of years.\n");
        Console.WriteLine("Enter a starting and ending year to show which days Easter falls within that range.");

        string repeat = "Y";
        while (repeat == "Y") {
            // variable instantiations for each iteration of the calculation
            // these variables will be garbage collected with the end of each loop
            int startYear;
            int endYear;
            List<DateTime> listOfDates = new List<DateTime>();
            List<int> occurrenceArrayList = new List<int>();
            List<DateTime> dateArrayList = new List<DateTime>();
            int[] occurrenceArray;
            DateTime[] dateArray;

            // User input for start year, with validation
            while (true) {
                try {
                    Console.Write("\nStart Year: ");
                    startYear = int.Parse(Console.ReadLine());

                    if (startYear < 1) {
                        throw new Exception();
                    } // end if

                    break;
                } catch (Exception) {
                    Console.WriteLine("Invalid start year: a start year must be an integer and greater than zero.");
                } // end try
            } // end while

            // User input for end year, with validation
            while (true) {
                try {
                    Console.Write("End Year: ");
                    endYear = int.Parse(Console.ReadLine());

                    if (endYear < startYear) {
                        throw new Exception();
                    } // end if

                    break;
                } catch (Exception) {
                    Console.WriteLine("Invalid end year: an end year must be and integer and greater than the start year.\n");
                } // end try
            } // end while
            
            Console.WriteLine($"\nBetween {startYear} and {endYear}, there are {(endYear - startYear) + 1} Easters on the following days:"); // output inclusive number of Easters

            // calculate the date of Easter using range given by the user
            for (int i = startYear; i <= endYear; i++) {
                listOfDates.Add(CalculateEasterRange(i));
            } // end for

            #region Easter Date LINQ Statement
            // groups the calculations by month and day, with the number of occurrences
            IEnumerable<dynamic> groupEastersByDateQuery =
                from easter in listOfDates
                group easter by new { easter.Month, easter.Day } into eastersByDateGroup
                orderby eastersByDateGroup.Key.Month, eastersByDateGroup.Key.Day
                select new {
                    Month = eastersByDateGroup.Key.Month,
                    Day = eastersByDateGroup.Key.Day,
                    Count = eastersByDateGroup.Count()
                };
            #endregion

            // adds the groupings and amounts to lists (to be converted to arrays) for use in graphing
            foreach (var easter in groupEastersByDateQuery) {
                occurrenceArrayList.Add(easter.Count);
                DateTime date = new DateTime(1, easter.Month, easter.Day); // DateTime requires a year, so 1 is used arbitrarily
                dateArrayList.Add(date);
            } // end foreach

            // converts the lists to arrays
            occurrenceArray = occurrenceArrayList.ToArray();
            dateArray = dateArrayList.ToArray();

            // For each array element, output a bar of the chart
            for (int i = 0; i < occurrenceArray.Length; i++) {
                // Output bar labels
                // using dateArray shows only the dates on which an Easter will occur within the range
                if (dateArray[i].Month == 4) {
                    if (dateArray[i].Day < 10) {
                        Console.Write($"April 0{dateArray[i].Day}: ");
                    } else {
                        Console.Write($"April {dateArray[i].Day}: ");
                    } // end if
                } else {
                    Console.Write($"March {dateArray[i].Day}: ");
                } // end if

                // Output bar of "X" marks
                for (int marks = 0; marks < occurrenceArray[i]; marks++) {
                    Console.Write($"X");
                } // end for

                // output the number of marks (occurrences on listed date)
                Console.Write($" ({occurrenceArray[i]})");

                Console.WriteLine();    // Starts a new line of output
            } // end for

            // does the user wish to do another calculation
            Console.Write("\nWould you like to calculate another range of years? (Y/n): ");
            repeat = Console.ReadLine().ToUpper();
            while (!(repeat == "Y" || repeat == "N")) {
                Console.WriteLine("\nEnter 'Y' to perform another calculation or 'N' to exit.");
                Console.Write("Would you like to calculate another range of years? (Y/n): ");
                repeat = Console.ReadLine().ToUpper();
            } // end while
        } // end while        
    } // end method

    private static DateTime CalculateEasterRange(int calculationYear) {
        // Get input from user and convert the input to integer
        double year = calculationYear;

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

        DateTime date = new DateTime();

        if (month == 3) {
            date = new DateTime((int)year, (int)month, (int)day);
        } else if (month == 4) {
            date = new DateTime((int)year, (int)month, (int)day);
        } else {
            Console.WriteLine("\nAn unknown error has occurred.");
        } // end if

        return date;
    } // end method 
} // end class