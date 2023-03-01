using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Pattern
{
    internal class AlphabetPyramid
    {
        static void Main(string[] args)
        {
            int a = 4;
            for(int i=1;i<=a;i++)
            {
                for(int j=1; j<=a-i+1;j++)
                {
                    Console.Write((char)(j+ 64));
                }
                Console.Write("\n");
            }
        }
    }
}
