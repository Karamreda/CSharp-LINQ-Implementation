namespace Implementation_SelectMany
{

    #region SelectMany() in LINQ
    /*
     What is SelectMany() in LINQ?
    >>>>>>>> If you have a Collection that contains Collections, 
             it will bring them all together into one Collection

     // Example: We have a collection of Numbers, and each index has a collection of Lists Number.
  


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    List<int> numbers = new List<int> { new List<int> {1,2}, new List<int> {3,4}, new List<int> {5,6} };
    var result = numbers.SelectMany(x => x)
    foreach (var item in result)
    {
        Console.WriteLine(item);
    }
    

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // output: 1,2,3,4,5,6


     */



    #endregion

    public static class MyLINQ_SelectMany_Extensions
    {
        public static IEnumerable<TResult> MySelectMany<TSource, TResult>
        (
        this IEnumerable<TSource> source, // The collection of collections
        Func<TSource, IEnumerable<TResult>> selector // x => x
        )
        {
            foreach (var item in source) // Any collection of TSource
            {
                foreach (var value in selector(item)) // Any collection of TResult 
                {
                    yield return value;
                }
            }
            
        }

        // TSource : This is the type of original element.
        // TResult : This is the type of the element in the collection that is returned by the selector function.

    }








    internal class Program
    {
        static void Main(string[] args)
        {
            // TSource is >>> List<int>
            // TResult is item >>> int

            List<List<int>> numbers = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3, 4 }, new List<int> { 5, 6 } }; 
            var result = numbers.MySelectMany(x => x);
            foreach (var item in result)
            {
                Console.WriteLine(item);

            }






        }
    }
}
