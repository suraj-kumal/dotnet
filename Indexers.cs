using System;

//namespace 
namespace NCClabsuraj
{

    //class
    public class JDMcars
    {
        private string name, company, model;
        private int year;
        public JDMcars(string name, string company, string model, int year)
        {
            this.name = name;
            this.company = company;
            this.model = model;
            this.year = year;
        }
        public object this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return this.name;
                }
                else if (i == 1)
                {
                    return this.company;
                }
                else if (i == 2)
                {
                    return this.model;
                }
                else if (i == 3)
                {
                    return this.year;
                }
                else
                {
                    return 0;
                }

            }

            set
            {
                if (i == 0)
                {
                    this.name = (string)value;
                }
                else if (i == 1)
                {
                    this.company = (string)value;
                }
                else if (i == 2)
                {
                    this.model = (string)value;
                }
                else if (i == 3)
                {
                    this.year = (int)value;
                }

            }

        }

    }

    internal class Indexers
    {
        public static void Main(string[] args)
        {
            JDMcars MyCar = new JDMcars("NissanGTR-R35", "Nissan", "GTR-R35 Nismo", 2015);
            Console.WriteLine(Environment.NewLine + MyCar[0] + Environment.NewLine + MyCar[1] + Environment.NewLine + MyCar[2] + Environment.NewLine + MyCar[3]);
            MyCar[0] = "Supra MK5";
            MyCar[1] = "Toyota";
            MyCar[2] = "MK5";
            MyCar[3] = 2022;
            Console.WriteLine(Environment.NewLine + MyCar[0] + Environment.NewLine + MyCar[1] + Environment.NewLine + MyCar[2] + Environment.NewLine + MyCar[3]);

        }
    }
}