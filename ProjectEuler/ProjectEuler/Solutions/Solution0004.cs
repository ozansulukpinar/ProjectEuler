using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Solutions
{
    public class Solution0004
    {
        //Problem0004: Find the largest palindrome made from the product of two 3-digit numbers
        //Answer004: 906609
        public int Euler0004()
        {
            int result = 0;

            bool processResult = false;
            int number = 0;
            int largestNumber = 998001;

            List<int> numbers = new List<int>();

            for (int i = 999; i >= 100; i--)
            {
                for (int j = 999; j >= 100; j--)
                {
                    number = i * j;

                    numbers.Add(number);
                }
            }

            List<int> palindromeNumbers = new List<int>();

            foreach (int item in numbers)
            {
                processResult = CheckPalindrome(item);

                if (processResult)
                    palindromeNumbers.Add(item);
            }

            largestNumber = palindromeNumbers.OrderByDescending(p => p).ToList().First();

            result = largestNumber;

            return result;
        }

        public bool CheckPalindrome(int number)
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