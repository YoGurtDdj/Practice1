using Practice1;

namespace Practice1.Tests
{
    [TestClass]
    public  class CircleTests
    {
        private Circle? _areaCalculator;

        [TestMethod]
        public void CalculateCircleArea()
        {
            _areaCalculator = new Circle(10);

            double expectedResult = 314;
            double result = _areaCalculator.CalculateArea();

            Assert.AreEqual(result, expectedResult);
        }
    }

    [TestClass]
    public class TriangleTests
    {
        private Triangle? _areaCalculator;

        [TestMethod]
        public void CalculateTriangleArea()
        {
            _areaCalculator = new Triangle(3, 4, 5);

            double expectedResult = 6;
            double result = _areaCalculator.CalculateArea();

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TrinagleType()
        {
            _areaCalculator = new Triangle(3, 5, 4);

            bool expectedResult = true;
            bool result = _areaCalculator.isRight();

            Assert.AreEqual(result, expectedResult);
        }
    }

    [TestClass]
    public class ShapeTests
    {
        private ShapeAreaCalculator? _areaCalculator;

        [TestMethod]
        public void CalculateCircleArea()
        {
            _areaCalculator = new ShapeAreaCalculator();
            double expectedResult = 314;
            double result = _areaCalculator.Calculate(10);

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void CalculateTriangleArea()
        {
            _areaCalculator = new ShapeAreaCalculator();
            double expectedResult = 6;
            double result = _areaCalculator.Calculate(3, 4, 5);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
