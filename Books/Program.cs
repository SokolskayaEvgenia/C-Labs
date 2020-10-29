using System;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Book();
            Book b3 = new Book();
            Book b4 = new Book();
            Book b5 = new Book();
            Book b6 = new Book();
            Book b7 = new Book();
            Book b8 = new Book();
            Book b9 = new Book();
            Book b10 = new Book();

            b1.SetBook("Cулгаков", "Мастер и Маргарита", 416, 2016);
            b2.SetBook("Пушкин", "Евгений Онегин", 224, 2020);
            b3.SetBook("Достоевский", "Преступление и наказание", 672, 2012);
            b4.SetBook("Толстой", "Война и мир", 1360, 2019);
            b5.SetBook("Сент-Экзюпери", "Маленький принц", 112, 2016);
            b6.SetBook("Лермонтов", "Герой нашего времени", 208, 2017);
            b7.SetBook("Оруэлл", "1984", 318, 2014);
            b8.SetBook("Гарсиа Маркес", "Сто лет одиночества", 544, 2017);
            b9.SetBook("Гоголь", "Мертвые души", 352, 2016);
            b10.SetBook("Уайльд", "Портрет Дориана Грея", 320, 2018);

            Book[] Library = { b1, b2, b3, b4, b5, b6, b7, b8, b9, b10 };

            ShowArray("До сортировки", Library);
            Array.Sort<Book>(Library);
            ShowArray("После сортировки", Library);
        }
        public static void ShowArray(string st, Book[] a)
        {
            Console.WriteLine(st);
            for (int i = 0; i < a.Length; i++)
            {
                a[i].Show();
            }
        }
    }
}
