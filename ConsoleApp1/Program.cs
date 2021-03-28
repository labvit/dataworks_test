using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Check(string romaNumber)
        {
            Console.WriteLine(romaNumber + ": " + RomanConverter.RomanToInt(romaNumber));
        }
        static void Main(string[] args)
        {
            Check("I");
            Check("II");
            Check("IV");
            Check("X");
            Check("XV");
            Check("MMIX");
        }
    }
}
