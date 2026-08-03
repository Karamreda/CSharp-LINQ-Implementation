namespace Implementation_Range
{
    #region Range() in LINQ
    /*
    What is Range() in C# LINQ?
    >>>> Used to generate a sequence of integers starting from a specific number for a specific count.
    إنشاء سلسلة من الأعداد الصحيحة تبدأ من رقم محدد لعدد محدد

    // Example : We can use the Range() method to generate a sequence of integers from 1 to 10 as follows:

    // C# code With LINQ
    ///////////////////////////////////////////////////////////////////////////////////////

    var numbers = Enumerable.Range(1, 10);
    foreach (var n in numbers)
        {
            Console.WriteLine(n);
        }

    ///////////////////////////////////////////////////////////////////////////////////////
    */
    #endregion
     
    public static class MyLINQ_Range_Extensions
    {
        public static IEnumerable<int> MyRange(int start, int count) // Takes two parameters: start and count, and returns an IEnumerable<int> sequence of integers.
        {
            for (int i = 0; i < count; i++)
            {
                yield return start + i; // Generates the next integer in the sequence
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = MyLINQ_Range_Extensions.MyRange(1, 10);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);

            }
        }
    }
}
