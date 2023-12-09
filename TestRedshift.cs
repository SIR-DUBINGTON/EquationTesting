using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Equationator;

namespace EquationTesting
{
    /// <summary>
    /// Test class for the Redshift class, containing unit tests.
    /// </summary>
    [TestClass]
    public class TestRedshift
    {
        /// <summary>
        /// Test method for the Calculate method of the Redshift class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculate()
        {
            // Arrange: Create an instance of Redshift with specific parameters
            Redshift redshift = new Redshift(0, 2000);

            // Act: Call the Calculate method and assert the result
            Assert.AreEqual(6.6712819039630409915115342894984e-6, redshift.Calculate());
        }

        /// <summary>
        /// Test method for the CalculateTerm2 method of the Redshift class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm2()
        {
            // Arrange: Create an instance of Redshift with specific parameters
            Redshift redshift = new Redshift(15, 0);

            // Act: Call the CalculateTerm2 method and assert the result
            Assert.AreEqual(4496886870, redshift.CalculateTerm2());
        }

        /// <summary>
        /// Test method for the CalculateTerm3 method of the Redshift class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm3()
        {
            // Arrange: Create an instance of Redshift with specific parameters
            Redshift redshift = new Redshift(0, 0);

            // Act: Call the CalculateTerm3 method and assert the result
            Assert.AreEqual(0, redshift.CalculateTerm3());
        }

        /// <summary>
        /// Test method for the CalculateTerm4 method of the Redshift class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm4()
        {
            // Arrange: Create an instance of Redshift with specific parameters
            Redshift redshift = new Redshift(0, 0);

            // Act: Call the CalculateTerm4 method and assert the result
            Assert.AreEqual(0, redshift.CalculateTerm4());
        }

        /// <summary>
        /// Test method for the GetFormula method of the Redshift class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormula()
        {
            // Arrange: Create an instance of Redshift with specific parameters
            Redshift redshift = new Redshift(0, 0);

            // Act: Call the GetFormula method and assert the result
            Assert.AreEqual("z = (lambda observed - lambda emitted) / lambda emitted", redshift.GetFormula());
        }
    }
}
