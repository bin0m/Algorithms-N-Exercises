using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms_N_Exercises.UnitTests
{
    [TestClass]
    public class GraphsTests
    {
        [TestMethod]
        public void GetNumberOfIslandsTest1()
        {
            Assert.AreEqual(1, Graphs.GetNumberOfIslands(new[,] { { 1}}));
        }

        [TestMethod]
        public void GetNumberOfIslandsTest2()
        {
            Assert.AreEqual(0, Graphs.GetNumberOfIslands(new[,] { { 0 } }));
        }

        [TestMethod]
        public void GetNumberOfIslandsTest3()
        {
            Assert.AreEqual(2, Graphs.GetNumberOfIslands(new[,] { { 1, 0, 1 } }));
        }

        [TestMethod]
        public void GetNumberOfIslandsTest4()
        {
            Assert.AreEqual(1, Graphs.GetNumberOfIslands(new[,] { { 1, 1, 1 } }));
        }

        [TestMethod]
        public void GetNumberOfIslandsTest5()
        {
            Assert.AreEqual(2, Graphs.GetNumberOfIslands(new[,] { { 1, 0, 1 }, { 1, 0, 0 } }));
        }

        [TestMethod]
        public void GetNumberOfIslandsTest6()
        {
            Assert.AreEqual(3, Graphs.GetNumberOfIslands(new[,] { { 1, 0, 1 }, { 0, 1, 0 } }));
        }


        [TestMethod]
        public void GetShortestDistancesTest1()
        {
            CollectionAssert.AreEqual(new[]{ -1, 6 }, Graphs.GetShortestDistances(3, 1, new[]{new[]{2,3}}, 2));
        }

        [TestMethod]
        public void GetShortestDistancesTest2()
        {
            CollectionAssert.AreEqual(new[] { 6, 6, -1 }, Graphs.GetShortestDistances(4, 2, new[] { new[] { 1, 2 }, new[] { 1, 3 } }, 1));
        }


        [TestMethod]
        public void longestPathTest1()
        {
            Assert.AreEqual(24, Graphs.longestPath("user\f\tpictures\f\tdocuments\f\t\tnotes.txt"));
        }

        [TestMethod]
        public void longestPathTest2()
        {
            Assert.AreEqual(0, Graphs.longestPath("a"));
        }

        [TestMethod]
        public void longestPathTest3()
        {
            Assert.AreEqual(5, Graphs.longestPath("a.txt"));
        }

        [TestMethod]
        public void longestPathTest4()
        {
            Assert.AreEqual(25, Graphs.longestPath("file name with  space.txt"));
        }

        [TestMethod]
        public void longestPathTest5()
        {
            Assert.AreEqual(0, Graphs.longestPath("a\f\tb\f\t\tc"));
        }

        [TestMethod]
        public void longestPathTest6()
        {
            Assert.AreEqual(9, Graphs.longestPath("a\f\tb\f\t\tc.txt"));
        }

        [TestMethod]
        public void longestPathTest7()
        {
            Assert.AreEqual(33, Graphs.longestPath("user\f\tpictures\f\t\tphoto.png\f\t\tcamera\f\tdocuments\f\t\tlectures\f\t\t\tnotes.txt"));
        }

    }
}
