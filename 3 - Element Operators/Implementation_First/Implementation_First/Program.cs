namespace Implementation_First
{
    #region First() in LINQ
    /*
    What is the First in Linq ?
    get the first item in the Collection >>>>>>>> If the collection is empty, First() will throw an exception 
    بتجيب اول عنصر 

    Example : We have a array of numbers we want the first item 
    // C# code with linq 

    -------------------------------------------------------------------------------------
    
    int[] numbers = { 10, 20, 30, 40, 50 };
    int result = numbers.First();
    Console.WriteLine(result);
    -------------------------------------------------------------------------------------
    output >>>>>>>>>>> 10 

    */
    #endregion

    public static class Mylinq_First_Extensions
    {
        public static int MyFirst(this IEnumerable<int> source) // take source collection 
        {
            foreach (int item in source)
            {
                return item;
            }

            throw new InvalidOperationException(); // is empty >>>>> throw an exception 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 10, 20, 30, 40, 50 }; // collection
            int result = numbers.MyFirst();
            Console.WriteLine(result);




        }
    }
}
