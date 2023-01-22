using System;

namespace Фигуры
{
    class Circle : Shape
    {
        private double radius;
        public Circle() { }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void ShowArea()
        {
            Console.WriteLine($"Площадь круга: {Math.Round(Math.PI * Math.Pow(radius, 2), 2)}");
        }
        public override void ShowPerimeter()
        {
            Console.WriteLine($"Периметр круга: {Math.Round(2 * Math.PI * radius, 2)}");
        }
        public void ShowParameters()
        {
            Console.WriteLine($"Радиус круга: {radius}");
        }
    }
}
