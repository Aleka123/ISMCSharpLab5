using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Введите  трехзначное число a=");
            float a = float.Parse(Console.ReadLine());
            double b,c,d,e,f;
            b =a%10;
            c = (a%100-b)/10;
            e = (a - 10*c - b )/100;
            d =b+c+e;
            f =b*c*e;
                Console.WriteLine("количество единиц="+b);
            Console.WriteLine("количество десятков=" + c);
            Console.WriteLine("сумма цифр=" + d);
            Console.WriteLine("произведение его цифр=" + f);
        }
    }
}
