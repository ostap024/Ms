using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcLib.Tests.Nunit
{
    [TestFixture]
    public class MyCalcTestsNunit
    {
        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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
