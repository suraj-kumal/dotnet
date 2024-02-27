using System;

namespace NCClabsuraj{
    class JDM{
        //static keyword is used declare static members
        static public string CarName;
        //static constructor initalizes before main method
        //static constructor is used to initialize the static variable
        static JDM(){
            CarName  = "GTR-R34 NISSAN";
            Console.WriteLine(CarName+Environment.NewLine);
        }

        public JDM(){
            Console.WriteLine("construtor"+Environment.NewLine);
        }

    }
    internal class StaticConstructor{
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Method"+Environment.NewLine);
            JDM cars = new JDM();
        }
    }
}