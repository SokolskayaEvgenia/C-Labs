using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquareRoots
{
    class Operation
    {
        public static double CalculateSquareRoots (double a, double b, double c, ref double x1, ref double x2)
        // public static double CalculateSquareRoots (double a, double b, double c, ref double x1, ref double x2)
        {
            double D = b * b - 4 * a * c; //вычисление дискриминанта
            if (D>0)
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                return 1;
            }
            else if (D == 0)
            {
                x1 = -b / 2 * a;
                //x2 = x1; //если возвращать в качестве аргументов out 
                return 0;
            }
            else
            {
                //x1 = 0; ??? не поняла, как вернуть x1 и x2, если их не существует
                //x2 = 0; ???
               return -1;
            }
        }
    }
}
