using Microsoft.VisualStudio.TestTools.UnitTesting;
using Users.Common.Models;

namespace User.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void Can_create_user()
        {
            var user = new User();
        }
    }
}
