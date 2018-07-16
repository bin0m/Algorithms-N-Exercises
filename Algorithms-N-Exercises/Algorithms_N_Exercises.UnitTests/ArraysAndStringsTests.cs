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

        [TestMethod]
        public void ReverseWordsTest1()
        {
            CollectionAssert.AreEqual(ArraysAndStrings.ReverseWords(new char[]{'y','o','u',' ','m','e'}), new char[] { 'm', 'e', ' ', 'y', 'o', 'u' });
        }

        [TestMethod]
        public void ReverseWordsTest2()
        {
            CollectionAssert.AreEqual(ArraysAndStrings.ReverseWords(new char[] {' ', ' '}), new char[] { ' ', ' '});
        }

        [TestMethod]
        public void ReverseWordsTest3()
        {
            CollectionAssert.AreEqual(ArraysAndStrings.ReverseWords(new char[] { 'a', ' ' }), new char[] { ' ', 'a' });
        }


        [TestMethod]
        public void ReverseWordsTest4()
        {
            CollectionAssert.AreEqual(ArraysAndStrings.ReverseWords(new char[] { 'p', 'e', 'r', 'f', 'e', 'c', 't',' ', 'm', 'a', 'k', 'e', 's',' ', 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e'}), new char[] { 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e',' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'e', 'r', 'f', 'e', 'c', 't' });
        }

        [TestMethod]
        public void ReverseWordsTest5()
        {
            CollectionAssert.AreEqual(ArraysAndStrings.ReverseWords(new char[] { 'p', 'e', 'r', 'f', 'e', 'c', 't', ' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e' }), new char[] { 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e', ' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'e', 'r', 'f', 'e', 'c', 't' });
        }
    }
}
