using System;
 namespace NCClabsuraj{
    class Even{
        private int[] num;
        public Even(){
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
        public void Display(){
            for(int i =0;i<num.Length;i++){
                Console.WriteLine($"index of {i} = "+num[i]);
            }

        }
    }
    internal class Array{
        public static void Main(string[] args)
        {
                Even num = new Even();
                num.Display();
        }
    }
 }