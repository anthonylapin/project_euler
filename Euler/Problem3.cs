using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{
    class Problem3
    {
        /* The prime factors of 13195 are 5, 7, 13 and 29.
        What is the largest prime factor of the number 600851475143 ? */
        public static void Solution()
        {
            const long number = 600851475143;
            long newnum = number;
            long largest = 0;
            int counter = 2;

            while (counter * counter <= newnum)
            {
                if (newnum % counter == 0)
                {
                    newnum = newnum / counter;
                    largest = counter;
                }
                else
                {
                    counter++;
                }
            }

            if (newnum > largest)
            {
                largest = newnum;
            }

            Console.WriteLine(largest);
        }
    }
}
