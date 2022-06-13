using System;

namespace Part2_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int s = 0;
            for(int i = 0; i<n; i++) {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++) {
                if (arr[i] % 2 != 0){
                    s=s+arr[i];
                }
                else{
                    break;
                }
            }
            Console.WriteLine("");
            Console.WriteLine(s);

        }
    }
}
