using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.SwitchCase
{
    internal class VowelConsonent
    {
            static void Main(string[]args)
        {
            char ch;
            Console.WriteLine("Enter the character");
            ch = Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 'a':
                    Console.WriteLine("The char is Vowel");
                    break;

                case 'e':
                    Console.WriteLine("The char is Vowel");
                    break;

                case 'i':
                    Console.WriteLine("The char is Vowel");
                    break;

                case 'o':
                    Console.WriteLine("The char is Vowel");
                    break;

                case 'u':
                    Console.WriteLine("The char is Vowel");
                    break;

                default:
                    Console.WriteLine("the char is consonent");
                    break;
            }
        }
    }
}
