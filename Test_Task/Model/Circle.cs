using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Task.Abstract;

namespace Test_Task.Model
{
    public class Circle : IShape
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            double answ = radius * radius * Math.PI;
            return answ;
        }
    }
}
