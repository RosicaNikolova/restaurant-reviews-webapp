using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public class RestaurantManager
    {
        IRestaurantRepository restaurantRepository;

        public RestaurantManager(IRestaurantRepository repository)
        {
            this.restaurantRepository = repository;
        }

        public List<Restaurant> GetAllRestaurants()
        {
            
            List<Restaurant> restaurants = restaurantRepository.GetRestuarants();
            if(restaurants == null)
            {
                throw new RestaurantException();
            }
            else
            {
                foreach (Restaurant restaurant in restaurants)
                {
                    try
                    {
                        restaurant.Food_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id, "food_score");
                        restaurant.Service_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id, "service_score");
                        restaurant.Price_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id, "athmosphere_score");
                        restaurant.NumberOfReviews = restaurantRepository.GetNumberOfReviews(restaurant.Id);
                    }

                    catch (ScoreException)
                    {
                        throw new RestaurantException();
                    }
                }

                return restaurants;
            }
        }

        public Restaurant GetRestaurant(int id)
        {
            Restaurant restaurant = restaurantRepository.FindRestaurant(id);
            if(restaurant != null)
            {
                restaurant.Food_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id, "food_score");
                restaurant.Service_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id, "service_score");
                restaurant.Price_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id, "athmosphere_score");
                restaurant.NumberOfReviews = restaurantRepository.GetNumberOfReviews(restaurant.Id);

                return restaurant;
            }
            else
            {
                throw new RestaurantException();
            }
          
        }

        public void CreateNewRestaurant(string name, string city, string street, string postcode, int streetNumber, string phone, string parking, string delivery)
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Name = name;
            restaurant.City = city;
            restaurant.Street = street;
            restaurant.PostCode = postcode;
            restaurant.StreetNumber = streetNumber;
            restaurant.PhoneNumber = phone;
            restaurant.HasParking = parking;
            restaurant.HasDelivery = delivery;

            if (!restaurantRepository.SaveRestaurant(restaurant))
            {
                throw new RestaurantException();
            }
        }

      

        public void UpdateRestaurantInfo(string name, string city, string street, string postcode, int streetNumber, string phone, string parking, string delivery, Restaurant restaurant)
        {
            try
            {
                restaurant.Name = name;
                restaurant.City = city;
                restaurant.Street = street;
                restaurant.PostCode = postcode;
                restaurant.StreetNumber = streetNumber;
                restaurant.PhoneNumber = phone;
                restaurant.HasParking = parking;
                restaurant.HasDelivery = delivery;
                restaurantRepository.UpdateRestaurant(restaurant);
            }
            catch (RestaurantException)
            {
                throw new RestaurantException();
            }
        }

        public void DeleteRestaurant(Restaurant restaurant)
        {
            if (!restaurantRepository.Delete(restaurant))
            {
                throw new RestaurantException();
            }
        }
    }
}
