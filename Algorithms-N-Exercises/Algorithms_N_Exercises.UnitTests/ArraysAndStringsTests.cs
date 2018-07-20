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
        public void CheckPermutationTest1()
        {
            Assert.IsTrue(ArraysAndStrings.CheckPermutation("a", "a"));
        }

        [TestMethod]
        public void CheckPermutationTest2()
        {
            Assert.IsFalse(ArraysAndStrings.CheckPermutation("abb", "ab"));
        }

        [TestMethod]
        public void CheckPermutationTest3()
        {
            Assert.IsTrue(ArraysAndStrings.CheckPermutation("AB", "BA"));
        }

        [TestMethod]
        public void CheckPermutationTest4()
        {
            Assert.IsFalse(ArraysAndStrings.CheckPermutation("AB", "bA"));
        }

        [TestMethod]
        public void CheckPermutationTest5()
        {
            Assert.IsTrue(ArraysAndStrings.CheckPermutation("abcd", "dbac"));
        }

        [TestMethod]
        public void MeetingPlannerTest1()
        {
            var slotA = new[,] { { 7, 12 } };
            var slotB = new[,] { { 2, 11 } };
            int dur = 5;
            Assert.IsNull(ArraysAndStrings.MeetingPlanner(slotA, slotB, dur));
        }

        [TestMethod]
        public void MeetingPlannerTest2()
        {
            var slotA = new[,] { { 6, 12 } };
            var slotB = new[,] { { 2, 11 } };
            int dur = 5;
            CollectionAssert.AreEqual(ArraysAndStrings.MeetingPlanner(slotA, slotB, dur), new[] { 6, 11 });
        }

        [TestMethod]
        public void MeetingPlannerTest3()
        {
            var slotA = new[,] { { 1, 10 } };
            var slotB = new[,] { { 2, 3 }, { 5, 7 } };
            int dur = 2;
            CollectionAssert.AreEqual(ArraysAndStrings.MeetingPlanner(slotA, slotB, dur), new[] { 5, 7 });
        }

        [TestMethod]
        public void MeetingPlannerTest4()
        {
            var slotA = new[,] { { 0, 5 }, { 50, 70 }, { 120, 125 } };
            var slotB = new[,] { { 0, 50 } };
            int dur = 8;
            Assert.IsNull(ArraysAndStrings.MeetingPlanner(slotA, slotB, dur));
        }

        [TestMethod]
        public void MeetingPlannerTest5()
        {
            var slotA = new[,] { { 10, 50 }, { 60, 120 }, { 140, 210 } };
            var slotB = new[,] { { 0, 15 }, { 60, 70 } };
            int dur = 8;
            CollectionAssert.AreEqual(ArraysAndStrings.MeetingPlanner(slotA, slotB, dur), new[] { 60, 68 });
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

        [TestMethod]
        public void FindGrantsCapTest1()
        {
            Assert.AreEqual(ArraysAndStrings.FindGrantsCap(new double[] { 2, 4 }, 3), 1.5);
        }

        [TestMethod]
        public void FindGrantsCapTest2()
        {
            Assert.AreEqual(ArraysAndStrings.FindGrantsCap(new double[] {2, 100, 50, 120, 1000},190),47);
        }

        [TestMethod]
        public void FindGrantsCapTest3()
        {
            Assert.AreEqual(ArraysAndStrings.FindGrantsCap(new double[] { 2, 4, 6 }, 3), 1);
        }

        [TestMethod]
        public void FindGrantsCapTest4()
        {
            Assert.AreEqual(ArraysAndStrings.FindGrantsCap(new double[] { 2, 100, 50, 120, 167 }, 400), 128);
        }

        [TestMethod]
        public void FindGrantsCapTest5()
        {
            Assert.AreEqual(ArraysAndStrings.FindGrantsCap(new double[] { 21, 100, 50, 120, 130, 110 }, 140), 23.8);
        }

        [TestMethod]
        public void IsMatchRegexTest1()
        {
            Assert.IsTrue(ArraysAndStrings.IsMatchRegex("", ""));
        }

        [TestMethod]
        public void IsMatchRegexTest2()
        {
            Assert.IsFalse(ArraysAndStrings.IsMatchRegex("aa", "a"));
        }

        [TestMethod]
        public void IsMatchRegexTest3()
        {
            Assert.IsTrue(ArraysAndStrings.IsMatchRegex("bb", "bb"));
        }

        [TestMethod]
        public void IsMatchRegexTest4()
        {
            Assert.IsTrue(ArraysAndStrings.IsMatchRegex("bb", "bb"));
        }

        [TestMethod]
        public void IsMatchRegexTest5()
        {
            Assert.IsTrue(ArraysAndStrings.IsMatchRegex("aba", "a.a"));
        }

        [TestMethod]
        public void IsMatchRegexTest6()
        {
            Assert.IsTrue(ArraysAndStrings.IsMatchRegex("abaa", "a.*a*"));
        }

        [TestMethod]
        public void IsPalindromePermutationTest1()
        {
            Assert.IsTrue(ArraysAndStrings.IsPalindromePermutation("a"));
        }

        [TestMethod]
        public void IsPalindromePermutationTest2()
        {
            Assert.IsFalse(ArraysAndStrings.IsPalindromePermutation("ba"));
        }

        [TestMethod]
        public void IsPalindromePermutationTest3()
        {
            Assert.IsTrue(ArraysAndStrings.IsPalindromePermutation("aA"));
        }

        [TestMethod]
        public void IsPalindromePermutationTest4()
        {
            Assert.IsTrue(ArraysAndStrings.IsPalindromePermutation("bba"));
        }

        [TestMethod]
        public void IsPalindromePermutationTest5()
        {
            Assert.IsTrue(ArraysAndStrings.IsPalindromePermutation("aabb"));
        }

        [TestMethod]
        public void IsPalindromePermutationTest6()
        {
            Assert.IsFalse(ArraysAndStrings.IsPalindromePermutation("aaab"));
        }

    }
}
