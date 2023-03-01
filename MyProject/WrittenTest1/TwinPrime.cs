using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.WrittenTest1
{
    internal class TwinPrime
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1=int.Parse(Console.ReadLine());
            num2=int.Parse(Console.ReadLine());
            int n1 = num1;
            int n2 = num2;

            bool isprime = true;
            for (int i = 2; (i <= num1) || (i <= num2); i++)
            {
                if ((num1 % i == 0) && (num2 % i == 0))
                {
                    isprime = false;
                    break;
                }
            }
                if (isprime == true)
                {
                    Console.WriteLine(num1+"," +num2);
                    Console.WriteLine("Twin Number");
                    if (n1- n2 == 2)
                    {
                        Console.WriteLine("Twin numbe");
                    }
                   
                }
            else
            {
                Console.WriteLine(" Not");
            }


        }
    }
}
