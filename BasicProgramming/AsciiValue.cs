using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class AsciiValue
    {
        public static void printAsciiValue()
        {
            int asciiValue;
            int i = 0;
            for(asciiValue = 33;asciiValue <=127;asciiValue ++)
            {
                if((i%5)==0)
                {
                    Console.WriteLine("\n");
                }
                Console.WriteLine(" " +Convert.ToChar(asciiValue));
                i++;
            }
        }
    }
}
