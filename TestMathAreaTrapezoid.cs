using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Equationator;

namespace EquationTesting
{
    /// <summary>
    /// Test class for the MathAreaTrapezoid class, containing unit tests.
    /// </summary>
    [TestClass]
    public class TestMathAreaTrapezoid
    {
        /// <summary>
        /// Test method for the Calculate method of the MathAreaTrapezoid class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculate()
        {
            // Arrange: Create an instance of MathAreaTrapezoid with specific parameters
            MathAreaTrapezoid mathAreaTrapezoid = new MathAreaTrapezoid(10, 10, 10, 0);

            // Act: Call the Calculate method and assert the result
            Assert.AreEqual(100, mathAreaTrapezoid.Calculate());
        }

        /// <summary>
        /// Test method for the CalculateTerm2 method of the MathAreaTrapezoid class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm2()
        {
            // Arrange: Create an instance of MathAreaTrapezoid with specific parameters
            MathAreaTrapezoid mathAreaTrapezoid = new MathAreaTrapezoid(0, 10, 10, 100);

            // Act: Call the CalculateTerm2 method and assert the result
            Assert.AreEqual(10, mathAreaTrapezoid.CalculateTerm2());
        }

        /// <summary>
        /// Test method for the CalculateTerm3 method of the MathAreaTrapezoid class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm3()
        {
            // Arrange: Create an instance of MathAreaTrapezoid with specific parameters
            MathAreaTrapezoid mathAreaTrapezoid = new MathAreaTrapezoid(10, 0, 10, 100);

            // Act: Call the CalculateTerm3 method and assert the result
            Assert.AreEqual(10, mathAreaTrapezoid.CalculateTerm3());
        }

        /// <summary>
        /// Test method for the CalculateTerm4 method of the MathAreaTrapezoid class.
        /// </summary>
        [TestMethod]
        public void TestMethodCalculateTerm4()
        {
            // Arrange: Create an instance of MathAreaTrapezoid with specific parameters
            MathAreaTrapezoid mathAreaTrapezoid = new MathAreaTrapezoid(10, 10, 0, 100);

            // Act: Call the CalculateTerm4 method and assert the result
            Assert.AreEqual(10, mathAreaTrapezoid.CalculateTerm4());
        }

        /// <summary>
        /// Test method for the GetFormula method of the MathAreaTrapezoid class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormula()
        {
            // Arrange: Create an instance of MathAreaTrapezoid with specific parameters
            MathAreaTrapezoid mathAreaTrapezoid = new MathAreaTrapezoid(0, 0, 0, 0);

            // Act: Call the GetFormula method and assert the result
            Assert.AreEqual("A = ((b + a) * h) / 2", mathAreaTrapezoid.GetFormula());
        }

        /// <summary>
        /// Test method for the GetFormulaTerm2 method of the MathAreaTrapezoid class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormulaTerm2()
        {
            // Arrange: Create an instance of MathAreaTrapezoid with specific parameters
            MathAreaTrapezoid mathAreaTrapezoid = new MathAreaTrapezoid(0, 0, 0, 0);

            // Act: Call the GetFormulaTerm2 method and assert the result
            Assert.AreEqual("b = (2 * A) / (h + a)", mathAreaTrapezoid.GetFormulaTerm2());
        }

        /// <summary>
        /// Test method for the GetFormulaTerm3 method of the MathAreaTrapezoid class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormulaTerm3()
        {
            // Arrange: Create an instance of MathAreaTrapezoid with specific parameters
            MathAreaTrapezoid mathAreaTrapezoid = new MathAreaTrapezoid(0, 0, 0, 0);

            // Act: Call the GetFormulaTerm3 method and assert the result
            Assert.AreEqual("h = (2 * A) / (b + a)", mathAreaTrapezoid.GetFormulaTerm3());
        }

        /// <summary>
        /// Test method for the GetFormulaTerm4 method of the MathAreaTrapezoid class.
        /// </summary>
        [TestMethod]
        public void TestMethodGetFormulaTerm4()
        {
            // Arrange: Create an instance of MathAreaTrapezoid with specific parameters
            MathAreaTrapezoid mathAreaTrapezoid = new MathAreaTrapezoid(0, 0, 0, 0);

            // Act: Call the GetFormulaTerm3 method and assert the result
            Assert.AreEqual("a = (2 * A) / (b + h)", mathAreaTrapezoid.GetFormulaTerm4());
        }
    }

    }