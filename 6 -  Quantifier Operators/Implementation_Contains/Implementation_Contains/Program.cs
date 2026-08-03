namespace Implementation_Contains
{
    #region Contains() in LINQ
    /*

    What is Contains() in LINQ?
    >>>>>>>>>>>> Checks whether the item is inside the Collection or not.
    بيشوف العنصر موجود في الكولكشن ولا لا


    // Example : We have a list of numbers and we want to check if a specific number is present in that list or not.
    We can use the Contains() method to achieve this.


    // C# Code With LINQ
    
    ///////////////////////////////////////////////////////////////////////////////////
    
    List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
    bool containsNumber = numbers.Contains(30);
    Console.WriteLine(containsNumber); 

    ///////////////////////////////////////////////////////////////////////////////////

    // Output: True



     */

    #endregion

    public static class MyLINQ_Contains_Extensions
    {
        public static bool MyContains(this IEnumerable<int> source, int value) // take the collection and the value to check
        {

            foreach (var item in source)
            {
                if (item == value) // check if the current item is equal to the specified value
                {
                    return true; // if found, return true

                }
            }

            return false;
        }




        internal class Program
        {
            static void Main(string[] args)
            {
                List<int> numbers = new List<int> { 10, 20, 30, 40, 50 }; // Source collection of numbers
                bool containsNumber = numbers.MyContains(30); // Value = 30
                Console.WriteLine(containsNumber); // Output: True
         









            }
        }
    }
}
