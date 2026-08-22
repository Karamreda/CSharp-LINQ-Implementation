namespace Implementation_SingleOrDefault
{
    #region SingleOrDefult() in LINQ
    /*
    What is the SingleOrDefult() in Linq ?
    Get one item >> and it must be the only different item in the collection.

    Example : We have a collection of number , we want the different item
    // C#  code with linq

    ---------------------------------------------------------------------------
    
    
    int[] numbers = { 10 };
    int result = numbers.SingleOrDefult();
    Console.WriteLine(result);
    ----------------------------------------------------------------------------
    output >>> 10

    If it contains more than one element >>>>>>>>> Expetion


    */
    #endregion


    public static class Mylinq_SingleOrDefult_Extentions
    {
        public static int MySingleOrDefult(this IEnumerable<int> source)
        {
            int result = default; // return output
            int count = 0; // count item

            foreach (int item in source)
            {
                result = item; // output
                count++;
            }

            if (count > 1)  //If it contains more than one element >>>>>>>>> Expetion
                throw new InvalidOperationException(); // Expetion

            return result;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10 };
            int result = numbers.MySingleOrDefult();
            Console.WriteLine(result);



            //int[] numbers = {  10 , 20 , 30 };
            //int result = numbers.MySingleOrDefult();
            //Console.WriteLine(result);

        }
    }
}

