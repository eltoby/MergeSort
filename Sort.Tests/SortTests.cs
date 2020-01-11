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
            var arr = new[] { 3, 1, 5, 2 };
            var qs = new QuickSort();
            var result = qs.SortArray(arr);
            Assert.AreEqual(4, result.Count);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(5, result[3]);
        }
    }
}
