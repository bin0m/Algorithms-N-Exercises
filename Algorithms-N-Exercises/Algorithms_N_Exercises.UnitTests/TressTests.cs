using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_N_Exercises.UnitTests
{
    [TestClass]
    public class TressTests
    {
        [TestMethod]
        public void ListOfDepthsTest1()
        {
            var res01 = Trees.ListOfDepths(Trees.CreateBinaryTree(new int?[] { 3, 9, 20, null, null, 15, 7 }));
            Console.WriteLine($"result=[[{res01[0].First.Value.Val}],[{res01[1].First.Value.Val},{res01[1].Last.Value.Val}],[{res01[2].First.Value.Val},{res01[2].Last.Value.Val}]],expected = [[3],[9,20],[15,7]]");
            //Assert.AreEqual()

        }
    }
}
