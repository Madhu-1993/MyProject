using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loops
{
    internal class Sum1To10
    {
        static void Main(string[] args)
        {
            for(int i=1;i<10;i++) 
            {
                i = i + 1;
                Console.WriteLine(i);
            }

        }
    }
}
