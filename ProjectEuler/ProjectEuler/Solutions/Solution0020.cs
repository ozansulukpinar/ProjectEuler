using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ProjectEuler.Solutions
{
    public class Solution0020
    {
        //Problem0020: Find the sum of the digits in the number 100!
        //Answer020: 648
        public int Eurel0020()
        {
            int result = 0;

            int factorial = 100;

            BigInteger number = 1;

            do
            {
                number *= factorial;
                factorial--;
            } while (factorial > 1);

            int sum = 0;

            while (number != 0)
            {
                sum += (int)(number % 10);
                number /= 10;
            }

            result = sum;

            return result;
        }
    }
}
