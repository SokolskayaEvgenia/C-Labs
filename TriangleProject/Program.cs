using System;

namespace TriangleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle ABC = NewTriangle();
                Print(ABC);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введены данные неверного формата");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        static Triangle NewTriangle()
        {
            Triangle Tr = new Triangle();
            Console.WriteLine("Введите значения сторон треугольника: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a <= 0 | b <= 0 | c <= 0)
                throw new Exception("Значение стороны треугольника не может быть меньше или равно 0!");
            else if (!((a + b) > c & (a + c) > b & (b + c) > a))
                throw new Exception("Треугольник не существует!");
            Tr.GetTriangle(a, b, c);
            return Tr;
        }

        static void Print(Triangle abc)
        {
            Console.WriteLine("Треугольник: сторона 1 = " + $"{abc.Side1():.#}" + ", сторона 2 = " + $"{abc.Side2():.#}" + ", сторона 3 = " + $"{abc.Side3():.#}");
            Console.WriteLine("Периметр треугольника = " + $"{abc.GetPerimetr():.#}");
            Console.WriteLine("Площадь треугольника  = " + $"{abc.GetSquare():.#}");

        }


    }
}
