using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentsConditional
{
    internal class DivisibleBy5and11
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the num");
            num = int.Parse(Console.ReadLine());

            if (num % 5 == 0)
            {
                Console.WriteLine(" The number is divisible by 5.");
            }
            else if(num%11==0)
            {
                Console.WriteLine(" The number is divisible by 11.");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 5 and 11.");
            }
        }
    }
}
