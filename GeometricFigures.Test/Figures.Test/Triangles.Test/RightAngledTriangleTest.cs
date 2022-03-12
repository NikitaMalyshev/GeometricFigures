using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricFigures.Figures.Triangles;
using GeometricFigures.Exceptions;

namespace GeometricFigures.Test.Figures.Test.Triangles.Test
{
    [TestClass]
    public class RightAngledTriangleTest
    {
        private RightAngledTriangle triangle { get; set; }

        [TestMethod]
        public void CreateInstanceWithNegativeFirstLegLength_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new RightAngledTriangle(-4, 5, 6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithZeroFirstLegLength_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new RightAngledTriangle(0, 5, 6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithNegativeSecondLegLength_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new RightAngledTriangle(4, -5, 6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithZeroSecondLegLength_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new RightAngledTriangle(4, 0, 6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithNegativehypotenuseLength_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new RightAngledTriangle(4, 5, -6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CreateInstanceWithZerohypotenuseLength_ReturnsArgumentException()
        {
            //Act and Assert
            try
            {
                triangle = new RightAngledTriangle(4, 5, -6);
                Assert.Fail("There was no ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TryCreateInstanceNoRightAngledTriangle_ReturnsCreateRightAndledTriangleException()
        {
            //Act and Assert
            try
            {
                triangle = new RightAngledTriangle(4, 5, 6);
                Assert.Fail("There was no CreateRightAndledTriangleException");
            }
            catch (CreateRightAndledTriangleException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TryCreateInstanceRightAngledTriangle_ReturnsCreateRightAndledTriangleException()
        {
            //Act and Assert
            try
            {
                triangle = new RightAngledTriangle(10, 24, 26);
                Assert.IsTrue(true);
            }
            catch (CreateRightAndledTriangleException)
            {
                Assert.Fail("There was CreateRightAndledTriangleException");
            }
        }

        [TestMethod]
        public void GetArea_AreEqual()
        {
            //Arrange
            double firstLegLength = 10;
            double secondLegLength = 24;
            double hypotenuseLength = 26;
            triangle = new RightAngledTriangle(firstLegLength, secondLegLength, hypotenuseLength);
            double arrangeArea = (firstLegLength * secondLegLength) / 2;
            //Act
            double resultArea = triangle.GetArea();
            // Assert
            Assert.AreEqual(arrangeArea, resultArea);
        }

        [TestMethod]
        public void GetPerimeter_AreEqual()
        {
            //Arrange
            double firstLegLength = 10;
            double secondLegLength = 24;
            double hypotenuseLength = 26;
            triangle = new RightAngledTriangle(firstLegLength, secondLegLength, hypotenuseLength);
            double arrangePerimeter = (firstLegLength + secondLegLength + hypotenuseLength);
            //Act
            double resultPerimeter = triangle.GetPerimeter();
            // Assert
            Assert.AreEqual(arrangePerimeter, resultPerimeter);
        }
    }
}
