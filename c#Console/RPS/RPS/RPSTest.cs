class RPSTest {
    public static void Main() {
        // Output the purpose of the program
        Console.WriteLine("RPS class tests");

        // Iterate through a series of tests
        Console.WriteLine("\nTest One: Both players choose paper");
        RPS rps1 = new RPS(1, 1);
        Console.WriteLine(rps1.GetWinner());

        Console.WriteLine("\nTest Two: Player One chooses rock and Player Two chooses scissors");
        RPS rps2 = new RPS(0, 2);
        Console.WriteLine(rps2.GetWinner());

        Console.WriteLine("\nTest Three: Player One chooses paper and Player Two chooses rock");
        RPS rps3 = new RPS(1, 0);
        Console.WriteLine(rps3.GetWinner());

        Console.WriteLine("\nTest Four: Player One chooses scissors and Player Two chooses paper");
        RPS rps4 = new RPS(2, 1);
        Console.WriteLine(rps4.GetWinner());

        Console.WriteLine("\nTest Five: Player One chooses rock and Player Two chooses paper");
        RPS rps5 = new RPS(0, 1);
        Console.WriteLine(rps5.GetWinner());

        Console.WriteLine("\nTest Six: Player One chooses paper and Player Two chooses scissors");
        RPS rps6 = new RPS(1, 2);
        Console.WriteLine(rps6.GetWinner());

        Console.WriteLine("\nTest Seven: Player One chooses scissors and Player Two chooses rock");
        RPS rps7 = new RPS(2, 0);
        Console.WriteLine(rps7.GetWinner());
    } // end method
} // end class