using System.Collections;

namespace Implementation_OFType
{
    #region OfType() inLINQ

    /*
     What is OfType() in LINQ?
     >>>>> Filter items by data type 
     بيرجع العناصر من نوع معين فقط

    Example: We have a list of objects that contains different types of data,
    such as integers, strings, and doubles. 
    We want to filter out only the String from this list

    // C# code 
    ////////////////////////////////////////////////////////
    ArrayList list =[ 1, "Karam" , 2 , "Said" , 3.5 , true];
    list.OfType<string>()
    ////////////////////////////////////////////////////////
    
    // the output will be: Karam , Said
    
    // using OfType() in LINQ, we can easily filter out the elements of a specific type from a collection.
      
      
      
     
     */





    #endregion
    public static class MyLINQ_OfType_Extension{
        public static IEnumerable<TResult> MyOfType<TResult>(this IEnumerable source)
        {
            foreach (object item in source) 
            {
                if (item is TResult) // Check if the item is of the specified type
                {
                    yield return (TResult)item; // Cast the item to the specified type and yield it
                }
                // anther if you can use it like this

                //if (item is TResult result)
                //{
                //    yield return result;
                //}
               


            }
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList { 1, "Karam", 2, "Said", 3.5, true };
            var filteredList = list.MyOfType<string>(); // TResult = String
            foreach (string item in filteredList)
            {
                Console.WriteLine("The filtered item is: " + item);
            }
        }
    }
}
