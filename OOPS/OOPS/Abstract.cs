using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
   public abstract class LearnAbstract
    {
        int pin;//can have field
        public abstract void Print();             //No brackets no implementation
    }


    public abstract class InheritAbstract : LearnAbstract
    {
                                                //Abstract class doesnt need to provide implementation of inherited Abstract class
    }

    public class InheritLearnAbstract : LearnAbstract
    {
                                     //Non Abstract needs to provide implementation
      public override void Print()
        {
            Console.WriteLine("Message");
        }
    }
}
