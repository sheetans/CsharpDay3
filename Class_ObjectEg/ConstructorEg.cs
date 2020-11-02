using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectEg
{
    class Pen
    {
        public int ISBN;
       public string brand;
      internal  string color;

        //Constructor --special method , by default private 
        //Initialise the value for the variables
        internal Pen() //no arguements
        {
            Console.WriteLine(" Default Constructor");
        }
        internal Pen(int ISBN) // 1 arguement
        {
            this.ISBN = ISBN;
           
        }

        internal Pen( string b, string color)
        {
            brand = b;
            //refers to current class instance---> Pen
            this.color = color;
        }
        internal void DisplayPen()
        {
            Console.WriteLine(" brand:{0}||color:{1}", brand, color);
        }
    }
    class ConstructorEg
    {
        static void Main()
        {
            Pen p = new Pen(); // call constructor with no arguements
            Pen p1 = new Pen(1234); //call constructor with one arguements
            Pen pen = new Pen(" parker", " blue"); //call constructor with two arguements
            //Constructor
            /* pend.brand = " parker";
            pen.color = "blue"; */

            pen.DisplayPen();
           
            Console.Read();
        }
       

    }
}
