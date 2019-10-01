using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    interface IProgram
    {
       // int Id;                          //Interface cannot hv field
        //public void Print()                   //this showsinterface cannot have implementation inside 
        //{
        //}

        void draw();                   //interface member are explicit public they are not allowed to have access modifier even not public
    }

    interface I2 : IProgram
    {
        void I2Method();
    }

    public class Customer : I2 
    {
        public void draw()
        {
            Console.WriteLine("interface print method");
        }

        public void I2Method()
        {
            throw new NotImplementedException();
        }
    }
}
