using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Equationator;

namespace EquationTesting
{
    /// <summary>
    /// Test class for MathAreaCircle, containing unit tests.
    /// </summary>
    [TestClass]
    public class TestMathAreaCircle
    {
        /// <summary>
        /// Test method for the Calculate method of MathAreaCircle.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculate()
        {
            // Arrange: Create an instance of MathAreaCircle with specific parameters
            MathAreaCircle mathAreaCircle = new MathAreaCircle(2, 0);

            // Act: Call the Calculate method and assert the result
            Assert.AreEqual(12.566370614359172, mathAreaCircle.Calculate());
        }

        /// <summary>
        /// Test method for the CalculateTerm2 method of MathAreaCircle.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm2()
        {
            // Arrange: Create an instance of MathAreaCircle with specific parameters
            MathAreaCircle mathAreaCircle = new MathAreaCircle(0, 12.566370614359172);

            // Act: Call the CalculateTerm2 method and assert the result
            Assert.AreEqual(2, mathAreaCircle.CalculateTerm2());
        }

        /// <summary>
        /// Test method for the CalculateTerm3 method of MathAreaCircle.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm3()
        {
            // Arrange: Create an instance of MathAreaCircle with specific parameters
            MathAreaCircle mathAreaCircle = new MathAreaCircle(0, 0);

            // Act: Call the CalculateTerm3 method and assert the result
            Assert.AreEqual(0, mathAreaCircle.CalculateTerm3());
        }

        /// <summary>
        /// Test method for the CalculateTerm4 method of MathAreaCircle.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm4()
        {
            // Arrange: Create an instance of MathAreaCircle with specific parameters
            MathAreaCircle mathAreaCircle = new MathAreaCircle(0, 0);

            // Act: Call the CalculateTerm4 method and assert the result
            Assert.AreEqual(0, mathAreaCircle.CalculateTerm4());
        }

        /// <summary>
        /// Test method for the GetFormula method of MathAreaCircle.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormula()
        {
            // Arrange: Create an instance of MathAreaCircle with specific parameters
            MathAreaCircle mathAreaCircle = new MathAreaCircle(0, 0);

            // Act: Call the GetFormula method and assert the result
            Assert.AreEqual("A = πr²", mathAreaCircle.GetFormula());
        }
    }
}
