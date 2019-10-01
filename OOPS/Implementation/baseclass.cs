using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{                                                       //Its a abstract class we keep just common thingsof two class..There is no base employee thing in oraganisation
    public abstract class Baseclass
    {                                           //hence we should not create instance of this class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public String LastName { get; set; }

        public void GetFullName()
        {
           Console.Write( this.FirstName + "" + LastName);
        }

        public abstract int GetMonthlySalary();
        
        /*public virtual int GetMonthlySalary()
        {
            throw new NotImplementedException();
        }*/
    }
}
