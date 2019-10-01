using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;

namespace CodingPracticeTests
{
    [TestClass]

    public class AlgorithmTest
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void FibonacciTest()
        {

            //Arrange
            var fib = new Algorithm();


            //Act
            fib.PrintFibbonacciSeries(5);

            //Assert 
        }

        [TestMethod]
        public void RecursiveFibonacciTest()
        {
            var recfib = new Algorithm();
          int x  =recfib.RecursiveFibonacci(5);
            Console.WriteLine(x);
        }

        [TestMethod]
        public void CalculationTest()
        {
            var calcT = new Algorithm();
            calcT.AddInList(100);
            calcT.Calculation();


        }

        [TestMethod]
        public void FindLcmTest()
        {
            var lcm = new Algorithm();
            lcm.FindLcm(20, 12);
            lcm.FindLcm(12, 20);
            lcm.FindLcm(0, 8);
            Console.WriteLine(lcm.FindLcm(2, 6));
            Console.Write("Enter the First Number : ");
            
        }

        [TestMethod]
        public void FindGcdTest()
        {
            var gcd = new Algorithm();
            gcd.FindGcd(20, 12);

            Console.WriteLine(gcd.FindGcd(36, 24));

        }

            [TestMethod]
        public void GetFactorialTest()
        {
            var fact = new Algorithm();
            Console.WriteLine(fact.GetFactorial(5));
        }


        [TestMethod]
        public void GetSquareRoot()
        {
            var sqrt = new Algorithm();
            Console.WriteLine(sqrt.SquareRoot(10));
        }

        


    
    }

}
