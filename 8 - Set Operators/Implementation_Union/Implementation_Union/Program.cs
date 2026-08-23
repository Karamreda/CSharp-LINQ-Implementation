namespace Implementation_Union
{
    #region Union() in LINQ
    /*
    What is the Union() in Linq ?
    Combines two collections and removes duplicate elements.
    بتجمع مجموعتين وتشيل المتكرر

    Example : We have two collections of numbers >>>> and we want to combine them without duplicates.

    // C# code with linq
    ---------------------------------------------------------------------------

    int[] numbers1 = { 10, 20, 30 };
    int[] numbers2 = { 20, 30, 40 };

    var result = numbers1.Union(numbers2);
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


    public static class Mylinq_Union_Extentions
    {
        public static IEnumerable<int> MyUnion(this IEnumerable<int> first,IEnumerable<int> second)
        {
            List<int> result = new List<int>(); // Store >>>>> unique items

            // Add items from first collection

            foreach (int item in first)
            {
                if (!result.Contains(item))
                {
                    result.Add(item);
                }
            }

            // Add items from second collection 

            foreach (int item in second)
            {
                if (!result.Contains(item))
                {
                    result.Add(item);
                }
            }

            // Return combined unique items
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
            int[] numbers1 = { 10, 20, 30 }; 
            int[] numbers2 = { 20, 30, 40 };

            var result = numbers1.MyUnion(numbers2);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}