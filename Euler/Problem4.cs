using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{
    class Problem4
    {
        /* Find the largest palindrome made from the product of two 3-digit numbers. */

        private static int makePalindrome(int half)
        {
            char[] reversed = Convert.ToString(half).ToCharArray();
            Array.Reverse(reversed);
            return Convert.ToInt32(Convert.ToString(half) + new string(reversed));
        }

        public static void Solution()
        {
            bool found = false;
            int firstHalf = 998, palin = 0;
            int[] factors = new int[2];

            while (!found)
            {
                firstHalf--;
                palin = makePalindrome(firstHalf);
                for (int i = 999; i > 99; i--)
                {
                    if ((palin / i) > 999 || i * i < palin)
                    {
                        break;
                    }

                    if ((palin % i == 0))
                    {
                        found = true;
                        factors[0] = palin / i;
                        factors[1] = i;
                        break;
                    }

                }

            }

            Console.WriteLine($"Found the palindrome {palin}, which is made from {factors[0]} and {factors[1]}");
        }
    }
}
