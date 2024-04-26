using System;
using GeometryLibrary;

class Program
{
    static void Main(string[] args)
    {
        double circleArea = GeometryCalculator.CalculateCircleArea(5);
        Console.WriteLine("Circle Area: " + circleArea);

        double triangleArea = GeometryCalculator.CalculateTriangleArea(3, 4, 5);
        Console.WriteLine("Triangle Area: " + triangleArea);

        bool isRightTriangle = GeometryCalculator.IsRightTriangle(3, 4, 5);
        Console.WriteLine("Is Right Triangle: " + isRightTriangle);

        Shape circle = new Shape(Shape.ShapeType.Circle, 5);
        double circleArea2 = circle.CalculateArea();
        Console.WriteLine("Circle Area (using Shape class): " + circleArea2);

        Shape triangle = new Shape(Shape.ShapeType.Triangle, 3, 4, 5);
        double triangleArea2 = triangle.CalculateArea();
        Console.WriteLine("Triangle Area (using Shape class): " + triangleArea2);

        Shape triangle2 = new Shape(Shape.ShapeType.Triangle, 3, 4, 5);
        bool isRightTriangle2 = triangle2.IsRightTriangle();
        Console.WriteLine("Is Right Triangle (using Shape class): " + isRightTriangle2);
    }
}