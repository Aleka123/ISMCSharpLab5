using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите а");
            double a = double.Parse(Console.ReadLine());
            double b,c,d,e,f,k,l,m,n,w,y;
            b = a * a;
            c = b * b;
            Console.Write("a4=");
            Console.WriteLine(c);
            d = b * c;
            Console.Write("a6=");
            Console.WriteLine(d);
            e = d * a;
            Console.Write("a7=");
            Console.WriteLine(e);
            f = c * c;
            Console.Write("a8=");
            Console.WriteLine(f);
            e = f * a;
            Console.Write("a9=");
            Console.WriteLine(e);
            k = e * a;
            Console.Write("a10=");
            Console.WriteLine(k);
            l = k * b * a;
            Console.Write("a13=");
            Console.WriteLine(l);
            m = l * b;
            Console.Write("a15=");
            Console.WriteLine(m);
            n = m *d ;
            Console.Write("a21=");
            Console.WriteLine(n);
            w = n * e;
            Console.Write("a28=");
            Console.WriteLine(w);
            y = w * w * f;
            Console.Write("a64=");
            Console.WriteLine(y);
        }
    }
}
