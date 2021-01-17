using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Solutions
{
    public class Solution0005
    {
        //Problem0005: What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20
        //Answer005: 232792560
        public int Euler0005()
        {
            int result = 0;

            int smallestNumber = 20;

            while (((smallestNumber % 2 != 0) || (smallestNumber % 3 != 0) || (smallestNumber % 4 != 0) || (smallestNumber % 5 != 0) || (smallestNumber % 6 != 0) || (smallestNumber % 7 != 0) || (smallestNumber % 8 != 0) || (smallestNumber % 9 != 0) || (smallestNumber % 10 != 0) || (smallestNumber % 11 != 0) || (smallestNumber % 12 != 0) || (smallestNumber % 13 != 0) || (smallestNumber % 14 != 0) || (smallestNumber % 15 != 0) || (smallestNumber % 16 != 0) || (smallestNumber % 17 != 0) || (smallestNumber % 18 != 0) || (smallestNumber % 19 != 0) || (smallestNumber % 20 != 0)))
            {
                smallestNumber += 20;
            }

            result = smallestNumber;

            return result;
        }
    }
}
