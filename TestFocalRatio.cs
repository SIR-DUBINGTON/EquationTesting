using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Equationator;

namespace EquationTesting
{
    /// <summary>
    /// Test class for FocalRatio, containing unit tests.
    /// </summary>
    [TestClass]
    public class TestFocalRatio
    {
        /// <summary>
        /// Test method for the Calculate method of FocalRatio.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculate()
        {
            // Arrange: Create an instance of FocalRatio with specific parameters
            FocalRatio focalRatio = new FocalRatio(400, 20, 0);

            // Act: Call the Calculate method and assert the result
            Assert.AreEqual(20, focalRatio.Calculate());
        }

        /// <summary>
        /// Test method for the CalculateTerm2 method of FocalRatio.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm2()
        {
            // Arrange: Create an instance of FocalRatio with specific parameters
            FocalRatio focalRatio = new FocalRatio(0, 50, 10);

            // Act: Call the CalculateTerm2 method and assert the result
            Assert.AreEqual(500, focalRatio.CalculateTerm2());
        }

        /// <summary>
        /// Test method for the CalculateTerm3 method of FocalRatio.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm3()
        {
            // Arrange: Create an instance of FocalRatio with specific parameters
            FocalRatio focalRatio = new FocalRatio(15, 0, 5);

            // Act: Call the CalculateTerm3 method and assert the result
            Assert.AreEqual(3, focalRatio.CalculateTerm3());
        }

        /// <summary>
        /// Test method for the CalculateTerm4 method of FocalRatio.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm4()
        {
            // Arrange: Create an instance of FocalRatio with specific parameters
            FocalRatio focalRatio = new FocalRatio(0, 0, 0);

            // Act: Call the CalculateTerm4 method and assert the result
            Assert.AreEqual(0, focalRatio.CalculateTerm4());
        }

        /// <summary>
        /// Test method for the GetFormula method of FocalRatio.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormula()
        {
            // Arrange: Create an instance of FocalRatio with specific parameters
            FocalRatio focalRatio = new FocalRatio(0, 0, 0);

            // Act: Call the GetFormula method and assert the result
            Assert.AreEqual("N = f / D", focalRatio.GetFormula());
        }
    }
}
