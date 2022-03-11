using System;

namespace GeometricFigures.Figures
{
    /// <summary>
    /// A class that describes a geometric figure - a triangle
    /// </summary>
    public class Triangle: IFigure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public double SideA
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException($"{nameof(SideA)} cannot be negative number", nameof(SideA));
                }
                else if (value == 0)
                {
                    throw new ArgumentNullException($"{nameof(SideA)} cannot be zero", nameof(SideA));
                }
                sideA = value;
            }
        }

        public double SideB
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException($"{nameof(SideB)} cannot be negative number", nameof(SideB));
                }
                else if (value == 0)
                {
                    throw new ArgumentNullException($"{nameof(SideB)} cannot be zero", nameof(SideB));
                }
                sideB = value;
            }
        }

        public double SideC
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException($"{nameof(SideC)} cannot be negative number", nameof(SideC));
                }
                else if (value == 0)
                {
                    throw new ArgumentNullException($"{nameof(SideC)} cannot be zero", nameof(SideC));
                }
                sideC = value;
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        /// <summary>
        /// Method for calculating the area of a triangle given three sides
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double p = GetPerimeter();
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        /// <summary>
        /// Method for calculating the perimeter of a triangle
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            return (sideA + sideB + sideC) / 2;
        }
    }
}
