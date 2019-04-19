using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(UnitTestClass.IsTriangle(7));
        }
    }
}
