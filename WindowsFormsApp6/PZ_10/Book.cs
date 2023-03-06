using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_10
{
    class Book : Item
    {
        private string author;
        private string title;
        private string publisher;
        private int pages;
        private int year;

        private bool returnSrok = false;
        private static double price = 9;

        public Book() { }
        public Book(string author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        static Book()
        {
            price = 10;
        }

        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
        }
        public Book(string author, string title, string publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        public void SetBook(string author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public override void Show()
        {
            Console.WriteLine("\nКнигa: \nАвтор: {0}\nНазвание: {1}\nГод издания: {2}\n{3} стр.\nСтоимость аренды: {4}\n", author, title,
          year, pages, Book.price);
            base.Show();
        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }


        public override void Return()
        {
            if (ReturnSrok == true)
                taken = true;
            else
                taken = false;
        }

        public delegate void ProcessBookDelegate(Book book);
        public static event ProcessBookDelegate RetSrok;

        public bool ReturnSrok
        {
            get { return returnSrok; }
            set
            {
                returnSrok = value;
                if (returnSrok == true)
                    RetSrok?.Invoke(this);
            }
        }

        public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
        {
            if (ReturnSrok)
                processBook(this);
        }

        public override string ToString()
        {
            string str = this.title + ", " + this.author + "Инв. номер" + this.invNumber;
            return str;
        }
    }

}
