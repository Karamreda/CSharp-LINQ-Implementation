namespace Implementation_Zip
{
    #region Zip() in LINQ
    /*
    What is the Zip() in Linq ?
    Combines two collections element by element
    
    Example : We have a collection of numbers and names >>>>> We want to combine each number with its matching name.

    // C# code with linq
    ---------------------------------------------------------------------------

    int[] numbers = { 10, 20, 30 };
    string[] names = { "Ali", "Ahmed", "Omar" };

    var result = numbers.Zip(names);
    foreach (var item in result)
    {
        Console.WriteLine($"{item.First} - {item.Second}");
    }

    ----------------------------------------------------------------------------
    output >>>
    10 - Ali
    20 - Ahmed
    30 - Omar

    If the collections have different lengths >>>>>>> Zip() stops when the shortest collection ends

    */
    #endregion


    public static class Mylinq_Zip_Extentions
    {
        public static IEnumerable<(int Number, string Name)> MyZip(this IEnumerable<int> first, IEnumerable<string> second)
        {
            // Get Enumerator for first collection
            IEnumerator<int> firstEnumerator = first.GetEnumerator();

            // Get Enumerator for second collection
            IEnumerator<string> secondEnumerator = second.GetEnumerator();

            while (true)
            {
                // Move both collections to the next item
                bool firstHasItem = firstEnumerator.MoveNext();
                bool secondHasItem = secondEnumerator.MoveNext();

                // Stop when one collection ends
                if (!firstHasItem || !secondHasItem)
                {
                    yield break;
                }

                // Combine the current items
                yield return
                    (firstEnumerator.Current, secondEnumerator.Current);
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30 };

            string[] names =
            {
                "Ali",
                "Ahmed",
                "Omar"
            };

            var result = numbers.MyZip(names);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Number} - {item.Name}");
            }
        }
    }
}
