using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N = int.Parse(Console.ReadLine());
            double S = 1.5, s = 1.0, e=3.0,t=3.0;
            int i;
            for (i = 0; i < N; i++)
            {
                S = S + 1 / e;
                e++;
            }
            for(i=0; i<N/2.0;i++)
            {
                s =s+1/t-1/(t+1);
                t += 2;
            }
            Console.WriteLine("Пройдет" + S+"км");
            Console.WriteLine("Будет за" + s);
        }
    }
}
