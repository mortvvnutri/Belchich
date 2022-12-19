using System;
namespace ConsoleApplication1
{
    // Создадим структуру
    struct Company
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string Oklad;
        public Company(string Name, string Surname, byte Age, string Oklad) //конструктор с параметрами для инициализации полей
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            this.Oklad = Oklad;
        }

        public void WriteCompany()
        {
            Console.WriteLine("Имя: {0}, Фамилия: {1}, возраст: {2}, оклад: {3}", Name, Surname, Age, Oklad);
        }
    }

    class Program
    {
        public static void ShowZP(int days)
        {

            double st = 1000;

            double result = Convert.ToDouble(days) * st;
            Console.WriteLine("{0} у.е.", result);

        }

        static void Main()
        {

            Company employee1 = new Company("Alexandr", "Egorov", 26, "35000");
            Console.Write("employee1: ");
            employee1.WriteCompany();
            Company employee2 = new Company("Elena", "Orlova", 22, "35000");
            Console.Write("employee2: ");
            employee2.WriteCompany();
            Company employee3 = new Company("Oleg", "Ivanov", 28, "40000");
            Console.Write("employee3: ");
            employee3.WriteCompany();

            Console.Write("Введите количество часов, отработанных сотрудником: ");
            string s = Console.ReadLine();
            ShowZP(Convert.ToInt32(s));



            Console.ReadLine();
        }
    }
}
