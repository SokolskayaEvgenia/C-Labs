using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("Введите число элементов массива: N = ");
                Begin:
                int N = int.Parse(Console.ReadLine());
                if (N <=0)
                {
                    Console.WriteLine("Введите целое число больше 0!");
                    goto Begin;
                }
                double[] Mass = new double[N];
                Console.WriteLine("Введите элементы массива: ");
                for (int i = 0; i < Mass.Length; i++)
                {
                    Mass[i] = double.Parse(Console.ReadLine());
                }

                Methods.Print("Заданный массив: ", Mass);

                double Sum = Methods.SumAllElem(Mass);
                Console.WriteLine("Сумма всех элементов массива = {0}", Sum);

                double Averg = Methods.Avrg(Mass);
                Console.WriteLine("Среднее арифметическое элементов массива = " + $"{Averg:.#}");

                double SumNegative = Methods.SumNegativElem(Mass);
                Console.WriteLine("Сумма всех отрицательных элементов массива = {0}", SumNegative);

                double SumPositive = Methods.SumPosElem(Mass);
                Console.WriteLine("Сумма всех положительных элементов массива = {0}", SumPositive);

                double SumNegativeInd = Methods.SumNegativIndex(Mass);
                Console.WriteLine("Сумма элементов массива с нечетными номерами = {0}", SumNegativeInd);

                double SumPositiveInd = Methods.SumPosIndex(Mass);
                Console.WriteLine("Сумма элементов массива с четными номерами = {0}", SumPositiveInd);

                int IndexMax = Array.IndexOf(Mass, Methods.MaxElem(Mass));
                Console.WriteLine("Индекс максимального элемента массива  = {0}", IndexMax);

                int IndexMin = Array.IndexOf(Mass, Methods.MinElem(Mass));
                Console.WriteLine("Индекс минимального элемента массива  = {0}", IndexMin);

                double Product = Methods.ProductMaxMin(IndexMin, IndexMax, Mass);
                Console.WriteLine("Произведение всех элементов массива между максимальным и минимальным значением = {0}", Product);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неправильный формат вводимых данных!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка! {0}", e.Message);
            }
        }
    }
}
