using System;
using GeometricFigures.Resources;

namespace GeometricFigures.Figures.Triangles
{
    /// <summary>
    /// Abstract class defining a arbitrary triangle
    /// </summary>
    public class ArbitraryTriangle : IFigure
    {
        private double firstSideLength;
        private double secondSideLength;
        private double thirdSideLength;

        public ArbitraryTriangle(double lengthSideA, double lengthSideB, double lengthSideC)
        {
            if (lengthSideA <= 0 || lengthSideB <= 0 || lengthSideC <= 0)
            {
                throw new ArgumentException(ErrorRes.TriangleSideLengthError);
            }
            this.firstSideLength = lengthSideA;
            this.secondSideLength = lengthSideB;
            this.thirdSideLength = lengthSideC;
        }

        /// <summary>
        /// Method for calculating the area of a arbitrary triangle
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double semiPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - firstSideLength) * (semiPerimeter - secondSideLength) * (semiPerimeter - thirdSideLength));
        }

        /// <summary>
        /// Method for calculating the perimeter of a arbitrary triangle
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            return firstSideLength + secondSideLength + thirdSideLength;
        }
    }
}
