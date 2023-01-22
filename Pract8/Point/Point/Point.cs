using System;

namespace MyClassLine
{
    class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point() { }

        public void Show()
        {
            Console.WriteLine($"Точка с координатами: ({x}, {y})");
        }

        public double Dlina(Point p1, Point p2)
        {
            double D1 = Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
            return D1;
        }

        public override string ToString()
        {
            string ss = x + " ; " + y;
            return ss;
        }
    }
}

