namespace Implementation_SequenceEqual
{
    #region SequenceEqual() in LINQ
    /*
    What is the SequenceEqual() in Linq ?
    Compares two collections and checks if they are equal
    SequenceEqual() checks:
    1- Same number of elements
    2- Same elements
    3- Same order

    بتقارن اتنين وتشوف هل هما متساويين تمامًا أم لا
    نفس عدد العناصر
    نفس العناصر
    بنفس الترتيب



    Example : We have two collections of numbers >>>>>> and we want to check if they are equal.

    // C# code with linq
    ---------------------------------------------------------------------------

    int[] numbers1 = { 10, 20, 30 };
    int[] numbers2 = { 10, 20, 30 };

    bool result = numbers1.SequenceEqual(numbers2);
    Console.WriteLine(result);

    ----------------------------------------------------------------------------
    output >>>
    True

    If the elements are different or the order is different
    >>>>>>>>> False

    */
    #endregion


    public static class Mylinq_SequenceEqual_Extentions
    {
        public static bool MySequenceEqual(this IEnumerable<int> first, IEnumerable<int> second)
        {
            // Get the enumerators for both collections
            using IEnumerator<int> firstEnumerator = first.GetEnumerator();
            using IEnumerator<int> secondEnumerator = second.GetEnumerator();

            while (true)
            {
                // Move to the next element
                bool firstHasNext = firstEnumerator.MoveNext();
                bool secondHasNext = secondEnumerator.MoveNext();

                // If one collection has more elements
                if (firstHasNext != secondHasNext)
                    return false;

                // Both collections are finished
                if (!firstHasNext)
                    return true;

                // Compare current elements
                if (firstEnumerator.Current != secondEnumerator.Current)
                    return false;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 10, 20, 30 };
            int[] numbers2 = { 10, 20, 30 };
            bool result = numbers1.MySequenceEqual(numbers2);
            Console.WriteLine(result);


            // Different order >>> False

            //int[] numbers1 = { 10, 20, 30 };
            //int[] numbers2 = { 30, 20, 10 };
            //bool result = numbers1.MySequenceEqual(numbers2);
            //Console.WriteLine(result);


            // Different elements >>> False

            //int[] numbers1 = { 10, 20, 30 };
            //int[] numbers2 = { 10, 20, 40 };
            //bool result = numbers1.MySequenceEqual(numbers2);
            //Console.WriteLine(result);


            // Different count >>> False

            //int[] numbers1 = { 10, 20, 30 };
            //int[] numbers2 = { 10, 20 };
            //bool result = numbers1.MySequenceEqual(numbers2);
            //Console.WriteLine(result);
        }
    }
}