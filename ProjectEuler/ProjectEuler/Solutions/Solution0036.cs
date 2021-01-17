using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEuler.Solutions
{
    public class Solution0036
    {
        //Problem0036: Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2
        //Answer036: 872187
        public int Euler0036()
        {
            int result = 0;

            int number = 0;
            bool processResult = false;

            List<int> numbers = new List<int>();

            for (int j = 999999; j >= 1; j--)
            {
                number = j;

                numbers.Add(number);
            }

            List<int> palindromeNumbers = new List<int>();

            foreach (int item in numbers)
            {
                processResult = CheckPalindrome(item);

                if (processResult)
                    palindromeNumbers.Add(item);
            }

            List<BigInteger> palindromeNumbersBasedTwo = new List<BigInteger>();

            foreach (int item in palindromeNumbers)
            {
                string binary = Convert.ToString(item, 2);
                BigInteger binaryInteger = BigInteger.Parse(binary);
                palindromeNumbersBasedTwo.Add(binaryInteger);
            }

            List<int> indexesOfPalindromeNumbers = new List<int>();
            processResult = false;

            for (int k = 0; k < (palindromeNumbersBasedTwo.Count()); k++)
            {
                processResult = CheckPalindrome(palindromeNumbersBasedTwo[k]);

                if (processResult)
                    indexesOfPalindromeNumbers.Add(k);
            }

            List<int> correctPalindromeNumbers = new List<int>();

            for (int m = 0; m < (palindromeNumbers.Count()); m++)
            {
                if (indexesOfPalindromeNumbers.Contains(m))
                    correctPalindromeNumbers.Add(palindromeNumbers[m]);
            }

            result = correctPalindromeNumbers.Sum();

            return result;
        }

        public bool CheckPalindrome(BigInteger number)
        {
            bool processResult = false;

            string stringOfNumber = number.ToString();
            char[] arrayOfDigits = stringOfNumber.ToCharArray();
            Array.Reverse(arrayOfDigits);
            string reverseStringOfNumber = new string(arrayOfDigits);

            if (stringOfNumber == reverseStringOfNumber)
                processResult = true;

            return processResult;
        }
    }
}
