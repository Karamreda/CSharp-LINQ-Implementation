namespace Implementation_Distinct
{
    #region Distinct() in LINQ
    /*
    What is the Distinct() in Linq ?
    Removes duplicate elements from a collection.
    بتشيل العناصر المتكررة

    Example : We have a collection of numbers >>>>>> and we want to remove duplicate numbers.

    // C# code with linq
    ---------------------------------------------------------------------------

    int[] numbers = { 10, 20, 10, 30, 20, 40 };
    var result = numbers.Distinct();
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

    */
    #endregion


    public static class Mylinq_Distinct_Extentions
    {
        public static IEnumerable<int> MyDistinct(this IEnumerable<int> source)
        {
            List<int> result = new List<int>(); // Store >>>>>>>> unique items

            foreach (int item in source)
            {
                // Check if the item already exists 
                if (!result.Contains(item))
                {
                    result.Add(item); // Add only unique item
                }
            }

            // Return unique items
            foreach (int item in result)
            {
                yield return item;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 10, 30, 20, 40 };
            var result = numbers.MyDistinct();
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}