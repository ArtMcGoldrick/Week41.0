using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a Car class with the following properties - Make, Model, Current Speed, Engine Size.
            //Use long hand properties, with private attributes and getters and setters.  In the program.cs 
            //file make use of this class by creating two objects and displaying details on the cars. 

            //Setting up
            car[] myCar = new car[1];
            string make, model;
            int currentSpeed, engineSize;

            //Loop to enter values
            for (int i = 0; i < myCar.Length; i++)
            {
                //Enter make
                Console.Write("Please enter make for car number {0} : ", i + 1);
                make = Console.ReadLine();

                //Enter model
                Console.Write("Please enter model for car number {0} : ", i + 1);
                model = Console.ReadLine();

                //Enter currentspeed
                Console.Write("Please enter current speed for car {0} : ", i + 1);
                currentSpeed = int.Parse(Console.ReadLine());

                //Enter engine size
                Console.Write("Please enter engine size for car {0} : ", i + 1);
                engineSize = int.Parse(Console.ReadLine());
            }
        }
    }
}
