using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorialProject;

namespace FactorialTest
{
    [TestClass]
    public class FactorialTest
    {
        private FactorialUtil f;

        [TestInitialize]
        public void Initialization()
        {
            f = new FactorialUtil();
            Console.Write("Initialization Done!");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Console.WriteLine("Cleanup done!");
        }

        [TestMethod]
        public void TestFactorialOf0Is1()
        {
            //exercise
            long result = f.GetFactorial(0);

            //verification
            Assert.AreEqual(1, result);
        }

        [TestMethod]

        public void TestFactorialOf1Is1()
        {
            //exercise
            long result = f.GetFactorial(1);

            //verification
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestFactorialOfXIsXTimesXMin1Fact()
        {
            //exercise
            for (long x = 2; x < 20; x++)
            {
                long result = f.GetFactorial(x);
                Console.WriteLine("{0}! = {1}", x, result);

                //verification
                Assert.AreEqual(x*f.GetFactorial(x-1), result);
            }
        }

        [TestMethod]
        public void TestFactorialResultCannotBeNegative()
        {

            //exercise
            try
            {
                long result = f.GetFactorial(24);
                Assert.Fail();
                Console.WriteLine("{0}! = {1}", 24, result);
            }
            catch (Exception fe)
            {
                Assert.IsInstanceOfType(fe, typeof(FactorialException));
            }
        }
    }
}
