using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter
{
    interface IEmployee
    {
        void Vacation();
        bool IfVacation
        {
            get;
            set;
        }
        void SickLeave();
        bool IfSick
        {
            get;
            set;
        }
    }
}
