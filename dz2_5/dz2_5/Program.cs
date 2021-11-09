using System;

namespace dz2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите месяц цифрой:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите уличную температуру:");
            int t = Convert.ToInt32(Console.ReadLine());

            if (m == 12 && t > 0)
            {
                Console.WriteLine("Дождливая зима");
            }
            else if (m == 1 && t > 0)
            {
                Console.WriteLine("Дождливая зима");
            }
            else if (m == 2 && t > 0)
            { 
                Console.WriteLine("Дождливая зима");
            }
            else
            { 
                Console.WriteLine("Это не зимний месяц или температура минусовая");
            }
            }
    }
}
