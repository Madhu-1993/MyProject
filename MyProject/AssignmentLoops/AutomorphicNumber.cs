using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class AutomorphicNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=int.Parse(Console.ReadLine());

            int square = num * num;

            while(num<0)
            {
                num = num % 10;
                square = square % 10;
                num = num / 10;
                square = square / 10;

                if (num==square)
                {
                    Console.WriteLine("Automorphic");
                }
                else
                {
                    Console.WriteLine("Not Atomorphic");
                }
                num = num / 10;
                square = square / 10;
            }
        }
    }
}
