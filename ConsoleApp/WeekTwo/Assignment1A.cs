using System;
using System.Collections.Generic;

namespace Practise.WeekOne
{
    class Assignment1A
    {
        public static void Run()
        {
            Console.WriteLine("A program to perform square roots computations! \n");

            List<double> nums = new List<double>();

            Console.Write("Enter the first number: ");
            string stringOne = Console.ReadLine();
            double numOne = Convert.ToDouble(stringOne);
            nums.Add(numOne);

            Console.Write("Enter the second number: ");
            string stringTwo = Console.ReadLine();
            double numTwo = Convert.ToDouble(stringTwo);
            nums.Add(numTwo);

            Console.Write("Enter the third number: ");
            string stringThree = Console.ReadLine();
            double numThree = double.Parse(stringThree);
            nums.Add(numThree);

            Console.Write("Enter the fourth number: ");
            string stringFour = Console.ReadLine();
            double numFour = Convert.ToDouble(stringFour);
            nums.Add(numFour);

            double rootOne = Math.Sqrt(numOne);
            double rootTwo = Math.Sqrt(numTwo);
            double rootThree = Math.Sqrt(numThree);
            double rootFour = Math.Sqrt(numFour);

            //Math.Min(numOne, Math.Min(numTwo, Math.Min(numThree, numFour)));
            nums.Sort();
            
            double minimum = MinimumOfFourNumbers(numOne, numTwo, numThree, numFour);
            double maximum = MaximumOfFourNumbers(numOne, numTwo, numThree, numFour);
            //minimum = nums[0];
            //maximum = nums[nums.Count - 1];



            Console.WriteLine(string.Format("The square-root of {0} is: {1}", numOne, rootOne));
            Console.WriteLine(string.Format("The square-root of {0} is: {1}", numTwo, rootTwo));
            Console.WriteLine($"The square-root of {numThree} is: {rootThree}");
            Console.WriteLine("The square-root of " + numFour + " is: " + rootFour);

            Console.WriteLine("The minimum of the four numbers is: " + minimum);
            Console.WriteLine("The maximum of the four numbers is: " + maximum);
        }

        private static double MinimumOfFourNumbers
            (double numOne, double numTwo, double numThree, double numFour)
        {
            double minimum = numOne;

            if (minimum > numTwo)
                minimum = numTwo;
            if (minimum > numThree)
                minimum = numThree;
            if (minimum > numFour)
                minimum = numFour;

            return minimum;
        }


        private static double MaximumOfFourNumbers
            (double numOne, double numTwo, double numThree, double numFour)
        {
            double maximum = numOne;

            if (maximum < numTwo)
                maximum = numTwo;
            if (maximum < numThree)
                maximum = numThree;
            if (maximum < numFour)
                maximum = numFour;

            return maximum;
        }
    }
}
