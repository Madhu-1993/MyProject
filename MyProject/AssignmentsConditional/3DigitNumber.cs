using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentsConditional
{
    internal class _3DigitNumber
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num=int.Parse(Console.ReadLine());

            if(num>=100 && num<=999)
            {
                Console.WriteLine("The number is 3 digit number");
            }
            else
            {
                Console.WriteLine("The num is not 3 digit num");
            }
        }
    }
}
