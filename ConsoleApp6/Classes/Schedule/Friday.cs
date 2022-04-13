using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes.Schedule
{
    internal class Friday : DayOfWeek
    {
        public Friday() : base(new NoWork(), new Fries()) { }
        public Friday(Food first, Food second) : base(first, second) { }
    }
}
