using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms_N_Exercises.UnitTests
{
    [TestClass]
    public class ArraysAndStringsTests
    {
        [TestMethod]
        public void IsStringUniqueTest1()
        {
            Assert.IsTrue(ArraysAndStrings.IsStringUnique("a"));
        }

        [TestMethod]
        public void IsStringUniqueTest2()
        {
            Assert.IsFalse(ArraysAndStrings.IsStringUnique("aa"));
        }

        [TestMethod]
        public void IsStringUniqueTest3()
        {
            Assert.IsTrue(ArraysAndStrings.IsStringUnique("aA"));
        }

        [TestMethod]
        public void IsStringUniqueTest4()
        {
            Assert.IsTrue(ArraysAndStrings.IsStringUnique("a b5<;"));
        }
        [TestMethod]
        public void IsStringUniqueTest5()
        {
            Assert.IsFalse(ArraysAndStrings.IsStringUnique("X b5<;-X"));
        }

        [TestMethod]
        public void IsStringUnique2Test1()
        {
            Assert.IsTrue(ArraysAndStrings.IsStringUnique2("a"));
        }

        [TestMethod]
        public void IsStringUnique2Test2()
        {
            Assert.IsFalse(ArraysAndStrings.IsStringUnique2("aa"));
        }

        [TestMethod]
        public void IsStringUnique2Test3()
        {
            Assert.IsTrue(ArraysAndStrings.IsStringUnique2("aA"));
        }

        [TestMethod]
        public void IsStringUnique2Test4()
        {
            Assert.IsTrue(ArraysAndStrings.IsStringUnique2("a b5<;"));
        }
        [TestMethod]
        public void IsStringUnique2Test5()
        {
            Assert.IsFalse(ArraysAndStrings.IsStringUnique2("X b5<;-X"));
        }
    }
}
