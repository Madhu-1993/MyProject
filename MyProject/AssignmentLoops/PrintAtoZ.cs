using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class PrintAtoZ
    {
        static void Main(string[] args)
        {
            for(char ch='A';ch<='Z';ch++) 
            {
                Console.WriteLine(ch);
            }
        }
    }
}
