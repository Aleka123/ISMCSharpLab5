using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите  трехзначное число a=");
            double a = double.Parse(Console.ReadLine());
            double b;
            b =(((a%100-a%10)/10)*100+((a-a%100)/100)*10+a%10) ;
            Console.WriteLine("перше число=" + b);
        }
    }
}
