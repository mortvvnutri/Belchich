using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopZ_PZ_10
{
    internal class Manager : Person
    {
        protected string faculty;
        protected string post;

        public Manager(string firstname, DateOnly birthday, string faculty, string post) : base(firstname, birthday)
        {
            base.firstname = firstname;
            base.birthday = birthday;
            this.faculty = faculty;
            this.post = post;
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

        public new void Print()
        {
            base.Print();
            WriteLine($"Факультет = {faculty}");
            WriteLine($"Должность = {post}");
        }
    }
}
