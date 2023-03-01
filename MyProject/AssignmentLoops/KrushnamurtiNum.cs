using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class KrushnamurtiNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int n = num;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                int fact = 1;
                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            if (sum == n)
            {
                Console.WriteLine("The number is krushnamurthi " + n);
            }
            else
            {
                Console.WriteLine("The number is not krushnamurthi");
            }
        }
    }
}