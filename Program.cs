//allows us to use namespace known as 'system'
using System;
//defining custom namespace ,collection of classes
namespace NCClabsuraj{
    //class name
    /*The convention is to use PascalCase for class names. 
    PascalCase means that the first letter of each word in the identifier is capitalized, 
    and there are no underscores between the words*/
    //public is access modifier of class can be accessed with other assembly or projects
    //if donot specify the default is internal
    // internal is access modifier of class that can accessed within the same assembly or same project
    public class FirstProgram{
        //public is access modifier and can be accessed outside the class
        //it is usually set to functions
        //void return type and every functions should have return type
        public void HelloWorld(){
            //System allows us to use console class
            //Writeline() is the method of console class
            //Console.WriteLine(); is method to display the output in console 
            Console.WriteLine("hello world");
        }
    }
    // internal is access modifier of class that can accessed within the same assembly or same project
    internal class Program{
        //static allows us to run method without creating object
        //main() method is the entry point of program
        static void Main()
        {
            //creating empty object world
            //memory is not allocated in ram
            //FirstProgram world;

            //creating object hello allocating memory
            FirstProgram hello = new FirstProgram();
            //call the method using the object 
            hello.HelloWorld();
        }
    }
}
