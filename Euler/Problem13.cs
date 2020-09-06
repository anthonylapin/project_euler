using System;
using System.Numerics;
using System.IO;

namespace Euler
{
    class Problem13
    {
        public static void Solution()
        {
            BigInteger result = new BigInteger();

            string filePath = Environment.CurrentDirectory + "/assets/problem13.txt";
            StreamReader reader = new StreamReader(filePath);
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                result += BigInteger.Parse(line);
            }
            reader.Close();

            BigInteger theBiggestTenDigitsInteger = 999_999_999_9;
            while (result >= theBiggestTenDigitsInteger)
            {
                result /= 10;
            }

            Console.WriteLine(result);
        }
    }
}