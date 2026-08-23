namespace Implementation_OrderBy
{
    #region OrderBy() in LINQ
    /*
    What is the OrderBy() in Linq ?
    Sorts the elements of a collection in ascending order.

    Example : We have a collection of numbers, and we want to sort
    the numbers from smallest to largest.

    // C# code with linq

    ---------------------------------------------------------------------------

    int[] numbers = { 50, 10, 40, 20, 30 };

    var result = numbers.OrderBy(x => x);

    foreach (int item in result)
    {
        Console.WriteLine(item);
    }

    ----------------------------------------------------------------------------
    output >>>
    10
    20
    30
    40
    50

    */
    #endregion


    public static class Mylinq_OrderBy_Extentions
    {
        public static IEnumerable<int> MyOrderBy(
            this IEnumerable<int> source)
        {
            int[] numbers = source.ToArray(); // Convert collection to array 

            for (int i = 0; i < numbers.Length - 1; i++) // Compare each item with the next items

            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j]) // If the first number is bigger, swap them

                    {
                        int temp = numbers[i];

                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            // Return the sorted numbers >>> output
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
            var result = numbers.MyOrderBy();
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}