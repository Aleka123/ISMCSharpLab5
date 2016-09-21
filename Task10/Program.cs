using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 1, a = 1.0, b = 3, t = 1, z = 1/2.0;
            while (n < 50)
            {
                t = t + Math.Pow((a),z);
                a++;
                b++;
                z++;
                n++;
            }
            Console.WriteLine("ответ=" + t);
        }
    }
}
