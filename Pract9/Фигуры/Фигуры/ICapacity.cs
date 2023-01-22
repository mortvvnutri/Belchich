using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигуры
{
    public interface ICapacity
    {
        double CapacityCounter();
    }
    class Shape
    {
        public virtual void ShowArea() { }
        public virtual void ShowPerimeter() { }
    }
}

