using System;

namespace Euler
{
    class Problem14
    {
        public static void Solution()
        {
            int longestChain = 1;
            int startingNumber = 0;
            const int maximumNumber = 1000000;

            int[] cache = new int[maximumNumber + 1];

            for (int j = 0; j < cache.Length; j++)
            {
                cache[j] = 0;
            }

            cache[1] = 1;

            for (int i = 2; i <= maximumNumber; i++)
            {
                int chain = 0;
                long num = i;
                while (num != 1 && num >= i)
                {
                    if (num % 2 == 0)
                    {
                        num = num / 2;
                    }
                    else
                    {
                        num = num * 3 + 1;
                    }
                    chain++;
                }

                cache[i] = chain + cache[num];

                if (cache[i] > longestChain)
                {
                    longestChain = cache[i];
                    startingNumber = i;
                }
            }

            Console.WriteLine($"Longest chain {longestChain} starts from {startingNumber}");
        }


    }
}