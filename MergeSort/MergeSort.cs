namespace MergeSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MergeSort
    {
        public IList<int> SortArray(int[] nums)
        {
            if (nums.Length <= 1)
                return nums.ToList();

            var middle = nums.Length / 2;
            var left = new List<int>(middle);
            var right = new List<int>(nums.Length - middle);

            for (var i = 0; i < middle; i++)
                left.Add(nums[i]);

            for (var i = middle; i < nums.Length; i++)
                right.Add(nums[i]);

            var sortedLeft = this.SortArray(left.ToArray());
            var sortedRight = this.SortArray(right.ToArray());

            return this.Merge(sortedLeft, sortedRight);
        }

        private IList<int> Merge(IList<int> left, IList<int> right)
        {
            var result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right.First());
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right.First());
                    right.RemoveAt(0);
                }
            }

            return result;
        }
    }
}
