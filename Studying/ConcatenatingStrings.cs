using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying
{
    public static class ConcatenatingStrings
    {
        static void Main()
        {
            DivisibleByThreeMultipleOfThree.Threes(99);
        }

        public static bool ConcatenationExists(string[] list, string target)
        {
            bool answer = false;

            for (int word1 = 0; word1 < list.Length; word1++)
            {
                for (int word2 = (list.Length - 1); word2 != word1; word2--)
                {
                    if (list[word1] + list[word2] == target || list[word2] + list[word1] == target)
                    {
                        answer = true;
                        break;

                    }
                    
                }
            }

            return answer;
            
        }
    }
}

