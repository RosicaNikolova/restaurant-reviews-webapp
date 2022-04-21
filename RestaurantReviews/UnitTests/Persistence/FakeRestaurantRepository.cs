
using ClassLibrary.Business;
using ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Persistence
{
    public class FakeRestaurantRepository : IRestaurantRepository
    {

        public List<Restaurant> restaurants;

        public FakeRestaurantRepository(List<Restaurant> restaurants)
        {
            this.restaurants = restaurants;
        }

        public void Delete(Restaurant restaurant)
        {
            restaurants.Remove(restaurant);
        }

        public Restaurant FindRestaurant(int id)
        {
            foreach (Restaurant r in restaurants)
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
            return restaurants;
        }

        public int GetNumberOfReviews(int id)
        {
            return 6;
        }

        public string GetRestaurantName(int restaurantId)
        {
            foreach (Restaurant restaurant in restaurants)
            {
                if (restaurant.Id == restaurantId)
                {
                    return restaurant.Name;
                }
            }
            return "";
        }

        public int GetRestuarantIdByName(string name)
        {
            foreach (Restaurant restaurant in restaurants)
            {
                if (restaurant.Name == name)
                {
                    return restaurant.Id;
                }
            }
            return -1;
        }

        public List<Restaurant> GetRestuarants()
        {
            return restaurants;
        }

        public double GetScoreForRestaurant(int id, string typeOfScore)
        {
            return 6.7;
        }

        public void SaveRestaurant(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
        }

        public void UpdateRestaurant(Restaurant restaurant)
        {
            if (restaurants.Count != 0)
            {
                for (int i = 0; i < restaurants.Count; i++)
                {
                    if (restaurants[i].Id == restaurant.Id)
                    {
                        restaurants[i] = restaurant;
                    }
                    //else
                    //{
                    //    if (i == restaurants.Count - 1)
                    //    {
                    //        throw new RestaurantInfoException();
                    //    }
                    //}

                }
            }
            else
            {
                throw new RestaurantInfoException();
            }
        }
    }

}

