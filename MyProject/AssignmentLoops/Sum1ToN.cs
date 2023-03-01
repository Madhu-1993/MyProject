using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class Sum1ToN
    {
        static void Main(string[] args)
        {
            int sum = 0, n=15;
            for(int num=1;num<=n;num++)
            {
                sum = sum + num;
                Console.WriteLine(sum);
            }
        }
    }
}
