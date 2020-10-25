using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalc
{
    public class Operation
    {
        static bool Existance(double a, double b, double c) // треугольник существует, если сумма значений двух сторон больше значения третьей
        {
            bool ok;
            if ((a + b) > c && (a + c) > b && (b + c) > a)
                ok = true;
            else
            {
                ok = false;
                Console.WriteLine("Треугольник не существует!");
            }
            return ok;
        }
        public static double TriangleSquare(double a, double b, double c)
        {
            bool ok;
            ok = Operation.Existance(a, b, c);
            if (ok)
            {
                double Pr = a + b + c;
                double p = Pr / 2;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                //Console.WriteLine("Площадь треугольника = " + $"{S:.#}");
                return S;
            }
            else
            return 0;
        }
        public static double TriangleSquare (double a) //вызов метода проверки существования не нужен, т.к. треугольник равносторонний
        {
            double Pr = a * 3;
            double p = Pr / 2;
            double S = Math.Sqrt(p * Math.Pow((p - a), 3)); 
            //Console.WriteLine("Площадь треугольника = " + $"{S:.#}");
            return S;
        }
    }
}
