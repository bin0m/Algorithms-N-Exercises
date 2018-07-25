using System;

namespace Algorithms_N_Exercises
{
    class Program
    {

        static void Main(string[] args)
        {
            // tuple try
            Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(1, "cat", true);
            var tuple2 = Tuple.Create("cat", 2, true);


            Console.WriteLine($"IsUnique: result={ArraysAndStrings.IsStringUnique("dFf")}, expected=True");

            Console.WriteLine($"CheckPermutation: result={ArraysAndStrings.CheckPermutation("abcb","cbba")}, expected=True");

            Console.WriteLine($"IsPalindromePermutation: result={ArraysAndStrings.IsPalindromePermutation("Tact coa")}, expected=True");
            Console.WriteLine($"IsPalindromePermutation: result={ArraysAndStrings.IsPalindromePermutation("bbcc bc")}, expected=False");

            Console.WriteLine($"IsOneAway: result={ArraysAndStrings.IsOneAway("pale", "ple")}, expected=True");


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

            var mat1 = new[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            Console.WriteLine($"RotateMatrix: result=[\n{ArraysAndStrings.MatrixToString(mat1)}], expected=[\n[13, 9, 5, 1],\n[14,10, 6, 2],\n[15,11, 7, 3],\n[16,12, 8, 4]\n]");
            
            var res01 = Trees.ListOfDepths(Trees.CreateBinaryTree(new int?[] { 3, 9, 20, null, null, 15, 7 }));
            Console.WriteLine($"result=[[{res01[0].First.Value.Val}],[{res01[1].First.Value.Val},{res01[1].Last.Value.Val}],[{res01[2].First.Value.Val},{res01[2].Last.Value.Val}]],expected = [[3],[9,20],[15,7]]");


            Console.WriteLine($"CheckBalanced: result={Trees.CheckBalanced(Trees.CreateBinaryTree(new int?[] { 3, 9, 20, null, null, 15, 7 }))}, expected=True");
            Console.WriteLine($"CheckBalanced: result={Trees.CheckBalanced(Trees.CreateBinaryTree(new int?[] { 3, null }))}, expected=True");
            Console.WriteLine($"CheckBalanced: result={Trees.CheckBalanced(Trees.CreateBinaryTree(new int?[] { 3, null, 20, 15 }))}, expected=False");

            ArraysAndStrings.ArrayInitializations();

            Console.WriteLine($"CanBeWrittenFrom: result={ArraysAndStrings.CanBeWrittenFrom("a,O,","qpz,,%ar0O")}, expected=True");
            Console.WriteLine($"CanBeWrittenFrom: result={ArraysAndStrings.CanBeWrittenFrom("a,O,", "qpz,%ar0O")}, expected=False");
            Console.WriteLine($"CanBeWrittenFrom: result={ArraysAndStrings.CanBeWrittenFrom("abba", "Banda b")}, expected=False");

            Console.WriteLine($"WordCountEngine: result=[{ArraysAndStrings.MatrixToString(ArraysAndStrings.WordCountEngine("Practice makes perfect, you'll get perfecT by practice. just practice! just just just!!"))}], expected=[[\"just\",\"4\"],[\"practice\",\"3\"],[\"perfect\",\"2\"],[\"makes\",\"1\"],[\"youll\",\"1\"],[\"get\",\"1\"],[\"by\",\"1\"]]");
            Console.WriteLine($"WordCountEngine: result=[{ArraysAndStrings.MatrixToString(ArraysAndStrings.WordCountEngine("Every book is a quotation; and every house is a quotation out of all forests, and mines, and stone quarries; and every man is a quotation from all his ancestors. "))}], expected=[[\"and\",\"4\"],[\"every\",\"3\"],[\"is\",\"3\"],[\"a\",\"3\"],[\"quotation\",\"3\"],[\"all\",\"2\"],[\"book\",\"1\"],[\"house\",\"1\"],[\"out\",\"1\"],[\"of\",\"1\"],[\"forests\",\"1\"],[\"mines\",\"1\"],[\"stone\",\"1\"],[\"quarries\",\"1\"],[\"man\",\"1\"],[\"from\",\"1\"],[\"his\",\"1\"],[\"ancestors\",\"1\"]]");

            Console.WriteLine($"ReverseWords: result=[{new string(ArraysAndStrings.ReverseWords(new char[] { 'y', 'o', 'u', ' ', 'm', 'e' }))}], expected=[me you]");

            Console.WriteLine($"MeetingPlanner: result=[{ArraysAndStrings.MeetingPlanner(new[,] { {7,12 }}, new[,] { { 2, 11 } },5)}], expected = []");

            Console.WriteLine($"IsMatchRegex: result={ArraysAndStrings.IsMatchRegex("abaa", "a.*a*")}, expected = True");

            Console.WriteLine($"GetShortestUniqueSubstring: result={ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'a','b'},"-acb")}, expected = acb");

            Console.ReadLine();
        }
    }
}
