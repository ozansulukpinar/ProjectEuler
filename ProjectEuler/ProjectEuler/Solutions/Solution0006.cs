using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Solutions
{
    public class Solution0006
    {
        //Problem0006: Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum
        //Answer006: 25164150
        public int Euler0006()
        {
            int result = 0;

            int sumOfNumbers = 0;
            int squaredOfSumOfNumbers = 0;
            int sumOfSquaredNumbers = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfNumbers += i;
                sumOfSquaredNumbers += i * i;
            }

            squaredOfSumOfNumbers = sumOfNumbers * sumOfNumbers;
            result = squaredOfSumOfNumbers - sumOfSquaredNumbers;

            return result;
        }
    }
}
