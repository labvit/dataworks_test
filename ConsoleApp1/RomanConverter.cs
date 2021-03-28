using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum RomanDigit
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000

    }
    public class WrongRomanDigit : Exception
    {
        public string Letter;
        public WrongRomanDigit(string letter) { Letter = letter; }
    }


    public class RomanConverter
    {
        static int RomanDigToInt(string c)
        {
            RomanDigit dig; // buffer for symbol parsing
            if (!Enum.TryParse<RomanDigit>(c, out dig)) throw new WrongRomanDigit(c);

            return (int)dig;
        }

        public static int RomanToInt(string romanIntegerTxt)
        {
            if (romanIntegerTxt == null || !romanIntegerTxt.Any()) throw new ArgumentNullException();

            int result = 0;
            int previousNumber = RomanDigToInt(romanIntegerTxt[0].ToString());

            for (int i = 0; i < romanIntegerTxt.Length; i++)
            {
                int number = RomanDigToInt(romanIntegerTxt[i].ToString());
                if (number > previousNumber)
                    result += number - 2 * previousNumber;
                else
                    result += number;
                previousNumber = number;
            }
            return result;
        }
    }
}
