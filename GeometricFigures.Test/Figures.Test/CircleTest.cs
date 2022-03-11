using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricFigures.Figures;

namespace GeometricFigures.Test.Figures.Test
{
    [TestClass]
    public class CircleTest
    {
        private Circle circle { get; set; }

        [TestInitialize]
        public void CircleTest_TestInitialize()
        {
            circle = new Circle(2);
        }

        [TestCleanup]
        public void CircleTest_TestCleanup()
        {
            circle = null;
        }

        [TestMethod]
        public void CreateInstanceWithNegativeRadius_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                circle = new Circle(-2);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithZeroRadius_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                circle = new Circle(0);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void GetArea_AreEqual()
        {
            //Arrange
            double arrangeArea = Math.PI * Math.Pow(2, 2);
            //Act
            double resultArea = circle.GetArea();
            // Assert
            Assert.AreEqual(arrangeArea, resultArea);
        }

        [TestMethod]
        public void GetPerimeter_AreEqual()
        {
            //Arrange
            double arrangePerimeter = 2 * Math.PI * 2;
            //Act
            double resultPerimeter = circle.GetPerimeter();
            // Assert
            Assert.AreEqual(arrangePerimeter, resultPerimeter);
        }
    }
}
