using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    delegate void SimpleDelegate();  //if has return type // delegate int SimpleDelegate();
                                      // delegate void SimpleDelgate(out int x)
    class MultiCastdelegate
    {
        public static void Main()   //
        {
            //SimpleDelegate simp = new SimpleDelegate(SimpleMethod);
            //simp();

            SimpleDelegate simp1, simp2, simp3, simp4;

            simp1 = new SimpleDelegate(SimpleMethod1);
            simp2 = new SimpleDelegate(SimpleMethod2);
            simp3 = new SimpleDelegate(SimpleMethod3);

            simp4 = simp1 + simp2 + simp3; //chaining method
            simp4();    //it will invoke all of the four methods..it is multicast delegates

            //or                                        //simp1 = new SimpleDelegate(SimpleMethod_1);
                                                       //simp1 += SimpleMethod_2
            simp1 += SimpleMethod2;                   //int deloutputval = -1;  
            simp1 += SimpleMethod3;                  // 
            simp1 -= SimpleMethod1;
            simp1();


            //in return type case
            // SimpleDelegate simp = new SimpleDelegate(SimpleMethod_1);
           // simp1 += SimpleMethod_2;
           // int storevar = simp();      //it will have 2 stored in it...the lastmethod value
        }

        public static void SimpleMethod1()            //public static void SimpleMethod1(out int x)
        {
            Console.WriteLine("Simple Method 1 Invoked");  // x = 1;
        }
        public static void SimpleMethod2()             ////public static void SimpleMethod1(out int x)
        {
            Console.WriteLine("Simple Method 2 Invoked");  // x= 2;
        }
        public static void SimpleMethod3()
        {
            Console.WriteLine("Simple Method 3 Invoked");
        }


        //has return type


        /*public static int SimpleMethod_1()
        {
            return 1;
        }
        public static int SimpleMethod_2()
        {
            return 2;
        }

       */


    }
}
