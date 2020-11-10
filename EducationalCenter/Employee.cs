using System;

namespace EducationalCenter
{
    class Employee : Person, IEmployee
    {
        private int standing; //стаж
        private DateTime job; //дата принятия на работу
        public decimal Stavka { get; set; }
        public double Bonus { get; set; }
        private decimal salary;

        public Employee()
        { }
        public Employee(long IDnumber, string name, string surname) : base(IDnumber, name, surname)
        {
        }

        public void SetJob(int day, int month, int year)
        {
            job = new DateTime(year, month, day);
        }
        public DateTime GetJob()
        {
            return job;
        }

        public int GetStanding()
        {
            standing = DateTime.Now.Year - job.Year;
            if (DateTime.Now.Month < job.Month || (DateTime.Now.Month == job.Month && DateTime.Now.Day < job.Day))
            {
                standing--;
            }
            return standing;
        }

        public decimal CalculateSalary(int hours)
        {

            return salary = Stavka * (decimal)(hours * (GetStanding() * Bonus));
        }


        public bool IfVacation
        {
            get;
            set;
        }
        public void Vacation()
        {
            Console.WriteLine("{1} {2} в отпуске: {0}", IfVacation, name, surname );
        }

        public bool IfSick
        {
            get;
            set;
        }
        public void SickLeave()
        {
            Console.WriteLine("{1} {2} на больничном: {0}", IfSick, name, surname);
        }
    }
}
