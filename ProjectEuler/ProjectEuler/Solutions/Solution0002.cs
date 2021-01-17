using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Solutions
{
    public class Solution0002
    {
        //Problem0002: Find the sum of the even-valued terms in the Fibonacci sequence whose values do not exceed four million
        //Answer002: 4613732
        public int Euler0002()
        {
            int result = 0;

            int previousNumber = 1;
            int currentNumber = 2;
            int transferNumber;

            List<int> numbers = new List<int>();

            int limit = 4000000;

            while (currentNumber < limit)
            {
                if (currentNumber % 2 == 0)
                    numbers.Add(currentNumber);

                transferNumber = currentNumber;
                currentNumber += previousNumber;
                previousNumber = transferNumber;
            }

            result = numbers.Sum();

            return result;
        }
    }
}
