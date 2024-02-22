using System;
using System.Linq;

namespace Mindbox
{
    public class SquareCalculator
    {
        /// <summary>
        /// Returns sqaure of circle
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public virtual double GetSquare(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Returns square of triangle
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        public virtual double GetSquare(double side1, double side2, double side3)
        {
            var sp = (side1 + side2 + side3) / 2;
            var result=  Math.Sqrt(sp * (sp - side1) * (sp - side2) * (sp - side3));
            return Math.Round(result, 2);
        }

        public virtual bool IsRectangular(double side1, double side2, double side3)
        {
            double[] sides = new double[] { side1, side2, side3 };
            double longestSide = sides.Max();
            return Math.Pow(longestSide, 2) == (Math.Pow(side2, 2) + Math.Pow(side3, 2));
        }
    }
}