using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class car
    {
        // Private attributes
        private string make;
        private string model;
        private int currentSpeed;      
        private int engineSize;


        //Putting values in
        public car(string m, string mo, int c, int e)
        {
            this.make = m;
            this.model = mo;
            this.currentSpeed = c;
            this.engineSize = e;
        }

        //Input make
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        //Input model
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        //Input current speed
        public int CurrentDpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }
        //Input engine size
        public int EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }

        //The string to show all values
        public override string ToString()
        {
            return "This car is a " + make + " its model is " + model + " its current speed is " + currentSpeed + " and its engine size is " + engineSize;
        }
    }
}
