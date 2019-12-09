using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms_N_Exercises.UnitTests
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void QuickSortTest1()
        {
            int[] arr = {1};
            int[] expected = {1};
            Sorting.QuickSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void QuickSortTest2()
        {
            int[] arr = { 2, 1 };
            int[] expected = { 1, 2 };
            Sorting.QuickSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void QuickSortTest3()
        {
            int[] arr = { 2, -1 };
            int[] expected = { -1, 2 };
            Sorting.QuickSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void QuickSortTest4()
        {
            int[] arr = { 3, 1, 2 };
            int[] expected = { 1, 2, 3 };
            Sorting.QuickSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void QuickSortTest5()
        {
            int[] arr = { 1, 4, 2, 3 };
            int[] expected = { 1, 2, 3, 4 };
            Sorting.QuickSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void QuickSortTest6()
        {
            int[] arr = { 2, -7, -2, 0 };
            int[] expected = { -7, -2, 0, 2 };
            Sorting.QuickSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }
    }
}
