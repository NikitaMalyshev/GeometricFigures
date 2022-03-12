using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricFigures.Figures.Triangles;

namespace GeometricFigures.Test.Figures.Test.Triangles.Test
{
    [TestClass]
    public class EquilateralTriangleTest
    {
        private EquilateralTriangle triangle { get; set; }

        [TestMethod]
        public void CreateInstanceWithNegativeSideLength_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new EquilateralTriangle(-4);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithZeroSizeLength_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new EquilateralTriangle(0);
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
            double sideLength = 5.3;
            triangle = new EquilateralTriangle(sideLength);
            double arrangeArea = (Math.Sqrt(3) / 4) * Math.Pow(sideLength, 2);
            //Act
            double resultArea = triangle.GetArea();
            // Assert
            Assert.AreEqual(arrangeArea, resultArea);
        }

        [TestMethod]
        public void GetPerimeter_AreEqual()
        {
            //Arrange
            double sideLength = 5.3;
            triangle = new EquilateralTriangle(sideLength);
            double arrangePerimeter = sideLength * 3;
            //Act
            double resultPerimeter = triangle.GetPerimeter();
            // Assert
            Assert.AreEqual(arrangePerimeter, resultPerimeter);
        }
    }
}
