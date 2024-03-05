using System;
namespace NCClabsuraj
{
    class OverLoadmethod
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public string Add(string a, string b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(int a, double b)
        {
            return a + b;
        }
    }
    internal class MethodOverloading
    {
        public static void Main(string[] args)
        {
            OverLoadmethod overLoadmethod = new OverLoadmethod();
            Console.WriteLine(overLoadmethod.Add(2.6, 3.8));
            Console.WriteLine(overLoadmethod.Add(2, 3));
            Console.WriteLine(overLoadmethod.Add("suraj", "kumal"));
            Console.WriteLine(overLoadmethod.Add(2, 3, 4));
            Console.WriteLine(overLoadmethod.Add(2, 3.8));
        }
    }
}