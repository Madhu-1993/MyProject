using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class SumofOdd1toN
    {
        static void Main(string[] args)
        {
            int n = 10, sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
