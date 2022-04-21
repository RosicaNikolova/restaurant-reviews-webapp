using ClassLibrary.Business;
using ClassLibrary.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void FindUserFailsTest()
        {         
            FakeUserRepository fakeRepo = new FakeUserRepository(new List<User> ());

            UserManager userManager = new UserManager(fakeRepo);
            User foundUser = userManager.FindUser("rosica@gmail.com", "123abv");
            Assert.AreEqual(null, foundUser);
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
        public void FindAllUsersFailsTest()
        {
            FakeUserRepository fakeRepo = new FakeUserRepository(new List<User>());
            UserManager userManager = new UserManager(fakeRepo);
            List<User> foundUsers = userManager.FindAllUsers();
            Assert.AreEqual(null, foundUsers);
        }


        [TestMethod]
        public void DeleteUsersTest()
        {
            User userCreated = new User();
            userCreated.Email = "rosica@gmail.com";
            userCreated.Password = "123abv";
            userCreated.Id = 1;
            List<User> users = new List<User>();
            users.Add(userCreated);
            FakeUserRepository fakeRepo = new FakeUserRepository(users);
            UserManager userManager = new UserManager(fakeRepo);
            userManager.DeleteUser(userCreated);
            users.Remove(userCreated);
            CollectionAssert.AreEqual(users, fakeRepo.users);
        }

        [TestMethod]
        public void GetNameOfUserTest()
        {
            User userCreated = new User();
            userCreated.Id = 1;
            userCreated.FirstName = "Rositsa";
            userCreated.LastName = "Nikolova";
            FakeUserRepository fakeRepo = new FakeUserRepository(new List<User> { userCreated });
            UserManager userManager = new UserManager(fakeRepo);
            string nameFound = userManager.GetNameOfUser(1);
            Assert.AreEqual("Rositsa Nikolova", nameFound);
        }

        [TestMethod]
        public void UpdateUserTest()
        {
            List<User> users = new List<User>();
            User user = new User();
            user.Id = 1;
            user.FirstName = "Rositsa";
            user.LastName = "Nikolova";
            user.Email = "rositsa@mail.com";
            user.Password = "123";
            users.Add(user);
            FakeUserRepository fakeRepo = new FakeUserRepository(users);
            UserManager userManager = new UserManager(fakeRepo);
            userManager.UpdateUser("nikolova@gmail.com", "123", "Jane", "Smith", 1);
            Assert.AreEqual("Jane", fakeRepo.users[0].FirstName);
        }
        [TestMethod]
        public void FindUserByIdTest()
        {
            User userCreated = new User();
            userCreated.Id = 1;
            FakeUserRepository fakeRepo = new FakeUserRepository(new List<User> { userCreated });
            UserManager userManager = new UserManager(fakeRepo);
            User userFound = userManager.FindUserById(1);
            Assert.AreEqual(userCreated, userFound);
        }

        [TestMethod]
        public void FindAllUsersEligibleForDiscount()
        {
            List<User> users = new List<User>() { new User { Id = 1, FirstName = "Rositsa" }, new User { Id = 2, FirstName = "John" } };
            FakeUserRepository fakeRepo = new FakeUserRepository(users);
            UserManager userManager = new UserManager(fakeRepo);
            List<User> foundUsers = userManager.FindAllUsersEligibleForDiscount();
            CollectionAssert.AreEqual(users, foundUsers);
        }
    }
}
