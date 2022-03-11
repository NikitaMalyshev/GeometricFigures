using System;
using GeometricFigures.Enums;
using GeometricFigures.Models;

namespace GeometricFigures.Figures
{
    /// <summary>
    /// A class that describes a geometric figure - a triangle
    /// </summary>
    public class Triangle: IFigure
    {
        private TriangleSide sideA { get; set; }
        private TriangleSide sideB { get; set; }
        private TriangleSide sideC { get; set; }

        public Triangle(double lenghtSideA, double lenghtSideB, double lenghtSideC)
        {
            sideA = new TriangleSide { Length = ValidateSideLength(lenghtSideA, nameof(sideA.Length)) };
            sideB = new TriangleSide { Length = ValidateSideLength(lenghtSideB, nameof(sideB.Length)) };
            sideC = new TriangleSide { Length = ValidateSideLength(lenghtSideC, nameof(sideC.Length)) };
            DetermineTriangleSideTypes();
        }

        /// <summary>
        /// Method for checking a given length of a side of a triangle
        /// </summary>
        /// <param name="sideLength"></param>
        /// <param name="sideName"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        private double ValidateSideLength(double sideLength, string sideName)
        {
            if (sideLength < 0 || sideLength == 0)
            {
                throw new ArgumentNullException($"{sideName} value cannot be negative or zero number", sideName);
            }
            return sideLength;
        }

        /// <summary>
        /// Triangle Side Type Method
        /// </summary>
        private void DetermineTriangleSideTypes()
        {
            if(Math.Pow(sideA.Length, 2) == Math.Pow(sideB.Length, 2) + Math.Pow(sideC.Length, 2))
            {
                sideA.Type = TriangleSideType.Hypotenuse;
                sideB.Type = TriangleSideType.Leg;
                sideC.Type = TriangleSideType.Leg;
            }
            else if(Math.Pow(sideB.Length, 2) == Math.Pow(sideA.Length, 2) + Math.Pow(sideC.Length, 2))
            {
                sideA.Type = TriangleSideType.Leg;
                sideB.Type = TriangleSideType.Hypotenuse;
                sideC.Type = TriangleSideType.Leg;
            }
            else if(Math.Pow(sideC.Length, 2) == Math.Pow(sideA.Length, 2) + Math.Pow(sideB.Length, 2))
            {
                sideA.Type = TriangleSideType.Leg;
                sideB.Type = TriangleSideType.Leg;
                sideC.Type = TriangleSideType.Hypotenuse;
            }
            else
            {
                sideA.Type = TriangleSideType.Other;
                sideB.Type = TriangleSideType.Other;
                sideC.Type = TriangleSideType.Other;
            }
        }

        /// <summary>
        /// Method for calculating the area of a triangle given three sides
        /// If at least one side is the hypotenuse then use the Pythagorean theorem
        /// Otherwise use the Heron formula
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            if (sideA.Type == TriangleSideType.Hypotenuse)
            {
                return GetAreaUsingPythagoreanTheorem(sideB.Length, sideC.Length);
            }
            else if (sideB.Type == TriangleSideType.Hypotenuse)
            {
                return GetAreaUsingPythagoreanTheorem(sideA.Length, sideC.Length);
            }
            else if (sideC.Type == TriangleSideType.Hypotenuse)
            {
                return GetAreaUsingPythagoreanTheorem(sideA.Length, sideB.Length);
            }
            return GetAreaUsingHeronsFormula();
        }

        /// <summary>
        /// Calculating the area using the Pythagorean theorem
        /// </summary>
        /// <returns></returns>
        private double GetAreaUsingPythagoreanTheorem(double legA, double legB)
        {
            return (legA * legB) / 2;
        }

        /// <summary>
        /// Calculating the area using Heron's formula
        /// </summary>
        /// <returns></returns>
        private double GetAreaUsingHeronsFormula()
        {
            double perimeter = GetPerimeter();
            return Math.Sqrt(perimeter * (perimeter - sideA.Length) * (perimeter - sideB.Length) * (perimeter - sideC.Length));
        }

        /// <summary>
        /// Method for calculating the perimeter of a triangle
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            return (sideA.Length + sideB.Length + sideC.Length) / 2;
        }
    }
}
