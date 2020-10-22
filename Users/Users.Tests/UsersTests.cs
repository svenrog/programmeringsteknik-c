using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Users.Common.Tools;

namespace Users.Tests
{
    [TestClass]
    public class UsersTests
    {

        [TestMethod]
        public void can_get_pepper()
        {
            Assert.AreEqual("z0AYHca$nk@5Lhr:vq7y;6e4P61&^U71coEl?dhyT$u8l;$LcG", Cmd.GlobalVariables.Pepper());
        }

        [TestMethod]
        public void can_generate_salt()
        {
            Assert.IsNotNull(Salt.Generate());
        }

        [TestMethod]
        public void can_generate_a_hash()
        {
            string salt = Salt.Generate();
            Assert.IsNotNull(Hash.Generate("password", salt));
        }

        [TestMethod]
        public void the_hash_is_different_from_the_password()
        {
            string salt = Salt.Generate();
            Assert.AreNotEqual("password", Hash.Generate("password", salt));
        }

        [TestMethod]
        public void different_passwords_generate_different_hashes()
        {
            string salt = Salt.Generate();
            string salt2 = Salt.Generate();
            Assert.AreNotEqual(Hash.Generate("password", salt), Hash.Generate("password", salt2));
        }

        [TestMethod]
        public void can_store_and_read_users()
        {
            string username = "user1";
            string password = "password";
            UserLogin.CreateUser(username, password);
            Assert.IsTrue(UserLogin.Find("user1"));
        }

        //[TestMethod]
        //public void can_store_and_read_hashes()
        //{
        //    string username = "user1";
        //    string password = "password";
        //    UserLogin.CreateUser(username, password);
        //    Assert.IsTrue(UserLogin.Login(username, password));
        //}

        //[TestMethod]
        //public void same_password_generates_different_hashes_for_different_users()
        //{
        //    UserLogin.CreateUser("user1", "password");
        //    UserLogin.CreateUser("user2", "password");
        //    Assert.AreNotEqual(Hash.Get("user1", "password"), Hash.Get("user2", "password"));
        //}
    }
}
