using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{
    class Problem10
    {
        // Find the sum of all the primes below two million.
        public static int Solution()
        {
            int sum = 0;
            for (int i = 2; i < 2000000; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }

            return sum;
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }

            int counter = 3;
            while (counter * counter < number)
            {
                if (number % counter == 0)
                {
                    return false;
                }

                counter++;
            }
            return true;
        }
    }
}
