namespace Implementation_Where
{


    #region  Where() in LINQ 
    /*
     * 
     What is the Where() method in C#? 
     >>>> Give me all the elements that meet a specific condition.
     >>>>> هاتلي كل العناصر اللي تحقق شرط معين

     // Example: 
     We have a list of numbers and we want to get all the even numbers from that list. 
     We can use the Where method to filter the list based on the condition that the number is even.

    // C# code:
    ////////////////////////////////////////////////////////
     var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
     var result = numbers.Where(x => x % 2 == 0);
    ////////////////////////////////////////////////////////

    // the output will be: 2, 4, 6

    // Using the Linq Where() method to filter a list of numbers based on a condition

     */
    #endregion

    public static class MyLINQ_Where_Extensions
    {

        // create a method called MyWhere
        // takes an >>>>>> IEnumerable<T> and a >>>>>>>>>>  predicate function as parameters (Condition) 
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> Condition )
        {
            foreach (T item in source) 
            {
                if (Condition(item)) //check if the item meets the condition
                {
                    yield return item; //return the item if it meets the condition
                }
              
            }
        }

    }
   
    public class Student // Class for example2
    {

    
        public string Name { get; set; }
        public int Grade { get; set; }
    
    }
    internal class Program
    {


        static void Main(string[] args)
        {

            // Example 1 

            List<int> numbers =[1,2,3,4,5,6,7,8]; // source

            var even = numbers.MyWhere(x => x % 2 == 0); // Filtering condition: Get all even numbers

            foreach (var item in even)
            {
                Console.WriteLine("The even number is: " + item);
            }




            // Example 2: Using MyWhere() with a list of students

            List<Student> students =[
                new Student{Name="Karam",Grade=50},
                new Student{Name="Yasmin",Grade=90},
                new Student{Name="Hussin",Grade=95}
                ];

            var passed = students.MyWhere(s => s.Grade >= 60);

            foreach (var student in passed)
            {
                Console.WriteLine("The student who passed is: " + student.Name);
            }
         
        }
    }
}
