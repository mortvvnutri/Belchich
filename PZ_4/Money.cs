using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_4
{
    internal class Money
    {
        int first;
        int second;


        public Money(int first, int second)
        {
            this.first = first;
            this.second = second;
        }

        public void Show()
        {
            Console.WriteLine("Номинал купюры = {0}, количество купюр = {1}", first, second);
        }
        //определить, хватит ли денежных средств на покупку товара на сумму N рублей
        public string IsEnough(int sum)
        {
            if (first * second > sum)
                return "Хватит";
            return "Не хватит";
        } // определить, сколько шт товара стоимости n рублей можно купить на имеющиеся денежные средства.
        public int Product_Amount(int product_price)
        {
            return (int)((first * second) / product_price);
        }

        // Свойства: позволяющее получить-установить значение полей (доступное для чтения и записи);
        public int First
        {
            set { first = value; }
            get { return first; }
        }

        public int Second
        {
            set { second = value; }
            get { return second; }
        }

        //позволяющее расчитатать сумму денег (доступное только для чтения).
        public int Total { get { return first * second; } }

        // Индексатор, позволяющий по индексу 0 обращаться к полю first, 
        // по индексу 1 – к полю second, при других значениях индекса выдается сообщение об ошибке. 
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return first;
                    case 1:
                        return second;
                    default:
                        throw new Exception("error");
                }
            }
        }

        //операции ++ (--): одновременно увеличивает (уменьшает) значение полей first и second;
        public static Money operator ++(Money obj)
        {
            obj.second++;
            obj.first++;
            return obj;
        }

        public static Money operator --(Money obj)
        {
            obj.second--;
            obj.first--;
            return obj;
        }

        //операции бинарный +:  добавляет к значению поля second значение скаляра;
        public static int operator +(Money obj, int scal)
        {
            return obj.second + scal;
        }

        public static int operator +(int scal, Money obj)
        {
            return obj.second + scal;
        }

        //операции !: возвращает значение true, если поле second не нулевое, иначе false;
        public static bool operator !(Money obj)
        {
            if (obj.second != 0)
                return true;
            return false;
        }

        //преобразования типа Money в string (и наоборот)
        public static explicit operator String(Money obj)
        {
            return obj.first + ", " + obj.second;
        }

        public static explicit operator Money(string str)
        {
            Money obj = new Money(0, 0);
            string[] q = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            obj.first = int.Parse(q[0]);
            obj.second = int.Parse(q[1]);
            return obj;
        }
    }
}
