using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.WeekThree
{
    class AssignmentTwo
    {
        public static void Run()
        {
            //StringMethods();
            //ListManipulation();
            MinMaxNumbers();
        }
        /// <summary>
        /// Question 1
        /// </summary>
        private static void StringMethods()
        {
            string sentence = "This is a sentence";
            Console.WriteLine("The sentence is: " + sentence);
            Console.WriteLine();

            int aIndex = sentence.IndexOf('a');  //Index of
            Console.WriteLine("index of 'a' is: " + aIndex);
            string substring = sentence.Substring(aIndex);  //Substring
            Console.WriteLine("Substring from index " + aIndex + " is: " + substring);

            char[] sentenceArray = sentence.ToCharArray(); //TocharArray
            char aValue = sentenceArray[aIndex];
            Console.WriteLine("The value of 'a' is: " + aValue);

            bool hasA = sentence.Contains('A', StringComparison.CurrentCultureIgnoreCase); //Contains
            Console.WriteLine("Does the sentence contain 'a'? " + hasA);

            bool endsWithE = sentence.EndsWith('e');    //EndsWith
            Console.WriteLine("Does the sentence end with 'e'? " + endsWithE);

            Type sentenceType = sentence.GetType();
            Console.WriteLine("Sentence Type: " + sentenceType);
        }

        /// <summary>
        /// Question 2
        /// </summary>
        private static void ListManipulation()
        {
            List<string> names = new List<string> { "Tobenna", "Tunde", "Caleb" };

            names.Add("Charles");
            names.AddRange(new [] { "John", "James" });

            names.Insert(2, "William");

            MyComparer descendingComparer = new MyComparer();
            //names.Sort((x, y) => -1 * x.CompareTo(y));
            names.Sort(descendingComparer);

            foreach (string name in names)
                Console.WriteLine(name);
        }

        /// <summary>
        /// Question 3
        /// </summary>
        private static void MinMaxNumbers()
        {
            Console.WriteLine("A function to generate the minimum and maximum of a list of numbers!  \n");

            Console.Write("Enter a list of numbers seperated by a comma: ");
            string numberValues = Console.ReadLine();

            string[] numberValuesList = numberValues.Split(',');
            int noOfValues = numberValuesList.Length;       //Getting the length of the string for initialization below

            int[] numberList = new int[noOfValues];
            for (int i = 0; i < noOfValues; i++)
            {
                string value = numberValuesList[i].Trim();
                numberList[i] = CheckValue(value);

                if(numberList[i] == -999999)
                {
                    Console.WriteLine("Process has been cancelled!");
                    return;
                }
            }

            Array.Sort(numberList);

            int smallestNumber = numberList[0];
            int largestNumber = numberList[noOfValues - 1];

            Console.WriteLine($"\nThe smallest number is: {smallestNumber}");
            Console.WriteLine($"\nThe largest number is: {largestNumber}");
        }

        private static int CheckValue(string value)
        {
            int number;
            bool numberIsCorrect = int.TryParse(value, out number);
            while (!numberIsCorrect)
            {
                Console.Write($"Invalid number found ({value}). Replace with a valid number (or C to cancel): ");
                value = Console.ReadLine();

                numberIsCorrect = int.TryParse(value, out number);
                if (value.Equals("C", StringComparison.OrdinalIgnoreCase))
                    return -999999;
            }

            return number;
        }

        public class MyComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return -1 * x.CompareTo(y);
            }
        }
    }
}
