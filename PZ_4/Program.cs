using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PZ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = 1, c = 1;
            string name = "Triangle";
            try
            {
                Write("Введите длину строны а: ");
                a = double.Parse(ReadLine());
                Write("Введите длину строны b: ");
                b = double.Parse(ReadLine());
                Write("Введите длину строны c: ");
                c = double.Parse(ReadLine());
            }
            catch
            {
                WriteLine("Стороны или имя были введены не верно и были заменены на стандартные параметры!");
            }

            Triangle obj1 = new Triangle(a, b, c, name);
            Triangle obj2 = new Triangle();
            obj2.A = 1;
            obj2.B = 2;
            obj2.C = 8;

            obj1.Print();
            obj1.Perimeter();
            obj1.Square();

            WriteLine();

            WriteLine("Получить-установить длины сторон треугольника (доступное для чтения и записи):");

            obj2.Print();
            obj2.Perimeter();
            obj2.Square();

            WriteLine("Позволяющее установить, существует ли треугольник с данными длинами сторон (доступное только для чтения):");
            WriteLine(obj2.isValid);
            WriteLine();

            WriteLine("Имя объекта (доступное для чтения): ");
            WriteLine(obj2.GetName());
            WriteLine();

            
            Write("Введите длину строны а: ");
            a = Int32.Parse(ReadLine());
            Write("Введите длину строны b: ");
            b = Int32.Parse(ReadLine());

            Rectangle obj = new Rectangle(a, b);
            WriteLine("Вывести длины сторон прямоугольника на экран:");
            obj.Print();
            WriteLine();

            Write("Периметр прямоугольника: ");
            WriteLine(obj.Perimeter());
            WriteLine();

            Write("Площадь прямоугольника: ");
            WriteLine(obj.Square());
            WriteLine();

            WriteLine("Получить-установить длины сторон прямоугольника (доступное для чтения и записи):");
            obj.A = a;
            obj.B = b;
            obj.Print();
            WriteLine();

            WriteLine("Позволяющее установить," +
            "является ли данный прямоугольник квадратом (доступное только для чтения):");
            WriteLine(obj.isValid);
            WriteLine();

            Write("Имя объекта (доступное для чтения): ");
            WriteLine(obj.GetName());
            WriteLine();

            int first, second;

            Console.Write("Введите номинал купюры: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Введите количество купюр: ");
            second = int.Parse(Console.ReadLine());
            Money obj3 = new Money(first, second);

            Console.WriteLine("\nВывести номинал и количество купюр: ");
            obj3.Show();

            Console.WriteLine("\nВведите сумму на которую небоходимо купить товара: ");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine(obj3.IsEnough(sum));

            Console.WriteLine("\nВведите цену товара, который необходимо купить:");
            int product_price = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы можете купить {0} шт.\n", obj3.Product_Amount(product_price));

            Console.WriteLine("Операция ++: одновременно увеличивает значение полей first и second:");
            obj3++;
            obj3.Show();
            Console.WriteLine();

            Console.WriteLine("Операция --: одновременно уменьшает значение полей first и second:");
            obj3--;
            obj3.Show();
            Console.WriteLine();

            Console.WriteLine("Операции бинарный +:  добавляет к значению поля second значение скаляра(5 + Money obj):");
            obj3.Second = 5 + obj3.Second;
            obj3.Show();
            Console.WriteLine();

            Console.WriteLine("Операции бинарный +:  добавляет к значению поля second значение скаляра(Money obj + 7):");
            obj3.Second = obj3.Second + 7;
            obj3.Show();
            Console.WriteLine();

            Console.WriteLine("Операция !: возвращает значение true, если поле second не нулевое, иначе false:S");
            if (!obj3)
                Console.WriteLine("second != 0\ntrue\n");
            else
                Console.WriteLine("second == 0\nfalse\n");

            Console.WriteLine("Преобразования типа Money в string:");
            string str = (string)obj3;
            Console.WriteLine(str + "\n");

            Console.WriteLine("Преобразования типа string в Money:");
            Money obj_new = (Money)str;
            obj_new.Show();

            Console.ReadLine();
        }
    }
}