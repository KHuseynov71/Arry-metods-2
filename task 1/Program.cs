using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse( Console.ReadLine());
            Console.WriteLine(NumLenth(num));
        }
           static int NumLenth(int num)
        {
            int clone = num;
            int i = 0;
            if (clone<0)
            {
                clone = clone * (-1);
            while (clone>0)
            {
                clone = clone / 10;
                i++;
            }
            return i;
            }
            else if (clone>0)
            {
                while (clone > 0)
                {
                    clone = clone / 10;
                    i++;
                }
                return i;
            }
            else
            {
                return 1;
            }
        }
    }
}
