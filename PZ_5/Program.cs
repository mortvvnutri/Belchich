namespace PZ_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Book emp1 = new Book();

            emp1.id = 1;
            emp1.author = "Кристина Старк";
            emp1.name = "Стигмарион";
            emp1.year = 2018;
            emp1.made = "АСТ";
            emp1.str = 420;
            emp1.DisplayStatus();


            Book emp2 = new Book(2, "Дж. К. Роулинг", "Гарри Поттер и Дары смерти", 2007, "Росмэн", 605);
            emp2.DisplayStatus();

            Book emp3 = new Book(3, "Дж. К. Роулинг", "Гарри Поттер и Дары смерти 2", 2009, "Росмэн");
            emp3.DisplayStatus();

        }
    }
}