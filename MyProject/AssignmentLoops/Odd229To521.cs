using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class Odd229To521
    {
        static void Main(string[] args)
        {
            for (int num = 229; num <= 521; num++)
            {
                if (num % 2 != 0)
                    Console.WriteLine(num);
            }
        }
    }
}
