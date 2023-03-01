using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Pattern
{
    internal class RightTraingle
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if (j == 2 || j == 4)
                    {
                        Console.Write(" 0 ");
                    }
                    else
                    {
                        Console.Write(" * ");
                    }
                }
                Console.Write("\n");
            }
            Console.Write(" ");
        }
    }
}
