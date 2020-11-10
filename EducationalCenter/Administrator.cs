using System;
namespace EducationalCenter
{
    class Administrator : Employee
    {
        private int laboratory;
        private static string position = "Администратор";
        

        public Administrator()
        { }
        public Administrator(long IDnumber, string name, string surname, int laboratory) : base(IDnumber, name, surname)
        {
            this.laboratory = laboratory;
        }
 
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Лаборатория: {0} \nДолжность: {1}\nСтаж работы (полных лет): {2}", laboratory, position, GetStanding());
        }

    }
}
