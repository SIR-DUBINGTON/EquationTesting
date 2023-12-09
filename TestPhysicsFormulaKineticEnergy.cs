using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Equationator;

namespace EquationTesting
{
    /// <summary>
    /// Test class for the PhysicsFormulaKineticEnergy class, containing unit tests.
    /// </summary>
    [TestClass]
    public class TestPhysicsFormulaKineticEnergy
    {
        /// <summary>
        /// Test method for the Calculate method of the PhysicsFormulaKineticEnergy class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculate()
        {
            // Arrange: Create an instance of PhysicsFormulaKineticEnergy with specific parameters
            PhysicsFormulaKineticEnergy physicsFormulaKineticEnergy = new PhysicsFormulaKineticEnergy(0, 10, 5);

            // Act: Call the Calculate method and assert the result
            Assert.AreEqual(250, physicsFormulaKineticEnergy.Calculate());
        }

        /// <summary>
        /// Test method for the CalculateTerm2 method of the PhysicsFormulaKineticEnergy class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm2()
        {
            // Arrange: Create an instance of PhysicsFormulaKineticEnergy with specific parameters
            PhysicsFormulaKineticEnergy physicsFormulaKineticEnergy = new PhysicsFormulaKineticEnergy(14, 8, 0);

            // Act: Call the CalculateTerm2 method and assert the result
            Assert.AreEqual(0.4375, physicsFormulaKineticEnergy.CalculateTerm2());
        }

        /// <summary>
        /// Test method for the CalculateTerm3 method of the PhysicsFormulaKineticEnergy class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm3()
        {
            // Arrange: Create an instance of PhysicsFormulaKineticEnergy with specific parameters
            PhysicsFormulaKineticEnergy physicsFormulaKineticEnergy = new PhysicsFormulaKineticEnergy(20, 0, 35);

            // Act: Call the CalculateTerm3 method and assert the result
            Assert.AreEqual(1.069044967649697538738213923519, physicsFormulaKineticEnergy.CalculateTerm3());
        }

        /// <summary>
        /// Test method for the CalculateTerm4 method of the PhysicsFormulaKineticEnergy class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm4()
        {
            // Arrange: Create an instance of PhysicsFormulaKineticEnergy with specific parameters
            PhysicsFormulaKineticEnergy physicsFormulaKineticEnergy = new PhysicsFormulaKineticEnergy(0, 0, 0);

            // Act: Call the CalculateTerm4 method and assert the result
            Assert.AreEqual(0, physicsFormulaKineticEnergy.CalculateTerm4());
        }

        /// <summary>
        /// Test method for the GetFormula method of the PhysicsFormulaKineticEnergy class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormula()
        {
            // Arrange: Create an instance of PhysicsFormulaKineticEnergy with specific parameters
            PhysicsFormulaKineticEnergy physicsFormulaKineticEnergy = new PhysicsFormulaKineticEnergy(0, 0, 0);

            // Act: Call the GetFormula method and assert the result
            Assert.AreEqual("KE = (m * v^2) / 2", physicsFormulaKineticEnergy.GetFormula());
        }

        /// <summary>
        /// Test method for the GetFormulaTerm2 method of the PhysicsFormulaKineticEnergy class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormulaTerm2()
        {
            // Arrange: Create an instance of PhysicsFormulaKineticEnergy with specific parameters
            PhysicsFormulaKineticEnergy physicsFormulaKineticEnergy = new PhysicsFormulaKineticEnergy(0, 0, 0);

            // Act: Call the GetFormulaTerm2 method and assert the result
            Assert.AreEqual("m = (2 * KE) / (v^2)", physicsFormulaKineticEnergy.GetFormulaTerm2());
        }

        /// <summary>
        /// Test method for the GetFormulaTerm3 method of the PhysicsFormulaKineticEnergy class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormulaTerm3()
        {
            // Arrange: Create an instance of PhysicsFormulaKineticEnergy with specific parameters
            PhysicsFormulaKineticEnergy physicsFormulaKineticEnergy = new PhysicsFormulaKineticEnergy(0, 0, 0);

            // Act: Call the GetFormulaTerm3 method and assert the result
            Assert.AreEqual("v = sqrt((2 * KE) / m)", physicsFormulaKineticEnergy.GetFormulaTerm3());
        }
    }
}
