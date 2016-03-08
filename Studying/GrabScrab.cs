using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying
{
    public static class GrabScrab
    {
        public static bool StealCharactersInOne(string first, string second)
        {
            first = first.ToLower();
            second = second.ToLower();

            var firstcopy = first;
            var count = 0;
            for(int i = 0; i < second.Length; i++)
            {
                for(int j = 0; j < firstcopy.Length; j++)
                {
                    if(second[i] == firstcopy[j])
                    {
                        count++;
                        firstcopy = firstcopy.Replace(firstcopy[j].ToString(), "");
                        break;
                    }
                }
            }

            if(count == first.Length)
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
