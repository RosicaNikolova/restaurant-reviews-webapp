using ClassLibrary.Business;
using ClassLibrary.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class RestaurantManagerTest
    {
        [TestMethod]
        public void GetRestaurantTest()
        {
            Restaurant restCreated = new Restaurant();
            restCreated.Name = "Pizzeria";
            restCreated.Id = 1;
            FakeRestaurantRepository fakeRepo = new FakeRestaurantRepository(new List <Restaurant> { restCreated});

            RestaurantManager restaurantManager = new RestaurantManager(fakeRepo);
            Restaurant foundRestaurant = restaurantManager.GetRestaurant(1);
            Assert.AreEqual(restCreated.Id, foundRestaurant.Id); 
        }

        [TestMethod]
        public void GetRestaurantFailsTest()
        {
            Restaurant restCreated = new Restaurant();
            FakeRestaurantRepository fakeRepo = new FakeRestaurantRepository(new List<Restaurant>());

            restCreated.Name = "Pizzeria";
            restCreated.Id = 1;
            RestaurantManager restaurantManager = new RestaurantManager(fakeRepo);
            Restaurant foundRestaurant = restaurantManager.GetRestaurant(1);
            Assert.AreEqual(null, foundRestaurant);
        }

        [TestMethod]
        public void GetAllRestaurantsTest()
        {
            List<Restaurant> restaurants = new List<Restaurant>() { new Restaurant { Id = 1, Name = "Pizzeria" } , new  Restaurant { Id = 2, Name = "Mexican Dream" } };
            FakeRestaurantRepository fakeRepo = new FakeRestaurantRepository(restaurants);

            RestaurantManager restaurantManager = new RestaurantManager(fakeRepo);
            List<Restaurant> foundRestaurants = restaurantManager.GetAllRestaurants();
            CollectionAssert.AreEqual(restaurants, foundRestaurants);
        }

        [TestMethod]
        public void DeleteRestaurant()
        {
            List<Restaurant> restaurants = new List<Restaurant>() { new Restaurant { Id = 1, Name = "Pizzeria" }, new Restaurant { Id = 2, Name = "Mexican Dream" } };
            FakeRestaurantRepository fakeRepo = new FakeRestaurantRepository(restaurants);
            RestaurantManager restaurantManager = new RestaurantManager(fakeRepo);
            Restaurant restaurant = new Restaurant();
            restaurant.Id = 1;
            restaurant.Name = "Pizzeria";
            restaurantManager.DeleteRestaurant(restaurant);
            restaurants.Remove(restaurant);
            CollectionAssert.AreEqual(restaurants, fakeRepo.restaurants);          
        }
        
        [TestMethod]
        public void GetIdByNameTest()
        {
            List<Restaurant> restaurants = new List<Restaurant>() { new Restaurant { Id = 1, Name = "Pizzeria" }};
            FakeRestaurantRepository fakeRepo = new FakeRestaurantRepository(restaurants);
            RestaurantManager restaurantManager = new RestaurantManager(fakeRepo);
            int expectedId = restaurantManager.GetIdByName("Pizzeria");
            Assert.AreEqual(1, expectedId);
        }

        [TestMethod]
        public void CreateRestaurantTest()
        {
            FakeRestaurantRepository fakeRepo = new FakeRestaurantRepository(new List<Restaurant>());
            RestaurantManager restaurantManager = new RestaurantManager(fakeRepo);

            Restaurant restaurant = new Restaurant();
            restaurant.Name = "Pizzeria";
            restaurantManager.CreateNewRestaurant("Pizzeria", "Eindhoven", "Pisano", "5623AA", 10, "+318967333", "Yes", "No");
            Assert.AreEqual("Pizzeria", fakeRepo.restaurants[0].Name);
        }

        [TestMethod]
        public void GetRestaurantNameTest()
        {
            List<Restaurant> restaurants = new List<Restaurant>() { new Restaurant { Id = 1, Name = "Pizzeria" } };
            FakeRestaurantRepository fakeRepo = new FakeRestaurantRepository(restaurants);
            RestaurantManager restaurantManager = new RestaurantManager(fakeRepo);
            string expectedName = restaurantManager.GetRestaurantName(1);
            Assert.AreEqual("Pizzeria", expectedName);
        }

        [TestMethod]
        public void UpdateRestaurantInfo()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            Restaurant restaurant = new Restaurant();
            restaurant.Id = 1;
            restaurant.Name = "Pizzeria";
            restaurant.City = "Eindhoven";
            restaurant.Street = "Pisano";
            restaurant.PostCode = "5623AA";
            restaurant.StreetNumber = 10;
            restaurant.PhoneNumber = "+318967333";
            restaurant.HasParking = "Yes";
            restaurant.HasDelivery = "No";
            restaurants.Add(restaurant);
            FakeRestaurantRepository fakeRepo = new FakeRestaurantRepository(restaurants);
            RestaurantManager restaurantManager = new RestaurantManager(fakeRepo);
            restaurantManager.UpdateRestaurantInfo("NewName", "Amsterdam", "Pisano", "5623AA", 5, "+318967333", "Yes", "Yes", restaurant);
            Assert.AreEqual(restaurant.Name, "NewName");
        }

        [TestMethod]
        [ExpectedException(typeof(RestaurantInfoException))]
        public void UpdateRestaurantInfoFail()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            Restaurant restaurant = new Restaurant();
            FakeRestaurantRepository fakeRepo = new FakeRestaurantRepository(restaurants);
            RestaurantManager restaurantManager = new RestaurantManager(fakeRepo);
            restaurantManager.UpdateRestaurantInfo("NewName", "Amsterdam", "Pisano", "5623AA", 5, "+318967333", "Yes", "Yes", restaurant);
        }

        [TestMethod]
        public void FindAllRestaurantsEligibleForDiscount()
        {
            List<Restaurant> restaurants = new List<Restaurant>() { new Restaurant { Id = 1, Name = "Pizzeria" }, new Restaurant { Id = 2, Name = "Mexican Dream" } };
            FakeRestaurantRepository fakeRepo = new FakeRestaurantRepository(restaurants);

            RestaurantManager restaurantManager = new RestaurantManager(fakeRepo);
            List<Restaurant> foundRestaurants = restaurantManager.FindAllRestaurantsEligibleForDiscount();
            CollectionAssert.AreEqual(restaurants, foundRestaurants);
        }
    }
}
