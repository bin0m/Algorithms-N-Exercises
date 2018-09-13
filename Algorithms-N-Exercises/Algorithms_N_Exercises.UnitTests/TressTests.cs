﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var res01 = ListOfDepths(CreateBinaryTree(new int?[] { 3, 0 }));

            Assert.AreEqual(2, res01.Count());
            Assert.AreEqual(3, res01[0]?.First?.Value?.Val);
            Assert.AreEqual(0, res01[1]?.First?.Value?.Val);
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
    }
}
