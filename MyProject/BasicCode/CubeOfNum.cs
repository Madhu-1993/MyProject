using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BasicCode
{
    internal class CubeOfNum
    {
        static void Main(String[] args)
            {
            int num;
            Console.WriteLine("Enter the number");

            num = int.Parse(Console.ReadLine());
            int cube = num * num * num;
            Console.WriteLine("the cube of number"+cube);
               
            }
    }
}
