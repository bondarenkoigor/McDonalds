using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes.Schedule
{
    internal class Wednesday : DayOfWeek
    {
        public Wednesday() : base(new Fries(), new Hamburger()) { }
        public Wednesday(Food first, Food second) : base(first, second) { }
    }
}
