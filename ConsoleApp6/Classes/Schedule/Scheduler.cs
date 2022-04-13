using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes.Schedule
{
    internal class Scheduler
    {
        public DayOfWeek[] days { get; private set; }

        public Scheduler()
        {
            days = new DayOfWeek[5];
            days[0] = new DayOfWeek(new Fries(), new NoWork());
            days[1] = new DayOfWeek(new Hamburger(), new IceCream());
            days[2] = new DayOfWeek(new Fries(), new Hamburger());
            days[3] = new DayOfWeek(new Hamburger(), new IceCream());
            days[4] = new DayOfWeek(new NoWork(), new Fries());
        }

        public void SetDaySchedule(int day, Food firstfood, Food secondfood)
        {
            days[day - 1].Firstfood = firstfood;
            days[day - 1].Secondfood = secondfood;
        }

        public DayOfWeek this[int ind]
        {
            get { return days[ind]; }
        }


    }
}
