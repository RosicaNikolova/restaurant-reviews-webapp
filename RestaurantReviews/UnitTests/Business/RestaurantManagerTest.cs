using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviews.Models;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class RestaurantManagerTest
    {
        [TestMethod]
        public void FindRestaurantTest()
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
        [ExpectedException(typeof(RestaurantException))]
        public void FindRestaurantFailsTest()
        {
            Restaurant restCreated = new Restaurant();
            restCreated.Name = "Pizzeria";
            restCreated.Id = 1;
            FakeRestaurantRepository fakeRepo = new FakeRestaurantRepository(new List<Restaurant>());

            RestaurantManager restaurantManager = new RestaurantManager(fakeRepo);
            Restaurant foundRestaurant = restaurantManager.GetRestaurant(1);
            
        }

        [TestMethod]
        public void FindAllRestaurantsTest()
        {
            List<Restaurant> restaurants = new List<Restaurant>() { new Restaurant { Id = 1, Name = "Pizzeria" } , new  Restaurant { Id = 2, Name = "Mexican Dream" } };
            FakeRestaurantRepository fakeRepo = new FakeRestaurantRepository(restaurants);

            RestaurantManager restaurantManager = new RestaurantManager(fakeRepo);
            List<Restaurant> foundRestaurants = restaurantManager.GetAllRestaurants();
            CollectionAssert.AreEqual(restaurants, foundRestaurants);
        }

        [TestMethod]
        [ExpectedException(typeof(RestaurantException))]
        public void FindAllRestaurantsFailsTest()
        { 
            FakeRestaurantRepository fakeRepo = new FakeRestaurantRepository(new List<Restaurant>());
            RestaurantManager restaurantManager = new RestaurantManager(fakeRepo);
            restaurantManager.GetAllRestaurants();
        }


        

    }
}
