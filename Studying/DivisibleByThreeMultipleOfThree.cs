using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying
{
    public static class DivisibleByThreeMultipleOfThree
    {
        public static void Threes(int n)
        {
            List<string> list = new List<string>();
 
            if(n == 0)
            {
                throw new ArgumentNullException("n");
            }

            if(n < 0)
            {
                throw new ArgumentException("cannot be negative");
            }

            for(int i = 1; i <= n; i++)
            {
                if(i % 3 == 0)
                {
                    var printO = i/3;
                    for(int j = 1; j <= printO; j++)
                    {
                        Console.Write("o");
                    }
                    Console.Write(",");
                }
                else
                {
                    Console.Write(i);
                    Console.Write(",");
                }
            }
            

            Console.ReadKey();
        }

    }
}
