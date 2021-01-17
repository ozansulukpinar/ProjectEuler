using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Solutions
{
    public class Solution0003
    {
        //Problem0003: What is the largest prime factor of the number 600851475143
        //Answer003: 6857
        public BigInteger Euler0003()
        {
            BigInteger result = 0;

            BigInteger number = 600851475143;
            List<BigInteger> primeFactors = new List<BigInteger>();

            //A prime factor of any integer is always less than or equal to its square root
            double squareRoot = Math.Floor(Math.Sqrt(600851475143));
            string stringOfSquareRoot = squareRoot.ToString();
            BigInteger bigIntegerOfsquareRoot = BigInteger.Parse(stringOfSquareRoot);

            for (BigInteger k = bigIntegerOfsquareRoot; k > 1; k--)
            {
                if (number % k == 0)
                    primeFactors.Add(k);
            }

            BigInteger largestPrimeFactor = bigIntegerOfsquareRoot;

            for (int l = 0; l < primeFactors.Count(); l++)
            {
                bool isItOk = false;

                foreach (BigInteger item in primeFactors)
                {
                    if (primeFactors[l] % item == 0 && primeFactors[l] != item)
                    {
                        isItOk = false;
                        break;
                    }
                    else
                    {
                        isItOk = true;
                    }
                }

                if (isItOk)
                {
                    largestPrimeFactor = primeFactors[l];
                    break;
                }
            }

            result = largestPrimeFactor;

            return result;
        }
    }
}
