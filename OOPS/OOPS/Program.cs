using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two ways of Assesing Class

            InheritLearnAbstract inh = new InheritLearnAbstract();
            inh.Print();

            //Otherway as in inheritence //base class left derived class right//Abstract class is only used as base class
            //its instance cannot be created.

            LearnAbstract ln = new InheritLearnAbstract();
            ln.Print();

            IProgram I1 = new Customer();
            I1.draw();
        }
    }
}
