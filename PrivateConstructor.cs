using System;

namespace NCClabsuraj{
    class Nezuko{
        //only this class allows to create object
        //not even child class use this class to create obejcts
        private Nezuko(){
            Console.WriteLine("nezuko chyaan");
        }
        public Nezuko(string text){
            Console.WriteLine(text);
        }
    }
    internal class PrivateConstructor{
        public static void Main(string[] args)
        {
            //Nezuko chan = new Nezuko();
            //above line allowed due to private constructor
            Nezuko chan = new Nezuko("NEZUKO CHYAAN");
        }
    }
}