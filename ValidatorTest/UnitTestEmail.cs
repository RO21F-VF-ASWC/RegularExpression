using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionLib.Validation;

namespace ValidatorTest
{
    [TestClass]
    public class UnitTestEmail
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string testStr = null;

            //assert
            Assert.IsFalse(Validator.CheckEmail(testStr));
        }


        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            string testStr = "";

            //assert
            Assert.IsFalse(Validator.CheckEmail(testStr));
        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            string testStr = "peter@mail.dk";

            //assert
            Assert.IsTrue(Validator.CheckEmail(testStr));
        }
        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            string testStr = "peter-levinsky@mail.dk";

            //assert
            Assert.IsTrue(Validator.CheckEmail(testStr));
        }
        [TestMethod]
        public void TestMethod5()
        {
            //arrange
            string testStr = "peter56@mail.dk";

            //assert
            Assert.IsTrue(Validator.CheckEmail(testStr));
        }
        [TestMethod]
        public void TestMethod6()
        {
            //arrange
            string testStr = " peter56@mail.dk";

            //assert
            Assert.IsFalse(Validator.CheckEmail(testStr));
        }

        [TestMethod]
        public void TestMethod7()
        {
            //arrange
            string testStr = "peter.levinsky@mail.dk";

            //assert
            Assert.IsTrue(Validator.CheckEmail(testStr));
        }

        [TestMethod]
        public void TestMethod8()
        {
            //arrange
            string testStr = "p@f.g.h";

            //assert
            Assert.IsTrue(Validator.CheckEmail(testStr));
        }

        [TestMethod]
        public void TestMethod9()
        {
            //arrange
            string testStr = "p.p.p.p@m.dk";

            //assert
            Assert.IsTrue(Validator.CheckEmail(testStr));
        }
        [TestMethod]
        public void TestMethod10()
        {
            //arrange
            string testStr = "p.l@dk";

            //assert
            Assert.IsFalse(Validator.CheckEmail(testStr));
        }
        [TestMethod]
        public void TestMethod11()
        {
            //arrange
            string testStr = "p.mail.dk";

            //assert
            Assert.IsFalse(Validator.CheckEmail(testStr));
        }
        [TestMethod]
        public void TestMethod12()
        {
            //arrange
            string testStr = "p@mail.longTopDomain";

            //assert
            Assert.IsFalse(Validator.CheckEmail(testStr));
        }



    }
}
