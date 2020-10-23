using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Darts1
{
    public struct Shot
    {
        public double x;
        public double y;
        public double points;
    }
    class Darts
    {
        static void Main(string[] args)
        {
            Shot S; // бросок
            string answer;
            int Points = 0; // итоговая сумма очков
            int i = 0; // счетчик бросков
            try
            {
                do
                {
                    Console.WriteLine("Введите координаты броска (х,у): ");
                    S.x = double.Parse(Console.ReadLine());
                    S.y = double.Parse(Console.ReadLine());
                    S.points = Math.Pow(S.x, 2) + Math.Pow(S.y, 2); // попадание в окружность, граница включается

                    if (S.points <= 1)
                    {
                        Console.WriteLine("Попали! 10 очков");
                        Points += 10;
                        i++;
                    }
                    else if (S.points > 4)
                    {
                        Console.WriteLine("Мимо! 0 очков");
                        Points += 0;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Попали! 5 очков");
                        Points += 5;
                        i++;
                    }
                    Console.WriteLine("Продолжаем? y/n");
                    answer = Console.ReadLine();
                }
                while (answer == "y");
                Console.WriteLine("За {1} бросков Вы набрали {0} очков. Поздравляем", Points, i);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен неверный формат данных!");
            }

        }   
                   

           

            
                
                
            
    }
}
