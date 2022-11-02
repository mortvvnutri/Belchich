using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1_1
{
    class Employee
    {

        // Поля
        public int id;
        public string author;
        public string name;
        public int year;
        public string made;
        public int str;

        // Конструктор

        public Employee()
        { }

        public Employee(int id, string author, string name, int year, string made, int str)
        {
            this.id = id;
            this.author = author;
            this.name = name;
            this.year = year;
            this.made = made;
            this.str = str;
        }

        // Методы

        public void DisplayStatus()
        {
            Console.WriteLine("Регистрационный номер:         {0}", id);
            Console.WriteLine("Автор:         {0}", author);
            Console.WriteLine("Название:    {0}", name);
            Console.WriteLine("Год издания:    {0}", year);
            Console.WriteLine("Издательство:    {0}", made);
            Console.WriteLine("Кол-во страниц:    {0}", str);

            string s = Console.ReadLine();
        }

    }
}


namespace ConsoleApp1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();

            emp1.id = 1;
            emp1.author = "Кристина Старк";
            emp1.name = "Стигмарион";
            emp1.year = 2018;
            emp1.made = "АСТ";
            emp1.str = 420;
            emp1.DisplayStatus();


            Employee emp2 = new Employee(2, "Дж. К. Роулинг", "Гарри Поттер и Дары смерти", 2007, "Росмэн", 605);
            emp2.DisplayStatus();

        }
    }
}

