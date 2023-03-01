using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.WhileLoop
{
    internal class AvgOfDigit
    {
        static void Main(string[]args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no");
            int n = num;
            int sum=0, avg;

            while(num>0)
            {
                num = num % 10;
                sum = sum = num;
                num = num / 10;
            }
            avg = sum / n;
        }
    }
}
