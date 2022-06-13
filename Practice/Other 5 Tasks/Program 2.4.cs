using System;

namespace Part3_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введитe крайнее число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество попыток");
            int b = int.Parse(Console.ReadLine());
            Random Random = new Random();
            int c = Random.Next(1, a);
            for (int i = 0; i <= b; i++)
            {
                int d = int.Parse(Console.ReadLine());
                if ((d < 1) || (d > a))
                {
                    Console.WriteLine("Число не входит в диапазон");
                    break;
                }
                if (d == c)
                {
                    Console.WriteLine("Вы победили");
                    break;
                }
                else if (i == b - 1)
                {
                    Console.WriteLine("Попытки кончились");
                }
                else if (d < c)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else if (d > c)
                {
                    Console.WriteLine("Загаданное число меньше");
                }
            }

        }
    }
}
