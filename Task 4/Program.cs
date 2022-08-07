using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to search");
            int num = int.Parse(Console.ReadLine());
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 13, 15, 17 };
            Console.WriteLine(Check(num, arr));
        }
        static bool Check(int num, int[] arr)
        {
            foreach (var item in arr)
            {
                if (item == num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

