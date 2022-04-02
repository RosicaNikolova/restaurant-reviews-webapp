using MySql.Data.MySqlClient;
using RestaurantReviews.Models.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
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
                    string sql = "select review_id, r.date, r.comment, r.food_score, r.service_score, r.athmosphere_score, u.first_name, u.last_name, rest.name from reviews as r join user as u on r.user_id_int = u.id join restaurant as rest on r.restaurant_id = rest.restaurant_id where r.restaurant_id = @restaurant_id;";

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
                    string sql = "select review_id, r.date, r.comment, r.food_score, r.service_score, r.athmosphere_score, u.first_name, u.last_name, rest.name from reviews as r join user as u on r.user_id_int = u.id join restaurant as rest on r.restaurant_id = rest.restaurant_id where u.id = @user_id;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("user_id", id);

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

        public List<Review> GetAll()
        {
            try
            {
                using (MySqlConnection conn = ConnectionFactory.CreateConnection())
                {
                    List<Review> reviews = new List<Review>();
                    string sql = "select review_id, r.date, r.comment, r.food_score, r.service_score, r.athmosphere_score, u.first_name, u.last_name, rest.name from reviews as r join user as u on r.user_id_int = u.id join restaurant as rest on r.restaurant_id = rest.restaurant_id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

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
                        review.RestaurantName = dateReader.GetString("name");

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
    }
}
