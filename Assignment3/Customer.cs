using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Customer
    {
        int Customerid, Age; long Phone;
        string Name, City;

        internal Customer() //No arguements
        {
            Console.WriteLine(" Constructor with No arguements");
        }

        internal Customer( int Customerid, int Age, long Phone, string Name, string City) //Constructor with arguements
        {
            this.Customerid = Customerid;
            this.Age = Age;
            this.Phone = Phone;
            this.Name = Name;
            this.City = City;
        }
         internal void DisplayCustomer()
        {
            Console.WriteLine(" Customerid:{0}||Name:{1}||Age:{2}||Phone:{3}||City:{4}", Customerid,Name,Age,Phone,City);
        }
        class CustomerData
        {

            static void Main()
            {
                Customer c = new Customer();
                Customer customer = new Customer(101, 20, 9876543210, "Rahul", "Jaipur");
                customer.DisplayCustomer();
                Console.Read();

            }
        }
    }
}

