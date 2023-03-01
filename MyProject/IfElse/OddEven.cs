using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.IfElse
{
    internal class OddEven
    {
        static void Main(String[]args)
        {

            int num;
             num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number");

            if (num % 2 == 0)

            {
                Console.WriteLine("Num is Even");
            }


            else
            {
                Console.WriteLine("Num is Odd");
            }
        }
    }
}

