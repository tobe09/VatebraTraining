using System;
using System.Collections.Generic;
using System.Linq;
using Practise.Animal;

namespace Practise.WeekFive
{
    /// <summary>
    /// Practise of Exception handling and its keyword
    /// </summary>
    class AssignmentFour
    {
        public static void Run()
        {
            //TryCatchFinally();
            //HelpAnimalBreathe();
            LinqQueryFiltering();
        }

        /// <summary>
        /// Number 2
        /// </summary>
        private static void TryCatchFinally()
        {
            Console.WriteLine("A program to test exceptions by dividing only even numbers!");

            try
            {
                Console.Write("\nEnter the divisor: ");
                string divisorText = Console.ReadLine();
                int divisor = int.Parse(divisorText);

                Console.Write("Enter the dividend: ");
                string dividendText = Console.ReadLine();
                int dividend = Convert.ToInt32(dividendText);

                int quotient = ReturnsEvenQuotientOnly(divisor, dividend);
                Console.WriteLine("\nThe result is: " + quotient);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of exercise!");
            }
        }

        /// <summary>
        /// To test generics with type constraint of Animal
        /// </summary>
        private static void HelpAnimalBreathe()
        {
            Dog dog = new Dog("Scooby");
            AnimalBreathe<Dog> animalBreathe = new AnimalBreathe<Dog>(dog);

            animalBreathe.HelpAnimalBreathe();
        }

        private static void LinqQueryFiltering()
        {
            Console.WriteLine("Program to practise linq filtering.\n");

            Console.Write("Enter names seperated by comma: ");
            string commaNames = Console.ReadLine();
            string[] arrayNames = commaNames.Split(',');

            IEnumerable<string> names = arrayNames;

            //verbose method syntax
            Func<string, bool> predicate = (string name) =>
             {
                 bool containsAtoK = false;
                 foreach (char c in name.ToLower())
                 {
                     if (c >= 'a' && c <= 'k')
                     {
                         containsAtoK = true;
                         break;
                     }
                 }

                 //verbose
                 containsAtoK = name.ToLower().Any(c =>
                 {
                     bool isGreaterOrEqualToA = c >= 'a';
                     bool isLessOrEqualToK = c <= 'k';

                     return isGreaterOrEqualToA && isLessOrEqualToK;
                 });

                 //inline
                 containsAtoK = name.ToLower().Any(c => c >= 'a' && c <= 'k');

                bool satisfiesConditions = containsAtoK || name.Length > 6;

                 return satisfiesConditions;
             };

            var methodNames = names.Where(predicate);

            var methodName2 = names.Where(name => name.Length > 6 || name.Any(c => c >= 'a' && c <= 'k'));

            var queryNames = from name in names
                             where
                             ((from c in name
                               where c >= 'a' && c <= 'k'
                               select c).Count() > 0)
                             || name.Length > 6
                             select name;

            Console.WriteLine("\nAnsers below: ");

            foreach (string name in queryNames)
                Console.WriteLine(name.Trim());
        }

        private static int ReturnsEvenQuotientOnly(int divisor, int dividend)
        {
            int quotient = divisor / dividend;

            bool isOdd = quotient % 2 == 1;
            if (isOdd)
            {
                EvenOnlyException ex = new EvenOnlyException();
                throw ex;
            }

            return quotient;
        }
    }

    public class EvenOnlyException : Exception
    {
        public EvenOnlyException() : base("Odd number result recieved") { }
    }
}