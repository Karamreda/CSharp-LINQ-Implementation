namespace Implementation_Any
{

    #region Any() in C# LINQ 

    /*
    What is the Any() method in C#?
    >>>>>>>>> It returns true if at least one element meets the condition.
    ترجع ترو لو كان هناك عنصر واحد على الاقل يحقق الشرط


    // Example : We have a list of numbers and we want to check if there is any even number in the list. 
    We can use the Any() method to achieve this.


    // C# code 
    ////////////////////////////////////////////////////////////////
    
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
    bool Result = numbers.Any(n => n % 2 == 0);
    Console.WriteLine(Result);

    ////////////////////////////////////////////////////////////////
    the output will be true because there are even numbers (2 and 4) in the list.


    */
    #endregion

    public static class MyLINQ_Any_Extensions
    {



        public static bool MyAny<T>(this IEnumerable<T> source, Func<T, bool> Condition)
        {
            foreach (var item in source)
            {
                if (Condition(item)) // Check if the condition is true for the current item
                {
                    return true; // If any item meets the condition, return true
                }
               
            }
            return false;
        }
    }
    



    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int> { 1, 2, 3, 4, 5 }; // Source
            bool result = list.MyAny(n => n % 2 == 0); 
            Console.WriteLine(result); // Output: True











        }
    }
}
