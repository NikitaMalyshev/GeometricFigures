using System;
using GeometricFigures.Resources;

namespace GeometricFigures.Figures.Сircles
{
    /// <summary>
    /// A class that describes a geometric figure - a circle
    /// </summary>
    public class Circle: IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException(ErrorRes.CircleRadiusLenthError);
            }
            this.radius = radius;
        }

        /// <summary>
        /// Method for calculating the area of a circle using a radius
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Method for calculating the perimeter of a circle using a radius
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
