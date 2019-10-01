using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingPractice;

namespace CodingPracticeTests
{
    [TestClass]
    public class StringProgramTest
    {
        [TestMethod]
        public void ReverseStringTest()
        {    //Arrange
            var sp = new StringProgram();  //var keyword does implicit TYPying
            string expectedresult = "ajoop";


            //Act
            var actualResult = sp.ReverseString("pooja");




            //Assert
            Assert.AreEqual(expectedresult, actualResult);
        }


        [TestMethod]
        public void IsPalindromeString()
        {
            var pal = new StringProgram();
            var expected = false;
           var actual = pal.IsPalindromeString("abhinav");
            Assert.AreEqual(actual, expected);


        }

        [TestMethod]
        public void PrintAStringTest()
        {
            var str = new StringProgram();
            str.PrintAString("Hello", "World", "in", "a", "frame");

        }








    }

}
