using System;

namespace Algorithms_N_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"IsUnique: result={ArraysAndStrings.IsStringUnique("dFf")}, expected=True");
            Console.WriteLine($"IsUnique: result={ArraysAndStrings.IsStringUnique("dFfd")}, expected=False");
            Console.WriteLine($"IsUnique2: result={ArraysAndStrings.IsStringUnique2("dFf")}, expected=True");
            Console.WriteLine($"IsUnique2: result={ArraysAndStrings.IsStringUnique2("dFfd")}, expected=False");

            Console.WriteLine($"CheckPermutation: result={ArraysAndStrings.CheckPermutation("abcb","cbba")}, expected=True");
            Console.WriteLine($"CheckPermutation: result={ArraysAndStrings.CheckPermutation("abcb","cbaa")}, expected=False");

            Console.WriteLine($"IsPalindromePermutation: result={ArraysAndStrings.IsPalindromePermutation("Tact coa")}, expected=True");
            Console.WriteLine($"IsPalindromePermutation: result={ArraysAndStrings.IsPalindromePermutation("bbcc bc")}, expected=False");

            Console.WriteLine($"IsOneAway: result={ArraysAndStrings.IsOneAway("pale", "ple")}, expected=True");
            Console.WriteLine($"IsOneAway: result={ArraysAndStrings.IsOneAway("pales", "pale")}, expected=True");
            Console.WriteLine($"IsOneAway: result={ArraysAndStrings.IsOneAway("pale", "bale")}, expected=True");
            Console.WriteLine($"IsOneAway: result={ArraysAndStrings.IsOneAway("pale", "bake")}, expected=False");


            Console.WriteLine($"IsPrime(\"a\"): result={ArraysAndStrings.IsPrime("a")}, expected=True");
            Console.WriteLine($"IsPrime(\"aaa\"): result={ArraysAndStrings.IsPrime("aaa")}, expected=False");
            Console.WriteLine($"IsPrime(\"aaab\"): result={ArraysAndStrings.IsPrime("aaab")}, expected=True");
            Console.WriteLine($"IsPrime(\"abcabc\"): result={ArraysAndStrings.IsPrime("abcabc")}, expected=False");
            Console.WriteLine($"IsPrime(\"ababab\"): result={ArraysAndStrings.IsPrime("ababab")}, expected=False");


            Console.ReadLine();
        }
    }
}
