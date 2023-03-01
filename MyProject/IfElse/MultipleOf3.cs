using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.IfElse
{
    internal class MultipleOf3
    {
        static void Main(string[] args)
        {
            int num;
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number");
            if(num%3==0)
            {
                Console.WriteLine("The num is Multiply by 3");
            }
            else
            {
                Console.WriteLine("The num is not multiple of 3");
            }
        }
    }
}
