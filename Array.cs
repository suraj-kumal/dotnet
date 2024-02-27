using System;
 namespace NCClabsuraj{
    class Even{
        //array delcare
        //[] empty means can be set letter
        private int[] num;
        public Even(){
            //logic to store even number between 0 to 30
            num = new int[15];
            int i;
            int index=0;
            for(i=0;i<30;i++){
                if(i%2==0){
                    num[index] = i;
                    index++;
                }
            }
        }

        //display even numbers
        public void Display(){
            for(int i =0;i<num.Length;i++){
                Console.WriteLine($"index of {i} = "+num[i]);
            }

        }
    }
    internal class Array{
        public static void Main()
        {
                Even num = new Even();
                num.Display();
        }
    }
 }