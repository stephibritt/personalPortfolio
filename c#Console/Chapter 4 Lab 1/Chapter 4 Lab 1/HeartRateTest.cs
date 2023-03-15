using System;

//Edited by: Stephen Britt
//     date: 2/02/2022

class HeartRateTest {
    static void Main() {

        // output program purpose
        Console.WriteLine("Target Heart-Rate Calculator");
        Console.WriteLine("\nAnswer the following questions to determine your safe heart rate for exercising.\n");

        // User input for name and year of birth
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.Write("What is your birth year? ");
        int birthYear = int.Parse(Console.ReadLine());

        // instantiate the class
        HeartRate userHeartRate = new HeartRate(name, birthYear);

        // output calculations
        Console.WriteLine($"\nHeart rate information for {userHeartRate.Name}:");
        Console.WriteLine($"\tAge: {userHeartRate.GetAge()} years old");
        Console.WriteLine($"\tMaximum heart rate: {userHeartRate.GetMaxHeartRate()} beats/minute");
        Console.WriteLine($"\tMinimum target heart rate: {userHeartRate.GetMinTargetHeartRate()} beats/minute");
        Console.WriteLine($"\tMaximum target heart rate: {userHeartRate.GetMaxTargetHeartRate()} beats/minute");
    } // end method
} // end class