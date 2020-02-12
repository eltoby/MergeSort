namespace MergeSort
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class QuickSort
    {
        public IList<int> SortArray(int[] nums)
        {
            this.Sort(nums, 0, nums.Length - 1);
            return nums;
        }

        public void Sort(int[] nums, int left, int right)
        {
            if (left >= right)
                return;

                var p = this.GetPartition(nums, left, right);
                this.Sort(nums, left, p - 1);
                this.Sort(nums, p + 1, right);
        }

        private int GetPartition(int[] nums, int left, int right)
        {
            var i = left;
            var pivot = nums[right];

            for (var j = left; j < right; j++)
            {
                if (nums[j] <= pivot)
                {
                    Swap(nums, i, j);
                    i++;
                }
            }

            Swap(nums, i, right);

            return i;
        }

        private static void Swap(int[] nums, int left, int right)
        {
            var temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
        }
    }
}
