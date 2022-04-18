using ClassLibrary.Business;
using ClassLibrary.Exceptions;
using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Persistence
{
    public class RestaurantRepository : IRestaurantRepository
    {
        public List<Restaurant> GetRestuarants()
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    List<Restaurant> restaurants = new List<Restaurant>();
                    string sql = "select restaurant_id, name, city, street, postcode, street_number, phone, is_parking_available, is_delivery_available, cuisine_type from restaurant order by restaurant_id;";
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
                        restaurant.Cuisine = (CuisineType)Enum.Parse(typeof(CuisineType), dateReader.GetString("cuisine_type"));
                        restaurants.Add(restaurant);
                    }
                    return restaurants;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Restaurant FindRestaurant(int id)
        {
            try {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    Restaurant restaurant = null;
                    string sql = "select restaurant_id, name, city, street, postcode, street_number, phone, is_parking_available, is_delivery_available, cuisine_type from restaurant where restaurant_id=@restaurant_id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("restaurant_id", id);

                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        restaurant = new Restaurant();
                        restaurant.Id = dateReader.GetInt32("restaurant_id");
                        restaurant.Name = dateReader.GetString("name");
                        restaurant.City = dateReader.GetString("city");
                        restaurant.Street = dateReader.GetString("street");
                        restaurant.PostCode = dateReader.GetString("postcode");
                        restaurant.StreetNumber = dateReader.GetInt32("street_number");
                        restaurant.PhoneNumber = dateReader.GetString("phone");
                        restaurant.HasParking = dateReader.GetString("is_parking_available");
                        restaurant.HasDelivery = dateReader.GetString("is_delivery_available");
                        restaurant.Cuisine = (CuisineType)Enum.Parse(typeof(CuisineType), dateReader.GetString("cuisine_type"));
                    }
                    return restaurant;
                }
               
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int GetNumberOfReviews(int id)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    int numberOfReviews = 0;
                    string sql = $"select Count(*) as count from reviews where restaurant_id = @restaurant_id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("restaurant_id", id);

                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    if (dateReader.Read())
                    {
                        numberOfReviews = dateReader.GetInt32("count");
                    }

                    return numberOfReviews;
                }
            }
            catch (Exception)
            {
                throw new ScoreException();
            }
        }

        public double GetScoreForRestaurant(int id, string typeOfScore)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    double score = 0.0;
                    string sql = $"SELECT SUM({typeOfScore}) as sum, Count(*) as count from reviews where restaurant_id = @restaurant_id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("restaurant_id", id);

                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();

                    while (dateReader.Read())
                    {
                        if (dateReader.GetInt32("count") == 0)
                        {
                            return 0;
                        }
                        else
                        {
                            score = (double)dateReader.GetInt32("sum") / dateReader.GetInt32("count");
                        }

                    }
                    score = Math.Round(score, 1);
                    return score;
                }
            }
            catch (Exception)
            {
                throw new ScoreException();
            }


        }

        public bool SaveRestaurant(Restaurant restaurant)
        {
            try
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
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateRestaurant(Restaurant restaurant)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    string sql = "update restaurant set name=@name, city=@city, street=@street, postcode=@postcode, street_number=@street_number, phone=@phone, is_parking_available=@is_parking_available, is_delivery_available=@is_delivery_available where restaurant_id=@restaurant_id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("restaurant_id", restaurant.Id);
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
                    return true;
                }
            }
            catch (Exception)
            {
                throw new RestaurantException();
            }
        }

        public bool Delete(Restaurant restaurant)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    string sql = "Delete from restaurant where restaurant_id=@restaurant_id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("restaurant_id", restaurant.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int GetRestuarantIdByName(string name)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    string sql = "Select restaurant_id from restaurant where name=@restaurant_name";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("restaurant_name", name);
                    conn.Open();

                    Object result = cmd.ExecuteScalar();
                    if(result != null)
                    {
                        int resturantId = Convert.ToInt32(result);
                        return resturantId;
                    }
                }
                return -1;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }


    }
}
