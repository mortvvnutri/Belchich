using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[,] a = new double[3, 4];

            Random r = new Random();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    a[i, j] = r.Next(0, 15);
                }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(String.Format("{0:f}  ", a[i, j]));
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 4; j++)
                {

                    if (a[i, j] % 2 == 0)
                    {
                        a[i, j] *= 2;
                    }
                    else
                    {
                        a[i, j] = 0;
                    }
                }
            }
            Console.WriteLine("Полученная матрица:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(String.Format("{0:f}  ", a[i, j]));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}

