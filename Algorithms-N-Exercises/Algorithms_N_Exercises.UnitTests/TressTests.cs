using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algorithms_N_Exercises.Trees;

namespace Algorithms_N_Exercises.UnitTests
{
    [TestClass]
    public class TressTests
    {
        [TestMethod]
        public void ListOfDepthsTest1()
        {
            var res01 = ListOfDepths(CreateBinaryTree(new int?[] { 3 }));

            Assert.AreEqual(1, res01.Count());
            Assert.AreEqual(3, res01[0]?.First?.Value?.Val);          
        }

        [TestMethod]
        public void ListOfDepthsTest2()
        {
            var res01 = ListOfDepths(CreateBinaryTree(new int?[] { -1, -2 }));

            Assert.AreEqual(2, res01.Count());
            Assert.AreEqual(-1, res01[0]?.First?.Value?.Val);
            Assert.AreEqual(-2, res01[1]?.First?.Value?.Val);
        }

        [TestMethod]
        public void ListOfDepthsTest3()
        {
            var res01 = ListOfDepths(CreateBinaryTree(new int?[] { 0, 1, 2 }));

            Assert.AreEqual(2, res01.Count());
            Assert.AreEqual(0, res01[0]?.First?.Value?.Val);
            Assert.AreEqual(1, res01[1]?.First?.Value?.Val);
            Assert.AreEqual(2, res01[1]?.Last?.Value?.Val);
        }

        [TestMethod]
        public void ListOfDepthsTest4()
        {
            var res01 = ListOfDepths(CreateBinaryTree(new int?[] { 0, 2, 1 }));

            Assert.AreEqual(2, res01.Count());
            Assert.AreEqual(0, res01[0]?.First?.Value?.Val);
            Assert.AreEqual(2, res01[1]?.First?.Value?.Val);
            Assert.AreEqual(1, res01[1]?.Last?.Value?.Val);
        }

        [TestMethod]
        public void ListOfDepthsTest5()
        {
            var res01 = ListOfDepths(CreateBinaryTree(new int?[] { 3, 9, 20, null, null, 15, 7 }));

            Assert.AreEqual(3, res01.Count());
            Assert.AreEqual(3, res01[0]?.First?.Value?.Val);
            Assert.AreEqual(9, res01[1]?.First?.Value?.Val);
            Assert.AreEqual(20, res01[1]?.Last?.Value?.Val);
            Assert.AreEqual(15, res01[2]?.First?.Value?.Val);
            Assert.AreEqual(7, res01[2]?.Last?.Value?.Val);
        }

        [TestMethod]
        public void CheckBalancedTest1()
        {
            Assert.AreEqual(true, CheckBalanced(CreateBinaryTree(new int?[] { 1 })));
        }

        [TestMethod]
        public void CheckBalancedTest2()
        {
            Assert.AreEqual(true, CheckBalanced(CreateBinaryTree(new int?[] { 1, 2 })));
        }

        [TestMethod]
        public void CheckBalancedTest3()
        {
            Assert.AreEqual(true, CheckBalanced(CreateBinaryTree(new int?[] { 1, 2, 3 })));
        }

        [TestMethod]
        public void CheckBalancedTest4()
        {
            Assert.AreEqual(false, CheckBalanced(CreateBinaryTree(new int?[] { 1, 2, null, 4 })));
        }

        [TestMethod]
        public void CheckBalancedTest5()
        {
            Assert.AreEqual(true, CheckBalanced(CreateBinaryTree(new int?[] { 1, 2, 3, 4 })));
        }

        [TestMethod]
        public void CheckBalancedTest6()
        {
            Assert.AreEqual(false, CheckBalanced(CreateBinaryTree(new int?[] { 1, 2, null, 4, 5 })));
        }

        [TestMethod]
        public void CheckBalancedTest7()
        {
            Assert.AreEqual(false, CheckBalanced(CreateBinaryTree(new int?[] { 1, 2, 3, 4, 5, 6, null, 8, 9, 10, 11, 12 })));
        }

        [TestMethod]
        public void CheckBalancedTest8()
        {
            Assert.AreEqual(true, CheckBalanced(CreateBinaryTree(new int?[] { 1, 2, 3, 4, 5, 6, 7, null, null, null, null, 12 })));
        }

        [TestMethod]
        public void TraverseInOrderRecursiveTest1()
        {
            CollectionAssert.AreEqual(new List<int>(){1}, TraverseInOrderRecursive(CreateBinaryTree(new int?[] { 1 })));
        }

        [TestMethod]
        public void TraverseInOrderRecursiveTest2()
        {
            CollectionAssert.AreEqual(new List<int>() { 2, 1 }, TraverseInOrderRecursive(CreateBinaryTree(new int?[] { 1, 2 })));
        }

        [TestMethod]
        public void TraverseInOrderRecursiveTest3()
        {
            CollectionAssert.AreEqual(new List<int>() { 2, 1, 3 }, TraverseInOrderRecursive(CreateBinaryTree(new int?[] { 1, 2, 3 })));
        }

        [TestMethod]
        public void TraverseInOrderRecursiveTest4()
        {
            CollectionAssert.AreEqual(new List<int>() { 4, 2, 1, 3 }, TraverseInOrderRecursive(CreateBinaryTree(new int?[] { 1, 2, 3, 4 })));
        }

        [TestMethod]
        public void TraverseInOrderRecursiveTest5()
        {
            CollectionAssert.AreEqual(new List<int>() { 4, 2, 5, 1, 3 }, TraverseInOrderRecursive(CreateBinaryTree(new int?[] { 1, 2, 3, 4, 5 })));
        }

