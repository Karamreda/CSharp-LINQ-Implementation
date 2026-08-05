namespace Implementation_ToList
{
    #region ToList in LINQ
    /*
     What is ToList in LINQ?
     >>>>>Take the sequence and create a new List from it.
    تستخدم لتحويل أي 
    IEnumerable<T>
    إلى 
    List<T>
       
    // Example : We have a list of numbers and we want to filter out the even numbers 
    and create a new list from them.
    
    // C# code:

    ////////////////////////////////////////////////////////////////////////////////////////////

    List<int> numbers = new() { 1, 2, 3, 4, 5 };
    List<int> result = numbers.Where(n => n % 2 == 0).ToList();
    foreach (var item in result)
    {
       Console.WriteLine(item);
    }

    ////////////////////////////////////////////////////////////////////////////////////////////
    
    // the output will be: 2, 4




     */



    #endregion

    public static class MyLINQ_ToList_Extensions
    {
        public static List<T> MyToList<T>(this IEnumerable<T> source) // the type method is list >>>> take the source  
        {
            List<T> result = new(); 

            foreach (var item in source) // add item in new list 
            {
                result.Add(item);
            }

            return result;
        }



    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            List<int> result = numbers.Where(n => n % 2 == 0) // Source is numbers and filter the even numbers
                .MyToList(); 
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }




        }
    }
}
