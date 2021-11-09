using System;

namespace dz2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текущий месяц цифрой:");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m == 1)
            {
                Console.WriteLine("январь");
            }
            else if (m == 2)
            {
                Console.WriteLine("февраль");
            }
            else if (m == 3)
            {
                Console.WriteLine("март");
            }
            else if (m == 4)
            {
                Console.WriteLine("апрель");
            }
            else if (m == 5)
            {
                Console.WriteLine("май");
            }
            else if (m == 6)
            {
                Console.WriteLine("июнь");
            }
            else if (m == 7)
            {
                Console.WriteLine("июль");
            }
            else if (m == 8)
            {
                Console.WriteLine("август");
            }
            else if (m == 9)
            {
                Console.WriteLine("сентябрь");
            }
            else if (m == 10)
            {
                Console.WriteLine("октябрь");
            }
            else if (m == 11)
            {
                Console.WriteLine("ноябрь");
            }
            else if (m == 12)
            {
                Console.WriteLine("декабрь");
            }
            else
            {
                Console.WriteLine("месяц не может быть 0 и больше 12");
            }
            }
    }
}
