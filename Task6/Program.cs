using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите  год=");
            double a = double.Parse(Console.ReadLine());
            double b,c;
            b = a % 100;
            c = a % 4;
            if(b==0)
            {
                if(c==0)
                    Console.WriteLine( a+"год высокосный" );
            }
            else
            Console.WriteLine("год не высокосный");
        }
    }
}
