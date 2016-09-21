using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {   double n=1,x=2,a=2.0,b=3,c=1,t=1,z=n,x1=-x;
            while(n<11)
            {
                t = t * (Math.Pow(x1, z) * (a / b));
                c -=t;
                a++;
                b++;
                z++;
                n++;
            }
            Console.WriteLine("ответ=" + c);
        }
    }
    }

