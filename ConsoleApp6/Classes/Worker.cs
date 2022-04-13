using System;
using ConsoleApp6.Classes.Schedule;
using ConsoleApp6.Classes;

namespace ConsoleApp6.Classes
{
    internal class Worker
    {
        public Scheduler Schedule { get; private set; }

        public int CurrentDay { get; set; }

        public double Salary { get; set; }

        public Worker() : this(10000)
        {
            CurrentDay = (int)DateTime.Now.DayOfWeek - 1;
            Schedule = new Scheduler();
        }

        public Worker(double salary)
        {
            Salary = salary;
        }

        public void PrintTodaySchedule()
        {
            Console.WriteLine($"Сегодня: 1 смена: {Schedule[CurrentDay].Firstfood.Name}, 2 смена: {Schedule[CurrentDay].Secondfood.Name}");
            Console.WriteLine($"Завтра: 1 смена: {Schedule[CurrentDay + 1].Firstfood.Name}, 2 смена: {Schedule[CurrentDay + 1].Secondfood.Name}");
        }

        public void PrintFullSchedule()
        {
            for (int i = 0; i < Schedule.days.Length; i++)
            {
                Console.WriteLine($"{Schedule[i].Firstfood.Name}, {Schedule[i].Secondfood.Name}");
            }
        }

        public string GetCurrentShift()
        {
            if (DateTime.Now.TimeOfDay < Schedule.days[CurrentDay].BreakStart) return "Первая смена";
            else if (DateTime.Now.TimeOfDay > Schedule.days[CurrentDay].BreakEnd) return "Вторая смена";
            return "Перерыв";
        }
    }
}
