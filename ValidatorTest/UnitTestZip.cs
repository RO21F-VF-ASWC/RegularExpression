using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionLib.Validation;

namespace ValidatorTest
{
    [TestClass]
    public class UnitTestZip
    {

        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string testStr = null;

            //assert
            Assert.IsFalse(Validator.CheckZip(testStr));
        }


        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            string testStr = "";

            //assert
            Assert.IsFalse(Validator.CheckZip(testStr));
        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            string testStr = "123";

            //assert
            Assert.IsFalse(Validator.CheckZip(testStr));
        }
        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            string testStr = "1234";

            //assert
            Assert.IsTrue(Validator.CheckZip(testStr));
        }
        [TestMethod]
        public void TestMethod5()
        {
            //arrange
            string testStr = "12345";

            //assert
            Assert.IsFalse(Validator.CheckZip(testStr));
        }
        [TestMethod]
        public void TestMethod6()
        {
            //arrange
            string testStr = " 4567";

            //assert
            Assert.IsFalse(Validator.CheckZip(testStr));
        }

        [TestMethod]
        public void TestMethod7()
        {
            //arrange
            string testStr = "a1234";

            //assert
            Assert.IsFalse(Validator.CheckZip(testStr));
        }

        [TestMethod]
        public void TestMethod8()
        {
            //arrange
            string testStr = "5678#";

            //assert
            Assert.IsFalse(Validator.CheckZip(testStr));
        }
    }

}

