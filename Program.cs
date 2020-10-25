using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalc
{
   
 
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                string answer;
                Console.WriteLine("Выберите тип треугольника: равносторонний? (y/n)");
                answer = Console.ReadLine();
                if (answer == "y")
                {
                    try
                    {
                        Console.WriteLine("Введите значение стороны треугольника:");
                        double st = double.Parse(Console.ReadLine());
                        if (st <= 0)
                            throw new Exception("Значение стороны треугольника не может быть меньше или равно 0!");
                        double Sq = Operation.TriangleSquare(st);
                        Console.WriteLine("Площадь треугольника = " + $"{Sq:.#}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    try
                    {
                        Console.WriteLine("Введите значения сторон треугольника:");
                        double x = double.Parse(Console.ReadLine());
                        double y = double.Parse(Console.ReadLine());
                        double z = double.Parse(Console.ReadLine());
                        if (x <= 0)
                            throw new Exception("Значение стороны треугольника не может быть меньше или равно 0!");
                        if (y <= 0)
                            throw new Exception("Значение стороны треугольника не может быть меньше или равно 0!");
                        if (z <= 0)
                            throw new Exception("Значение стороны треугольника не может быть меньше или равно 0!");
                        double Sq = Operation.TriangleSquare(x, y, z);
                        if (Sq != 0)
                            Console.WriteLine("Площадь треугольника = " + $"{Sq:.#}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

            }
            catch (FormatException caught)
            {
                Console.WriteLine("Возникло исключение! {0}", caught.Message);
            }
            catch (Exception caught)
            {
                Console.WriteLine("Возникло исключение! {0}", caught.Message);
            }
            

        }
    }
}
