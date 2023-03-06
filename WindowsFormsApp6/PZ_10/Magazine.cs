using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_10
{
    class Magazine : Item
    {
        private string volume;
        private int number;
        private string title;
        private int year;

        public Magazine(string volume, int number, string title, int year, long invNomber, bool taken) : base(invNomber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        public Magazine() { }

        public override void Return()
        {
            taken = true;
        }
        public override void Show()
        {
            Console.WriteLine("\nЖурнал:\nТом: {0}\nНомер: {1}\nНазвание: {2}\nГод выпуска: {3}", volume, number, title, year);
            base.Show();
        }

    }
}

