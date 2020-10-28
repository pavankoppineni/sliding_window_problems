using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindowProblems.MaxConsecutiveOnesII
{
    /// <summary>
    /// https://cheonhyangzhang.gitbooks.io/leetcode-solutions/content/solutions-451-500/487-max-consecutive-ones-ii.html
    /// </summary>
    public class MaxConsecutiveOnesIIV1
    {
        public int Find(int[] values)
        {
            var maxLength = 0;
            var lastZeroInex = -1;
            var currentMaxLength = 0;
            var start = -1;
            for (var i = 0; i < values.Length; i++)
            {
                // Case 1 : Value is zero
                if (values[i] == 0)
                {
                    // Case 1A : First zero
                    if (lastZeroInex == -1)
                    {
                        lastZeroInex = i;
                        start = 0;
                    }
                    else
                    {
                        start = lastZeroInex + 1;
                    }
                    currentMaxLength = i - start + 1;
                }
                // Case 2 : Value is one
                else
                {
                    currentMaxLength += 1;
                }

                if(currentMaxLength > maxLength)
                {
                    maxLength = currentMaxLength;
                }
            }

            return maxLength;
        }
    }
}
