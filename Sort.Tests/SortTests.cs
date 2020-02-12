using MergeSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sort.Tests
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void QuickSortTest()
        {
            var arr = new[] { 3, 1, 5, 2, 1 };
            var qs = new QuickSort();
            var result = qs.SortArray(arr);
            Assert.AreEqual(5, result.Count);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(2, result[2]);
            Assert.AreEqual(3, result[3]);
            Assert.AreEqual(5, result[4]);
        }

        [TestMethod]
        public void DuplicatesTest()
        {
            var arr = new[] { 5, 2, -4, 11, 0, 18, 2, 67, 51, 6 };
            var qs = new QuickSort();
            var result = qs.SortArray(arr);

            var expected = new[] { -4, 0, 2, 2, 5, 6, 11, 18, 51, 67 };

            for (var i = 0; i < arr.Length; i++)
                Assert.AreEqual(expected[i], result[i]);

        }

        [TestMethod]
        public void AllEqual()
        {
            var arr = new[] { 1, 1, 1 };
            var qs = new QuickSort();

            var result = qs.SortArray(arr);

            foreach (var it in result)
                Assert.AreEqual(1, it);
        }
    }
}
