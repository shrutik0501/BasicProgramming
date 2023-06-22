using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to execute that UC");
            int UseCaseNumber = Convert.ToInt32(Console.ReadLine());
            switch (UseCaseNumber)
            {
                    case 1:
                    Console.WriteLine("UC1 Executing");
                    Size_DataType.sizeOfDataType();
                    break;
                    case 2:
                    Console.WriteLine("UC2 Executing");
                    DaysToYears_WeeksAndDays.conDayToYearsWeeksAndDays();
                    break;
                    case 3:
                    Console.WriteLine("UC3 Executing");
                    AsciiValue.printAsciiValue();
                    break;
                    case 4:
                    Console.WriteLine("UC4 Executing");
                    AreaOfCircle.circleArea();
                    break;
                    case 5:
                    Console.WriteLine("UC5 Executing");
                    Swap_var.swapExample();
                    break;
                    case 6:
                    Console.WriteLine("UC6 Executing");
                    ArithmeticOperation.performArithmeticOpe();
                    break;
                    default : Console.WriteLine("Invalid Input");
                    break;
            }
            //Size_DataType.sizeOfDataType();
            //DaysToYears_WeeksAndDays.conDayToYearsWeeksAndDays();
            //AsciiValue.printAsciiValue();
            //AreaOfCircle.circleArea();
            //Swap_var.swapExample();
            //ArithmeticOperation.performArithmeticOpe();
        }
    }
}
