using MindLib;
using Xunit;

namespace MindLibTests
{

    public class UnitTest1
    {
        [Fact]
        public void CircleTest1()
        {
            double right = 314.159;
            Circle c = new Circle("Test",10);
            Assert.Equal(right, c.GetSquare());
        }
        [Fact]
        public void TriangleTest1()
        {
            double right = 6;
            Triangle t = new Triangle("Test", 3, 4, 5);
            Assert.Equal(right, t.GetSquare());
        }
        [Fact]
        public void TriangleTest2()
        {
            bool right = true;
            Triangle t = new Triangle("Test", 3, 4, 5);
            Assert.Equal(right, t.IsRectangular());
        }
    }
}