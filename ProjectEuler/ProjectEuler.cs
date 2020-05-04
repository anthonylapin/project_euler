using System;
using System.Reflection.Metadata.Ecma335;

namespace ProjectEuler
{
    class ProjectEuler
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Problem2.Solution();
        }

    }

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

    class Problem2
    {
        public static void Solution()
        {
            long answer = 0;
            long number = 0;
            int n = 1;
            while(number < 4000000)
            {
                number = F(n);
                if(number % 2 == 0)
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
