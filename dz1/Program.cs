using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цифрами текущий месяц: ");
             mn = Console.ReadLine();
                       Console.WriteLine($"Cегодня" + mn.ToString("Y")); //Вывод приветствия с датой
        }
    }
}
