using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ProjectEuler.Solutions
{
    public class Solution0016
    {
        //Problem0016: What is the sum of the digits of the number 2^1000
        //Answer016: 1366
        public int Euler0016()
        {
            int result = 0;

            BigInteger number = BigInteger.Pow(2, 1000);

            int sumOfDigits = 0;

            while (number != 0)
            {
                sumOfDigits += (int)(number % 10);
                number /= 10;
            }

            result = sumOfDigits;

            return result;
        }
    }
}
