using System;
namespace NCClabsuraj
{
    delegate void Message(string msg);
    internal class DelegateTest
    {
        public static void Main(string[] args)
        {
            Message myMessage = new Message(Display);
            myMessage.Invoke("Hello");
            static void Display(string msg)
            {
                Console.WriteLine(msg);
            }
        }
    }
}