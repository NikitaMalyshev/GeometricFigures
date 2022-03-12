using GeometricFigures.Resources;
using System;

namespace GeometricFigures.Figures.Triangles
{
    /// <summary>
    /// Сlass defining a equilateral triangle
    /// </summary>
    public class EquilateralTriangle : IFigure
    {
        private double sideLength;

        public EquilateralTriangle(double sideLength)
        {
            if (sideLength <= 0)
            {
                throw new ArgumentException(ErrorRes.TriangleSideLengthError);
            }
            this.sideLength = sideLength;
        }

        /// <summary>
        /// Method for calculating the area of a equilateral triangle
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(sideLength, 2);
        }

        /// <summary>
        /// Method for calculating the perimeter of a equilateral triangle
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            return 3 * sideLength;
        }
    }
}
