namespace Implementation_Except
{
    #region Except() in LINQ
    /*
    What is the Except() in Linq ?
    Returns the elements that exist in the first collection >>>> but do not exist in the second collection.
    بتجيب العناصر الموجودة في الأولى فقط ومش موجودة في الثانية

    Example : We have two collections of numbers >>>>> and we want to find numbers that exist only in the first collection.

    // C# code with linq

    ---------------------------------------------------------------------------

    int[] numbers1 = { 10, 20, 30, 40 };
    int[] numbers2 = { 20, 30 };

    var result = numbers1.Except(numbers2);
    foreach (int item in result)
    {
        Console.WriteLine(item);
    }
    ----------------------------------------------------------------------------
    output >>>
    10
    40

    */
    #endregion


    public static class Mylinq_Except_Extentions
    {
        public static IEnumerable<int> MyExcept(this IEnumerable<int> first, IEnumerable<int> second)
        {
            List<int> result = new List<int>(); // Store >>>>>>>> unique items

            // Check items from first collection
            foreach (int item in first)
            {


                // Add item only if it doesn't exist in second

                if (!second.Contains(item) && !result.Contains(item))
                {
                    result.Add(item);
                }
            }

            // Return
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
            int[] numbers2 = { 20, 30 };

            var result = numbers1.MyExcept(numbers2);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}