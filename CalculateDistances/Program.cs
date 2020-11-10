using System;

namespace CalculateDistances
{
    class Program
    {
        static void Main(string[] args)
        {
            Distance d1 = new Distance(15, 10);
            Distance d2 = new Distance(15, 10);
            Distance d3;
            Distance d4;
            d3 = d1 + d2;
            d4 = d1 - d2;
            Console.WriteLine("Расстояние d1 = " + d1.ToString());
            Console.WriteLine("Расстояние d2 = " + d2.ToString());
            Console.WriteLine("d1 + d2 = " + d3.ToString());
            Console.WriteLine("d1 - d2 = " + d4.ToString());
            if (d1==d2)
                Console.WriteLine("расстояния равны");
            else
                if (d1> d2)
                Console.WriteLine("d1 больше, чем d2");
                else
                Console.WriteLine("d2 больше, чем d1");
            
            
        }
    }
}
