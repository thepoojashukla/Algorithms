using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    class PermanentEmployee : Baseclass
    {
        public int AnnualSalary { get; set; }


        public override int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }

       /* public override int GetMonthlySalary()
        {
           return this.AnnualSalary / 12;
        }*/
    }
}
