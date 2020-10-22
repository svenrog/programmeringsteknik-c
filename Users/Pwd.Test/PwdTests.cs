using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Users.Common.Services;

namespace Pwd.Tests
{
    [TestClass]
    public class PwdTests
    {
        [TestMethod]
        public void password_is_of_length()
        {
            var passwordService = new PasswordService();
            var password = passwordService.GeneratePassword(8);
            Assert.AreEqual(8, password.Length);
        }

        [TestMethod]
        public void passwords_mutate()
        {
            var passwordService = new PasswordService();
            var firstPassword = passwordService.GeneratePassword(8);
            var secondPassword = passwordService.GeneratePassword(8);
            Assert.AreNotEqual(firstPassword, secondPassword);
        }

        [TestMethod]
        public void too_many_parameters_throws_error()
        {
            var passwordService = new PasswordService();
            Assert.ThrowsException<ArgumentOutOfRangeException>
                (() => passwordService.GeneratePassword(3, 2, 2, 2));

        }

        [TestMethod]
        public void correct_amount_of_capital_letters()
        {
            var passwordService = new PasswordService();
            var password = passwordService.GeneratePassword(4,2);
            var capitalLettercount = password.Count(x => char.IsUpper(x));
            Assert.AreEqual(2, capitalLettercount);
        }

        [TestMethod]
        public void correct_amount_of_number()
        {
            var passwordService = new PasswordService();
            var password = passwordService.GeneratePassword(5, 1, 2);
            var numberCount = password.Count(x => char.IsDigit(x));
            Assert.AreEqual(2, numberCount);
        }

        [TestMethod]
        public void correct_amount_of_special_characters()
        {
            var passwordService = new PasswordService();
            var password = passwordService.GeneratePassword(80, 1, 1, 30);
            var specialCharacterCount = password.Length -password.Count(x => char.IsLetterOrDigit(x));
            Assert.AreEqual(30, specialCharacterCount);
        }
    }
}
