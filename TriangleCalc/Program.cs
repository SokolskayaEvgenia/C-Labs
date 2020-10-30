using System;

namespace TriangleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle TR1, TR2, TR3;
                TR1 = new Triangle(10, 12, 14);
                TR2 = new Triangle(10, 12);
                TR3 = new Triangle(10);
                CheckTriangle(TR1);
                CheckTriangle(TR2);
                CheckTriangle(TR3);
                Print(TR1);
                Print(TR2);
                Print(TR3);

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


        //static Triangle NewTriangle()
        //{
        //    Triangle Tr = new Triangle();
        //    Console.WriteLine("Введите значения сторон треугольника: ");
        //    double a = double.Parse(Console.ReadLine());
        //    double b = double.Parse(Console.ReadLine());
        //    double c = double.Parse(Console.ReadLine());
        //    if (a <= 0 | b <= 0 | c <= 0)
        //        throw new Exception("Значение стороны треугольника не может быть меньше или равно 0!");
        //    else if (!((a + b) > c & (a + c) > b & (b + c) > a))
        //        throw new Exception("Треугольник не существует!");
        //    Tr.GetTriangle(a, b, c);
        //    return Tr;
        //}

        static void Print(Triangle abc)
        {
            if (abc.Side1() == abc.Side2() && abc.Side2() == abc.Side3())
            {
                Console.WriteLine("\nРавносторонний треугольник: \nстороны = " + $"{abc.Side1():.#}");
            }
            else if (abc.Side1() == abc.Side2())
            {
                Console.WriteLine("\nРавнобедренный треугольник: \nстороны 1, 2 = " + $"{abc.Side1():.#}" + ", сторона 3  = " + $"{abc.Side3():.#}");
            }
            else
            {
                Console.WriteLine("\nТреугольник: \nсторона 1 = " + $"{abc.Side1():.#}" + ", сторона 2 = " + $"{abc.Side2():.#}" + ", сторона 3 = " + $"{abc.Side3():.#}");
            }
            Console.WriteLine("Периметр треугольника = " + $"{abc.GetPerimetr():.#}");
            Console.WriteLine("Площадь треугольника  = " + $"{abc.GetSquare():.#}");

        }

        public static void CheckTriangle(Triangle abc)
        {
            if (abc.Side1() <= 0 | abc.Side2() <= 0 | abc.Side3() <= 0)
                throw new Exception("Значение стороны треугольника не может быть меньше или равно 0!");
            else if (!((abc.Side1() + abc.Side2()) > abc.Side3() & (abc.Side1() + abc.Side3()) > abc.Side2() & (abc.Side2() + abc.Side3()) > abc.Side1()))
                throw new Exception("Треугольник не существует!");
        }


    }
}
