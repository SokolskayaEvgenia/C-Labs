using System;

namespace EducationalCenter
{
    class Manager : Employee
    {
        private string faculty;
        private static string position = "Менеджер";
       

        public Manager()
        { }
        public Manager(long IDnumber, string name, string surname, string faculty) : base(IDnumber, name, surname)
        {
            this.faculty = faculty;
        }
   
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Факультет: {0} \nДолжность: {1}\nСтаж работы (полных лет): {2}", faculty, position, GetStanding());
        }

    }
}
