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
                    string sql = "insert into discounts_restaurant (name_discount, calculated_discount, isActive, id_restaurant) values (@name_discount,@calculated_discount,@isActive,@id_restaurant)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("name", restaurantDiscount.Name);
                    cmd.Parameters.AddWithValue("calculated_discount", restaurantDiscount.CalculatedDiscount);
                    cmd.Parameters.AddWithValue("isActive", restaurantDiscount.IsActive);
                    cmd.Parameters.AddWithValue("id_restaurant", restaurantDiscount.RestaurantId);
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
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    string sql = "insert into discounts_user (name_discount, calculated_discount, isActive, user_id) values (@name_discount,@calculated_discount,@isActive,@user_id)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("name", userDiscount.Name);
                    cmd.Parameters.AddWithValue("calculated_discount", userDiscount.CalculatedDiscount);
                    cmd.Parameters.AddWithValue("isActive", userDiscount.IsActive);
                    cmd.Parameters.AddWithValue("id_restaurant", userDiscount.UserId);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }


    }
}
