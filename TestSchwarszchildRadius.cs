using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Equationator;

namespace EquationTesting
{
    /// <summary>
    /// Test class for the SchwarszchildRadius class, containing unit tests.
    /// </summary>
    [TestClass]
    public class TestSchwarszchildRadius
    {
        /// <summary>
        /// Test method for the Calculate method of the SchwarszchildRadius class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculate()
        {
            // Arrange: Create an instance of SchwarszchildRadius with specific parameters
            SchwarszchildRadius schwarszchildRadius = new SchwarszchildRadius(0, 20, 40);

            // Act: Call the Calculate method and assert the result
            Assert.AreEqual(1.7802400896857894914785439437568e-14, schwarszchildRadius.Calculate());
        }

        /// <summary>
        /// Test method for the CalculateTerm2 method of the SchwarszchildRadius class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm2()
        {
            // Arrange: Create an instance of SchwarszchildRadius with specific parameters
            SchwarszchildRadius schwarszchildRadius = new SchwarszchildRadius(45, 0, 105);

            // Act: Call the CalculateTerm2 method and assert the result
            Assert.AreEqual(19259039544360377.295238095238095, schwarszchildRadius.CalculateTerm2());
        }

        /// <summary>
        /// Test method for the CalculateTerm3 method of the SchwarszchildRadius class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm3()
        {
            // Arrange: Create an instance of SchwarszchildRadius with specific parameters
            SchwarszchildRadius schwarszchildRadius = new SchwarszchildRadius(25, 10, 0);

            // Act: Call the CalculateTerm3 method and assert the result
            Assert.AreEqual(112344397342102195.2, schwarszchildRadius.CalculateTerm3());
        }

        /// <summary>
        /// Test method for the CalculateTerm4 method of the SchwarszchildRadius class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm4()
        {
            // Arrange: Create an instance of SchwarszchildRadius with specific parameters
            SchwarszchildRadius schwarszchildRadius = new SchwarszchildRadius(0, 0, 0);

            // Act: Call the CalculateTerm4 method and assert the result
            Assert.AreEqual(0, schwarszchildRadius.CalculateTerm4());
        }

        /// <summary>
        /// Test method for the GetFormula method of the SchwarszchildRadius class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormula()
        {
            // Arrange: Create an instance of SchwarszchildRadius with specific parameters
            SchwarszchildRadius schwarszchildRadius = new SchwarszchildRadius(0, 0, 0);

            // Act: Call the GetFormula method and assert the result
            Assert.AreEqual("r = (2GM) / c²", schwarszchildRadius.GetFormula());
        }
    }
}
