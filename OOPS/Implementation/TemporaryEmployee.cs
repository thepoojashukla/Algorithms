using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    class TemporaryEmployee : Baseclass
    { 
        public int wage { get; set; }
        public int workhours { get; set; }

        public override int GetMonthlySalary()
        {
            return this.workhours * this.wage;
        }

        /*public override int GetMonthlySalary()
        {
            return this.workhours * this.wage;
        }*/
    }
}
