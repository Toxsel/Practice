using System;

namespace Part2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int Del1 = 0, DelN = 0;
            int[] massiv = new int[n];
            Random rnd = new Random();
            Console.WriteLine("");
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = rnd.Next(0, 10);
                Console.WriteLine(massiv[i]);
            }
            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i] % massiv[0] == 0)
                {
                    Del1 += 1;
                }
                if (massiv[i] % massiv[n-1] == 0)
                {
                    DelN += 1;
                }
            }
            if (Del1 > DelN)
            {
                Console.WriteLine("Больше тех чисел, что делятся на первый элемент массива");
            }
            else
            {
                Console.WriteLine("Больше тех чисел, что делятся на последний элемент массива");
            }
        }
    }
}
