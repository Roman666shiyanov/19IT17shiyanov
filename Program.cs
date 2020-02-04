using System;

namespace Shiyanov.laba
{
    class Program
    {
        static void Main(string[] args)
            {
                Random rnd = new Random(); //создание рандома
                int R = -1; //выход
                int fuel = 0; //переменная равная 0 для проверки
                int one; //перебор
                int a = 0;
                int b = 0;

                for (int i = 0; i < 1000; i++)
                {
                    one = rnd.Next(0, 10000); //рандомное число от 0 до 10000
                    if (one > fuel) { fuel = one; } //проверка того что результат будет = max
                    if ((one % 7 == 0) && (a < one)) { a = one; }
                    if ((one % 2 == 0) && (b < one)) { b = one; }
                    // проверка переменных по условию
                    if ((fuel % 14 == 0) && (fuel > R) && (fuel == (a * b)))
                    { R = fuel; }
                }

                Console.WriteLine(R);
            }
        }
    }
