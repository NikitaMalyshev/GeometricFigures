using System;
using GeometricFigures.Exceptions;
using GeometricFigures.Resources;

namespace GeometricFigures.Figures.Triangles
{
    /// <summary>
    /// Сlass defining a right angled triangle
    /// </summary>
    public class RightAngledTriangle : IFigure
    {
        private double firstLegLength;
        private double secondLegLength;
        private double hypotenuseLength;

        public RightAngledTriangle(double firstLeg, double secondLeg, double hypotenuse)
        {
            if (firstLeg <= 0 || secondLeg <= 0 || hypotenuse <= 0)
            {
                throw new ArgumentException(ErrorRes.TriangleSideLengthError);
            }
            if (hypotenuse != (Math.Sqrt(Math.Pow(firstLeg, 2) + Math.Pow(secondLeg, 2))))
            {
                throw new CreateRightAndledTriangleException(ErrorRes.CreateRightAngledTriangleError);
            }
            this.firstLegLength = firstLeg;
            this.secondLegLength = secondLeg;
            this.hypotenuseLength = hypotenuse;
        }

        /// <summary>
        /// Method for calculating the area of a right angled triangle
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return (firstLegLength * secondLegLength) / 2;
        }

        /// <summary>
        /// Method for calculating the perimeter of a right angled triangle
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            return firstLegLength + secondLegLength + hypotenuseLength;
        }
    }
}
