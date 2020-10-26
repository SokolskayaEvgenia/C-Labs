using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquareRoots
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                nachalo:
                Console.WriteLine("Введите коэффициенты квадратного уравнения (a, b, c):");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Коэффициент а не может быть равен нулю!");
                    goto nachalo;
                }
                double x1 = 0; // можно не присваивать значения, если метод с аргументом out
                double x2 = 0;
                double res = Operation.CalculateSquareRoots(a, b, c, ref x1, ref x2); 
                // double res = Operation.CalculateSquareRoots(a, b, c, out x1, out x2);
                if (res == 1)
                {
                    Console.WriteLine("Корни уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны: x1 = " + $"{x1:.#}" + ", x2 = " + $"{x2:.#}", a, b, c);
                }
                else if (res == 0)
                {
                    Console.WriteLine("Корень уравнения с коэффициентами a = {0}, b = {1}, c = {2} один: x1 = x2 = " + $"{x1:.#}.", a, b, c);
                }
                else
                {
                    Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} нет.", a, b, c);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат введенных данных");
            }
            catch (Exception caught)
            {
                Console.WriteLine(caught.Message);
            }
            
        }
    }
}
