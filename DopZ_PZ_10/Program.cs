using System;
using System.Text;
using static System.Console;

namespace DopZ_PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range1 = 20,
                range2 = 20;

            Administator person1 = new Administator("Иванов", new DateOnly(1998, 12, 25), "Лаборатория №1");
            Administator person2 = new Administator("Иванов", new DateOnly(1996, 04, 02), "Лаборатория №2");
            Student person3 = new Student("Петров", new DateOnly(1996, 06, 13), "ФИТУ", 2);
            Teacher person4 = new Teacher("Косарева", new DateOnly(2004, 09, 29), "ФИТУ", "Декан", 6);
            Manager person5 = new Manager("Сидоров", new DateOnly(1998, 09, 24), "ФИТУ", "Главный менеджер");

            person1.Print();
            WriteLine("---------------------");
            person2.Print();
            WriteLine("---------------------");
            person3.Print();
            WriteLine("---------------------");
            person4.Print();
            WriteLine("---------------------");
            person5.Print();
            WriteLine("---------------------");
            person1.AgeInText();
            WriteLine("---------------------");



            Person[] persons = { person1, person2, person3, person4, person5 };

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Print();
                WriteLine("---------------------");
            }

            Write("Введите диапазон возраста для поиска: \n(от:) "); 
            range1 = Convert.ToInt32(ReadLine());
            Write("(до:) ");
            range2 = Convert.ToInt32(ReadLine());
            WriteLine("---------------------");

            for (int i = 0; i < persons.Length; i++)
            {
                if (range1 <= persons[i].Age()  && persons[i].Age() <= range2) {
                    persons[i].AgeInText();
                    WriteLine("---------------------");
                }
                
            }




        }
    }
}