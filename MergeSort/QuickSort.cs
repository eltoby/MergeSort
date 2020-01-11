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
            if (right <= left)
                return;

            var pivot = this.GetPartition(nums, left, right);

            if (pivot > 1)
                this.Sort(nums, left, pivot - 1);

            if (pivot + 1 < right)
                this.Sort(nums, pivot + 1, right);
        }

        private int GetPartition(int[] nums, int left, int right)
        {
            var pivot = nums[left];

            while (true)
            {
                while (nums[left] < pivot)
                    left++;

                while (nums[right] > pivot)
                    right--;

                if (left >= right)
                    return right;

                if (nums[left] == nums[right])
                    return right;

                Swap(nums, left, right);
            }
        }

        private static void Swap(int[] nums, int left, int right)
        {
            var temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
        }
    }
}
