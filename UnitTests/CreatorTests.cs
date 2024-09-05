using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Task.Factory;
using Test_Task.Model;
using Xunit;

namespace UnitTests.Tests
{
    public class CreatorTests
    {
        [Fact]
        public void CreateTriangleUsingFactory()
        {
            //Arrange
            
            //Act
            string type = "Circle";
            double[] args = { 10 };
            var shape = Creator.FactoryMethod(type, args[0]);
            //Assert
            Assert.Matches(shape.GetType().ToString(), "Test_Task.Model.Circle");
        }
        [Fact]
        public void CreateCircleUsingFactory()
        {
            //Arrange
           
            //Act
            string type = "Triangle";
            double[] args = { 5, 4, 3 };
            var shape = Creator.FactoryMethod(type, args[0], args[1], args[2]);
            //Assert
            Assert.Matches(shape.GetType().ToString(), "Test_Task.Model.Triangle");
        }
    }
}
