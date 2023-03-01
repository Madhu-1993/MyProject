using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.IfElse
{
    internal class PosNegOr0
    {
        static void Main(string[] args)
        {
            int num;
            num=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number");
            if(num>0) 
            {
                Console.WriteLine("The no is positive");
            }
            else if(num<0) 
            {
                Console.WriteLine("The no is negative");
            }
            else
            {
                Console.WriteLine("The no is 0");
            }
        }
    }
}
