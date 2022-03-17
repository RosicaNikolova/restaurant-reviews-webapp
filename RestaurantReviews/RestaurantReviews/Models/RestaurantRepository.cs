using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public class RestaurantRepository
    {
        public List<Restaurant> GetRestuarants()
        {
            using (MySqlConnection conn = ConnectionFactory.CreateConnection())
            {
                List<Restaurant> restaurants = new List<Restaurant>();
                string sql = "select restaurant_id, name, city, street, postcode, street_number, phone, is_parking_available, is_delivery_available from restaurant order by restaurant_id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dateReader = cmd.ExecuteReader();
                while (dateReader.Read())
                {
                    Restaurant restaurant = new Restaurant();
                    restaurant.Id = dateReader.GetInt32("restaurant_id");
                    restaurant.Name = dateReader.GetString("name");
                    restaurant.City = dateReader.GetString("city");
                    restaurant.Street = dateReader.GetString("street");
                    restaurant.PostCode = dateReader.GetString("postcode");
                    restaurant.StreetNumber = dateReader.GetInt32("street_number");
                    restaurant.PhoneNumber = dateReader.GetString("phone");
                    restaurant.HasParking = dateReader.GetString("is_parking_available");
                    restaurant.HasDelivery = dateReader.GetString("is_delivery_available");
                    restaurants.Add(restaurant);
                }
                return restaurants;
            }
        }

        public void SaveRestaurant(Restaurant restaurant)
        {
            using (MySqlConnection conn = ConnectionFactory.CreateConnection())
            {
                string sql = "insert into restaurant (name, city, street, postcode, street_number, phone, is_parking_available, is_delivery_available) values (@name,@city,@street,@postcode,@street_number,@phone,@is_parking_available,@is_delivery_available)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("name", restaurant.Name);
                cmd.Parameters.AddWithValue("city", restaurant.City);
                cmd.Parameters.AddWithValue("street", restaurant.Street);
                cmd.Parameters.AddWithValue("postcode", restaurant.PostCode);
                cmd.Parameters.AddWithValue("street_number", restaurant.StreetNumber);
                cmd.Parameters.AddWithValue("phone", restaurant.PhoneNumber);
                cmd.Parameters.AddWithValue("is_parking_available", restaurant.HasParking);
                cmd.Parameters.AddWithValue("is_delivery_available", restaurant.HasDelivery);
        

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
