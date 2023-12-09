using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Equationator;

namespace EquationTesting
{
    /// <summary>
    /// Test class for the MathAreaRectangle class, containing unit tests.
    /// </summary>
    [TestClass]
    public class TestMathAreaRectangle
    {
        /// <summary>
        /// Test method for the Calculate method of the MathAreaRectangle class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculate()
        {
            // Arrange: Create an instance of MathAreaRectangle with specific parameters
            MathAreaRectangle mathAreaRectangle = new MathAreaRectangle(40, 40, 0);

            // Act: Call the Calculate method and assert the result
            Assert.AreEqual(1600, mathAreaRectangle.Calculate());
        }

        /// <summary>
        /// Test method for the CalculateTerm2 method of the MathAreaRectangle class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm2()
        {
            // Arrange: Create an instance of MathAreaRectangle with specific parameters
            MathAreaRectangle mathAreaRectangle = new MathAreaRectangle(0, 5, 25);

            // Act: Call the CalculateTerm2 method and assert the result
            Assert.AreEqual(5, mathAreaRectangle.CalculateTerm2());
        }

        /// <summary>
        /// Test method for the CalculateTerm3 method of the MathAreaRectangle class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm3()
        {
            // Arrange: Create an instance of MathAreaRectangle with specific parameters
            MathAreaRectangle mathAreaRectangle = new MathAreaRectangle(25, 0, 100);

            // Act: Call the CalculateTerm3 method and assert the result
            Assert.AreEqual(4, mathAreaRectangle.CalculateTerm3());
        }

        /// <summary>
        /// Test method for the CalculateTerm4 method of the MathAreaRectangle class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm4()
        {
            // Arrange: Create an instance of MathAreaRectangle with specific parameters
            MathAreaRectangle mathAreaRectangle = new MathAreaRectangle(0, 0, 0);

            // Act: Call the CalculateTerm4 method and assert the result
            Assert.AreEqual(0, mathAreaRectangle.CalculateTerm4());
        }

        /// <summary>
        /// Test method for the GetFormula method of the MathAreaRectangle class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormula()
        {
            // Arrange: Create an instance of MathAreaRectangle with specific parameters
            MathAreaRectangle mathAreaRectangle = new MathAreaRectangle(0, 0, 0);

            // Act: Call the GetFormula method and assert the result
            Assert.AreEqual("a = b * h", mathAreaRectangle.GetFormula());
        }
    }
}
