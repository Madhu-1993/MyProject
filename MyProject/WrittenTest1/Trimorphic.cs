using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyProject.WrittenTest1
{
    internal class Trimorphic
    {
        static void Main(string[]args)
        {
            int num, rem = 0, cube;
            num = int.Parse(Console.ReadLine());
            
                cube = num * num * num;
                rem = cube % 10;
                int r = rem;
            
            if(r==num)
            {
                Console.WriteLine("The number is trimorphic number");
            }
            else
            {
                Console.WriteLine("The number is not trimorphic");
            }
        }
    }
}
