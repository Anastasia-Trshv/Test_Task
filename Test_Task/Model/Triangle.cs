using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Task.Abstract;

namespace Test_Task.Model
{
    public class Triangle : IShape
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculateArea()
        {
            double p = (side1 + side2 + side3) / 2;
            double answ = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            return answ;
        }

        public bool IsRightAngled() //проверка на прямоугольный треугольник
        {
            List<double> sides = new List<double>() { side1, side2, side3 };
            sides.Sort();
            if (sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1])
            {
                return true;
            }
            else { return false; }
        }
    }
}
