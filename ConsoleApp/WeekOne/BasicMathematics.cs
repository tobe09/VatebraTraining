using System;

namespace Practise.WeekOne
{
    class BasicMathematics
    {
        public static void Run()
        {
            Console.WriteLine("A program to perform mathematical computations! \n");

            Console.Write("Enter the first number: ");
            string stringOne = Console.ReadLine();
            double numOne = Convert.ToDouble(stringOne);

            Console.Write("Enter the second number: ");
            string stringTwo = Console.ReadLine();
            double numTwo = double.Parse(stringTwo);

            double sum = numOne + numTwo;
            double diff = numOne - numTwo;
            diff = Math.Abs(diff);
            double product = numOne * numTwo;
            double div = numOne / numTwo;

            Console.WriteLine();

            Console.WriteLine("Their sum is: " + sum);
            Console.WriteLine("Their difference is: " + diff);
            Console.WriteLine("Their Product is: " + product);
            Console.WriteLine("Their Division is: " + div);
        }
    }
}
