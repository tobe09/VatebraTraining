using System.Collections.Generic;
using System.Linq;

namespace Practise.WeekTwelve
{
    public class ArrayIntersection
    {
        public static void Run()
        {
            int[] arrayOne = new[] { 10, 20, 25, 27, 38, 90, 87, 34, 52, 44, 76, 88, 22 };
            int[] arrayTwo = new[] { 11, 45, 22, 90, 27, 16, 25, 33, 56, 81, 87, 19, 29 };

            var commonValues = ManualIntersection(arrayOne, arrayTwo);
            int[] commonArray = ManualToArray(commonValues);

            //int[] commonArrayLinq = arrayOne.Intersect(arrayTwo).ToArray();
        }

        private static IEnumerable<int> ManualIntersection(IEnumerable<int> arr1, IEnumerable<int> arr2)
        {
            List<int> commonValues = new List<int>();

            foreach (int val in arr1)
            {
                if (ManualContain(arr2, val))
                    commonValues.Add(val);
            }

            return commonValues;
        }

        private static bool ManualContain(IEnumerable<int> values, int val)
        {
            foreach (int value in values)
            {
                if (value == val)
                    return true;
            }

            return false;
        }

        private static int[] ManualToArray(IEnumerable<int> values)
        {
            var vals = values.ToList();
            int count = vals.Count;
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = vals[i];
            }

            return array;
        }
    }
}