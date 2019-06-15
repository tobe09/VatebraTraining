using System;

namespace Practise.WeekTwo
{
    class GuessingGame
    {
        public static void Run()
        {
            Console.WriteLine("A Basic Guessing Game! \n");

            string continuationToken;

            do
            {
                Console.Write("What should be the minimum number: ");
                string strMin = Console.ReadLine();
                int min = Convert.ToInt32(strMin);

                Console.Write("What should be the maximum number: ");
                string strMax = Console.ReadLine();
                int max = Convert.ToInt32(strMax);

                Console.Write("How many guesses : ");
                string guesses = Console.ReadLine();
                int noOfGuesses = Convert.ToInt32(guesses);

                Console.WriteLine($"You have {noOfGuesses} " +
                    $"guesses for a number between {min} and {max} inclusive. \n");

                Random random = new Random();
                double fraction = random.NextDouble();

                double number = (fraction * (max - min)) + 1;
                int originalNumber = (int)number + min;

                bool isCorrect = false;
                for (int i = 1; i <= noOfGuesses; i = i + 1)
                {
                    Console.Write($"Enter Your Guess ({i}): ");
                    string value = Console.ReadLine();
                    int numValue = Convert.ToInt32(value);

                    if (originalNumber > numValue)
                    {
                        Console.WriteLine("The original number is greater than your guess. Try again.");
                    }
                    else if (originalNumber < numValue)
                    {
                        Console.WriteLine("The original number is less than your guess. Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Congrats! Corect Guess.");
                        isCorrect = true;
                        break;
                    }
                }

                Console.WriteLine();

                if (isCorrect)
                    Console.WriteLine("You are a great guesser.");
                else
                    Console.WriteLine("You have lost. The answer is: " + originalNumber);

                Console.Write("Do you want to continue? (Enter 'y' or 'yes' to continue): ");
                continuationToken = Console.ReadLine();

                Console.WriteLine();
            }
            while (continuationToken.ToUpper() == "YES" || continuationToken.ToUpper() == "Y");

            Console.WriteLine("\nThank you for playing!");
        }
    }
}
