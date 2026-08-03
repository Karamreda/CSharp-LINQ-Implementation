namespace Implementation_All
{
    #region All() in C# LINQ
    /*
     What is All() in C# LINQ?
     >>>>>> It returns true if all elements meet the condition.
     ترجع ترو إذا كانت جميع العناصر تفي بالشرط

    // Example: We have a list of numbers and we want to check if all numbers are Even .

    // C# code With LINQ
    /////////////////////////////////////////////////////////////////////////
    
    list<int> numbers = new List<int>() { 2, 4, 6, 8, 10 };
    bool result = numbers.All(n => n % 2 == 0);
    console.WriteLine(result); 

    /////////////////////////////////////////////////////////////////////////
    // Output: True




    */
    #endregion

    public static class MyLINQ_All_Extensions
    {
        public static bool MyAll<T>(this IEnumerable<T> source, Func<T, bool> Condition)
        {
            foreach (var item in source)
            {
                if (!Condition(item)) // Check if the condition is not met for any item
                {
                    return false; // If any item does not meet the condition, return false
                }
              
            }
            return true; // If all items meet the condition, return true
        }





    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> {2, 4, 6, 8, 10 };
            bool result = list.MyAll(n => n % 2 == 0);
            Console.WriteLine(result);
            // Output: True



        }
    }
}
