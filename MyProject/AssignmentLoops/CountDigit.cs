using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class CountDigit
    {
        static void Main(string[] args)
        {
            int num, count = 0;
            Console.WriteLine("Enter the number");
            num=int.Parse(Console.ReadLine());

            while(num>0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine("The count of digit given number is " + count);
        }
    }
}
