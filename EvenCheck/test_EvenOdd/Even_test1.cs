using System;
using System.Collections.Generic;
using System.Text;
using Even_Check.feature;

namespace test_EvenOdd
{
    [TestClass]
    public class Even_test1
    {
        [TestMethod]
        public void Even_test_m()
        {
            var et = new EvenOrOdd();
            bool result = et.check(4);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void sumofno_m()
        {
            var et = new SumOfnumber();
            int result = et.sumofnumber(4);
            Assert.AreEqual(10, result);
        }
        [TestMethod]
        public void ReverseString_Test()
        {
            // Arrange
            var et1 = new Reverse();
            string input = "Shivansh";
            // Act
            string result = et1.ReverseString(input);
            // Assert
            Assert.AreEqual("hsnavihS", result);
        }

    }
}
