using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class SaleDetails
    {
        int Salesno, ProductNo, Qty, Price;
        float TotalAmount;
        DateTime DateofSale;

       

        internal SaleDetails(int Salesno, int ProductNo, /*int Price, int Qty,*/ DateTime DateofSale)
        {
            this.Salesno = Salesno;
            this.ProductNo = ProductNo;
          //  this.Price = Price;
           // this.Qty = Qty;
            this.DateofSale = DateofSale;
        }
        internal float Sale(int Qty, int Price)
        {
            TotalAmount = Qty * Price;
            return TotalAmount;
        }
        internal void ShowData()
        {
            Console.WriteLine("salesno:{0}||productno:{1}||price:{2}||dateofsale:{3}||Qty:{4}||totalamount:{5}", Salesno, 
                ProductNo, Price, DateofSale, Qty, TotalAmount);
        }
        
       
        class SalesData
        {
            static void Main()
            {
                Console.WriteLine("Enter salesno:");
                int Salesno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter ProductNo:");
                int ProductNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Quanty:");
                int Qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Price:");
                int Price = Convert.ToInt32(Console.ReadLine());
                DateTime DateofSale = new DateTime(2000, 01, 01);
                SaleDetails saledetails = new SaleDetails(Salesno, ProductNo, DateofSale);
                saledetails.Sale(Qty, Price);
                saledetails.ShowData();
                Console.Read();


            }
        }
    }
}

