using System;
using ConsoleApp6.Classes;
namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.PrintTodaySchedule();
            Console.WriteLine(worker.GetCurrentShift());
            Console.WriteLine(worker.Salary);
            Console.WriteLine("\n");
            worker.PrintFullSchedule();

        }
    }
}
