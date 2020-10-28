using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv
{
    class Methods
    {
        public static double SumAllElem(double[] a) // сумма всех элементов массива
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }

        public static double Avrg(double[] a) // среднее арифметическое элементов массива
        {
            double avrg = SumAllElem(a) / a.Length;
            return avrg;
        }

        public static double SumNegativElem(double[] a) // сумма всех отрицательных элементов массива
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    sum += a[i];
                }
            }
            return sum;
        }

        public static double SumPosElem(double[] a) //сумма всех положительных элементов массива
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    sum += a[i];
                }
            }
            return sum;
        }

        public static double SumOddElem(double[] a) // сумма элементов массива с нечетным номером
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i += 2)
            {
                sum += a[i];
            }
            return sum;
        }

        public static double SumEvenElem(double[] a) // сумма элементов массива с четным номером
        {
            double sum = 0;
            for (int i = 1; i < a.Length; i += 2)
            {
                sum += a[i];
            }
            return sum;
        }

        public static double MaxElem(double[] a) // максимальный элемент массива
        {
            int pos = 0;
            double max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    pos = i;
                    max = a[i];
                }
            }
            return max;
        }

        public static double MinElem(double[] a) // минимальный элемент массива
        {

            int pos = 0;
            double min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    pos = i;
                    min = a[i];
                }
            }
            return min;
        }

        public static double ProductMaxMin(int IndexMin, int IndexMax, double[] a)
        {
            if (IndexMin < IndexMax)
            {
                double product = 1;
                for (int i = 0; i < a.Length; i++)
                {
                    if (i > IndexMin & i < IndexMax)
                    {
                        product *= a[i];
                    }
                    else
                    {
                        continue;
                    }
                }
                return product;
            }
            else
            {
                double product = 1;
                for (int i = 0; i < a.Length; i++)
                {
                    if (i > IndexMax & i < IndexMin)
                    {
                        product *= a[i];
                    }
                    else
                    {
                        continue;
                    }
                }
                return product;
            }
        }


        public static void Print(string st, double[] a)
        {
            Console.Write(st);
            for (int i = 0; i < a.GetLength(0); i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
    }
}
