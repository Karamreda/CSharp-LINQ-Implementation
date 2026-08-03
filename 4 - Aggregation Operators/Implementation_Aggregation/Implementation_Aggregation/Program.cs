namespace Implementation_Aggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = new(){ 10, 20, 30, 40, 50 }; // Sample collection of numbers




            // Count
            var count = numbers.MyCount();

            Console.WriteLine($"Count = {count}"); // output: Count = 5



            // Sum
            var sum = numbers.MySum();

            Console.WriteLine($"Sum = {sum}"); // output: Sum = 150



            // Average
            var avg = numbers.MyAverage();

            Console.WriteLine($"Average = {avg}"); // output: Average = 30



            // Min
            var min = numbers.MyMin();

            Console.WriteLine($"Min = {min}"); // output: Min = 10



            // Max
            var max = numbers.MyMax();

            Console.WriteLine($"Max = {max}"); // output: Max = 50



            // Aggregate
            var multiply = numbers.MyAggregate(  (total, number) => total * number);

            Console.WriteLine($"Aggregate Multiply = {multiply}"); // output: Aggregate Multiply = 12000000
        }
    }
}
