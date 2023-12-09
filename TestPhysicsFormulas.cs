using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Equationator;

namespace EquationTesting
{
    /// <summary>
    /// Test class for the PhysicsFormulas class, containing unit tests.
    /// </summary>
    [TestClass]
    public class TestPhysicsFormulas
    {
        /// <summary>
        /// Test method for the Calculate method of the PhysicsFormulas class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculate()
        {
            // Arrange: Create an instance of PhysicsFormulas with specific parameters
            PhysicsFormulas physicsFormulas = new PhysicsFormulas(2, 2, 0);

            // Act: Call the Calculate method and assert the result
            Assert.AreEqual(4, physicsFormulas.Calculate());
        }

        /// <summary>
        /// Test method for the CalculateTerm2 method of the PhysicsFormulas class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm2()
        {
            // Arrange: Create an instance of PhysicsFormulas with specific parameters
            PhysicsFormulas physicsFormulas = new PhysicsFormulas(0, 5, 10);

            // Act: Call the CalculateTerm2 method and assert the result
            Assert.AreEqual(2, physicsFormulas.CalculateTerm2());
        }

        /// <summary>
        /// Test method for the CalculateTerm3 method of the PhysicsFormulas class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm3()
        {
            // Arrange: Create an instance of PhysicsFormulas with specific parameters
            PhysicsFormulas physicsFormulas = new PhysicsFormulas(10, 0, 5);

            // Act: Call the CalculateTerm3 method and assert the result
            Assert.AreEqual(0.5, physicsFormulas.CalculateTerm3());
        }

        /// <summary>
        /// Test method for the CalculateTerm4 method of the PhysicsFormulas class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm4()
        {
            // Arrange: Create an instance of PhysicsFormulas with specific parameters
            PhysicsFormulas physicsFormulas = new PhysicsFormulas(0, 0, 0);

            // Act: Call the CalculateTerm4 method and assert the result
            Assert.AreEqual(0, physicsFormulas.CalculateTerm4());
        }

        /// <summary>
        /// Test method for the GetFormula method of the PhysicsFormulas class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormula()
        {
            // Arrange: Create an instance of PhysicsFormulas with specific parameters
            PhysicsFormulas physicsFormulas = new PhysicsFormulas(0, 0, 0);

            // Act: Call the GetFormula method and assert the result
            Assert.AreEqual("F = m * g", physicsFormulas.GetFormula());
        }

        /// <summary>
        /// Test method for the GetFormulaTerm2 method of the PhysicsFormulas class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormulaTerm2()
        {
            // Arrange: Create an instance of PhysicsFormulas with specific parameters
            PhysicsFormulas physicsFormulas = new PhysicsFormulas(0, 0, 0);

            // Act: Call the GetFormulaTerm2 method and assert the result
            Assert.AreEqual("m = F / g", physicsFormulas.GetFormulaTerm2());
        }

        /// <summary>
        /// Test method for the GetFormulaTerm3 method of the PhysicsFormulas class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormulaTerm3()
        {
            // Arrange: Create an instance of PhysicsFormulas with specific parameters
            PhysicsFormulas physicsFormulas = new PhysicsFormulas(0, 0, 0);

            // Act: Call the GetFormulaTerm3 method and assert the result
            Assert.AreEqual("g = F / m", physicsFormulas.GetFormulaTerm3());
        }
    }
}
