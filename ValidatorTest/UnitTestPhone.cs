using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionLib.Validation;

namespace ValidatorTest
{
    [TestClass]
    public class UnitTestPhone
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string testStr = null;

            //assert
            Assert.IsFalse(Validator.CheckPhone(testStr));
        }


        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            string testStr = "";

            //assert
            Assert.IsFalse(Validator.CheckPhone(testStr));
        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            string testStr = "1234567";

            //assert
            Assert.IsFalse(Validator.CheckPhone(testStr));
        }
        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            string testStr = "12345678";

            //assert
            Assert.IsTrue(Validator.CheckPhone(testStr));
        }
        [TestMethod]
        public void TestMethod5()
        {
            //arrange
            string testStr = "123456789";

            //assert
            Assert.IsFalse(Validator.CheckPhone(testStr));
        }
        [TestMethod]
        public void TestMethod6()
        {
            //arrange
            string testStr = " 12345678";

            //assert
            Assert.IsFalse(Validator.CheckPhone(testStr));
        }

        [TestMethod]
        public void TestMethod7()
        {
            //arrange
            string testStr = "1234m678";

            //assert
            Assert.IsFalse(Validator.CheckPhone(testStr));
        }

        [TestMethod]
        public void TestMethod8()
        {
            //arrange
            string testStr = "+45 12345678";

            //assert
            Assert.IsTrue(Validator.CheckPhone(testStr));
        }

        [TestMethod]
        public void TestMethod9()
        {
            //arrange
            string testStr = "+4512345678";

            //assert
            Assert.IsTrue(Validator.CheckPhone(testStr));
        }
        [TestMethod]
        public void TestMethod10()
        {
            //arrange
            string testStr = "-45 12345678";

            //assert
            Assert.IsFalse(Validator.CheckPhone(testStr));
        }
        [TestMethod]
        public void TestMethod11()
        {
            //arrange
            string testStr = "+45 123456789";

            //assert
            Assert.IsFalse(Validator.CheckPhone(testStr));
        }
        [TestMethod]
        public void TestMethod12()
        {
            //arrange
            string testStr = "+ab 12345678";

            //assert
            Assert.IsFalse(Validator.CheckPhone(testStr));
        }



    }
}
