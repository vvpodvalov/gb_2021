using System;

namespace dz3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявляем двумерный массив
            Console.WriteLine("Введите размер массива");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            string[,] myarray=new string[x,y];
            Console.WriteLine("Введите данные в справочник");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    myarray[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine(myarray[i, j] + "\t");
                }
            }
            
            
            
        }
    }
}
