using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying
{
    public static class AllUniqueCharacters
    {
        public static bool UniqueCharacters(string letters)
        {
          if(string.IsNullOrEmpty(letters))
          {
              throw new ArgumentNullException();
          }

            bool unique = true;
            
            for(int i = 0; i < letters.Length; i++)
            {
                for(int j = letters.Length - 1; i != j; j--)
                {
                    if(letters[i] == letters[j])
                    {
                        unique = false;
                    }
                }
            }

            return unique;
        }
    }
}
