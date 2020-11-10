using System;
using System.Collections;

namespace EducationalCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(01, "Вася", "Иванов");
            student.SetBirthday(03, 12, 1987);
            student.Faculty = "Физико-математический";
            student.Group = 123;
            student.Show();
            Console.WriteLine(student.GetAge());

            Student student2 = new Student(02, "Ольга", "Васина");
            student2.SetBirthday(05, 09, 1986);
            student2.Faculty = "Экономический";
            student2.Group = 321;
            student2.Show();

            Teacher teacher = new Teacher(03, "Валентин", "Николаев");
            teacher.SetBirthday(05, 09, 1955);
            teacher.SetJob(03, 11, 1987);
            teacher.Faculty = "Экономический";
            teacher.Position = "старший преподаватель";
            teacher.Show();
            teacher.Bonus = 0.15;
            teacher.Stavka = 100;
            Console.WriteLine(teacher.CalculateSalary(150));


            Manager manager = new Manager(12, "Анатолий", "Петров", "Экономический");
            manager.SetBirthday(16, 04, 1959);
            manager.SetJob(11, 10, 2005);
            manager.Bonus = 0.1;
            manager.Stavka = 100;
            manager.Show();
            Console.WriteLine(manager.CalculateSalary(160));
            manager.IfSick = true;
            manager.SickLeave();
            teacher.IfVacation = true;
            teacher.Vacation();

            Teacher teacher2 = new Teacher(04, "Петр", "Смирнов");
            teacher2.SetBirthday(12, 01, 1965);
            teacher2.SetJob(20, 08, 2010);
            teacher2.Faculty = "Биологический";
            teacher2.Position = "ведущий преподаватель";
            teacher2.Show();
            teacher2.Bonus = 0.16;
            teacher2.Stavka = 100;
            Console.WriteLine(teacher2.CalculateSalary(140));


            ArrayList Employees = new ArrayList(); //выбран данный тип, т.к. есть возможность сохранить вместе разнотипные объекты
            Employees.Add(manager);
            Employees.Add(teacher);
            Employees.Add(teacher2);
            ShowArray(Employees);
        }

        public static void ShowArray(ArrayList a)
        {
            foreach (Person o in a)
                o.Show();
        }
    }
}
