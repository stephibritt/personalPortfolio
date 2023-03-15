using System;

class MontyHallTest {
    static void Main() {

        // global variable
        const int TOTAL_GAMES = 1000000;

        // variables
        MontyHallProblem.GameResult resultOfGame;

        decimal averageWins;
        decimal averageLosses;
        int winCounter;
        int lossCounter;

        Console.WriteLine("Demonstrating the \"Monty Hall Problem\"\n");
        Console.WriteLine($"Simulating {TOTAL_GAMES:N0} games for each strategy...\n");

        #region KEEP Strategy
        // loop for KEEP strategy
        winCounter = 0;
        lossCounter = 0;
        for (int i = 0; i < TOTAL_GAMES; i++) {
            MontyHallProblem game = new MontyHallProblem();
            
            resultOfGame = game.PlayGame(MontyHallProblem.GameStrategy.Keep);
            if (resultOfGame == MontyHallProblem.GameResult.Won) {
                winCounter++;
            } else {
                lossCounter++;
            } // end if
        } // end for

        averageWins = (decimal)winCounter / (decimal)TOTAL_GAMES;
        averageLosses = (decimal)lossCounter / (decimal)TOTAL_GAMES;

        Console.WriteLine($"Keep Strategy");
        Console.WriteLine($"{"Wins:", -7} {winCounter:N0} ({averageWins:P2})");
        Console.WriteLine($"{"Losses:",-7} {lossCounter:N0} ({averageLosses:P2})\n");
        #endregion

        #region SWITCH Strategy
        // loop for SWITCH strategy
        winCounter = 0;
        lossCounter = 0;
        for (int i = 0; i < TOTAL_GAMES; i++) {
            MontyHallProblem game = new MontyHallProblem();

            resultOfGame = game.PlayGame(MontyHallProblem.GameStrategy.Switch);
            if (resultOfGame == MontyHallProblem.GameResult.Won) {
                winCounter++;
            } else {
                lossCounter++;
            } // end if
        } // end for

        averageWins = (decimal)winCounter / (decimal)TOTAL_GAMES;
        averageLosses = (decimal)lossCounter / (decimal)TOTAL_GAMES;

        Console.WriteLine($"Switch Strategy");
        Console.WriteLine($"{"Wins:",-7} {winCounter:N0} ({averageWins:P2})");
        Console.WriteLine($"{"Losses:",-7} {lossCounter:N0} ({averageLosses:P2})\n");
        #endregion

        #region RANDOM Strategy
        // loop for KEEP strategy
        winCounter = 0;
        lossCounter = 0;
        for (int i = 0; i < TOTAL_GAMES; i++) {
            MontyHallProblem game = new MontyHallProblem();

            resultOfGame = game.PlayGame(MontyHallProblem.GameStrategy.Random);
            if (resultOfGame == MontyHallProblem.GameResult.Won) {
                winCounter++;
            } else {
                lossCounter++;
            } // end if
        } // end for

        averageWins = (decimal)winCounter / (decimal)TOTAL_GAMES;
        averageLosses = (decimal)lossCounter / (decimal)TOTAL_GAMES;

        Console.WriteLine($"Random Strategy");
        Console.WriteLine($"{"Wins:",-7} {winCounter:N0} ({averageWins:P2})");
        Console.WriteLine($"{"Losses:",-7} {lossCounter:N0} ({averageLosses:P2})\n");
        #endregion
    } // end method
} // end class