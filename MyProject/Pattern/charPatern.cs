using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Pattern
{
    internal class charPatern
    {
        static void Main(string[]args)
        {
            int a = 4;
            for(int i=1;i<=a;i++)
            {
                for(int j=a;j>=i;j--)
                {
                     Console.Write((char)(j+64));
                }
                Console.Write("\n");
            }
        }
    }
}
