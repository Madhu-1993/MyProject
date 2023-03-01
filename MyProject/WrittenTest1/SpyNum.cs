
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.WrittenTest1
{
    internal class SpyNum
    {
        static void Main(string[]args)
        {
            int prod = 1,num, sum = 0;
            num = int.Parse(Console.ReadLine());

            while(num>0)
            {
               num= num % 10;
               prod = prod * num;
               sum = sum + num;
               num = num / 10;
            }
            if(prod==sum)
            {
                Console.WriteLine("The number is spy number");
            }
            else
            {
                Console.WriteLine("The number is not spy number");
            }
        }
    }
}
