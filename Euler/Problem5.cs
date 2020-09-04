using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{
    class Problem5
    {
        /*2520 is the smallest number that can be divided by each of the numbers from 1 to 10
         * without any remainder. What is the smallest positive number that
         * is evenly divisible by all of the numbers from 1 to 20? */
        public static void Solution()
        {
            int res = 1;

            for (int i = 2; i <= 20; i++)
            {
                res = Lcm(res, i);
            }


            Console.WriteLine(res);
        }

        private static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                a %= b;
                a ^= b;
                b ^= a;
                a ^= b;
            }

            return a;
        }

        private static int Lcm(int a, int b)
        {
            return a / Gcd(a, b) * b;
        }

    }
}
