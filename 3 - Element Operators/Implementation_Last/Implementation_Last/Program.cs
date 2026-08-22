namespace Implementation_Last
{
    #region Last() in Linq
    /*
    What is the Last() in Linq ?
    get the last item in the collection >>>>>>>>>>>>> if the collection is empty throw Exception
    بتجيب اخر عنصر

    Example : We have collection of number we want the last number
    // C# code with linq 
--------------------------------------------------------------------------------------

    int[] numbers = { 10, 20, 30, 40, 50 };
    int result = numbers.Last();
    Console.WriteLine(result);
--------------------------------------------------------------------------------------
    output >>>> 50

    */
    #endregion
    public static class Mylinq_Last_Extentions
    {
        public static int MyLast(this IEnumerable<int> source)
        {
            int last = default; // return output
            bool found = false;

            foreach (int item in source)
            {
                last = item;
                found = true;
            }
            
            if (!found) 
                throw new InvalidOperationException(); // Exception

            return last;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int result = numbers.MyLast();
            Console.WriteLine(result);

            //int[] numbers = {};
            //int result = numbers.MyLast();
            //Console.WriteLine(result);
        }
    }
}
