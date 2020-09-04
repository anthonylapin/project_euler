using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{
    class Problem6
    {
        /* Find the difference between the sum of the
         * squares of the first one hundred natural numbers and the square of the sum. */
        public static void Solution()
        {
            int n = 100;
            int answer = SumSquare(n) - SquaresSum(n);
            Console.WriteLine(answer);
        }

        private static int SquaresSum(int n)
        {
            return n * (n + 1) * (2 * n + 1) / 6;
        }

        private static int SumSquare(int n)
        {
            int i = (n + 1) * n / 2;
            return i * i;
        }
    }
}
