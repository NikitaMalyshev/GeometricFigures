using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricFigures.Figures.Triangles;

namespace GeometricFigures.Test.Figures.Test.Triangles.Test
{
    [TestClass]
    public class ArbitraryTriangleTest
    {
        private ArbitraryTriangle triangle { get; set; }

        [TestMethod]
        public void CreateInstanceWithNegativeFirstSideLength_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new ArbitraryTriangle(-4, 5, 6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithZeroFirstSizeLength_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new ArbitraryTriangle(0, 5, 6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithNegativeSecondSideLength_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new ArbitraryTriangle(4, -5, 6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithZeroSecondSizeLength_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new ArbitraryTriangle(4, 0, 6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithNegativeThirdSideLength_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new ArbitraryTriangle(4, 5, -6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithZeroThirdSizeLength_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new ArbitraryTriangle(4, 5, -6);
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
            double firstSideLength = 5.3;
            double secondSideLength = 6.4;
            double thirdSideLength = 7.6;
            triangle = new ArbitraryTriangle(firstSideLength, secondSideLength, thirdSideLength);
            double arrangePerimeter = (firstSideLength + secondSideLength + thirdSideLength) / 2;
            double arrangeArea = Math.Sqrt(arrangePerimeter * (arrangePerimeter - firstSideLength) * (arrangePerimeter - secondSideLength) * (arrangePerimeter - thirdSideLength));
            //Act
            double resultArea = triangle.GetArea();
            // Assert
            Assert.AreEqual(arrangeArea, resultArea);
        }

        [TestMethod]
        public void GetPerimeter_AreEqual()
        {
            //Arrange
            double firstSideLength = 5.3;
            double secondSideLength = 6.4;
            double thirdSideLength = 7.6;
            triangle = new ArbitraryTriangle(firstSideLength, secondSideLength, thirdSideLength);
            double arrangePerimeter = (firstSideLength + secondSideLength + thirdSideLength);
            //Act
            double resultPerimeter = triangle.GetPerimeter();
            // Assert
            Assert.AreEqual(arrangePerimeter, resultPerimeter);
        }
    }
}
