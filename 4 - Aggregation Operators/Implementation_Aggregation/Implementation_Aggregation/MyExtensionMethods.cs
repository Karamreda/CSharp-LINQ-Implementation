using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation_Aggregation
{



    public static class MyExtensionMethods
    {
        // Count() >>>>>> Count the number of elements in a collection
        public static int MyCount<T>(this IEnumerable<T> source)
        {
            int count = 0;

            foreach (var item in source)
            {
                count++;
            }

            return count;
        }



        // Sum() >>>>>> Calculate the sum of a collection of numbers
        public static int MySum(this IEnumerable<int> source)
        {
            int sum = 0;

            foreach (var item in source)
            {
                sum += item;
            }

            return sum;
        }



        // Average() >>>>>>> Calculate the average of a collection of numbers
        public static double MyAverage(this IEnumerable<int> source)
        {
            int sum = 0;
            int count = 0;


            foreach (var item in source)
            {
                sum += item;
                count++;
            }


            return (double)sum / count;
        }



        // Min() >>>>>> Find the minimum value in a collection of numbers
        public static int MyMin(this IEnumerable<int> source)
        {
            int min = int.MaxValue;


            foreach (var item in source)
            {
                if (item < min)
                {
                    min = item;
                }
            }


            return min;
        }



        // Max() >>>> Find the maximum value in a collection of numbers
        public static int MyMax(this IEnumerable<int> source)
        {
            int max = int.MinValue;


            foreach (var item in source)
            {
                if (item > max)
                {
                    max = item;
                }
            }


            return max;
        }



        // Aggregate() >>>>>> Apply an accumulator function over a collection
        public static int MyAggregate(this IEnumerable<int> source,Func<int, int, int> func)
        {

            int result = 1;


            foreach (var item in source)
            {
                result = func(result, item);
            }

            return result;
        }

    }
}




