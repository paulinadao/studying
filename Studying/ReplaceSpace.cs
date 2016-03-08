using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying
{
    public static class ReplaceSpace
    {
        public static string ReplacingSpaces(string sentence)
        {
            
            if(string.IsNullOrEmpty(sentence))
            {
                throw new ArgumentNullException();
            }

            var newSentence = sentence.Replace(" ", "%20");

            return newSentence;

        }

        public static string ReplacingSpacesAlternate(string sentence)
        {
            StringBuilder newSentence = new StringBuilder();


            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    newSentence.Append('%');
                    newSentence.Append('2');
                    newSentence.Append('0');
                }
                else
                {
                    newSentence.Append(sentence[i]);
                }
            }

            var newSentenceString = newSentence.ToString();

            return newSentenceString;
        }
    }
}
