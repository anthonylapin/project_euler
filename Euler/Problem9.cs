using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{
    class Problem9
    {
        // a^2 + b^2 = c^2. a + b + c = 1000. find a*b*c ?
        // m / n method for finding pythagorean triplets.
        public static int Solution()
        {
            int m = 2;

            while (true)
            {
                int a, b, c;
                for (int n = 1; n < m; n++)
                {
                    a = m * m - n * n;
                    b = 2 * m * n;
                    c = m * m + n * n;

                    if (a + b + c == 1000)
                    {
                        return a * b * c;
                    }
                }
                m++;
            }
        }
    }
}
