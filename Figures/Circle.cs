using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle : Shape
    {
        private double r;
        private static double Pi = 3.14;
        new private static string name = "Окружность";

        public Circle() : base(name)
        {
            this.r = 1;
        }

        public Circle (double r) : base(name)
        {
            if (IfExist(r))
            {
                this.r = r;
            }
        }
        private bool IfExist(double r)
        {
            if (r > 0)
                return true;
            return false;
        }
        public override double Perimetr()
        {
            return 2*Pi*r;
        }

        public override double Square()
        {
            return Pi*Math.Pow(r, 2);
        }

        public override void Show()
        {
            base.Show();
            if (IfExist(r))
            {
                Console.WriteLine("с радиусом = " + $"{r:.#}");
                Console.WriteLine("Длина окружности = " + $"{Perimetr():.#}");
                Console.WriteLine("Площадь = " + $"{Square():.#}");
            }
            else
            {
                Console.WriteLine("с таким радиусом не существует!");
            }

        }

    }
}
