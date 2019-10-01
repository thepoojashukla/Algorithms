using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation              //external Implematation when interfaces have same methods
{
    interface I1
    {
        void Print();
    }
    interface I2
    {
        void Print();
    }
    class Program : I2, I1
    {
        void I2.Print()
        {
            Console.Write("Hello");
        }

        void I1.Print()
        {
            Console.Write("Hello madam");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            ((I1)p).Print();            //no longer access is through class object now it is through typecasting interface with class variable
            ((I2)p).Print();

        }

    }
}
