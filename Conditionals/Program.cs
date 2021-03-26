using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;

            switch (number)
            {
                case 10:
                case 25:
                    Console.WriteLine("Bu sayı 10'dur");
                    break;
                case 20:
                    Console.WriteLine("Bu sayı 20'dir");
                    break;
                case 30:
                    Console.WriteLine("Bu sayı 30'dur");
                    break;
                default:
                    Console.WriteLine("Bu sayı {0}", number);
                    break;
            }
        }
    }
}
