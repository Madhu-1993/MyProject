using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.WhileLoop
{
    internal class Armstrong
    {
        static void Main(string[]args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number");
            int sum = 0;
            int n = num;

            while(num>0)
            {
                num = num % 10;
                sum = sum + (num * num * num);
                num = num / 10;
            }
            if(n==num) 
            {
                Console.WriteLine("The number is armstrong");
            }
            else
            {
                Console.WriteLine("the number is not armstrong");
            }
        }
    }
}
