using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviews.Models;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class RegistrationManagerTest
    {
        [TestMethod]
        public void RegistrationSuccessfulTest()
        {
            User userCreated = new User();
            userCreated.Email = "rosica@gmail.com";
            userCreated.Password = "123abv";
            userCreated.FirstName = "Rositsa";
            userCreated.LastName = "Nikolova";
            userCreated.Id = 1;
            FakeUserRepository fakeRepo = new FakeUserRepository(new List<User>());

            RegistrationManager registerManager = new RegistrationManager(fakeRepo);
            User registeredUser = registerManager.Register("rosica@gmail.com", "123abv", "Rositsa", "Nikolova");
            Assert.AreEqual(1, registeredUser.Id);
        }


        [TestMethod]
        [ExpectedException(typeof(RegistrationException))]
        public void RegisterFailsTest()
        {
            User userCreated = new User();
            userCreated.Email = "rosica@gmail.com";
            userCreated.Password = "123abv";
            userCreated.FirstName = "Rositsa";
            userCreated.LastName = "Nikolova";
            userCreated.Id = 1;
            FakeUserRepository fakeRepo = new FakeUserRepository(new List<User> { userCreated });
            RegistrationManager registerManager = new RegistrationManager(fakeRepo);
            User registeredUser = registerManager.Register("rosica@gmail.com", "123abv", "Rositsa", "Nikolova");
        }

        [TestMethod]
        [ExpectedException(typeof(SaveUserException))]
        public void RegistrationFailsToSaveUserTest()
        {
            FakeUserRepository fakeRepo = new FakeUserRepository(new List<User>());
            RegistrationManager registerManager = new RegistrationManager(fakeRepo);
            User registeredUser = registerManager.Register("rosica@gmail.com", "123abv", "Rositsa", "");  
        }



    }
}

