using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectEg
{
    class Mobile
    {
        internal static string companyname; //Class variable
        internal string Modelname; //object variable
        //non static method can access both static and non static information
        internal void DisplayModel()
        {
            Console.WriteLine(" companyname:{0}||Modelname{1}", companyname, Modelname);
        }
        //static method can access only static variables cant access not non static variable

        internal static void Getdata()
        {
           
            Console.WriteLine(" companyname:{0}||Modelname{1}", companyname /*,Modelname*/);

        }
    }


    class StaticEg2
    {
        internal static void Info()
        {
            Console.WriteLine("static method");
        }
        static void Main()
        {
            Mobile mobile = new Mobile();
            mobile.Modelname = "Moto g4 plus";
            Mobile.companyname = "motorola";
            Mobile.Getdata();
            mobile.DisplayModel();
            //Info() is in the same class so class name is not required
            Info();
            Console.Read();

        }
    }
}
