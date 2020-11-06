using System;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle TR1 = new Triangle(10, 12, 14);
            Triangle TR2 = new Triangle(10);
            Triangle TR3 = new Triangle(11, 10);
            TR1.Show();
            TR2.Show();
            TR3.Show();

            Squares SQ1 = new Squares(2);
            SQ1.Show();

            Circle CR1 = new Circle(3);
            CR1.Show();

            TR1.IfTurn = true;
            TR1.Turn();
            SQ1.IfTurn = true;
            SQ1.Turn();


            Console.WriteLine("\n Тестирование полиморфизма");
            Shape it;
            it = TR1;
            it.Show();
            it = TR2;
            it.Show();
            it = TR3;
            it.Show();
            it = SQ1;
            it.Show();
            it = CR1;
            it.Show();
        }
    }
}
