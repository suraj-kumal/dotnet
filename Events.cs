using System;
namespace NCClabsuraj{
    public delegate void Notify();
    public class Process{
        public event Notify ProcessCompleted;
        public void StartProcess(){
            Console.WriteLine("started");
            Console.WriteLine("running");
            OnProcessCompleted();
        }
        protected virtual void OnProcessCompleted(){
            ProcessCompleted?.Invoke();
        }
        public static void Main(string[] args)
        {
            Process p1 = new Process();
            p1.ProcessCompleted += p1_ProcessCompleted;
            p1.StartProcess(); 
        }
        private static void p1_ProcessCompleted(){
            Console.WriteLine("completed");
        }
    
        
    }
}