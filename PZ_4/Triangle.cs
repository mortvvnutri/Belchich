using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_4
{
    internal class Triangle
    {
        string name = "Triangle";
        double a, b, c;

        public Triangle() { }
        public Triangle(double aa = 1, double bb = 1, double cc = 1, string nname = "Triangle")
        {
            a = aa;
            b = bb;
            c = cc;
            name = nname;
        }
        public void Print()
        {
            Console.WriteLine("Вывести длины сторон треугольника на экран:");
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
        }
        public void Perimeter()
        {
            double result = a + b + c;

            Console.WriteLine("Периметр треугольника: {0}", result);
        }
        public void Square()
        {
            double p = (a + b + c) / 2;
            double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            if (!double.IsNaN(result))
            {
                Console.WriteLine("Площадь треугольника: {0}", result);
            }
            else
            {
                Console.WriteLine("Площадь треугольника: не существует таких треугольников");
            }
        }
        public string GetName()
        {
            return name;
        }
        public double A
        {
            get => a;
            set { if (value > 0) a = value; }
        }
        public double B
        {
            get => b;
            set { if (value > 0) b = value; }
        }
        public double C
        {
            get => c;
            set { if (value > 0) c = value; }
        }
        public string Name
        {
            get => name;
            set { if (value.Length > 0) name = value; }
        }
        public bool isValid
        {
            get
            {
                if (a + b > c && b + c > a && a + c > b && a > 0 && b > 0 && c > 0)
                    return true;
                return false;
            }
        }
    }
}
