using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{
    class Problem1
    {
        /* If we list all the natural numbers below 10 that are multiplies of 3 or 5, we get 3,5,6 and 9. The sum of these multiplies is 23.
            * Find the sum of all the multiplies of 3 or 5 below 1000 */
        public static void Solution()
        {
            int result = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            Console.WriteLine(result);
        }
    }
}
