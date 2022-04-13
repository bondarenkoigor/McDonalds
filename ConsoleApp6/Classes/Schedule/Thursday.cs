using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes.Schedule
{
    internal class Thursday : DayOfWeek
    {
        public Thursday() : base(new Hamburger(), new IceCream()) { }
        public Thursday(Food first, Food second) : base(first, second) { }
    }
}
