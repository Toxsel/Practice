using System;

namespace Part3_Task5
{
    class Program
    {
        public int rnd(int a, int b)
        {
            Random rnd = new Random();
            return rnd.Next(a + 1, b - 1);
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Program random = new Program();
            for (int i = 0; i < 100; i++){
                Console.Write($"{random.rnd(a, b)} ");
            }
        }
    }
}
