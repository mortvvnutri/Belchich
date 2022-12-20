using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace DopZ_PZ_10
{
    abstract class Person
    {
        protected string firstname;
        protected DateOnly birthday;

        public Person(string firstname, DateOnly birthday)
        {
            this.firstname = firstname;
            this.birthday = birthday;
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public DateOnly Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public void Print()
        {
            WriteLine("Доступная информация:");
            WriteLine($"Фамилия = {firstname}");
            WriteLine($"Дата рождения = {birthday}");
        }

        public void AgeInText()
        {
            DateOnly nowday = new(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            int daysAge = nowday.DayNumber - birthday.DayNumber;
            
            WriteLine($"Возраст человека по фамилии {firstname}: {daysAge / 365}");
        }

        public int Age()
        {
            DateOnly nowday = new(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            int daysAge = nowday.DayNumber - birthday.DayNumber;

            return daysAge / 365;
        }
    }
}
