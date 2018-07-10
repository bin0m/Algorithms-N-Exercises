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

            QueueViaStacks<int> queueViaStacks = new QueueViaStacks<int>();
            queueViaStacks.Enqueue(1);
            queueViaStacks.Enqueue(2);
            Console.WriteLine($"QueueViaStacks: result={queueViaStacks.Dequeue()}, expected=1");
            queueViaStacks.Enqueue(3);
            Console.WriteLine($"QueueViaStacks: result={queueViaStacks.Peek()}, expected=2");
            Console.WriteLine($"QueueViaStacks: result={queueViaStacks.Dequeue()}, expected=2");
            Console.WriteLine($"QueueViaStacks: result={queueViaStacks.Dequeue()}, expected=3");

            var mat1 = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            var res1 = ArraysAndStrings.RotateMatrix(mat1);
            Console.WriteLine($"RotateMatrix: result=[\n{ArraysAndStrings.MatrixToString(mat1)}], expected=[\n[13, 9, 5, 1],\n[14,10, 6, 2],\n[15,11, 7, 3],\n[16,12, 8, 4]\n]");
            
            var res01 = Trees.ListOfDepths(Trees.CreateBinaryTree(new int?[] { 3, 9, 20, null, null, 15, 7 }));
            Console.WriteLine($"result=[[{res01[0].First.Value.val}],[{res01[1].First.Value.val},{res01[1].Last.Value.val}],[{res01[2].First.Value.val},{res01[2].Last.Value.val}]],expected = [[3],[9,20],[15,7]]");


            Console.WriteLine($"CheckBalanced: result={Trees.CheckBalanced(Trees.CreateBinaryTree(new int?[] { 3, 9, 20, null, null, 15, 7 }))}, expected=True");
            Console.WriteLine($"CheckBalanced: result={Trees.CheckBalanced(Trees.CreateBinaryTree(new int?[] { 3, null }))}, expected=True");
            Console.WriteLine($"CheckBalanced: result={Trees.CheckBalanced(Trees.CreateBinaryTree(new int?[] { 3, null, 20, 15 }))}, expected=False");

            ArraysAndStrings.ArrayInitializations();

            Console.WriteLine($"CanBeWrittenFrom: result={ArraysAndStrings.CanBeWrittenFrom("a,O,","qpz,,%ar0O")}, expected=True");
            Console.WriteLine($"CanBeWrittenFrom: result={ArraysAndStrings.CanBeWrittenFrom("a,O,", "qpz,%ar0O")}, expected=False");
            Console.WriteLine($"CanBeWrittenFrom: result={ArraysAndStrings.CanBeWrittenFrom("abba", "Banda b")}, expected=False");

            Console.WriteLine($"WordCountEngine: result=[{ArraysAndStrings.MatrixToString(ArraysAndStrings.WordCountEngine("Practice makes perfect, you'll get perfecT by practice. just practice! just just just!!"))}], expected=[[\"just\",\"4\"],[\"practice\",\"3\"],[\"perfect\",\"2\"],[\"makes\",\"1\"],[\"youll\",\"1\"],[\"get\",\"1\"],[\"by\",\"1\"]]");
            Console.WriteLine($"WordCountEngine: result=[{ArraysAndStrings.MatrixToString(ArraysAndStrings.WordCountEngine("Every book is a quotation; and every house is a quotation out of all forests, and mines, and stone quarries; and every man is a quotation from all his ancestors. "))}], expected=[[\"just\",\"4\"],[\"practice\",\"3\"],[\"perfect\",\"2\"],[\"makes\",\"1\"],[\"youll\",\"1\"],[\"get\",\"1\"],[\"by\",\"1\"]]");


            Console.ReadLine();
        }
    }
}
