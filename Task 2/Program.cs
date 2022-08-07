using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string Text = Console.ReadLine();
            char[] vowel = { 'a', 'i', 'o', 'u', 'e' };
            Console.WriteLine(CountVowel(Text, vowel));
        }
        static int CountVowel(string Text, char[] vowel)
        {
            int count = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                for (int k = 0; k < vowel.Length; k++)
                {
                    if (Text[i] == vowel[k])
                    {
                        count++;
                    }
                }
            }
            return count;
        }   
    }
}
