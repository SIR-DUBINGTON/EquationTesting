using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Equationator;

namespace EquationTesting
{
    /// <summary>
    /// Test class for the PhysicsFormulaVelocity class, containing unit tests.
    /// </summary>
    [TestClass]
    public class TestPhysicsFormulaVelocity
    {
        /// <summary>
        /// Test method for the Calculate method of the PhysicsFormulaVelocity class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculate()
        {
            // Arrange: Create an instance of PhysicsFormulaVelocity with specific parameters
            PhysicsFormulaVelocity physicsFormulaVelocity = new PhysicsFormulaVelocity(20, 10, 5, 0);

            // Act: Call the Calculate method and assert the result
            Assert.AreEqual(70, physicsFormulaVelocity.Calculate());
        }

        /// <summary>
        /// Test method for the CalculateTerm2 method of the PhysicsFormulaVelocity class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm2()
        {
            // Arrange: Create an instance of PhysicsFormulaVelocity with specific parameters
            PhysicsFormulaVelocity physicsFormulaVelocity = new PhysicsFormulaVelocity(0, 10, 5, 50);

            // Act: Call the CalculateTerm2 method and assert the result
            Assert.AreEqual(0, physicsFormulaVelocity.CalculateTerm2());
        }

        /// <summary>
        /// Test method for the CalculateTerm3 method of the PhysicsFormulaVelocity class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm3()
        {
            // Arrange: Create an instance of PhysicsFormulaVelocity with specific parameters
            PhysicsFormulaVelocity physicsFormulaVelocity = new PhysicsFormulaVelocity(15, 0, 5, 50);

            // Act: Call the CalculateTerm3 method and assert the result
            Assert.AreEqual(7, physicsFormulaVelocity.CalculateTerm3());
        }

        /// <summary>
        /// Test method for the CalculateTerm4 method of the PhysicsFormulaVelocity class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm4()
        {
            // Arrange: Create an instance of PhysicsFormulaVelocity with specific parameters
            PhysicsFormulaVelocity physicsFormulaVelocity = new PhysicsFormulaVelocity(25, 10, 0, 50);

            // Act: Call the CalculateTerm4 method and assert the result
            Assert.AreEqual(-7.5, physicsFormulaVelocity.CalculateTerm4());
        }

        /// <summary>
        /// Test method for the GetFormula method of the PhysicsFormulaVelocity class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormula()
        {
            // Arrange: Create an instance of PhysicsFormulaVelocity with specific parameters
            PhysicsFormulaVelocity physicsFormulaVelocity = new PhysicsFormulaVelocity(0, 0, 0, 0);

            // Act: Call the GetFormula method and assert the result
            Assert.AreEqual("v = u + a * t", physicsFormulaVelocity.GetFormula());
        }

        /// <summary>
        /// Test method for the GetFormulaTerm2 method of the PhysicsFormulaVelocity class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormulaTerm2()
        {
            // Arrange: Create an instance of PhysicsFormulaVelocity with specific parameters
            PhysicsFormulaVelocity physicsFormulaVelocity = new PhysicsFormulaVelocity(0, 0, 0, 0);

            // Act: Call the GetFormulaTerm2 method and assert the result
            Assert.AreEqual("u = -(a * t) + v", physicsFormulaVelocity.GetFormulaTerm2());
        }

        /// <summary>
        /// Test method for the GetFormulaTerm3 method of the PhysicsFormulaVelocity class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormulaTerm3()
        {
            // Arrange: Create an instance of PhysicsFormulaVelocity with specific parameters
            PhysicsFormulaVelocity physicsFormulaVelocity = new PhysicsFormulaVelocity(0, 0, 0, 0);

            // Act: Call the GetFormulaTerm3 method and assert the result
            Assert.AreEqual("a = -(u + v) / t", physicsFormulaVelocity.GetFormulaTerm3());
        }

        /// <summary>
        /// Test method for the GetFormulaTerm4 method of the PhysicsFormulaVelocity class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormulaTerm4()
        {
            // Arrange: Create an instance of PhysicsFormulaVelocity with specific parameters
            PhysicsFormulaVelocity physicsFormulaVelocity = new PhysicsFormulaVelocity(0, 0, 0, 0);

            // Act: Call the GetFormulaTerm4 method and assert the result
            Assert.AreEqual("t = -(u + v) / a", physicsFormulaVelocity.GetFormulaTerm4());
        }
    }
}
