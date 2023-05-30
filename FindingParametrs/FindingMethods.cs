using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class FindingMethods
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 3;
            double h = Math.Pow(10, -10);
            Print(Dichotomy(a, b, h));
            Console.WriteLine();
            Print(Newton(a, b, h));
            Console.WriteLine();
            Print(Chord(a, b, h));
        }

        public static double Function(double x)
        {
            double y = Math.Pow(x, 2) - 2;
            return y;
        }
        public static double FristDerivativeFunction(double x)
        {
            double y = Math.Pow(x, 2) - 2;
            return y;
        }

        public static void Print(double x)
        {
            Console.WriteLine(x);
        }

        public static double Dichotomy(double x1, double x2, double h)
        {
            Console.WriteLine("МЕТОД ДИХОТОМИЯ");
            int count = 0;
            if (Function(x1) * Function(x2) < 0)
            {
                while (Math.Abs(x1 - x2) > h)
                {
                    if (Function(x1) * Function((x1 + x2) / 2) > 0)
                    {
                        x1 = (x1 + x2) / 2;
                    }
                    else
                    {
                        x2 = (x1 + x2) / 2;
                    }
                    count++;
    
                }
                double answer = (x1 + x2) / 2;
                Console.WriteLine("Кол-во итерраций затраченых на поиск корня:" + count);
                return answer;
            }

            return -101;
        }

        public static double Newton(double x1, double x0, double h)
        {
            Console.WriteLine("МЕТОД НЬЮТОНА");
            int count = 0;
            if(Function(x1) * Function(x0) < 0)
            {
                x0 = (x1 + x0) / 2;
                while (Math.Abs(Function(x1)) >= h)
                {
                    x1 = x0 - (Function(x0) / (2 * x0));
                    x0 = x1;
                    count++;
                }
                Console.WriteLine("Кол-во итерраций затраченых на поиск корня:" + count);
                return x0;
            }
            return -101;
        }
        public static double Chord(double x1, double x2, double h)
        {
            Console.WriteLine("МЕТОД ХОРД");
            int count = 0;
            double x0 = x1;
            if (Function(x1) * Function(x2) < 0)
            {
                while (Math.Abs(Function(x1)) >= h)
                {
                    x1 = x0 - (Function(x0)*(x2-x0)/(Function(x2)-Function(x0)));
                    x0 = x1;
                    count++;
                }
                Console.WriteLine("Кол-во итерраций затраченых на поиск корня:" + count);
                return x0;
            }
                return -101;
        }
    }
}