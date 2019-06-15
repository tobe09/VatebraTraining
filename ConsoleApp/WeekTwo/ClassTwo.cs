using System;
using System.Collections;
using System.Collections.Generic;

namespace Practise.WeekTwo
{
    class ClassTwo
    {
        public static void Run()
        {
            ForLoop();
        }

        private static void PractiseString()
        {
            string name = "James";
            string otherName = "John";

            bool isEqual = name == otherName;
            isEqual = name.Equals(otherName);

            int index = name.IndexOf('e');
            Console.WriteLine(index);

            string[] vals = name.Split(',');
        }

        private static void PractiseArray()
        {
            List<string> values = new List<string>();
            values.Add("Hello");

            int[] myIntArray = new int[8];
            myIntArray[0] = 34;
            myIntArray[1] = 1;
            myIntArray[2] = 2;
            myIntArray[3] = 13;
            myIntArray[4] = 4;
        }

        private static void PractiseArrayList()
        {
            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add("Chaye");
            list.Add(new ClassTwo());
            list.Add(true);
            list.Add(new object());

            int value = (int)list[0];
        }

        private static void PractiseList()
        {
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(67);
            list.Add(6);

            bool hasSix = list.Contains(6);
        }

        private static void SwitchPractise()
        {
            int num = 95;

            switch (num)
            {
                case 55:
                    Console.WriteLine("55");
                    break;
                case 65:
                    Console.WriteLine("65");
                    break;
                default:
                    Console.WriteLine("95");
                    break;
            }
        }

        private static void ForLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                    continue;
                if (i == 4)
                    break;

                i = 1;
                Console.WriteLine(i);
            }
        }

        private static void WhileLoop()
        {
            int i = 0;
            while (i < 5)
            {

                i++;
            }
        }
    }
}
