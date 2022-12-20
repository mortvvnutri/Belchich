using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopZ_PZ_10
{
    internal class Teacher : Person
    {
        protected string faculty;
        protected string post;
        protected int experience;

        public Teacher(string firstname, DateOnly birthday, string faculty, string post, int experience) : base(firstname, birthday)
        {
            base.firstname = firstname;
            base.birthday = birthday;
            this.faculty = faculty;
            this.post = post;
            this.experience = experience;
        }

        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public string Post
        {
            get { return post; }
            set { post = value; }
        }

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        public new void Print()
        {
            base.Print();
            WriteLine($"Факультет = {faculty}");
            WriteLine($"Должность = {post}");
            WriteLine($"Стаж = {experience}");
        }
    }
}
