using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Studying
{
    public static class IsWordInString
    {
        public static bool IsString1InString2(string string1, string string2)
        {
           int counter = Regex.Matches(string2, string1).Count;
            if (counter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
