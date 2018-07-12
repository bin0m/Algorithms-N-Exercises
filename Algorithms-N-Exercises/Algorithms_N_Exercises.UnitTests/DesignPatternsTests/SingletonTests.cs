using System;
using Algorithms_N_Exercises.DesignPatterns;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms_N_Exercises.UnitTests.DesignPatternsTests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void IsSingletonTest()
        {
            var instance1 = SafeSingletonDatabase.Instance;
            var instance2 = SafeSingletonDatabase.Instance;
            Assert.AreSame(instance1,instance2);
            Assert.AreEqual(SafeSingletonDatabase.CountOfInstances,1);
        }

        [TestMethod]
        public void IsCapitalsDBWorks()
        {
            var db = SafeSingletonDatabase.Instance;
            Assert.AreEqual(db.GetPopulation("Osaka"), 16425000);
        }
    }
}
