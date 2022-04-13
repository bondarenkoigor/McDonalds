using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes.Schedule
{
    internal class Monday : DayOfWeek
    {
        public Monday() : base(new Fries(), new NoWork()) { }
        public Monday(Food first, Food second) : base(first, second) { }
    }
}