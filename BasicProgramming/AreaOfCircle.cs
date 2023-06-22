using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class AreaOfCircle
    {
        public static void circleArea()
        {
            double radius, area;
            Console.WriteLine("Enter Radius:");
            radius = double.Parse(Console.ReadLine());
            area = 3.14 * radius * radius;
            Console.WriteLine("\n Area of circle: " + area);
        }
    }
}
