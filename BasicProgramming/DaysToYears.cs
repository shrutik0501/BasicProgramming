using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class DaysToYears
    {
        public static void convertDaysToYears()
        {
            int days, years;
            days = 6788;
            years = days / 365;
            Console.WriteLine("Number of years is:"+years);
        }
    }
}
