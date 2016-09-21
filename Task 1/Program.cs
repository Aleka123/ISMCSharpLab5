using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = double.Parse(Console.ReadLine());
            double z = 0, g = 0, c = 0, a = 0, b = 0;
            a = x * x;
            b = Math.Sqrt(x * x + 10);
            c = (y + (1 / Math.Sqrt(x * x + 10)));
            if (c != 0 && b != 0 && a != 0)
            {
                {
                    z = ((x + (2 + y) / a) / c);
                    g = 2.8 * Math.Sin(x) + Math.Abs(y);
                    Console.Write("z=" + z);
                    Console.Write("g=" + g);
                }
            }
            else
                Console.WriteLine("нету решения, знаменатель равняеться 0");
        }
    }
}
