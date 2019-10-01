using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intializing
            LunchDemo lunch1 = new LunchDemo();
            LunchDemo lunch2 = new LunchDemo();
            LunchDemo lunch3 = new LunchDemo();
            //lunch1 
            lunch1.Entree = "hamburger";
            lunch1.Side = "fries";
            lunch1.Drink = "cola";
            //lunch2 
            lunch2.Entree = "hot dog";
            lunch2.Side = "chips";
            lunch2.Drink = "lemonade";
            //lunch3 
            lunch3.Entree = "pizza";
            lunch3.Side = "salad";
            lunch3.Drink = "iced tea";

            //Table
            Console.WriteLine( "Entree                    side                      Drinks");
            Console.WriteLine($"{lunch1.Entree}                  {lunch1.Side}                       {lunch1.Drink}");
        }
    }
}
