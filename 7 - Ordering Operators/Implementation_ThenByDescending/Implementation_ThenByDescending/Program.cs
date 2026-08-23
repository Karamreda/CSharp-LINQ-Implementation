namespace Implementation_ThenByDescending
{
    #region ThenByDescending() in LINQ
    /*
    What is the ThenByDescending() in Linq ?
    Performs a secondary sorting in descending order
    First, we use OrderBy()
    If two elements have the same value
    ThenByDescending() sorts them using another value
    in descending order.

    Example : We have students >>> We want to sort students by Age ascending.If two students have the same Age,
    we sort their Names descending

    // C# code with linq

    ---------------------------------------------------------------------------
    List<Student> students = new List<Student>
     {
      new Student { Name = "Karam", Age = 20 },
      new Student { Name = "Ahmed", Age = 20 },
      new Student { Name = "Ali", Age = 18 },
      new Student { Name = "Omar", Age = 20 }
    };
    var result = students.OrderBy(x => x.Age).ThenByDescending(x => x.Name);

    ----------------------------------------------------------------------------
    output >>>
    18 - Ali
    20 - Omar
    20 - Karam
    20 - Ahmed

    */
    #endregion


    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    public static class Mylinq_ThenByDescending_Extentions
    {
        public static IEnumerable<Student> MyThenByDescending( this IEnumerable<Student> source )
        {
            var students = source.ToList(); // Convert collection to List

            // Sort by Age first
            for (int i = 0; i < students.Count - 1; i++)
            {
                for (int j = i + 1; j < students.Count; j++)
                {
                    // Compare Age 
                    if (students[i].Age > students[j].Age)
                    {
                        Student temp = students[i];

                        students[i] = students[j];
                        students[j] = temp;
                    }
                    // If Age is equal >>>>>> compare Name >>>>>>>>> ( descending )
                    else if (students[i].Age == students[j].Age && string.Compare(students[i].Name, students[j].Name) < 0)
                    {
                        Student temp = students[i];

                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }

            // Return the sorted students
            foreach (Student student in students)
            {
                yield return student;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Karam", Age = 20 },
                new Student { Name = "Ahmed", Age = 20 },
                new Student { Name = "Ali", Age = 18 },
                new Student { Name = "Omar", Age = 20 }
            };
            var result = students.MyThenByDescending();
            foreach (Student student in result)
            {
                Console.WriteLine($"{student.Age} - {student.Name}");
            }
        }
    }
}
