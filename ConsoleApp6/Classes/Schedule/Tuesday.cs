using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes.Schedule
{
    internal class Tuesday : DayOfWeek
    {
        public Tuesday() : base(new Hamburger(), new IceCream()) { }
        public Tuesday(Food first, Food second) : base(first, second) { }
    }
}
