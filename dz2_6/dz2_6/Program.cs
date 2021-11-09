using System;
namespace HelloWorld

{
    class Program
{
    [Flags]
    public enum DayOfWeek
    {
        // Задаем дни недели.
        Monday = 0b_0000001,
        Tuesday = 0b_0000010,
        Wednesday = 0b_0000100,
        Thursday = 0b_0001000,
        Friday = 0b_0010000,
        Saturday = 0b_0100000,
        Sunday = 0b_1000000,
    }

    static void Main(string[] args)
    {
        // Маски офисов
        DayOfWeek Office1Requirements = DayOfWeek.Thursday | DayOfWeek.Wednesday | DayOfWeek.Thursday | DayOfWeek.Friday;
        DayOfWeek Office2Requirements = DayOfWeek.Monday | DayOfWeek.Tuesday | DayOfWeek.Wednesday | DayOfWeek.Thursday | DayOfWeek.Friday | DayOfWeek.Saturday | DayOfWeek.Sunday;

        Console.WriteLine($"Рабочие дни Офиса№1: {Office1Requirements}");
        Console.WriteLine($"Рабочие дни Офиса№2: {Office2Requirements}");

        //Дни в которые работает сотрудник  офиса
        DayOfWeek allDays = (DayOfWeek)0b0011111;

        // Варианты офисов  вкоторых может работать сотрудник
        DayOfWeek Office1 = allDays & Office1Requirements;
        DayOfWeek Office2 = allDays & Office2Requirements;


        bool isOffice1 = Office1 == Office1Requirements;
        bool isOffice2 = Office2 == Office2Requirements;


        Console.WriteLine($"Рабочие дни сотрудника: {allDays}");


        if (isOffice1)
        {
            Console.WriteLine("Сотрудник работает в Офисе №1");
        }

            if (isOffice2)
            {
                Console.WriteLine("Сотрудник работает в Офисе №2");
            }
    }
}
}
