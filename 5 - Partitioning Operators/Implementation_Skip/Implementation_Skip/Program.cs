namespace Implementation_Skip
{
    #region Skip() in LINQ
    /*
    What is the Skip() in LINQ ?
    It ignores the first n elements and returns the rest.
    بتتجاهل اول عدد معين من العناصر و ترجع الباقي



    //Example : We have a Collection of number we want skip the first 3 element 
    //C# code with Linq

    /////////////////////////////////////////////////////////////////////////////////////
    
    
    int[] numbers = { 2, 4, 6, 7, 8, 10 };
    var result = numbers.Skip(2);
    foreach (var number in result)
    {
       Console.WriteLine(number);
    }
 
    /////////////////////////////////////////////////////////////////////////////////////


    */
    #endregion

    public static class MyLinq_Skip_Extetion
    {

        public static IEnumerable<int> MySkip(this IEnumerable<int> source, int count) 
        {
            int skipped = 0;

            foreach (int item in source) 
            {
                if (skipped < count) 
                {
                    skipped++;
                    continue;
                }

                yield return item;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 7, 8, 10 };
            var result = numbers.MySkip(2);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
