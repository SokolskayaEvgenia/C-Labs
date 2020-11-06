using System;

namespace Figures
{
    class Triangle : Shape, IFig
    {
        private double a;
        private double b;
        private double c;
        new private static string name = "Треугольник";
        public Triangle() : base(name)
        {
            this.a = 1;
            this.b = 1;
            this.c = 1;
        }

        public Triangle(double a, double b, double c) : base(name)
        {
            if (IfExist(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

        }

        public Triangle(double a) : base(name) //конструктор равностороннего треугольника
        {
            if (IfExist(a))
            {
                this.a = a;
                this.b = a;
                this.c = a;
            }
        }

        public Triangle(double a, double b) : base(name) //конструктор равнобедренного треугольника
        {
            if (IfExist(a, b))
            {
                this.a = a;
                this.b = a;
                this.c = b;
            }
        }

        private bool IfExist(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
                return true;
            return false;
        }
        private bool IfExist(double a, double b)
        {
            if (a > 0 && b > 0 && 2 * a > b)
                return true;
            return false;
        }
        private bool IfExist(double a)
        {
            if (a > 0)
                return true;
            return false;
        }
        public override double Perimetr()
        {
            return a + b + c;
        }

        public override double Square()
        {
            double P = Perimetr() / 2;
            return Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        }

        public override void Show()
        {
            base.Show();
            if (IfExist(a, b, c) || IfExist(a, b) || IfExist(a))
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("стороны = " + $"{a:.#}");
                    Console.WriteLine("Периметр = " + $"{Perimetr():.#}");
                    Console.WriteLine("Площадь = " + $"{Square():.#}");
                }
                else if (a == b)
                {
                    Console.WriteLine("стороны 1, 2 = " + $"{ a:.#}" + ", сторона 3  = " + $"{c:.#}");
                    Console.WriteLine("Периметр = " + $"{Perimetr():.#}");
                    Console.WriteLine("Площадь = " + $"{Square():.#}");
                }
                else
                {
                    Console.WriteLine("сторона 1 = " + $"{ a:.#}" + ", сторона 2 = " + $"{b:.#}" + ", сторона 3 = " + $"{c:.#}");
                    Console.WriteLine("Периметр = " + $"{Perimetr():.#}");
                    Console.WriteLine("Площадь = " + $"{Square():.#}");
                }

            }
            else
            {
                Console.WriteLine("с такими сторонами не существует!");
            }

        }

        public bool IfTurn { get; set; }
        public void Turn()
        {
            base.Show();
            Console.WriteLine("повернулась: {0}.", IfTurn);
        }




    }
}
