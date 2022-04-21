using ClassLibrary.Business;
using ClassLibrary.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class LoginManagerTest
    {
        [TestMethod]
        public void LoginSuccessfulTest()
        {
            User userCreated = new User();
            userCreated.Email = "rosica@gmail.com";
            userCreated.Password = "123abv";
            userCreated.Id = 1;
            FakeUserRepository fakeRepo = new FakeUserRepository(new List <User> { userCreated});
            LoginManager logginManager = new LoginManager(fakeRepo);

            User loggedInUser = logginManager.Login("rosica@gmail.com", "123abv");
            Assert.AreEqual(1, loggedInUser.Id);
        }
    }
}
