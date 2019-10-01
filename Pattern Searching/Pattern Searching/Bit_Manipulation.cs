using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Searching
{
    class Bit_Manipulation
    {
        //Calculate XOR from 1 to n.
        static int computeXOR(int n)
        {
            // If n is a multiple of 4 
            if (n % 4 == 0)
                return n;

            // If n%4 gives remainder 1 
            if (n % 4 == 1)
                return 1;

            // If n%4 gives remainder 2 
            if (n % 4 == 2)
                return n + 1;

            // If n%4 gives remainder 3 
            return 0;
        }

        //Find XOR of two number without using XOR operator

        // Returns XOR of x and y 
        static int myXOR(int x, int y)
        {
            return (x | y) &
                   (~x | ~y);
        }


    }
}
