using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Euler
{
    class Problem12
    {
        public static void Solution()
        {
            int number = 0, i = 1;

            while(NumberOfDivisors(number) < 500)
            {
                number += i;
                i++;
            }
            Console.WriteLine(number);
        }

        private static int NumberOfDivisors(int number)
        {
            int numberOfDivisors = 0;
            int sqrt = (int)Math.Sqrt(number);

            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    numberOfDivisors += 2;
                }
            }
            if (sqrt * sqrt == number)
            {
                numberOfDivisors--;
            }
            return numberOfDivisors;
        }
    }
}
