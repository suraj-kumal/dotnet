using System;

namespace NCClabsuraj{
    class Cube{

        //compiler makes default contructor if no constructor is created
        //it initialize values to 0 
        //for string / reference type it initializes value to null
        public double Length,breadth,height;

        //non parametrized default contructor
        public Cube(){
            Length = 3.5;
            breadth = 2.6;
            height= 4.8;
        }
        //parameterized default constructor
        public Cube(double length,double breadth, double height){
            this.Length = length;
            this.breadth = breadth;
            this.height = height;
        }

        //function to set values
        public void SetDimensions(double l, double b, double h){
            Length = l;
            breadth = b;
            height = h;
            
        }


        //function to display
        public void Display(){
            Console.WriteLine("Length :"+Length+"Breadth:"+breadth + " height:"+height);
        }

    }
    internal class Constructor{
        static void Main()
        {
            //set the values to parameterzed default contructor 
            Cube C1 = new()
            {
                Length = 3.6,
                breadth = 4.8,
                height = 1.8
            };
            //display method
            C1.Display();
            Console.WriteLine();

            //calling non parameterized constructor
            Cube C3 = new Cube();

            //display method
            C3.Display();
            Console.WriteLine();


            Cube C2 = new Cube();
            //set the values to method
            C2.SetDimensions(11.5,12.6,9.5);

            //display method
            C2.Display();
            Console.WriteLine();
        }

    }
}