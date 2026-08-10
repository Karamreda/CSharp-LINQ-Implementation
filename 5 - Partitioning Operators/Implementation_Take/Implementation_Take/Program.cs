namespace Implementation_Take
{
    #region Take() in LINQ
    /*
     What is Take() in LINQ?
    It takes the first n elements from the Collection.
    بتاخد أول عنصر عناصر من المجموعة


    // Example : We have a list of numbers and we want to take the first 3 numbers from the list.
    // C# Code:
    //////////////////////////////////////////////////////////////////////
    
    int[] numbers = { 10, 20, 30, 40, 50 };
    var result = numbers.Take(3);
    foreach (var number in result)
    {
       Console.WriteLine(number);
    }


    //////////////////////////////////////////////////////////////////////
    // Output: 10 20 30



    */
    #endregion


    public static class MyLINQ_Take_Extensions
    {
        public static IEnumerable<int> MyTake(this IEnumerable<int> source, int count) // take first n elements from the collection >>> count = n
        {
            
            int taken = 0; 

            foreach (int item in source) 
            {
                if (taken >= count)
                    yield break;

                yield return item;
                taken++;
            }
        }
    }





    internal class Program

    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            var result = numbers.MyTake(3);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
