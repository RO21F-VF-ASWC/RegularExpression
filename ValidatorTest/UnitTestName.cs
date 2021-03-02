using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionLib.Validation;

namespace ValidatorTest
{
    [TestClass]
    public class UnitTestName
    {


        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string testStr = null;

            //assert
            Assert.IsFalse(Validator.CheckName(testStr));
        }


        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            string testStr = "";

            //assert
            Assert.IsFalse(Validator.CheckName(testStr));
        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            string testStr = "p";

            //assert
            Assert.IsTrue(Validator.CheckName(testStr));
        }
        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            string testStr = "to";

            //assert
            Assert.IsTrue(Validator.CheckName(testStr));
        }
        [TestMethod]
        public void TestMethod5()
        {
            //arrange
            string testStr = "peter";

            //assert
            Assert.IsTrue(Validator.CheckName(testStr));
        }
        [TestMethod]
        public void TestMethod6()
        {
            //arrange
            string testStr = " peter";

            //assert
            Assert.IsFalse(Validator.CheckName(testStr));
        }

        [TestMethod]
        public void TestMethod7()
        {
            //arrange
            string testStr = "peter8";

            //assert
            Assert.IsFalse(Validator.CheckName(testStr));
        }

        [TestMethod]
        public void TestMethod8()
        {
            //arrange
            string testStr = "peter()";

            //assert
            Assert.IsFalse(Validator.CheckName(testStr));
        }
    }
}
