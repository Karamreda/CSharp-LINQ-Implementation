namespace Implementation_FirstOrDefult
{
    #region FirstOrDefult() in LINQ
    /*
    What is the FirstOrDefult() in Linq ?
    get the first item in the Collection >>>>>>>> If the collection is empty, FirstOrDefult() will return defult
    بتجيب اول عنصر 

    Example : We have a array of numbers we want the first item 
    // C# code with linq 

    -------------------------------------------------------------------------------------
    
    int[] numbers = { 10, 20, 30, 40, 50 };
    int result = numbers.FirstOrDefult();
    Console.WriteLine(result);
    -------------------------------------------------------------------------------------
    output >>>>>>>>>>> 10 

    */
    #endregion

    public static class Mylinq_FirstOrDefult_Extensions
    {
        public static int MyFirstOrDefult(this IEnumerable<int> source) // take source collection 
        {
            foreach (int item in source)
            {
                return item;
            }

            return default;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 10, 20, 30, 40, 50 }; // collection
            int result = numbers.MyFirstOrDefult();
            Console.WriteLine(result);

            // if empty
            //int[] numbers = {}; // collection
            //int result = numbers.MyFirstOrDefult();
            //Console.WriteLine(result);



        }
    }
}