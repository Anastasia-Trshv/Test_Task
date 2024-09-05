using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Task.Model;
using Xunit;

namespace UnitTests.Tests
{
    public class CircleTests
    {
        [Fact]
        public void FindCircleArea()
        {
            //Arrange
            Circle shape = new Circle(10);
            //Act
            var s = shape.CalculateArea();
            //Assert
            Assert.Matches(s.ToString(), (100 * Math.PI).ToString());
        }
    }
}
