namespace Implementation_Select
{
    #region Select() in LINQ

    /*
     What is Select() in LINQ?
     >>>>>>> It transforms every item in the Collection into a new form
    بيحول كل عنصر في المجموعة إلى شكل جديد

    // Example : We have a list of numbers and we want to get the square of each number using Select() in LINQ.

    // C# code with Select() in LINQ
    ////////////////////////////////////////////////////////////////////////////////

    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
    var squares = numbers.Select(x => x * x);
    foreach (var square in squares)
    {
        Console.WriteLine(square);
    }
    ////////////////////////////////////////////////////////////////////////////////
    // Output: 1 4 9 16 25
    
     */




    #endregion

    public static class MyLINQ_Select_Extensions
    {
        public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach (var item in source)
            {
                yield return selector(item); // Transform each item using the provided selector function
            }
        }

        // TSource: The type of the elements in the source collection.
        // TResult: The type of the elements in the resulting collection.





    }











    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Using MySelect() to get the squares of numbers in a list

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 }; // Source collection 
            var squares = numbers.MySelect(x => x * x); // the TSource is int and TResult is int 
            foreach (var square in squares)
            {
                Console.WriteLine("The square of is : " + square);
            }

            ////////////////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            ////////////////////////////////////////////////////////

            // Example 2: Using MySelect() to transform a list of strings to their lengths

            List<string> words = new List<string> { "Karam", "Yasmin", "Said" };
            var lengths = words.MySelect(word => word.Length); // the TSource is string and TResult is int
            foreach (var item in lengths)
            {
                Console.WriteLine("The length of is : " + item);
            }


        }
    }
}
