using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Equationator;

namespace EquationTesting
{
    /// <summary>
    /// Test class for the IFormula interface, containing unit tests.
    /// </summary>
    [TestClass]
    public class TestIFormulaInterface
    {
        /// <summary>
        /// Test method for the Calculate method of the IFormula interface.
        /// </summary>
        [TestMethod]
        public void Calculate_ReturnCorrectResult()
        {
            // Arrange: Create an instance of a class implementing IFormula (FocalRatio in this case)
            IFormula formula = new FocalRatio(400, 20, 0);

            // Act: Call the Calculate method and assert the result
            double result = formula.Calculate();
            Assert.AreEqual(20, result);
        }

        /// <summary>
        /// Test method for the CalculateTerm2 method of the IFormula interface.
        /// </summary>
        [TestMethod]
        public void CalculateTerm2_ReturnCorrectResult()
        {
            // Arrange: Create an instance of a class implementing IFormula (FocalRatio in this case)
            IFormula formula = new FocalRatio(0, 50, 10);

            // Act: Call the CalculateTerm2 method and assert the result
            double result = formula.CalculateTerm2();
            Assert.AreEqual(500, result);
        }

        /// <summary>
        /// Test method for the CalculateTerm3 method of the IFormula interface.
        /// </summary>
        [TestMethod]
        public void CalculateTerm3_ReturnCorrectResult()
        {
            // Arrange: Create an instance of a class implementing IFormula (FocalRatio in this case)
            IFormula formula = new FocalRatio(15, 0, 5);

            // Act: Call the CalculateTerm3 method and assert the result
            double result = formula.CalculateTerm3();
            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// Test method for the CalculateTerm4 method of the IFormula interface.
        /// </summary>
        [TestMethod]
        public void CalculateTerm4_ReturnCorrectResult()
        {
            // Arrange: Create an instance of a class implementing IFormula (FocalRatio in this case)
            IFormula formula = new FocalRatio(0, 0, 0);

            // Act: Call the CalculateTerm4 method and assert the result
            double result = formula.CalculateTerm4();
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// Test method for the GetFormula method of the IFormula interface.
        /// </summary>
        [TestMethod]
        public void GetFormula_ReturnCorrectString()
        {
            // Arrange: Create an instance of a class implementing IFormula (FocalRatio in this case)
            IFormula formula = new FocalRatio(0, 0, 0);

            // Act: Call the GetFormula method and assert the result
            string result = formula.GetFormula();
            Assert.AreEqual("N = f / D", result);
        }
    }
}
