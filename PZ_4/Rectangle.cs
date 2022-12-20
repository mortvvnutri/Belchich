using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_4
{
    internal class Rectangle
    {
        private double a = 1;
        private double b = 1;
        private string name = "Rectangle";
        
        public Rectangle(double aa, double bb)
        {
            a = aa;
            b = bb;
        }
        public void Print()
        {
            Console.WriteLine("a = {0}, b = {1}", a, b);

        }
        public double Perimeter() { return (a + b) * 2; }
        public double Square()
        {

            return (a * b);
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

        public string Name
        {
            get => name;
        }
        public bool isValid
        {
            get
            {
                return a == b;
            }
        }
        public string GetName()
        {
            return name;
        }
    }
}
