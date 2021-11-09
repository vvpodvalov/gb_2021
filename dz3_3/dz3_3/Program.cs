using System;

namespace dz3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();

            for (int i = str.Length-1; i >=0 ; i--) // пересчет от последнего элемента
            {
                Console.WriteLine(str[i]); // построчный вывод каждого символа строки
            }

        }
    }
}
