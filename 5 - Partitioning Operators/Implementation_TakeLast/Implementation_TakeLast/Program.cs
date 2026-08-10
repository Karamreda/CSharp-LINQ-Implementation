using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Implementation_TakeLast
{
    #region Takelast() in LINQ
    /*
    What is TakeLast() in LINQ?
    It takes the last n elements
    بتاخد اخر عدد معين من العناصر 
     
    // Example : We have a list of numbers and we want to take the last 3 elements from that list. We can use the TakeLast() method to achieve this.
    // C# code Without LINQ

    ////////////////////////////////////////////////////////////////////////////
    int[] numbers = { 10, 20, 30, 40, 50 };
    var result = numbers.TakeLast(3);
    foreach (var number in result)
    {
        Console.WriteLine(number);
    }




    ////////////////////////////////////////////////////////////////////////////
    // output: 30, 40, 50







    */
    #endregion

    public static class MyLinq_TakeLast_Extensions
    {

        public static IEnumerable<int> MyTakeLast(this IEnumerable<int> source, int count)
        {
            // count length of the source collection
            int length = 0;

            foreach (int item in source)
            {
                length++;
            }

            // calculate how many items to skip
            int skip = length - count;

            if (skip < 0) 
            // if count is greater than the length of the source collection, return all item >>> dont skip any item
                skip = 0;

            int index = 0; 
            
            foreach (int item in source) 
            {
                if (index >= skip) // if the index is greater than or equal to the skip value, yield return the item
                    yield return item;

                index++;
            }
        }

       



    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            var result = numbers.MyTakeLast(3);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }

        }
    }
}