        [TestMethod]
        public void TraverseInOrderRecursiveTest6()
        {
            CollectionAssert.AreEqual(new List<int>() { 2, 5, 1, 6, 3 }, TraverseInOrderRecursive(CreateBinaryTree(new int?[] { 1, 2, 3, null, 5, 6 })));
        }


        [TestMethod]
        public void TraverseInOrderIterativeTest1()
        {
            CollectionAssert.AreEqual(new List<int>() { 1 }, TraverseInOrderIterative(CreateBinaryTree(new int?[] { 1 })));
        }

        [TestMethod]
        public void TraverseInOrderIterativeTest2()
        {
            CollectionAssert.AreEqual(new List<int>() { 2, 1 }, TraverseInOrderIterative(CreateBinaryTree(new int?[] { 1, 2 })));
        }

        [TestMethod]
        public void TraverseInOrderIterativeTest3()
        {
            CollectionAssert.AreEqual(new List<int>() { 2, 1, 3 }, TraverseInOrderIterative(CreateBinaryTree(new int?[] { 1, 2, 3 })));
        }

        [TestMethod]
        public void TraverseInOrderIterativeTest4()
        {
            CollectionAssert.AreEqual(new List<int>() { 4, 2, 1, 3 }, TraverseInOrderIterative(CreateBinaryTree(new int?[] { 1, 2, 3, 4 })));
        }

        [TestMethod]
        public void TraverseInOrderIterativeTest5()
        {
            CollectionAssert.AreEqual(new List<int>() { 4, 2, 5, 1, 3 }, TraverseInOrderIterative(CreateBinaryTree(new int?[] { 1, 2, 3, 4, 5 })));
        }

        [TestMethod]
        public void TraverseInOrderIterativeTest6()
        {
            CollectionAssert.AreEqual(new List<int>() { 2, 5, 1, 6, 3 }, TraverseInOrderIterative(CreateBinaryTree(new int?[] { 1, 2, 3, null, 5, 6 })));
        }

        public void TraversePreOrderIterativeTest1()
        {
            CollectionAssert.AreEqual(new List<int>() { 1 }, TraversePreOrderIterative(CreateBinaryTree(new int?[] { 1 })));
        }

        [TestMethod]
        public void TraversePreOrderIterativeTest2()
        {
            CollectionAssert.AreEqual(new List<int>() {  1, 2  }, TraversePreOrderIterative(CreateBinaryTree(new int?[] { 1, 2 })));
        }

        [TestMethod]
        public void TraversePreOrderIterativeTest3()
        {
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3 }, TraversePreOrderIterative(CreateBinaryTree(new int?[] { 1, 2, 3 })));
        }

        [TestMethod]
        public void TraversePreOrderIterativeTest4()
        {
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 4, 3 }, TraversePreOrderIterative(CreateBinaryTree(new int?[] { 1, 2, 3, 4 })));
        }

        [TestMethod]
        public void TraversePreOrderIterativeTest5()
        {
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 4, 5, 3 }, TraversePreOrderIterative(CreateBinaryTree(new int?[] { 1, 2, 3, 4, 5 })));
        }

        [TestMethod]
        public void TraversePreOrderIterativeTest6()
        {
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 4, 5, 3, 6 }, TraversePreOrderIterative(CreateBinaryTree(new int?[] { 1, 2, 3, 4, 5, 6 })));
        }


        [TestMethod]
        public void TraversePreOrderIterativeTest7()
        {
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 5, 3, 6 }, TraversePreOrderIterative(CreateBinaryTree(new int?[] { 1, 2, 3, null, 5, 6 })));
        }

        [TestMethod]
        public void TraversePostOrderIterativeTest1()
        {
            CollectionAssert.AreEqual(new List<int>() { 1 }, TraversePostOrderIterative(CreateBinaryTree(new int?[] { 1 })));
        }

        [TestMethod]
        public void TraversePostOrderIterativeTest2()
        {
            CollectionAssert.AreEqual(new List<int>() { 2, 1 }, TraversePostOrderIterative(CreateBinaryTree(new int?[] { 1, 2 })));
        }

        [TestMethod]
        public void TraversePostOrderIterativeTest3()
        {
            CollectionAssert.AreEqual(new List<int>() { 2, 3, 1 }, TraversePostOrderIterative(CreateBinaryTree(new int?[] { 1, 2, 3 })));
        }

        [TestMethod]
        public void TraversePostOrderIterativeTest4()
        {
            CollectionAssert.AreEqual(new List<int>() { 4, 2, 3, 1 }, TraversePostOrderIterative(CreateBinaryTree(new int?[] { 1, 2, 3, 4 })));
        }

        [TestMethod]
        public void TraversePostOrderIterativeTest5()
        {
            CollectionAssert.AreEqual(new List<int>() { 4, 5, 2, 3, 1 }, TraversePostOrderIterative(CreateBinaryTree(new int?[] { 1, 2, 3, 4, 5 })));
        }

        [TestMethod]
        public void TraversePostOrderIterativeTest6()
        {
            CollectionAssert.AreEqual(new List<int>() { 4, 5, 2, 6, 3, 1 }, TraversePostOrderIterative(CreateBinaryTree(new int?[] { 1, 2, 3, 4, 5, 6 })));
        }

        [TestMethod]
        public void TraversePostOrderIterativeTest7()
        {
            CollectionAssert.AreEqual(new List<int>() { 5, 2, 6, 7, 3, 1 }, TraversePostOrderIterative(CreateBinaryTree(new int?[] { 1, 2, 3, null, 5, 6, 7 })));
        }

    }
}
