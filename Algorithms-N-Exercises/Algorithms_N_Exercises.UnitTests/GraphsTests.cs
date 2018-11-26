﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}