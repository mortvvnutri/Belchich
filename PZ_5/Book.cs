using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_5
{
    internal class Book
    {
        public int id;
        public string author;
        public string name;
        public int year;
        public string made;
        public int str;

        // Конструктор

        public Book()
        { }

        public Book(int id, string author, string name, int year, string made, int str)
        {
            this.id = id;
            this.author = author;
            this.name = name;
            this.year = year;
            this.made = made;
            this.str = str;
        }

        public Book(int id, string author, string name, int year, string made)
        {
            this.id = id;
            this.author = author;
            this.name = name;
            this.year = year;
            this.made = made;
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
