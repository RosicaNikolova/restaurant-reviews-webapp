using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviews.Models;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class UserManagerTest
    {
        [TestMethod]
        public void FindUserTest()
        {
            User userCreated = new User();
            userCreated.Email = "rosica@gmail.com";
            userCreated.Password = "123abv";
            userCreated.Id = 1;
            FakeUserRepository fakeRepo = new FakeUserRepository(new List <User> { userCreated});

            UserManager userManager = new UserManager(fakeRepo);
            User foundUser = userManager.FindUser("rosica@gmail.com", "123abv");
            Assert.AreEqual(1, foundUser.Id);       
        }

        [TestMethod]
        [ExpectedException(typeof(LoginException))]
        public void FindUserFailsTest()
        {         
            FakeUserRepository fakeRepo = new FakeUserRepository(new List<User> ());

            UserManager userManager = new UserManager(fakeRepo);
            User foundUser = userManager.FindUser("rosica@gmail.com", "123abv"); 
        }

        [TestMethod]
        public void FindAllUsersTest()
        {
            List<User> users = new List<User>() { new User { Id = 1, FirstName = "Rositsa" } , new  User { Id = 2, FirstName = "John" } };
            FakeUserRepository fakeRepo = new FakeUserRepository(users);
            UserManager userManager = new UserManager(fakeRepo);
            List<User> foundUsers = userManager.FindAllUsers();
            CollectionAssert.AreEqual(users, foundUsers);
        }


        [TestMethod]
        [ExpectedException(typeof(FindUsersException))]
        public void FindAllUsersFailsTest()
        {
            
            FakeUserRepository fakeRepo = new FakeUserRepository(new List<User>());
            UserManager userManager = new UserManager(fakeRepo);
            List<User> foundUsers = userManager.FindAllUsers();
        }


        [TestMethod]
        public void DeleteUsersTest()
        {
            User userCreated = new User();
            userCreated.Email = "rosica@gmail.com";
            userCreated.Password = "123abv";
            userCreated.Id = 1;
            FakeUserRepository fakeRepo = new FakeUserRepository(new List<User> { userCreated });
            UserManager userManager = new UserManager(fakeRepo);
            userManager.DeleteUser(userCreated);     
        }


        [TestMethod]
        [ExpectedException(typeof(DelteUserException))]
        public void DeleteUsersFailsTest()
        {
            User userCreated = new User();
            userCreated.Email = "rosica@gmail.com";
            userCreated.Password = "123abv";
            userCreated.Id = 1;
            FakeUserRepository fakeRepo = new FakeUserRepository(new List<User>());

            UserManager userManager = new UserManager(fakeRepo);
            userManager.DeleteUser(userCreated);

        }

    }
}
