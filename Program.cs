using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как к Вам обращаться? ");
            string name = Console.ReadLine();
            string data = DateTime.Now.ToString(); //Присвоение даты
            Console.WriteLine($"Привет, {name}, сегодня {data}"); //Вывод приветствия с датой
        }
    }
}
