
    class Triangle
    {
        double a, b, c;
        private string name = "Triangle";

        public Triangle() { }
        public Triangle(string n) { name = n; }
        public Triangle(double aa, double bb, double cc)
        {
            a = aa;
            b = bb;
            c = cc;
        }
        public void Print()
        {
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

        }
        public double Perimeter() { return a + b + c; }
        public double Square()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
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
        class Program
        {
            static void Main(string[] args)
            {
                int a, b, c;

                Console.Write("Введите длину строны а: ");
                a = Int32.Parse(Console.ReadLine());
                Console.Write("Введите длину строны b: ");
                b = Int32.Parse(Console.ReadLine());
                Console.Write("Введите длину строны c: ");
                c = Int32.Parse(Console.ReadLine());

                Triangle obj = new Triangle(a, b, c);
                Console.WriteLine("Вывести длины сторон треугольника на экран:");
                obj.Print();
                Console.WriteLine();

                Console.Write("Периметр треугольника: ");
                Console.WriteLine(obj.Perimeter());
                Console.WriteLine();

                Console.Write("Площадь треугольника: ");
                Console.WriteLine(obj.Square());
                Console.WriteLine();

                Console.WriteLine("Получить-установить длины сторон треугольника (доступное для чтения и записи):");
                obj.A = a;
                obj.B = b;
                obj.C = c;
                obj.Print();
                Console.WriteLine();

                Console.WriteLine("Позволяющее установить," +
                "существует ли треугольник с данными длинами сторон (доступное только для чтения):");
                Console.WriteLine(obj.isValid);
                Console.WriteLine();

                Console.Write("Имя объекта (доступное для чтения): ");
                Console.WriteLine(typeof(Triangle));
                Console.WriteLine();


            }
        }
    }
