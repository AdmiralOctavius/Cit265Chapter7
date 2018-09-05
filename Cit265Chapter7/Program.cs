using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit265Chapter7
{
    class Program
    {
        private enum Colors
        {
            Red=0, Green=256, Bue=512, Purple=242
        }
        static void Main(string[] args)
        {
            double test = 4.24;
            Console.WriteLine(Math.Sqrt(test));
            Console.WriteLine(Program.Square((int)test));

            int test1 = 256;
            switch ((Colors)test1)
            {
                case Colors.Green:
                    Console.WriteLine("Color is green");
                    break;
                case Colors.Purple:
                    Console.WriteLine("Color is green");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
            //Using colons allows for specific value correction 
            Program.TimeMethod(second: 43, hour: 12);
        }

        static double Square(int number)
        {
            return Math.Sqrt(number);
        }

        static void TimeMethod(int second=0, int minute=0, int hour = 0)
        {

        }
    }
}
