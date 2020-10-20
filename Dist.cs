using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDistance
{
    public struct Distance
    {
        public int feet;
        public double inches;
    }
    class Dist
    {
        static void Main(string[] args)
        {
            Distance d1;
            Distance d2;
            Distance d3;

            try
            {

                Console.WriteLine("Введите число футов первого расстояния: ");
                d1.feet = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число дюймов первого расстояния: ");
                d1.inches = Double.Parse(Console.ReadLine());

                Console.WriteLine("Введите число футов второго расстояния: ");
                d2.feet = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число дюймов второго расстояния: ");
                d2.inches = Double.Parse(Console.ReadLine());

                d3.feet = d1.feet + d2.feet;
                d3.inches = d1.inches + d2.inches;
                d3.feet = d3.feet + (int)d3.inches / 12;
                d3.inches = d3.inches % 12;

                Console.WriteLine("Расстояние d1 = {0}\'-{1}\"", d1.feet, d1.inches);
                Console.WriteLine("Расстояние d2 = {0}\'-{1}\"", d2.feet, d2.inches);
                Console.WriteLine("Cумма расстояний d1 и d2 = {0}\'-{1}\"", d3.feet, d3.inches);

            }

            catch (FormatException e)
            {
                Console.WriteLine("Возникло исключение! {0}", e.Message);
            }

        }
    }
}
