using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class TriangleSq
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Console.WriteLine("Пожалуйста, введите, чему равен периметр треугольника");
            double pr = Double.Parse(Console.ReadLine());
            double st = pr / 3; // расчитываем сторону треугольника
            double p = pr / 2; // расчитываем полупериметр
            double S = Math.Sqrt(p * Math.Pow((p - st), 3));
            Console.WriteLine("\tСторона\t\tПлощадь");
            Console.WriteLine("\t" + $"{st:.##}" + "\t\t" + $"{S:.##}");
        }
    }
}
