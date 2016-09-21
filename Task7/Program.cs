using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите k");
            int k = int.Parse(Console.ReadLine());
          switch (m)
                {
                    case 1: Console.WriteLine("пики"); break;
                    case 2: Console.WriteLine("трефи"); break;
                    case 3: Console.WriteLine("бубны"); break;
                    case 4: Console.WriteLine("червы"); break;
            }
                switch (k)
            { case 6: Console.WriteLine("шестерка"); break;
                case 7: Console.WriteLine("семерка"); break;
                case 8: Console.WriteLine("врсьмерка"); break;
                case 9: Console.WriteLine("девятка"); break;
            case 10: Console.WriteLine("десятка"); break;
            case 11: Console.WriteLine("валет"); break;
                    case 12: Console.WriteLine("дама"); break;
                    case 13: Console.WriteLine("король"); break;
                    case 14: Console.WriteLine("туз"); break;
                }
        }
    }
    }

