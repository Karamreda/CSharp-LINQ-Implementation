namespace Implementation_TakeWhile
{
    #region TakeWhile() in LINQ
    /*
    What is the TakeWhile() in Linq ?
    It prefers to take Elements as long as the Condition is met
    بتاخد العنصر اللي بيحقق شرط

    // Exampel : We have a list of numbers , we want the even number
    // C# code with LINQ

    ////////////////////////////////////////////////////////////////////
    
    int[] numbers = { 1, 2, 3, 4, 5, 6 , 7 ,8 };
    var result = numbers.TakeWhile(x =>  x % 2 == 0);
    foreach (var number in result)
    {
        Console.WriteLine(number);
    }

    ///////////////////////////////////////////////////////////////////
     Output : 2 4 6 8 


    */
    #endregion

    public static class MyMyLinq_TakeWhile_Extensions
    {
        public static IEnumerable<int> MyTakeWhile(this IEnumerable<int> source , Func<int, bool> Condition)
        {
            foreach (int item in source)
            {
                if (!Condition(item)) 
                    yield break;

                yield return item;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 2, 4, 6, 7, 8, 10 };
            var result = numbers.MyTakeWhile(x => x % 2 == 0);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }

        }
    }
}
