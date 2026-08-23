namespace Implementation_OrderByDescending
{
    #region OrderByDescending() in LINQ
    /*
    What is the OrderByDescending() in Linq ?
    Sorts the elements of a collection in descending order.
    ترتيب تنازلي 

    Example : We have a collection of numbers, and we want to sort
    the numbers from largest to smallest.

    // C# code with linq

    ---------------------------------------------------------------------------

    int[] numbers = { 50, 10, 40, 20, 30 };
    var result = numbers.OrderByDescending(x => x);
    foreach (int item in result)
    {
        Console.WriteLine(item);
    }

    ----------------------------------------------------------------------------
    output >>>
    50
    40
    30
    20
    10

    */
    #endregion


    public static class Mylinq_OrderByDescending_Extentions
    {
        public static IEnumerable<int> MyOrderByDescending(this IEnumerable<int> source)
        {
            int[] numbers = source.ToArray(); // Convert collection to array

            
            for (int i = 0; i < numbers.Length - 1; i++) // Compare each item with the next items

            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // If the first number is smaller >> swap them
                    if (numbers[i] < numbers[j])
                    {
                        int temp = numbers[i];

                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            // Return the sorted numbers 
            foreach (int item in numbers)
            {
                yield return item;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 50, 10, 40, 20, 30 };
            var result = numbers.MyOrderByDescending();
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}