using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    class SubtractProductAndSumOfDigits
    {
        public static int SubtractProductAndSum(int n)
        {
            int product = 1;
            int sum = 0;
            while (n != 0)
            {
                int y = n % 10;
                product *= y;
                sum += y;
                n = n / 10;
            }
            return (product - sum);
        }
    }
}
