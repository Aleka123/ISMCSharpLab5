using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите  трехзначное число a=");
            float a = float.Parse(Console.ReadLine());
            double b, c, d;
            b = (a % 100 - a%10)/10;
            c =(a-a%100)/100;
            d =b*100+c*10+a%10;
            Console.WriteLine("отримане число=" + d);
        }
    }
}
