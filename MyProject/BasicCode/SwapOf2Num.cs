using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BasicCode
{
    internal class SwapOf2Num
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 2 num");
            Console.WriteLine("Befor Swapping");
            num3 = num1;
            num1= num2;
            num2= num3;
            Console.WriteLine("Befor Swapping");

        }

    }
}
