using System;

namespace EducationalCenter
{
    class Student : Person
    {
        public string Faculty { get; set; }
        public int Group { get; set; }
                
        public Student()
        {
        }
        public Student(long IDnumber, string name, string surname) : base(IDnumber, name, surname)
        {
        }
        public Student(long IDnumber, string name, string surname, string faculty, int group) : base(IDnumber, name, surname)
        {
            Faculty = faculty;
            Group = group;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Студент(ка)\nФакультет: {0} \nГруппа: {1}", Faculty, Group);
        }
        






    }
}
