using System;

namespace Figures
{
    class Squares : Shape, IFig
    {
        private double a;
        new private static string name = "Квадрат";
        public Squares() : base(name)
        {
            this.a = 1;
        }

        public Squares(double a) : base(name)
        {
            if (IfExist(a))
            {
                this.a = a;
            }
        }
        private bool IfExist(double a)
        {
            if (a > 0)
                return true;
            return false;
        }
        public override double Perimetr()
        {
            return 4 * a;
        }

        public override double Square()
        {
            return Math.Pow(a, 2);
        }

        public override void Show()
        {
            base.Show();
            if (IfExist(a))
            {
                Console.WriteLine("со сторонами = " + $"{a:.#}");
                Console.WriteLine("Периметр = " + $"{Perimetr():.#}");
                Console.WriteLine("Площадь = " + $"{Square():.#}");
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
