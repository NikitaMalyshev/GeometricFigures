using System;

namespace GeometricFigures.Figures
{
    /// <summary>
    /// A class that describes a geometric figure - a circle
    /// </summary>
    public class Circle: IFigure
    {
        private double radius;

        public double Radius
        {
            set
            {
                if (value < 0 || value == 0)
                {
                    throw new ArgumentException($"{nameof(Radius)} value cannot be negative or zero number", nameof(Radius));
                }
                radius = value;
            }
        }

        public Circle(double radius)
        {
            this.Radius = radius;
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
