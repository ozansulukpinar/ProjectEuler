using System.Numerics;

namespace ProjectEuler.Solutions
{
    public class Solution0048
    {
        //Problem0048: Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000
        //Answer048: 9110846700
        public string Euler0048()
        {
            string result = "";

            int number = 1000;

            BigInteger sum = 0;
            BigInteger everyNumber = 1;

            for (int i = 1; i <= number; i++)
            {
                everyNumber = 1;

                for (int l = 1; l <= i; l++)
                {
                    everyNumber *= i;
                }

                sum += everyNumber;
            }

            string digits = sum.ToString();
            int length = digits.Length;
            digits = digits.Substring((length - 10), 10);

            result = digits;

            return result;
        }
    }
}
