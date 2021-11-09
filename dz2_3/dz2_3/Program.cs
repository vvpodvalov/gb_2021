using System;

namespace dz2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("число четное");
            }
            else
            {
                Console.WriteLine("число не является четным");
            }
            }
    }
}
