using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ClassesAndObejects
{
    class ProductClass
    {
        string productName;
        int productPrice;
        int productQuantity;
       // int bill;
        public void Details(string pname,int pprice,int pquantity)
        {
            productName = pname;
            productPrice = pprice;
            productQuantity = pquantity;

        }
       
        public void Display()
        {
            Console.WriteLine(productName+" "+productPrice+" "+productQuantity);
            if(productQuantity>0)
            {
                int n=productQuantity;
                for (int i = 1; i <= n; i++)
                {
                    int price = 0;
                    price=price+productPrice;
                    Console.WriteLine("Total bill=" + " " + productName + " " + price + " " + productQuantity);
                }
                }
            else
            {
                Console.WriteLine("Error");
            }
        }
        static void Main(string[] args)
        {
            ProductClass pc= new ProductClass();
            pc.Details("Mobile" , 10000 , 10);
            pc.Display();
        }

    }
}
