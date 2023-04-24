using System;

//Edited by: Stephen Britt
//     date: 2/02/2022

class HeartRateTest {
    static void Main() {

        // output program purpose
        Console.WriteLine("Target Heart-Rate Calculator");
        Console.WriteLine("\nWARNING: This calculation should not be used to make medical decisions.\n" +
            "Always consult a physician or qualified health professional before beginning or modifying an exercise program.");
        Console.WriteLine("\nAnswer the following questions to determine your safe heart rate for exercising.");


        // User input for name and year of birth
        Console.Write("\nWhat is your name? ");
        string name = Console.ReadLine();

        Console.Write("What is your birth year? ");
        int birthYear = int.Parse(Console.ReadLine());

        // instantiate the class
        HeartRate userHeartRate = new HeartRate(name, birthYear);

        // output calculations
        Console.WriteLine($"\nHeart rate information for {userHeartRate.Name}:");
        Console.WriteLine($"    Age: {userHeartRate.GetAge(), 24} years old");
        Console.WriteLine($"    Maximum heart rate: {userHeartRate.GetMaxHeartRate(), 12:f1} beats/minute");
        Console.WriteLine($"    Minimum target heart rate: {userHeartRate.GetMinTargetHeartRate():f1} beats/minute");
        Console.WriteLine($"    Maximum target heart rate: {userHeartRate.GetMaxTargetHeartRate():f1} beats/minute");
    } // end method
} // end class