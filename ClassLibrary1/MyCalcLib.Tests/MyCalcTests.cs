using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLib;
namespace MyCalcLib.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Addition_2and4_6returned()
        {
            //arrange
            double x = 2;
            double y = 4;
            double expected = 6;

            //act
            MyCalc c = new MyCalc();
            double actual = c.Addition(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtraction_2from4_2returned()
        {
            //arrange
            double x = 4;
            double y = 2;
            double expected = 2;

            //act
            MyCalc c = new MyCalc();
            double actual = c.Subtraction(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiplication_2and4_8returned()
        {
            //arrange
            double x = 2;
            double y = 4;
            double expected = 8;

            //act
            MyCalc c = new MyCalc();
            double actual = c.Multiplication(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Division_4by2_6returned()
        {
            //arrange
            double x = 4;
            double y = 2;
            double expected = 2;

            //act
            MyCalc c = new MyCalc();
            double actual = c.Division(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
