
using ClassLibrary.Business;
using ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Persistence
{
    public class FakeRestaurantRepository : IRestaurantRepository
    {

        private List<Restaurant> restaurants;

        public FakeRestaurantRepository(List<Restaurant> restaurants)
        {
            this.restaurants = restaurants;
        }

        public bool Delete(Restaurant restaurant)
        {
            restaurants.Remove(restaurant);
        }

        public Restaurant FindRestaurant(int id)
        {
            foreach (var r in restaurants)
            {
                if (r.Id == id)
                {
                    return r;
                }
            }
            return null;
        }

        public List<Restaurant> GetAllRestaurantsEligibleForDiscount()
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfReviews(int id)
        {
            return 6;
        }

        public string GetRestaurantName(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public int GetRestuarantIdByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetRestuarants()
        {
            if (restaurants.Count == 0)
            {
                return null;
            }
            else
            {
                return restaurants;
            }
        }

        public double GetScoreForRestaurant(int id, string typeOfScore)
        {
            return 6.7;
        }

        public bool SaveRestaurant(Restaurant restaurant)
        {
            if (restaurant.Id != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateRestaurant(Restaurant restaurant)
        {
            foreach (var r in restaurants)
            {
                if (r.Id == restaurant.Id)
                {
                    return true;
                }
            }
            return false;
        }

       
    }
}
