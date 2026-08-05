namespace Implementation_ToArray
{

    #region ToArray in LINQ
    /*
     What is ToArray in LINQ?
     >>>>>>>>> Convert the sequence into an array
     تستخدم لتحويل أي 
    Collection 
    إلى
    Array

    // Example : we have a list of integers and we want to convert it into an array using the ToArray method in LINQ.

    // C# code

    ///////////////////////////////////////////////////////////////////////////////////
    
    List<int> numbers = new() { 1, 2, 3, 4, 5 };
    int[] result = numbers.ToArray();
    foreach (var item in result)
    {
      Console.WriteLine(item);
    }
    ////////////////////////////////////////////////////////////////////////////////////
     */


    public static class MyLINQ_ToArray_Extensions
    {
        public static T[] MyToArray<T>(this IEnumerable<T> source) 
        {
            List<T> temp = new(); // Create a list to hold the elements

            foreach (var item in source) // Iterate through each element in the source collection
            {
                temp.Add(item); // Add the element to the list
            }
          

            T[] array = new T[temp.Count]; // Create an array of the same size as the list

            for (int i = 0; i < temp.Count; i++) // Iterate through the list
            {
                array[i] = temp[i]; // Copy each element from the list to the array
            }

            return array;
        }
    }







    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new() { 1, 2, 3, 4, 5 }; // source collection
            int[] result = numbers.MyToArray(); 
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }



        }
    }
}
