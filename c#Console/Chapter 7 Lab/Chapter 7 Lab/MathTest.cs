using System;

class MathTest {
    // Constants 
    const int NUMBER_OF_PROBLEMS = 10;
    readonly static string[] POSITIVE_COMMENT = { "Correct!", "That's right!", "Yes!" };
    readonly static string[] NEGATIVE_COMMENT = { "Incorrect.", "That's wrong.", "No." };


    static void Main() {
        Console.WriteLine("The Math Test\n");
        Console.WriteLine($"Enter the answer for the following {NUMBER_OF_PROBLEMS} math problems.\n");

        string repeat = "Y";            // Holds whether the user wants to do another Math Test 
        while (repeat == "Y") {
            int numberCorrect = 0;      // Holds the number of questions answered correctly 

            // Output 10 questions 
            for (int i = 0; i < NUMBER_OF_PROBLEMS; i++) {
                Console.Write($"{i + 1}.  {MathQuestion.GetProblem()}");        // Output a question                 
                int userAnswer = int.Parse(Console.ReadLine());             // Get answer from user 
                int actualAnswer = MathQuestion.GetAnswer();                    // Get actual answer 

                // Test if user's answer and actual answer are the same 
                if (userAnswer == actualAnswer) {
                    numberCorrect++;    // Increment number of correct answers 
                    Console.WriteLine($"{GetPositiveComment()}\n");
                } else {
                    Console.WriteLine($"{GetNegativeComment()}\n");
                } // end if 
            } // end for 

            // Output results 
            double percentage = ((double)numberCorrect / NUMBER_OF_PROBLEMS) * 100;
            Console.WriteLine($"You answered {numberCorrect} problems correctly: {percentage}%");

            // Determine if user wants to repeat Math Test 
            Console.Write("Do you want to take another Math Test? (Y/n): ");
            repeat = Console.ReadLine().ToUpper();
            // Ensure to user either enters Y or N only 
            while (!(repeat == "Y" || repeat == "N")) {
                Console.WriteLine("Enter 'Y' to take another Math Test or 'N' to exit.");
                Console.Write("Do you want to take another Math Test? (Y/n): ");
                repeat = Console.ReadLine().ToUpper();
            } // end while 
        } // end while 
    } // end method 


    private static string GetPositiveComment() {
        Random rnd = new Random();
        return POSITIVE_COMMENT[rnd.Next(POSITIVE_COMMENT.Length)];   // Return a random positive comment 
    } // end method 


    private static string GetNegativeComment() {
        Random rnd = new Random();
        return NEGATIVE_COMMENT[rnd.Next(NEGATIVE_COMMENT.Length)];   // Return a random negative comment 
    } // end method
} // end class