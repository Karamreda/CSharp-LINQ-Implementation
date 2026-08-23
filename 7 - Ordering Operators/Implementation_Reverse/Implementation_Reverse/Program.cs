namespace Implementation_Reverse
{
    #region Reverse() in LINQ
    /*
    What is the Reverse() in Linq ?
    Reverses the order of the elements in a collection.
    بتتتتتتتتتتتتتتتعكس

    Example : We have a collection of numbers  >>>>>>>>> and we want to reverse the order.

    // C# code with linq

    ---------------------------------------------------------------------------

    int[] numbers = { 10, 20, 30, 40, 50 };
    var result = numbers.Reverse();
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


    public static class Mylinq_Reverse_Extentions
    {
        public static IEnumerable<int> MyReverse(this IEnumerable<int> source)
        {
            int[] numbers = source.ToArray(); // Convert collection to array

            // Start from the last index
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                yield return numbers[i]; 
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            var result = numbers.MyReverse();
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}