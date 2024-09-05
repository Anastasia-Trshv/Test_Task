using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Task.Abstract;
using Test_Task.Model;

namespace Test_Task.Factory
{
    public class Creator //класс-фабрика, нужен для создания экземпляров фигур, когда заранее не известно какого типа будет фигура
    {
        public static IShape FactoryMethod(string type, params double[] args)
        {
            switch (type)
            {
                case "Circle":
                    return new
                        Circle(args[0]);
                case "Triangle":
                    return new Triangle(args[0], args[1], args[2]);
                default:
                    throw new ArgumentException("Invalid figure type");
            };

        }
    }
}
