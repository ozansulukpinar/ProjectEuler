using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Solutions
{
    public class Solution0001
    {
        //Problem0001: Find the sum of all the multiples of 3 or 5 below 1000
        //Answer001: 233168
        public int Euler0001()
        {
            int result = 0;

            List<int> numbers = new List<int>();

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    numbers.Add(i);
            }

            result = numbers.Sum();

            return result;
        }
    }
}
