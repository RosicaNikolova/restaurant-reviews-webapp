﻿using ClassLibrary.Business;
using ClassLibrary.Exceptions;
using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Persistence

{
    public class ReviewRepository : IReviewRepository
    {

        public List<Review> FindReviewsForRestaurant(int id)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    List<Review> reviews = new List<Review>();
                    string sql = "select review_id, r.date, r.comment, r.food_score, r.service_score, r.athmosphere_score, u.first_name, u.last_name, rest.name from reviews as r join user as u on r.user_id = u.id join restaurant as rest on r.restaurant_id = rest.restaurant_id where r.restaurant_id = @restaurant_id;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("restaurant_id", id);

                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        Review review = new Review();
                        review.Id = dateReader.GetInt32("review_id");
                        review.Date = (DateTime)dateReader.GetMySqlDateTime("date");
                        review.Comment = dateReader.GetString("comment");
                        review.FoodScore = dateReader.GetInt32("food_score");
                        review.ServiceScore = dateReader.GetInt32("service_score");
                        review.PriceScore = dateReader.GetInt32("athmosphere_score");
                        review.AuthorFirstName = dateReader.GetString("first_name");
                        review.AuthorLastName = dateReader.GetString("last_name");

                        reviews.Add(review);
                    }
                    return reviews;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Review> GetReviewsForUser(int id)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    List<Review> reviews = new List<Review>();
                    string sql = "select review_id, r.date, r.comment, r.food_score, r.service_score, r.athmosphere_score, u.first_name, u.last_name, rest.name from reviews as r join user as u on r.user_id = u.id join restaurant as rest on r.restaurant_id = rest.restaurant_id where u.id = @user_id;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("user_id", id);

                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        Review review = new Review();
                        review.Id = dateReader.GetInt32("review_id");
                        review.Date = (DateTime)dateReader.GetMySqlDateTime("date");
                    try
                    {
                        review.Comment = dateReader.GetString("comment");
                    }
                    catch (Exception)
                    {
                        review.Comment = "";
                    }
                        review.FoodScore = dateReader.GetInt32("food_score");
                        review.ServiceScore = dateReader.GetInt32("service_score");
                        review.PriceScore = dateReader.GetInt32("athmosphere_score");
                        review.AuthorFirstName = dateReader.GetString("first_name");
                        review.AuthorLastName = dateReader.GetString("last_name");
                        review.RestaurantName = dateReader.GetString("name");

                        reviews.Add(review);
                    }
                    return reviews;
                }
        }
            catch (Exception)
            {
                throw new DataBaseException();
            }
}

        public List<Review> GetAll()
        {
            //try
            //{
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    List<Review> reviews = new List<Review>();
                    string sql = "select * from reviews as r join user as u on r.user_id = u.id join restaurant as rest on r.restaurant_id = rest.restaurant_id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        Review review = new Review();
                        review.Id = dateReader.GetInt32("review_id");
                        review.Date = (DateTime)dateReader.GetMySqlDateTime("date");
                    try
                    {
                        review.Comment = dateReader.GetString("comment");
                    }
                    catch (Exception)
                    {
                        review.Comment = "";
                    }
                   
                        review.FoodScore = dateReader.GetInt32("food_score");
                        review.ServiceScore = dateReader.GetInt32("service_score");
                        review.PriceScore = dateReader.GetInt32("athmosphere_score");
                        review.AuthorFirstName = dateReader.GetString("first_name");
                        review.AuthorLastName = dateReader.GetString("last_name");
                        review.RestaurantName = dateReader.GetString("name");

                        reviews.Add(review);
                    }
                    return reviews;
                }
            //}
            //catch (Exception)
            //{
            //    return null;
            //}
        }

        public bool DeleteReview(Review review)
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    string sql = "Delete from reviews where review_id=@review_id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("review_id", review.Id);
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

        public bool CreateReview(Review review, int authorId, int restaurantId)
        {
        try
        {
            using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    string sql = "insert into reviews (date, comment, food_score, service_score, athmosphere_score, user_id, restaurant_id) values(@date, @comment, @food_score, @service_score, @athmosphere_score, @user_id, @restaurant_id);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("date", review.Date);
                    cmd.Parameters.AddWithValue("comment", review.Comment);
                    cmd.Parameters.AddWithValue("food_score", review.FoodScore);
                    cmd.Parameters.AddWithValue("service_score", review.ServiceScore);
                    cmd.Parameters.AddWithValue("athmosphere_score", review.PriceScore);
                    cmd.Parameters.AddWithValue("user_id", authorId);
                    cmd.Parameters.AddWithValue("restaurant_id", restaurantId);

                    conn.Open();

                    int result = cmd.ExecuteNonQuery();
                    if(result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                   
                }
        }
        catch (Exception)
        {
            throw new Exception();
        }

    }

    }
}
