using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Task.Abstract
{
    public interface IShape //чтобы добавить новую фигуру, достаточно создать класс, реализующий этот интерфейс
    {
        public double CalculateArea();
    }
}

