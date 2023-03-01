using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Pattern
{
    internal class HollowCharPattern
    {
        static void Main(string[] args)
        {
            int i, j;
            int n = 4,m=4;
            
            for(i=1;i<=n;i++)
            {
                for(j=1;j<=m;j++)
                {
                    if (i == 1 || j == 1 || i == n || j == n)
                    {
                        Console.Write((char)(j + 64));
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");

            }
        }
    }
}
