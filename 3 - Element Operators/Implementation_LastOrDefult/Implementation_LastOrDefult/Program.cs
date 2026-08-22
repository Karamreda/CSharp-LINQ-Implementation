namespace Implementation_LastOrDefult
{
    #region LastOrDefult() in Linq
    /*
    What is the Last() in Linq ?
    get the last item in the collection >>>>>>>>>>>>> if the collection is empty return defult
    بتجيب اخر عنصر

    Example : We have collection of number we want the last number
    // C# code with linq 
--------------------------------------------------------------------------------------

    int[] numbers = { 10, 20, 30, 40, 50 };
    int result = numbers.LastOrDefult();
    Console.WriteLine(result);
--------------------------------------------------------------------------------------
    output >>>> 50

    */
    #endregion
    public static class Mylinq_LastOrDefult_Extentions
    {
        public static int MyLastOrDefult(this IEnumerable<int> source)
        {
    
            int last = default; 

            foreach (int item in source)
            {
                last = item;
            }

            return last;
        
    }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int result = numbers.MyLastOrDefult();
            Console.WriteLine(result);

            //int[] numbers = {};
            //int result = numbers.MyLastOrDefult();
            //Console.WriteLine(result);
        }
    }
}

