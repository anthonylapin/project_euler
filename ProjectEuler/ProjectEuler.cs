using System;
using System.Reflection.Metadata.Ecma335;

namespace ProjectEuler
{
    class ProjectEuler
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Problem2.Solution();

            Problem3.Solution();
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
        /* By considering the terms in the Fibonacci sequence whose values do not
         * exceed four million, find the sum of the even-valued terms. */
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

            while(counter * counter <= newnum)
            {
                if(newnum % counter == 0)
                {
                    newnum = newnum / counter;
                    largest = counter;
                }
                else
                {
                    counter++;  
                }
            }

            if(newnum > largest)
            {
                largest = newnum;
            }

            Console.WriteLine(largest);




        }

         
       
    }
}
