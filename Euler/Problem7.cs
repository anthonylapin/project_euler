using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{
    class Problem7
    {
        /* What is the 10 001st prime number? */
        public static void Solution()
        {
            int num = 1;
            int primes = 0;

            while (primes < 10001)
            {
                num++;
                if (isPrime(num))
                {
                    primes++;
                }
            }

            Console.WriteLine($"10,001's prime number is {num}");
        }

        // trial division algorithm
        private static bool isPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            int counter = 3;
            while (counter * counter <= n)
            {
                if (n % counter == 0)
                {
                    return false;
                }
                else
                {
                    counter++;
                }
            }
            return true;
        }
    }
}
