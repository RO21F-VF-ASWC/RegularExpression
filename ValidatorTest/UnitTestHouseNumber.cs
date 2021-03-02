using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionLib.Validation;

namespace ValidatorTest
{
    [TestClass]
    public class UnitTestHouseNumber
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string testStr = null;

            //assert
            Assert.IsFalse(Validator.CheckHouseNumber(testStr));
        }


        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            string testStr = "";

            //assert
            Assert.IsFalse(Validator.CheckHouseNumber(testStr));
        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            string testStr = "4";

            //assert
            Assert.IsTrue(Validator.CheckHouseNumber(testStr));
        }
        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            string testStr = "167";

            //assert
            Assert.IsTrue(Validator.CheckHouseNumber(testStr));
        }
        [TestMethod]
        public void TestMethod5()
        {
            //arrange
            string testStr = "167 B";

            //assert
            Assert.IsTrue(Validator.CheckHouseNumber(testStr));
        }
        [TestMethod]
        public void TestMethod6()
        {
            //arrange
            string testStr = "167B";

            //assert
            Assert.IsTrue(Validator.CheckHouseNumber(testStr));
        }

        [TestMethod]
        public void TestMethod7()
        {
            //arrange
            string testStr = "1 1";

            //assert
            Assert.IsTrue(Validator.CheckHouseNumber(testStr));
        }

        [TestMethod]
        public void TestMethod8()
        {
            //arrange
            string testStr = "17 1 tv";

            //assert
            Assert.IsTrue(Validator.CheckHouseNumber(testStr));
        }

        [TestMethod]
        public void TestMethod9()
        {
            //arrange
            string testStr = "17X 1tv";

            //assert
            Assert.IsTrue(Validator.CheckHouseNumber(testStr));
        }
        [TestMethod]
        public void TestMethod10()
        {
            //arrange
            string testStr = "17 1.tv";

            //assert
            Assert.IsTrue(Validator.CheckHouseNumber(testStr));
        }
        [TestMethod]
        public void TestMethod11()
        {
            //arrange
            string testStr = "a17 1 tv";

            //assert
            Assert.IsFalse(Validator.CheckHouseNumber(testStr));
        }
        [TestMethod]
        public void TestMethod12()
        {
            //arrange
            string testStr = "17 1#";

            //assert
            Assert.IsFalse(Validator.CheckHouseNumber(testStr));
        }
    }
}
