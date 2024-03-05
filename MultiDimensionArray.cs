using System;
//namespace
namespace NCClabsuraj
{
    //public class
    public class MultiDA
    {
        //multidimension array initialization 
        private int[,,] numbers = { { { 1, 2, 3 }, { 3, 4, 6 }, { 3, 3, 6 } } };

        //return type array in method()
        public int[,,] GetArray()
        {
            //return array
            return numbers;
        }
    }


    internal class MultiDimensionArray
    {
        //main method()
        public static void Main()
        {
            //creating object
            MultiDA multiDAInstance = new MultiDA();
            int[,,] myNumbers = multiDAInstance.GetArray();
            //travrse through array
            foreach (int num in myNumbers)
            {
                //printing array
                Console.WriteLine(num + " ");
            }
        }
    }
}