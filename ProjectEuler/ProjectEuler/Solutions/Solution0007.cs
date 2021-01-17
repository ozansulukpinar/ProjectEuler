using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Solutions
{
    public class Solution0007
    {
        //Problem0007: What is the 10001st prime number
        //Answer007: 104743
        public int Euler0007()
        {
            int result = 0;

            List<int> primeNumbers = new List<int>() { 2, 3, 5, 7, 11, 13 };
            List<int> numbers = new List<int>();

            int n = 6;
            int maximumInteger = 1000000;
            bool isItPrime = true;

            for (int i = 14; i < maximumInteger; i++)
            {
                numbers.Add(i);
            }

            foreach (int item in numbers)
            {
                isItPrime = true;

                foreach (int element in primeNumbers)
                {
                    if (item % element == 0)
                    {
                        isItPrime = false;
                        break;
                    }
                }

                if (isItPrime)
                {
                    primeNumbers.Add(item);
                    n++;
                }

                if (n == 10001)
                    break;
            }

            result = primeNumbers[primeNumbers.Count - 1];

            return result;
        }
    }
}
