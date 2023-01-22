using System;

namespace MyClassLine
{
    class Line
    {
        private Point pStart = new Point();
        private Point pEnd = new Point();

        public Line(Point pStart, Point pEnd)
        {
            this.pStart = pStart;
            this.pEnd = pEnd;
        }
        public Line() { }

        public void Show()
        {
            Console.WriteLine($"Отрезок с координатами: ({pStart}) - ({pEnd})");
        }

        public double DlinL()
        {
            return pStart.Dlina(pEnd, pStart);
        }
    }
}

