using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms_N_Exercises.UnitTests
{
    [TestClass]
    public class MathAndLogicPuzzlesTests
    {
        [TestMethod]
        public void RootOfNumberTest1()
        {
            Assert.AreEqual(MathAndLogicPuzzles.RootOfNumber(4, 2), 2.00);
        }

        [TestMethod]
        public void RootOfNumberTest2()
        {
            Assert.AreEqual(MathAndLogicPuzzles.RootOfNumber(27, 3), 3.00);
        }

        [TestMethod]
        public void RootOfNumberTest3()
        {
            Assert.AreEqual(MathAndLogicPuzzles.RootOfNumber(3, 2), 1.73);
        }

        [TestMethod]
        public void RootOfNumberTest4()
        {
            Assert.AreEqual(MathAndLogicPuzzles.RootOfNumber(160, 3), 5.43);
        }

        [TestMethod]
        public void RootOfNumberTest5()
        {
            Assert.AreEqual(MathAndLogicPuzzles.RootOfNumber(0.25, 2), 0.5);
        }
    }
}
