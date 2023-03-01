using MyProject.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.WhileLoop
{
    internal class Palindrom
    {
        static void Main(string[]args)
        {
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num");
            int rev = 0;
            int n = num;

            while(num>0)
            {
                num = num % 10;
                rev = rev + num;
                num = num / 10;
            }
            if(n == num)
            {
                Console.WriteLine("The number is palindrom number");
            }
            else
            {
                Console.WriteLine("The number is not palindrom");
            }
        }
    }
}
