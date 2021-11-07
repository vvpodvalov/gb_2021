using System;

namespace dz2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру в этом месяце:");
            int minTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру в этом месяце:");
            int maxTemp = Convert.ToInt32(Console.ReadLine()); ;
            int srTemp = (minTemp + maxTemp) / 2;
            Console.WriteLine($"Средняя температура в этом месяце" +""+srTemp);
        }
    }
}
