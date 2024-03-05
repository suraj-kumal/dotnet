using System;
namespace NCClabsuraj{
    class Human{
        public virtual void Display(){
            Console.WriteLine("\nI am Human");
        }
    }
    class Male:Human{
        public override void Display()
        {
            base.Display();
            Console.WriteLine("I am Male");
        }
    }
    class Female:Human{
        public override void Display()
        {
            base.Display();
            Console.WriteLine("I am Female");
        }
    }
    internal class MethodOverriding(){
        public static void Main(string[] args)
        {
            Human living = new Human();
            living.Display();
            Male male = new Male();
            living = male;
            living.Display();
            Female female = new Female();
            living = female;
            living.Display();
        }
    }

}