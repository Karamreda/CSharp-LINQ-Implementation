namespace Implementation_Concat
{
    #region Concat() in LINQ
    /*
    What is the Concat() in Linq ?
    Combines two collections into one collection >>>>>>>> Concat() does NOT remove duplicate elements.
    بتجمع مجموعتين بدون ما تشيل المتكرر

    Example : We have two collections of numbers >>> and we want to combine them together.

    // C# code with linq

    ---------------------------------------------------------------------------

    int[] numbers1 = { 10, 20, 30 };
    int[] numbers2 = { 20, 30, 40 };

    var result = numbers1.Concat(numbers2);
    foreach (int item in result)
    {
        Console.WriteLine(item);
    }

    ----------------------------------------------------------------------------
    output >>>
    10
    20
    30
    20
    30
    40

    */
    #endregion


    public static class Mylinq_Concat_Extentions
    {
        public static IEnumerable<int> MyConcat(this IEnumerable<int> first,IEnumerable<int> second)
        {
            // Return all items from first collection
            foreach (int item in first)
            {
                yield return item;
            }

            // Return all items from second collection
            foreach (int item in second)
            {
                yield return item;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 10, 20, 30 };
            int[] numbers2 = { 20, 30, 40 };

            var result = numbers1.MyConcat(numbers2);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
