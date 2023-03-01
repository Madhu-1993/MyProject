using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.WrittenTest1
{
    internal class PrintSeries
    {
        static void Main(string[]args)
        {
            int n = 10;
                    
            for(int i=1;i<=n;i++)
            {
                int num = (i * i) + (i * i*i);
                Console.WriteLine(num);

            }
        }
    }
}
