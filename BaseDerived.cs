using System;
namespace NCClabsuraj{
    public class Base {
        public virtual void Output(){
            Console.WriteLine("base class");
        }
    }
    public class Derived:Base{
        public override void Output(){
            Console.WriteLine("Derived class");
        }
    }
    internal class BaseDerived{
        public static void Main(string[] args)
        {
            Base B1 = new Base();
            Derived D1 = new Derived();
            B1.Output();
            B1 = D1;
            D1.Output();
        }
    }
}