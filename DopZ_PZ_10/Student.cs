using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopZ_PZ_10
{
    internal class Student : Person
    {
        protected string faculty;
        protected int course;

        public Student(string firstname, DateOnly birthday, string faculty, int course) : base(firstname, birthday)
        {
            base.firstname = firstname;
            base.birthday = birthday;
            this.faculty = faculty;
            this.course = course;
        }

        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public new void Print()
        {
            base.Print();
            WriteLine($"Факультет = {faculty}");
            WriteLine($"Курс = {course}");
        }
    }
}
