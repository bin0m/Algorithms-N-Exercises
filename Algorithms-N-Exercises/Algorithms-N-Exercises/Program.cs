﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.ReadLine();
        }
    }
}
