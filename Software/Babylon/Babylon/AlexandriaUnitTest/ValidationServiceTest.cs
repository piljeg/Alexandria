using Bll.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace AlexandriaUnitTest
{
    [TestClass]
    public class ValidationServiceTest
    {

        [TestMethod]
        public void ParseNumberTest()
        {
            int parsedNum = 0;

            ValidationService.ParseNumber("1", out parsedNum);

            Assert.IsTrue(parsedNum == 1);
        }
        [TestMethod]
        public void AssertPositiveTest() 
        {
            bool parsed = false;

            parsed = ValidationService.AssertPositive("1");

            Assert.IsTrue(parsed);
        }
        [TestMethod]
        public void AssertEmailTest()
        {
            bool isEmail = true;

            isEmail = ValidationService.AssertEmail("toni.skobicgmail.com");

            Assert.IsFalse(isEmail);
        }
        [TestMethod]
        public void CheckPhoneNumTest()
        {
            bool isPhone = true;

            isPhone = ValidationService.IsPhoneNumberValid("51252151242144214");

            Assert.IsFalse(isPhone);
        }
        [TestMethod]
        public void AssertStringLengthTest()
        {
            bool stringLength = false;
            stringLength = ValidationService.AssertStringLenght("alexandria", 10);
            Assert.IsTrue(stringLength);
        }
    }
}
