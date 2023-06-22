using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class ArithmeticOperation
    {
        public static void performArithmeticOpe()
        {
            int num1 = 50;
            int num2 = 25;
            int result;
            result = num1 + num2;
            Console.WriteLine("Value is {0}",result);
            result = num1 - num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 * num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 / num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 % num2;
            Console.WriteLine("Value is {0}", result);
            result = num1++;
            Console.WriteLine("Value is {0}", result);
            result = num1--;
            Console.WriteLine("Value is {0}", result);
            
        }
    }
    }
    
    

