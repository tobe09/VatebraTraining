using System;
using Practise.Animal;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Linq.Expressions;

namespace Practise.WeekFour
{
    class ClassFour
    {
        public static void Run()
        {
            try
            {
                //GenericsPractise();
                //LinqPractise();
                ExceptionPractise();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void GenericsPractise()
        {
            Dog dogConstructor = new Dog("Bobby");
            MyGenericClass<Dog> myGenericClass = new MyGenericClass<Dog>(dogConstructor);

            Dog dogParameter = new Dog("Jimmy");
            Dog dogMethod = myGenericClass.GenericMethod(dogParameter);

            bool isEqual = dogConstructor.Equals(dogMethod);
            bool isEqual2 = dogConstructor.Equals(dogParameter);

            Console.WriteLine(isEqual);
            Console.WriteLine(isEqual2);
        }

        private static void LinqPractise()
        {
            int zero = 0;
            double trial = 1 / zero;

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              select number;

            var evenNo = numbers.Where(number => number % 2 == 1);
        
            MyQueryAble<string> queryable = new MyQueryAble<string>();
        }

        private static bool EvenNumbers(int number)
        {
            return number % 2 == 0;
        }

        private static void ExceptionPractise()
        {
            Console.Write("Enter a number less than 20: ");
            string numberStr = Console.ReadLine();
            try
            {
                int no = Convert.ToInt32(numberStr);

                if (no >= 20)
                    throw new UserFriendlyException();
                else
                    no = no / no;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a number next time");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dont divide by zero next time");
            }
            finally
            {
                Console.WriteLine("Its over");
            }
        }
        
    }

    class UserFriendlyException: Exception
    {
        public UserFriendlyException() : base("This is a user friendly message") { }
    }

    class MyQueryAble<T> : IQueryable<T>
    {
        //NotImplementedException is thrown when a method or property is not implemented
        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class MyGenericClass<T> where T : Animal.Animal
    {
        private T genericMemberVariable;
        
        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T GenericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter Type: {0}, Value: {1}", genericParameter.GetType(), genericParameter.Name);
            Console.WriteLine("Parameter Type: {0}, Value: {1}", genericMemberVariable.GetType(), genericMemberVariable.Name);

            return genericMemberVariable;
        }
    }

}
