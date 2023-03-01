using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class FreqOfDigitInNumber
    {
        static void Main(string[] args)
        {
            long num,rem;
            int digit, count = 0;
            Console.WriteLine("Enter the number");
            num =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the digit to be counted");
            digit= int.Parse(Console.ReadLine());

            while(num>=0)
            {
                rem = num % 10;

                if (rem == digit)
                {
                    count++;
                    num = num / 10;
                }

            }
            Console.WriteLine("The frequency of digit in number is " + digit);

        }
    }
}
