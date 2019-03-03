using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms_N_Exercises.UnitTests
{
    [TestClass]
    public class MinHeapTests
    {
        [TestMethod]
        public void MinHeapTestEmpty1()
        {
            var minHeap = new MinHeap();
            Assert.IsTrue(minHeap.IsEmpty);
        }

        [TestMethod]
        public void MinHeapTestEmpty2()
        {
            var minHeap = new MinHeap();
            minHeap.Insert(1);
            minHeap.Insert(0);
            minHeap.ExtractMin();
            minHeap.ExtractMin();
            Assert.IsTrue(minHeap.IsEmpty);
        }

        [TestMethod]
        public void MinHeapTestInsert()
        {
            var minHeap = new MinHeap();
            minHeap.Insert(1);
            int res = minHeap.ExtractMin();
            Assert.AreEqual(res, 1);
        }

        [TestMethod]
        public void MinHeapTestExtractMin1()
        {
            var minHeap = new MinHeap();
            minHeap.Insert(3);
            minHeap.Insert(1);
            int res = minHeap.ExtractMin();
            Assert.AreEqual(res, 1);
        }

        [TestMethod]
        public void MinHeapTestExtractMin2()
        {
            var minHeap = new MinHeap();
            minHeap.Insert(3);
            minHeap.Insert(1);
            minHeap.ExtractMin();
            int res = minHeap.ExtractMin();
            Assert.AreEqual(res, 3);
        }

        [TestMethod]
        public void MinHeapTestExtractMin3()
        {
            var minHeap = new MinHeap();
            minHeap.Insert(3);
            minHeap.Insert(1);
            minHeap.ExtractMin();
            minHeap.Insert(0);
            int res = minHeap.ExtractMin();
            Assert.AreEqual(res, 0);
        }

        [TestMethod]
        public void MinHeapTestExtractMin4()
        {
            var minHeap = new MinHeap();
            minHeap.Insert(3);
            minHeap.Insert(10);
            minHeap.Insert(8);
            minHeap.Insert(2);
            minHeap.Insert(9);
            minHeap.Insert(0);

            Assert.AreEqual(minHeap.ExtractMin(), 0);

            minHeap.Insert(1);
            Assert.AreEqual(minHeap.ExtractMin(), 1);
            Assert.AreEqual(minHeap.ExtractMin(), 2);

        }

        //1,4,5,2,3,7,8,6,10,9
        public void MinHeapTestExtractMin5()
        {
            var minHeap = new MinHeap(3);
            minHeap.Insert(1);
            minHeap.Insert(4);
            minHeap.Insert(5);
            Assert.AreEqual(minHeap.ExtractMin(), 1);
            minHeap.Insert(2);
            Assert.AreEqual(minHeap.ExtractMin(), 2);
            minHeap.Insert(3);
            Assert.AreEqual(minHeap.ExtractMin(), 3);
            minHeap.Insert(7);
            Assert.AreEqual(minHeap.ExtractMin(), 4);
            minHeap.Insert(8);
            Assert.AreEqual(minHeap.ExtractMin(), 5);
            minHeap.Insert(6);
            Assert.AreEqual(minHeap.ExtractMin(), 6);
            minHeap.Insert(10);
            Assert.AreEqual(minHeap.ExtractMin(), 7);
            minHeap.Insert(9);
            Assert.AreEqual(minHeap.ExtractMin(), 8);
            Assert.AreEqual(minHeap.ExtractMin(), 9);
            Assert.AreEqual(minHeap.ExtractMin(), 10);

            Assert.IsTrue(minHeap.IsEmpty);

        }
    }
}
