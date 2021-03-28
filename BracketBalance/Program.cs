using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketBalance
{
    class Program
    {
        /// <summary>
        /// method to check that braces are balanced
        /// </summary>
        /// <param name="txt">text with braces</param>
        /// <returns></returns>
        static bool Balanced(string txt)
        {
            int bracket_scope = 0;
            foreach (var c in txt)
            {
                if (c == '(') bracket_scope++;
                else if (c == ')') bracket_scope--;
            }

            return bracket_scope == 0;
        }
        static void Check(string txt)
        {
            Console.WriteLine(txt + " " + (Balanced(txt) ? "is balanced" : "not balanced"));
        }
        static void Main(string[] args)
        {
            Check("()");
            Check("())");
            Check("(tete(hshsh))");
            Check("sdsfsdf(hshdh(djdj))");
        }
    }
}
