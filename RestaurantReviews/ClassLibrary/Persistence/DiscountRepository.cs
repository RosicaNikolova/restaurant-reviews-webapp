using ClassLibrary.Business;
using ClassLibrary.Exceptions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Persistence
{
    public class DiscountRepository : IDiscountRepository
    {
        public int GetNumberOfReviewsForRestaurant(int restarauntId)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    int numberOfReviews = 0;
                    string sql = $"select Count(*) as count from reviews where restaurant_id = @restaurant_id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("restaurant_id", restarauntId);

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
                throw new DataBaseException();
            }
        }

        public int GetNumberOfReviewsForUser(int userId)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    int numberOfReviews = 0;
                    string sql = $"select Count(*) as count from reviews where user_id = @user_id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("user_id", userId);

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
                throw new DataBaseException();
            }
        }


        public void CreateDiscountForRestaurant(RestaurantDiscount restaurantDiscount)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    string sql = "insert into discounts (name_discount, calculated_discount, isActive, id_restaurant,type_discount) values (@name_discount,@calculated_discount,@isActive,@id_restaurant, @type_discount)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("name_discount", restaurantDiscount.Name);
                    cmd.Parameters.AddWithValue("calculated_discount", restaurantDiscount.CalculatedDiscount);
                    cmd.Parameters.AddWithValue("isActive", restaurantDiscount.IsActive);
                    cmd.Parameters.AddWithValue("id_restaurant", restaurantDiscount.RestaurantId);
                    cmd.Parameters.AddWithValue("type_discount", "Restaurant");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }

        }

        public void CreateDiscountForUser(UserDiscount userDiscount)
        {
            //try
            //{
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    string sql = "insert into discounts (name_discount, calculated_discount, isActive, id_user, type_discount) values (@name_discount,@calculated_discount,@isActive,@id_user, @type_discount)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("name_discount", userDiscount.Name);
                    cmd.Parameters.AddWithValue("calculated_discount", userDiscount.CalculatedDiscount);
                    cmd.Parameters.AddWithValue("isActive", userDiscount.IsActive);
                    cmd.Parameters.AddWithValue("id_user", userDiscount.UserId);
                    cmd.Parameters.AddWithValue("type_discount", "Customer");
                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
            //}
            //catch (Exception)
            //{
            //    throw new DataBaseException();
            //}
        }

        public List<Discount> GetAllDiscounts()
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    List<Discount> discounts = new List<Discount>();
                    string sql = "select * from discounts where isActive = 1";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    
                    conn.Open();
                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        string discountType = dateReader.GetString("type_discount");
                        if (discountType == "Customer")
                        {
                            UserDiscount userDiscount = new UserDiscount();
                            userDiscount.Id = dateReader.GetInt32("id_discount");
                            userDiscount.Name = dateReader.GetString("name_discount");
                            userDiscount.CalculatedDiscount = dateReader.GetInt32("calculated_discount");
                            userDiscount.UserId = dateReader.GetInt32("id_user");
                            discounts.Add(userDiscount);
                        }
                        else
                        {
                            RestaurantDiscount restaurantDiscount = new RestaurantDiscount();
                            restaurantDiscount.Id = dateReader.GetInt32("id_discount");
                            restaurantDiscount.Name = dateReader.GetString("name_discount");
                            restaurantDiscount.CalculatedDiscount = dateReader.GetInt32("calculated_discount");
                            restaurantDiscount.RestaurantId = dateReader.GetInt32("id_restaurant");
                            discounts.Add(restaurantDiscount);
                        }
                    }
                    return discounts;
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public SpeacialDish GetSpeshialDish(int restauratnId)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    SpeacialDish speacialDish = new SpeacialDish();
                    string sql = "select * from special_dish where restaurant_id = @restaurant_id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("restaurant_id",restauratnId);


                    conn.Open();
                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        speacialDish.Id = dateReader.GetInt32("id_dish");
                        speacialDish.DishName = dateReader.GetString("dish_name");
                        speacialDish.Price = dateReader.GetInt32("dish_price");
                        speacialDish.RestaurantId = dateReader.GetInt32("restaurant_id");
                    }
                    return speacialDish;
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }
    }
}
