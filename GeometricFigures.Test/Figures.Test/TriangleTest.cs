using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricFigures.Figures;

namespace GeometricFigures.Test.Figures.Test
{
    [TestClass]
    public class TriangleTest
    {
        private double sideA { get; set; }
        private double sideB { get; set; }
        private double sideC { get; set; }
        private Triangle triangle { get; set; }

        [TestMethod]
        public void CreateInstanceWithNegativeSizeA_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new Triangle(-4, 5, 6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithZeroSizeA_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new Triangle(0, 5, 6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithNegativeSizeB_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new Triangle(4, -5, 6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithZeroSizeB_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new Triangle(4, 0, 6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithNegativeSizeC_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new Triangle(4, 5, -6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithZeroSizeC_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new Triangle(4, 5, 0);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void GetArea_RightAngledTriangle_AreEqual()
        {
            //Arrange
            sideA = 10;
            sideB = 26;
            sideC = 24;
            triangle = new Triangle(sideA, sideB, sideC);
            double arrangeArea = (10 * 24) / 2;
            //Act
            double resultArea = triangle.GetArea();
            // Assert
            Assert.AreEqual(arrangeArea, resultArea);
        }

        [TestMethod]
        public void GetArea_OtherTriangle_AreEqual()
        {
            //Arrange
            sideA = 5.3;
            sideB = 6.4;
            sideC = 7.6;
            triangle = new Triangle(sideA, sideB, sideC);
            double arrangePerimeter = (sideA + sideB + sideC) / 2;
            double arrangeArea = Math.Sqrt(arrangePerimeter * (arrangePerimeter - sideA) * (arrangePerimeter - sideB) * (arrangePerimeter - sideC));
            //Act
            double resultArea = triangle.GetArea();
            // Assert
            Assert.AreEqual(arrangeArea, resultArea);
        }

        [TestMethod]
        public void GetPerimeter_AreEqual()
        {
            //Arrange
            sideA = 5.3;
            sideB = 6.4;
            sideC = 7.6;
            triangle = new Triangle(sideA, sideB, sideC);
            double arrangePerimeter = (sideA + sideB + sideC) / 2;
            //Act
            double resultPerimeter = triangle.GetPerimeter();
            // Assert
            Assert.AreEqual(arrangePerimeter, resultPerimeter);
        }
    }
}
