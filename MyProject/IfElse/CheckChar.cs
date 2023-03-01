using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.IfElse
{
    internal class CheckChar
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the Character");
            ch=Convert.ToChar(Console.ReadLine());
            if(ch>='a' && ch<='z' || ch>='A' && ch<='Z')
            {
                Console.WriteLine("The character is Alphabet");
            }
               else if(ch>='0' || ch<='9')
            {
                Console.WriteLine("The character is Digit");
            }
            else
            {
                Console.WriteLine("The character is Special character");
            }
        }
    }
}
