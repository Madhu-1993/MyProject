using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.IfElse
{
    internal class DivisibleBy3Or9
    {
        static void Main(string[] args)
        {
            int num;
            num=int.Parse(Console.ReadLine());
            Console.WriteLine(num);

            if(num%3==0)
            {
                Console.WriteLine("The num is divisible by 3");
            }
            else if(num%9==0)
            {
                Console.WriteLine("The num is divisible by 9");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            Console.ReadLine();
        }
    }
}
