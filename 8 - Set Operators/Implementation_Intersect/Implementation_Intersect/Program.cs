namespace Implementation_Intersect
{
    #region Intersect() in LINQ
    /*
    What is the Intersect() in Linq ?
    Returns the elements that exist in both collections.
    بتجيب العناصر الموجودة في المجموعتين معا

    Example : We have two collections of numbers >>>>>>>> and we want to find the common numbers.

    // C# code with linq
    ---------------------------------------------------------------------------

    int[] numbers1 = { 10, 20, 30, 40 };
    int[] numbers2 = { 20, 30, 50 };

    var result = numbers1.Intersect(numbers2);
    foreach (int item in result)
    {
        Console.WriteLine(item);
    }

    ----------------------------------------------------------------------------
    output >>>
    20
    30

    */
    #endregion


    public static class Mylinq_Intersect_Extentions
    {
        public static IEnumerable<int> MyIntersect( this IEnumerable<int> first, IEnumerable<int> second)
        {
            List<int> result = new List<int>(); // Store >>>>>>>> common items

            // Check items from first collection
            foreach (int item in first)
            {

                // Check if item exists in second collection

                if (second.Contains(item) && !result.Contains(item))
                {
                    result.Add(item); // Add common item
                }
            }

            // Return common items
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
            int[] numbers1 = { 10, 20, 30, 40 };
            int[] numbers2 = { 20, 30, 50 };

            var result = numbers1.MyIntersect(numbers2);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}