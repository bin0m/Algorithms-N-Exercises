using System;
using System.Collections.Generic;
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
            CollectionAssert.AreEqual(new[] { 6, 11 }, ArraysAndStrings.MeetingPlanner(slotA, slotB, dur));
        }

        [TestMethod]
        public void MeetingPlannerTest3()
        {
            var slotA = new[,] { { 1, 10 } };
            var slotB = new[,] { { 2, 3 }, { 5, 7 } };
            int dur = 2;
            CollectionAssert.AreEqual(new[] { 5, 7 }, ArraysAndStrings.MeetingPlanner(slotA, slotB, dur));
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
            CollectionAssert.AreEqual(new[] { 60, 68 }, ArraysAndStrings.MeetingPlanner(slotA, slotB, dur));
        }

        [TestMethod]
        public void ReverseWordsTest1()
        {
            CollectionAssert.AreEqual(new char[] { 'm', 'e', ' ', 'y', 'o', 'u' }, ArraysAndStrings.ReverseWords(new char[] { 'y', 'o', 'u', ' ', 'm', 'e' }));
        }

        [TestMethod]
        public void ReverseWordsTest2()
        {
            CollectionAssert.AreEqual(new char[] { ' ', ' '}, ArraysAndStrings.ReverseWords(new char[] { ' ', ' ' }));
        }

        [TestMethod]
        public void ReverseWordsTest3()
        {
            CollectionAssert.AreEqual(new char[] { ' ', 'a' }, ArraysAndStrings.ReverseWords(new char[] { 'a', ' ' }));
        }


        [TestMethod]
        public void ReverseWordsTest4()
        {
            CollectionAssert.AreEqual(new char[] { 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e',' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'e', 'r', 'f', 'e', 'c', 't' }, ArraysAndStrings.ReverseWords(new char[] { 'p', 'e', 'r', 'f', 'e', 'c', 't', ' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e' }));
        }

        [TestMethod]
        public void ReverseWordsTest5()
        {
            CollectionAssert.AreEqual(new char[] { 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e', ' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'e', 'r', 'f', 'e', 'c', 't' }, ArraysAndStrings.ReverseWords(new char[] { 'p', 'e', 'r', 'f', 'e', 'c', 't', ' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e' }));
        }

        [TestMethod]
        public void FindGrantsCapTest1()
        {
            Assert.AreEqual(1.5, ArraysAndStrings.FindGrantsCap(new double[] { 2, 4 }, 3));
        }

        [TestMethod]
        public void FindGrantsCapTest2()
        {
            Assert.AreEqual(47, ArraysAndStrings.FindGrantsCap(new double[] { 2, 100, 50, 120, 1000 }, 190));
        }

        [TestMethod]
        public void FindGrantsCapTest3()
        {
            Assert.AreEqual(1, ArraysAndStrings.FindGrantsCap(new double[] { 2, 4, 6 }, 3));
        }

        [TestMethod]
        public void FindGrantsCapTest4()
        {
            Assert.AreEqual(128, ArraysAndStrings.FindGrantsCap(new double[] { 2, 100, 50, 120, 167 }, 400));
        }

        [TestMethod]
        public void FindGrantsCapTest5()
        {
            Assert.AreEqual(23.8, ArraysAndStrings.FindGrantsCap(new double[] { 21, 100, 50, 120, 130, 110 }, 140));
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

        [TestMethod]
        public void IsOneAwayTest1()
        {
            Assert.IsTrue(ArraysAndStrings.IsOneAway("", ""));
        }
        [TestMethod]
        public void IsOneAwayTest2()
        {
            Assert.IsTrue(ArraysAndStrings.IsOneAway("a", ""));
        }

        [TestMethod]
        public void IsOneAwayTest3()
        {
            Assert.IsTrue(ArraysAndStrings.IsOneAway("", "a"));
        }

        [TestMethod]
        public void IsOneAwayTest4()
        {
            Assert.IsTrue(ArraysAndStrings.IsOneAway("pale", "ple"));
        }

        [TestMethod]
        public void IsOneAwayTest5()
        {
            Assert.IsTrue(ArraysAndStrings.IsOneAway("pale", "bale"));
        }

        [TestMethod]
        public void IsOneAwayTest6()
        {
            Assert.IsFalse(ArraysAndStrings.IsOneAway("pale", "bake"));
        }

        [TestMethod]
        public void GetShortestUniqueSubstringTest1()
        {
            Assert.AreEqual("", ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'a' }, ""));
        }

        [TestMethod]
        public void GetShortestUniqueSubstringTest2()
        {
            Assert.AreEqual("", ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'a' }, "b"));
        }

        [TestMethod]
        public void GetShortestUniqueSubstringTest3()
        {
            Assert.AreEqual("a", ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'a' }, "a"));
        }

        [TestMethod]
        public void GetShortestUniqueSubstringTest4()
        {
            Assert.AreEqual("acb", ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'a', 'b' }, "-acb"));
        }

        [TestMethod]
        public void GetShortestUniqueSubstringTest5()
        {
            Assert.AreEqual("zyx", ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'x', 'y', 'z' }, "xyyzyzyx"));
        }

        [TestMethod]
        public void GetShortestUniqueSubstringTest6()
        {
            Assert.AreEqual("", ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'x', 'y', 'z', 'r' }, "xyyzyzyx"));
        }

        [TestMethod]
        public void GetShortestUniqueSubstringTest7()
        {
            Assert.AreEqual("zyxr", ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'x', 'y', 'z', 'r' }, "xyyzyzyxr"));
        }

        [TestMethod]
        public void FlattenDictionaryTest1()
        {
            var inputDict = new Dictionary<string, object>();
            inputDict.Add("key1", "1");
            var expectedDict = new Dictionary<string, string>();
            expectedDict.Add("key1", "1");
            CollectionAssert.AreEqual(expectedDict, ArraysAndStrings.FlattenDictionary(inputDict));
        }

        [TestMethod]
        public void NumOfPathsToDestTest1()
        {
            Assert.AreEqual(1, ArraysAndStrings.NumOfPathsToDest(1));
        }

        [TestMethod]
        public void NumOfPathsToDestTest2()
        {
            Assert.AreEqual(1, ArraysAndStrings.NumOfPathsToDest(2));
        }

        [TestMethod]
        public void NumOfPathsToDestTest3()
        {
            Assert.AreEqual(2, ArraysAndStrings.NumOfPathsToDest(3));
        }

        [TestMethod]
        public void NumOfPathsToDestTest4()
        {
            Assert.AreEqual(5, ArraysAndStrings.NumOfPathsToDest(4));
        }

        [TestMethod]
        public void NumOfPathsToDestTest5()
        {
            Assert.AreEqual(14, ArraysAndStrings.NumOfPathsToDest(5));
        }

        [TestMethod]
        public void NumOfPathsToDestTest6()
        {
            Assert.AreEqual(35357670, ArraysAndStrings.NumOfPathsToDest(17));
        }

        [TestMethod]
        public void IsPrimeTest1()
        {
            Assert.IsTrue(ArraysAndStrings.IsPrime("a"));
        }

        [TestMethod]
        public void IsPrimeTest2()
        {
            Assert.IsTrue(ArraysAndStrings.IsPrime("ab"));
        }

        [TestMethod]
        public void IsPrimeTest3()
        {
            Assert.IsTrue(ArraysAndStrings.IsPrime("aba"));
        }

        [TestMethod]
        public void IsPrimeTest4()
        {
            Assert.IsFalse(ArraysAndStrings.IsPrime("aa"));
        }

        [TestMethod]
        public void IsPrimeTest5()
        {
            Assert.IsFalse(ArraysAndStrings.IsPrime("abab"));
        }

        [TestMethod]
        public void IsPrimeTest6()
        {
            Assert.IsTrue(ArraysAndStrings.IsPrime("abcab"));
        }

        [TestMethod]
        public void IsPrimeTest7()
        {
            Assert.IsFalse(ArraysAndStrings.IsPrime("abcabc"));
        }

        [TestMethod]
        public void IsPrimeTest8()
        {
            Assert.IsTrue(ArraysAndStrings.IsPrime("abcabdc"));
        }

        [TestMethod]
        public void IsPrimeTest9()
        {
            Assert.IsFalse(ArraysAndStrings.IsPrime("ababab"));
        }

        [TestMethod]
        public void CanBeWrittenFromTest1()
        {
            Assert.IsTrue(ArraysAndStrings.CanBeWrittenFrom("a", "a"));
        }

        [TestMethod]
        public void CanBeWrittenFromTest2()
        {
            Assert.IsFalse(ArraysAndStrings.CanBeWrittenFrom("aa", "abcd"));
        }

        [TestMethod]
        public void CanBeWrittenFromTest3()
        {
            Assert.IsTrue(ArraysAndStrings.CanBeWrittenFrom("a,O,", "qpz,,%ar0O"));
        }

        [TestMethod]
        public void CanBeWrittenFromTest4()
        {
            Assert.IsFalse(ArraysAndStrings.CanBeWrittenFrom("a,O,", "qpz,%ar0O"));
        }

        [TestMethod]
        public void CanBeWrittenFromTest5()
        {
            Assert.IsFalse(ArraysAndStrings.CanBeWrittenFrom("abba", "Banda b"));
        }

        [TestMethod]
        public void MinimumBribesTest1()
        {
            var input = new[] {1};
            var expected = "0";

            // Needed to test a method which writes to the Console to validate the output
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                ArraysAndStrings.MinimumBribes(input);
                Assert.AreEqual(expected + "\r\n", consoleOutput.GetOuput());
            }
            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void MinimumBribesTest2()
        {
            var input = new[] { 2, 1 };
            var expected = "1";

            // Needed to test a method which writes to the Console to validate the output
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                ArraysAndStrings.MinimumBribes(input);
                Assert.AreEqual(expected + "\r\n", consoleOutput.GetOuput());
            }
            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void MinimumBribesTest3()
        {
            var input = new[] { 2, 3, 1 };
            var expected = "2";

            // Needed to test a method which writes to the Console to validate the output
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                ArraysAndStrings.MinimumBribes(input);
                Assert.AreEqual(expected + "\r\n", consoleOutput.GetOuput());
            }
            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void MinimumBribesTest4()
        {
            var input = new[] { 3, 2, 1 };
            var expected = "3";

            // Needed to test a method which writes to the Console to validate the output
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                ArraysAndStrings.MinimumBribes(input);
                Assert.AreEqual(expected + "\r\n", consoleOutput.GetOuput());
            }
            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void MinimumBribesTest5()
        {
            var input = new[] { 4, 3, 2, 1 };
            var expected = "Too chaotic";

            // Needed to test a method which writes to the Console to validate the output
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                ArraysAndStrings.MinimumBribes(input);
                Assert.AreEqual(expected + "\r\n", consoleOutput.GetOuput());
            }
            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void MinimumBribesTest6()
        {
            var input = new[] { 3, 4, 1, 2 };
            var expected = "4";

            // Needed to test a method which writes to the Console to validate the output
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                ArraysAndStrings.MinimumBribes(input);
                Assert.AreEqual(expected + "\r\n", consoleOutput.GetOuput());
            }
            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void MinimumBribesTest7()
        {
            var input = new[] { 3, 4, 2, 1 };
            var expected = "5";

            // Needed to test a method which writes to the Console to validate the output
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                ArraysAndStrings.MinimumBribes(input);
                Assert.AreEqual(expected + "\r\n", consoleOutput.GetOuput());
            }
            Assert.AreEqual(currentConsoleOut, Console.Out);
        }
    }
}
