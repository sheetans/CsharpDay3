using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Swapping
   
    {
        void Swap(int n1, int n2)
        {
            
            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("After swaping n1={0}, n2={1}", n1, n2);
        }
        void Swap(string a, string b)
        {
           
            string Temp = a;
            a = b;
            b = Temp;
            Console.WriteLine("After swaping a={0}, b={1}", a, b);
        }

        static void Main()
        {
            Swapping sw = new Swapping();
            Console.WriteLine("enter two numbers:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swaping n1={0},n2={1}", n1, n2);
            sw.Swap(n1, n2);
            Console.WriteLine("enter two strings:");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine("Before swaping a={0},b={1}", a, b);
            sw.Swap(a, b);

            Console.Read();
        }
    }
}

