using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying
{
    public static class RemoveDuplicateCharacters
    {
        public static string RemovingDuplicateCharacters(string sentence)
        {
            if(String.IsNullOrEmpty(sentence))
            {
                throw new ArgumentNullException(sentence);

            }

            var removed = new String(sentence.Distinct().ToArray());

            return removed;

        }

    }
}
