using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    abstract class Shape
    {

        protected string name;

        public Shape (string name)
        {
            this.name = name;
        }
        public Shape ()
        {
        }

        public virtual void Show()
        {
            Console.WriteLine("\nФигура: {0}", name);
        }

        abstract public double Square();
        abstract public double Perimetr();


    }
}
