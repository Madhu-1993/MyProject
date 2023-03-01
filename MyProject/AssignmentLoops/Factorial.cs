using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int num, fact=1, i;
            Console.WriteLine("Enter the number");
            num=int.Parse(Console.ReadLine());

            for(i=1;i<=num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
