using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.WrittenTest1
{
    internal class InverseNumPyr
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int i=n;i>=1;i--)
            {
                for(int j=1;j<=n-i;j++)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
