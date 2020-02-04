using System;

namespace Labor.rabota4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); //random
            int[] massive = new int[1000]; //massiv
            for (int i = 0; i < 100; i++) //цикл от 0 до 10000 
            {
                massive[i] = rand.Next(0, 1000);
                Console.WriteLine(massive[i]);
            }
            int R = massive[0];
            Console.WriteLine("min: ");
            for (int i = 0; i < massive.Length; i++) //ищем min и присвоем его R
            {
                if (massive[i] < R) { R = massive[i]; }

            }
            Console.WriteLine(R);
            Console.WriteLine("Yslovie: ");
            // здесь проверим условие
            int a = massive[new Random().Next(0, massive.Length)];
            int b = massive[new Random().Next(0, massive.Length)];

            int c = a * b;
            if ((R % 21 == 0) && (R == c && (a - b <= 8 || b - a <= 8)))
            {
                Console.WriteLine(R);
            }
            else
            {
                Console.WriteLine("-1");
            }

        }



    }
}


