using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loops
{
    internal class OddNum20To50
    {
        static void Main(string[] args)
        {
            for (int i = 20; i <= 50; i++)
            {
                {
                    if(i%2!=0)
                    {
                        i=i+1;
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
