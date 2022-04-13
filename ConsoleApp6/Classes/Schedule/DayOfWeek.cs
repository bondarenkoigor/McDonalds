using System;

namespace ConsoleApp6.Classes.Schedule
{
    internal class DayOfWeek
    {
        public TimeSpan BreakStart = new TimeSpan(12, 0, 0);
        public TimeSpan BreakEnd = new TimeSpan(13, 0, 0);
        public Food Firstfood { get; set; }
        public Food Secondfood { get; set; }

        public DayOfWeek(Food first, Food second)
        {
            Firstfood = first;
            Secondfood = second;
        }

        public void SetFood(Food first, Food second)
        {
            Firstfood = first;
            Secondfood = second;
        }
}
}
