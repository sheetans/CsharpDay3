using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Product
    {
        int pid, price;
        string pname;
        static string shopname = "RelianceFresh";
        internal Product(int pid, string pname, int price)
        {
            this.pid = pid;
            this.pname = pname;
            this.price = price;
        }

        internal void Display()
        {
            Console.WriteLine("the product id:{0}, product name:{1},price:{2} and shopname is {3}", pid, pname, price, shopname);
        }
    }
    class Prodetails
    {
        static void Main()
        {
            Console.WriteLine("the size is:");
            int n = Convert.ToInt32(Console.ReadLine());
            Product[] pd = new Product[n];
            for (int i = 0; i < pd.Length; i++)
            {
                Console.WriteLine("enter productno:");
                int Pid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter Productname:");
                string pname = Console.ReadLine();
                Console.WriteLine("enter price");
                int price = Convert.ToInt32(Console.ReadLine());
                pd[i] = new Product(Pid, pname, price);
            }
            for (int i = 0; i < pd.Length; i++)
            {
                pd[i].Display();
            }
            Console.Read();
        }
    }
}

