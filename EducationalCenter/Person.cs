using System;

namespace EducationalCenter
{
    abstract class Person
    {
        protected long IDNumber { get; set; }
        protected string name;
        protected string surname;
        protected DateTime birthday;
        private int age;
        public Person()
        {
        }
        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public Person(long IDnumber, string name, string surname)
        {
            IDNumber = IDnumber;
            this.name = name;
            this.surname = surname;
        }
        public void SetBirthday(int day, int month, int year)
        {
            birthday = new DateTime(year, month, day);
        }
        public DateTime GetBirthday()
        {
            return birthday;
        }
        public int GetAge() 
        {
            age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.Month < birthday.Month || (DateTime.Now.Month == birthday.Month && DateTime.Now.Day < birthday.Day))
            {
                age--;
            }
            return age;
        }


        public virtual void Show()
        {
            Console.WriteLine("\nИдентификационный номер: {0} \nФамилия: {1} \nИмя: {2} \nДата рождения: {3}", IDNumber, name, surname, birthday.ToString("d"));
        }


    }
}
