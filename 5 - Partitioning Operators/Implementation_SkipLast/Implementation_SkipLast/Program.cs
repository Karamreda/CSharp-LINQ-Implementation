namespace Implementation_SkipLast
{
    #region SkipLast() in Linq
    /*
    What is the SkipLast() in Linq ?
    It ignores the last n elements and returns all those before them
    بتتجاهل اخر عدد معين من العناصر

    // Example : We have a collction of number we want skip the last 2 element
    // C# code with linq

    /////////////////////////////////////////////////////////////////////////////
    
    int[] numbers = { 10, 20, 30, 45, 50, 60 };
    var result = numbers.SkipLast(2);
    foreach (var number in result)
    {
        Console.WriteLine(number);
    }
    /////////////////////////////////////////////////////////////////////////////

    output : 10 20 30 45 

    */
    #endregion

    public static class MyLinq_SkipLast_Extaction
    {
        public static IEnumerable<int> MySkipLast(this IEnumerable<int> source, int count)
        {
            // count length of collection
            int length = 0;

            foreach (int item in source)
            {
                length++;
            }
            // Calculate how many elements should be returned
            // Example: length = 5, count = 2
            // takeCount = 3 → return the first 3 elements
            int takeCount = length - count;

            if (takeCount < 0) // If count is greater than the collection length >>>>> return an empty sequence
                takeCount = 0;

            int index = 0;

            foreach (int item in source)
            {
                if (index >= takeCount) // Stop when we reach the number of elements to return

                    yield break;

                yield return item;
                index++;
            }
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 45, 50, 60 };
            var result = numbers.MySkipLast(2);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
