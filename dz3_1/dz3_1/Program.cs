using System;

namespace dz3_1
{
    class Program
    {
        static void Main(string[] args)
        { int[,] mymatrix = new int[,]

            {
                {13,26,67,15,98},
                {1,44,90,24,7},
                {77,20,61,17,88},
                {33,39,67,52,10},
                {0,99,39,45,18}
            };


            Console.Write($"{mymatrix[0, 0]} ");
            Console.Write($"{mymatrix[1, 1]} ");
            Console.Write($"{mymatrix[2, 2]} ");
            Console.Write($"{mymatrix[3, 3]} ");
            Console.Write($"{mymatrix[4, 4]} ");
        }
        
    }        

}



