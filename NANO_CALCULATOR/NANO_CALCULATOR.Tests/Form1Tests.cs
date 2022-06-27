using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NANO_CALCULATOR.Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void calculate_test_sum()
        {
            //arrange
            int op = 1;
            double a = 10;
            double c = 20;
            string expected = "30";

            //act
            Form1 x = new Form1 ();
            string actual = x.calculate(op, a, c);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void calculate_test_dif()
        {
            //arrange
            int op = 2;
            double a = 30;
            double c = 20;
            string expected = "10";

            //act
            Form1 x = new Form1();
            string actual = x.calculate(op, a, c);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void calculate_test_mul()
        {
            //arrange
            int op = 3;
            double a = 10;
            double c = 20;
            string expected = "200";

            //act
            Form1 x = new Form1();
            string actual = x.calculate(op, a, c);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void calculate_test_div()
        {
            //arrange
            int op = 4;
            double a = 20;
            double c = 10;
            string expected = "2";

            //act
            Form1 x = new Form1();
            string actual = x.calculate(op, a, c);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void calculate_test_sin()
        {
            //arrange
            int op = 5;
            double a = 0;
            double c = 0;
            string expected = "0";

            //act
            Form1 x = new Form1();
            string actual = x.calculate(op, a, c);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void calculate_test_cos()
        {
            //arrange
            int op = 6;
            double a = 0;
            double c = 0;
            string expected = "1";

            //act
            Form1 x = new Form1();
            string actual = x.calculate(op, a, c);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void calculate_test_ln()
        {
            //arrange
            int op = 7;
            double a = Math.Exp(1);
            double c = 0;
            string expected = "1";

            //act
            Form1 x = new Form1();
            string actual = x.calculate(op, a, c);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
