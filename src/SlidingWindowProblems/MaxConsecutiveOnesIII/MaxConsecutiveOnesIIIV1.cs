using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindowProblems.MaxConsecutiveOnesIII
{
    /// <summary>
    /// https://leetcode.com/problems/max-consecutive-ones-iii/
    /// </summary>
    public class MaxConsecutiveOnesIIIV1
    {
        private Queue<int> queue;
        public int FindLongestConsecutiveOnes(int[] values, int k)
        {
            queue = new Queue<int>(k);
            var maxLength = 0;
            var currentMaxLength = 0;
            for (var i = 0; i < values.Length; i++)
            {
                //Case 1 : Value is 1
                if (values[i] == 1)
                {
                    currentMaxLength += 1;
                }
                //Case 2 : Value is 0
                else
                {
                    if (k == 0)
                    {
                        currentMaxLength = 0;
                        continue;
                    }

                    // Case 2A : Queue is full
                    if (queue.Count == k)
                    {
                        var firstZeroIndex = queue.Dequeue();
                        queue.Enqueue(i);
                        currentMaxLength = i - firstZeroIndex;
                    }
                    // Case 2B : Queue is not full
                    else
                    {
                        queue.Enqueue(i);
                        currentMaxLength += 1;
                    }
                }

                if(currentMaxLength > maxLength)
                {
                    maxLength = currentMaxLength;
                }
            }

            return maxLength;
        }

        public class NodeZero
        {
            public int Index { get; set; }
            public NodeZero Next { get; set; }
        }
    }
}
