using System;
using NUnit.Framework;

namespace UnitTestProject3
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        [Ignore("Ignore this test case:")]
        public void TestMethod1()
        {
        }

        [TestCase]
        public void TestMethod2()
        {
        }


    }
}
