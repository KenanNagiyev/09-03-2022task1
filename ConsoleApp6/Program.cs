using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(VowelLetter(text));
        }
            static int VowelLetter(string text)
            {
                int count = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == 'a' || text[i] == 'e' || text[i] == 'o' || text[i] == 'i' || text[i] == 'u')
                    {
                        count++;
                    }
                }
                return count;            
        }
    }
}
