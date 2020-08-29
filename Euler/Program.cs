using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace ProjectEuler
{
    class ProjectEuler
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Problem10.Solution());
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
            while (number < 4000000)
            {
                number = F(n);
                if (number % 2 == 0)
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

    class Problem4
    {
        /* Find the largest palindrome made from the product of two 3-digit numbers. */

        private static int makePalindrome(int half)
        {
            char[] reversed = Convert.ToString(half).ToCharArray();
            Array.Reverse(reversed);
            return Convert.ToInt32(Convert.ToString(half) + new string(reversed));
        }

        public static void Solution()
        {
            bool found = false;
            int firstHalf = 998, palin = 0;
            int[] factors = new int[2];

            while(!found)
            {
                firstHalf--;
                palin = makePalindrome(firstHalf);
                for(int i = 999; i > 99; i--)
                {
                    if ((palin/i) > 999 || i*i < palin)
                    {
                        break;
                    }

                    if((palin % i == 0))
                    {
                        found = true;
                        factors[0] = palin / i;
                        factors[1] = i;
                        break;
                    }

                }

            }

            Console.WriteLine($"Found the palindrome {palin}, which is made from {factors[0]} and {factors[1]}");
        }
    }

    class Problem5
    {
        /*2520 is the smallest number that can be divided by each of the numbers from 1 to 10
         * without any remainder. What is the smallest positive number that
         * is evenly divisible by all of the numbers from 1 to 20? */
        public static void Solution()
        {
            int res = 1;

            for (int i = 2; i <= 20; i++)
            {
                res = Lcm(res, i);
            }
            

            Console.WriteLine(res);
        }

        private static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                a %= b;
                a ^= b;
                b ^= a;
                a ^= b;
            }

            return a;
        }

        private static int Lcm(int a, int b)
        {
            return a / Gcd(a, b) * b;
        }

    }

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
                if(isPrime(num))
                {
                    primes++;
                }
            }

            Console.WriteLine($"10,001's prime number is {num}");
        }

        // trial division algorithm
        private static bool isPrime(int n)
        {
            if(n <= 1)
            {
                return false;
            }
            if(n == 2)
            {
                return true;
            }
            if(n % 2 == 0)
            {
                return false;
            }
            int counter = 3;
            while(counter*counter <= n)
            {
                if(n % counter == 0)
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

    class Problem8
    {
        /*Find the greatest product of five consecutive digits in the 1000-digit number.

        73167176531330624919225119674426574742355349194934
        96983520312774506326239578318016984801869478851843
        85861560789112949495459501737958331952853208805511
        12540698747158523863050715693290963295227443043557
        66896648950445244523161731856403098711121722383113
        62229893423380308135336276614282806444486645238749
        30358907296290491560440772390713810515859307960866
        70172427121883998797908792274921901699720888093776
        65727333001053367881220235421809751254540594752243
        52584907711670556013604839586446706324415722155397
        53697817977846174064955149290862569321978468622482
        83972241375657056057490261407972968652414535100474
        82166370484403199890008895243450658541227588666881
        16427171479924442928230863465674813919123162824586
        17866458359124566529476545682848912883142607690042
        24219022671055626321111109370544217506941658960408
        07198403850962455444362981230987879927244284909188
        84580156166097919133875499200524063689912560717606
        05886116467109405077541002256983155200055935729725
        71636269561882670428252483600823257530420752963450 */

        public static void Solution()
        {
            string num = "73167176531330624919225119674426574742355349194934" +
                          "96983520312774506326239578318016984801869478851843" +
                          "85861560789112949495459501737958331952853208805511" +
                          "12540698747158523863050715693290963295227443043557" +
                          "66896648950445244523161731856403098711121722383113" +
                          "62229893423380308135336276614282806444486645238749" +
                          "30358907296290491560440772390713810515859307960866" +
                          "70172427121883998797908792274921901699720888093776" +
                          "65727333001053367881220235421809751254540594752243" +
                          "52584907711670556013604839586446706324415722155397" +
                          "53697817977846174064955149290862569321978468622482" +
                          "83972241375657056057490261407972968652414535100474" +
                          "82166370484403199890008895243450658541227588666881" +
                          "16427171479924442928230863465674813919123162824586" +
                          "17866458359124566529476545682848912883142607690042" +
                          "24219022671055626321111109370544217506941658960408" +
                          "07198403850962455444362981230987879927244284909188" +
                          "84580156166097919133875499200524063689912560717606" +
                          "05886116467109405077541002256983155200055935729725" +
                          "71636269561882670428252483600823257530420752963450";
            int largest = 0;
            int numm = 0;

            for(int i = 0; i < num.Length-4; i++)
            {
                numm = Int32.Parse(num.Substring(i, 1)) * Int32.Parse(num.Substring(i + 1, 1)) *
                    Int32.Parse(num.Substring(i + 2, 1)) * Int32.Parse(num.Substring(i + 3, 1)) * Int32.Parse(num.Substring(i+4,1));

                if(numm > largest)
                {
                    largest = numm;
                }
            }

            Console.WriteLine(largest);

            


        }
    }

    class Problem9
    {
        // a^2 + b^2 = c^2. a + b + c = 1000. find a*b*c ?
        // m / n method for finding pythagorean triplets.
        public static int Solution()
        {
            int m = 2;

            while(true)
            {
                int a, b, c;

                for(int n = 1; n < m; n++)
                {
                    a = m * m - n * n;
                    b = 2 * m * n;
                    c = m * m + n * n;

                    if(a + b + c == 1000)
                    {
                        return a * b * c;
                    }
                }
                m++;
            }
        }
    }

    class Problem10
    {
        // Find the sum of all the primes below two million.
        public static int Solution()
        {
            int sum = 0;
            for(int i = 2; i < 2000000; i++)
            {
                if(IsPrime(i))
                {
                    sum += i;
                }
            }

            return sum;
        }

        private static bool IsPrime(int number)
        {
            if(number <= 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if(number % 2 == 0)
            {
                return false;
            }

            int counter = 3;
            while(counter * counter < number)
            {
                if(number % counter == 0)
                {
                    return false;
                }

                counter++;
            }
            return true;
        }
    }

}
