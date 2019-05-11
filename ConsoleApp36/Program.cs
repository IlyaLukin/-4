using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
   
    class Program
    {
        const double Epsilon = 0.001;
        static double Function(double x)
        {
            return Math.Pow(x, 4) + (0.8 * Math.Pow(x, 3)) - (0.4 * Math.Pow(x, 2)) - 1.4 * x - 1.2;
        }
        static void Main(string[] args)
        {
            double begin = -1.2;
            double end = -0.5;
            double x = end - begin;
            double mid = (begin + end) / 2;

            while(Math.Abs(Function(mid))>Epsilon)
            {
                x /= 2;
                mid = begin + x;
                if (Math.Sign(Function(begin)) == Math.Sign(Function(mid)))
                    begin = mid;
            }

            Console.WriteLine($"Корень уравнения {mid}");
            Console.ReadKey();
        }
    }
}
