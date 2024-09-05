using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Test_Task.Model;

namespace UnitTests.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void FindTriangleArea()
        {
            //Arrange
            Triangle shape = new Triangle(4, 5, 3);
            //Act
            var s = shape.CalculateArea();
            var p = (shape.side1 + shape.side2 + shape.side3) / 2;
            //Assert
            Assert.Matches(s.ToString(), Math.Sqrt(p * (p - 4) * (p - 5) * (p - 3)).ToString());
        }
    }
}
