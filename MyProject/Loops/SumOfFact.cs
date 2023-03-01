using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loops
{
    internal class SumOfFact
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1,sum=0;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
                sum = sum + factorial;
            }
            Console.Write(factorial+"\n");
            Console.Write(sum);

        }
    }
}
