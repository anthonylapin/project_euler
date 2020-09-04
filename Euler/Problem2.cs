using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{
    class Problem2
    {
        /* By considering the terms in the Fibonacci sequence whose values do not
         * exceed four million, find the sum of the even-valued terms. */
        public static void Solution()
        {
            long answer = 0;
            long number = 0;
            int n = 1;
            while (number < 4000000)
            {
                number = F(n);
                if (number % 2 == 0)
                {
                    answer += number;
                }
                n++;

            }
            Console.WriteLine(answer);

        }

        static long F(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return F(n - 2) + F(n - 1);
            }
        }
    }
}
