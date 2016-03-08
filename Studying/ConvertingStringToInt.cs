using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying
{
    public static class ConvertingStringToInt
    {
        private static int ToDigit(char digit)
        {
            return digit - '0';
        }


        public static int StringToInteger(string numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers))
            {
                throw new ArgumentNullException();
            }

            long answer = 0;
            long multiplier = 1;

            bool negative = false;
            if(numbers[0] == '-')
            {
                numbers = numbers.Remove(0, 1);
                negative = true;
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                long digit = numbers[i] - '0';
                if (digit < 0 || digit > 9)
                {
                    throw new ArgumentException("Invalid string.");
                }

                checked
                {
                        answer += (digit * multiplier);

                }

                multiplier *= 10;
            }

            if(negative && answer > 0)
            {
                answer *= -1;
            }

            if(answer < int.MinValue || answer > int.MaxValue)
            {
                throw new OverflowException();
            }

            return (int)answer;
        }

        public static int StringToInt(string numbers)
        {
            int answer = 0;
            char[] alpha = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            if(string.IsNullOrEmpty(numbers))
            {
                throw new ArgumentNullException("numbers");
            }

            for (int i = 0; i < numbers.Length; i++)
            {

                for (int x = 0; x < 10; x++)
                {

                    if (alpha[x] == numbers[i])
                    {

                        answer = answer + x * (int)Math.Pow(10, numbers.Length - 1 - i);

                        if (numbers[0] == '-')
                        {
                            answer = answer * (-1);
                            break;
                        }

                    }

                }
            }

            return answer;
        }
    }
}
