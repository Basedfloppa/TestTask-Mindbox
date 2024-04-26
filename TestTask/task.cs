using System;

namespace GeometryLibrary
{
    public class GeometryCalculator
    {
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculateTriangleArea(double side1, double side2, double side3)
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);
            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }
    }

    public class Shape
    {
        public enum ShapeType { Circle, Triangle }

        public ShapeType Type { get; private set; }
        public double[] Parameters { get; private set; }

        public Shape(ShapeType type, params double[] parameters)
        {
            Type = type;
            Parameters = parameters;
        }

        public double CalculateArea()
        {
            switch (Type)
            {
                case ShapeType.Circle:
                    return GeometryCalculator.CalculateCircleArea(Parameters[0]);
                case ShapeType.Triangle:
                    return GeometryCalculator.CalculateTriangleArea(Parameters[0], Parameters[1], Parameters[2]);
                default:
                    throw new InvalidOperationException("Unknown shape type");
            }
        }

        public bool IsRightTriangle()
        {
            if (Type != ShapeType.Triangle || Parameters.Length != 3)
                throw new InvalidOperationException("Not a triangle");

            return GeometryCalculator.IsRightTriangle(Parameters[0], Parameters[1], Parameters[2]);
        }
    }
}