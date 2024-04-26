using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

namespace GeometryLibraryTests
{
    [TestClass]
    public class GeometryCalculatorTests
    {
        [TestMethod]
        public void TestCalculateCircleArea()
        {
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;
            double actualArea = GeometryCalculator.CalculateCircleArea(radius);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void TestCalculateTriangleArea()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedArea = 6;
            double actualArea = GeometryCalculator.CalculateTriangleArea(side1, side2, side3);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void TestIsRightTriangle()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            bool expectedIsRightTriangle = true;
            bool actualIsRightTriangle = GeometryCalculator.IsRightTriangle(side1, side2, side3);
            Assert.AreEqual(expectedIsRightTriangle, actualIsRightTriangle);
        }
    }

    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void TestCalculateCircleAreaWithShapeClass()
        {
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;
            Shape circle = new Shape(Shape.ShapeType.Circle, radius);
            double actualArea = circle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void TestCalculateTriangleAreaWithShapeClass()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedArea = 6;
            Shape triangle = new Shape(Shape.ShapeType.Triangle, side1, side2, side3);
            double actualArea = triangle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void TestIsRightTriangleWithShapeClass()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            bool expectedIsRightTriangle = true;
            Shape triangle = new Shape(Shape.ShapeType.Triangle, side1, side2, side3);
            bool actualIsRightTriangle = triangle.IsRightTriangle();
            Assert.AreEqual(expectedIsRightTriangle, actualIsRightTriangle);
        }
    }
}