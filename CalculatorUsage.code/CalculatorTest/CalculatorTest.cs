using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using CalculatorCode.Feature;
namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add_Giventwonum_resultint()
        {
            var calculator = new Calculator();
            int result = calculator.Add(6, 2);
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        [DataRow(2, 1, 3)]
        [DataRow(11, 1, 12)]
        public void Add_Parameterized(int a, int b, int expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            int result = calculator.Add(a, b);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
