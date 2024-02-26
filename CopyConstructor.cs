using System;

namespace NCClabsuraj{
    class Person{
        private string name;
        private int age;

        //parameterized constructor
        public Person(string name, int age){
            this.name = name;
            this.age = age;
        }

        //copy contructor
        //it have parameter of type of constructor 
        public Person(Person another){
            name = another.name;
            age = another.age;
        }

        //Display function
        public void Display(){
            Console.WriteLine("Name :"+name+" Age:"+age);
        }
    }
    internal class CopyConstructor{
        public static void Main()
        {
            //creating object me and setting values
            Person me = new Person("suraj", 22);

            //Environment.NewLine lets to break to new line
            Console.WriteLine(Environment.NewLine+"original me ");
            me.Display();
            
            //creating object copy and passing the object me 
            Person Copy = new Person(me);
            Console.WriteLine(Environment.NewLine+"Copy of me ");
            Copy.Display();

        }
    }
}