using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class Prime400To300
    {
        static void Main(string[] args)
        {
            for (int num = 300; num <= 400; num++)
            {
                int i;
                bool isprime = true;
                for (i = 2; i<num; i++)
                {
                    if (num%i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
