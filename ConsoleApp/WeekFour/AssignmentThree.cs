using System;

namespace Practise.WeekFour
{
    class AssignmentThree
    {
        public static void Run()
        {
            Console.WriteLine("This is a program to check if a word is a palindrome!");

            string continuationToken;
            int count = 1;
            do
            {
                Console.WriteLine("\nTrial " + count);
                Console.Write("Enter the word you wish to check: ");
                string word = Console.ReadLine();

                bool isPalindnrome = IsPalindrome_Complete(word);

                string message = isPalindnrome ? "The word is a palindrome!" : "The word is not a palindrome!";

                Console.WriteLine("\n" + message);

                Console.WriteLine();

                Console.Write("Do you want to continue? (enter y or yes to continue): ");
                continuationToken = Console.ReadLine();
                count++;
            }
            while (continuationToken.ToLower() == "yes" || continuationToken.ToLower() == "y");

            Console.WriteLine("\nGame over");
        }

        private static bool IsPalindrome_Basic(string word) //"Johnson"
        {
            bool isPalindrome = false;

            string reversedWord = "";

            int wordLength = word.Length;
            for (int i = wordLength - 1; i >= 0; i--)
            {
                reversedWord = reversedWord + word[i];
            }

            isPalindrome = word == reversedWord;

            return isPalindrome;
        }

        private static bool IsPalindrome_Complete(string word)
        {
            word = word.ToUpper();

            string newWord = "";

            foreach (char ch in word)
            {
                if (ch < 'A' || ch > 'Z')
                    continue;

                newWord += ch;
            }


            int start = 0;
            int middle = newWord.Length / 2;
            int end = newWord.Length - 1;


            while (start <= middle && end >= middle)
            {
                char charStart = newWord[start];
                char charEnd = newWord[end];

                if (charStart != charEnd)
                    return false;

                start++;
                end--;
            }            

            return true;
        }
    }
}
