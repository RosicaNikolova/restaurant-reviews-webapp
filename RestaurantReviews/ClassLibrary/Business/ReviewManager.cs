
using ClassLibrary.Exceptions;
using ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Business
{
    public class ReviewManager
    {

        private IReviewRepository reviewRepository;


        public ReviewManager(IReviewRepository reviewRepository)
        {
            this.reviewRepository = reviewRepository;
        }
       
        public List<Review> GetReviewsForRestaurant(int id)
        {
            List<Review> reviews = reviewRepository.FindReviewsForRestaurant(id);
            return reviews;
        }

        public void Update(double foodScore, double serviceScore, double priceScore, string comment, int id)
        {
            Review review = new Review();
            review.FoodScore = foodScore;
            review.ServiceScore = serviceScore;
            review.PriceScore = priceScore;
            review.Comment = comment;
            review.Id = id;
            reviewRepository.UpdateReview(review);
        }

        public Review GetReviewById(int id)
        {
            Review review = new Review();
            review = reviewRepository.GetReviewById(id);
            return review;

        }

        public List<Review> GetReviewsForUser(int id)
        {
            List<Review> reviews = reviewRepository.GetReviewsForUser(id);
            return reviews;
        }

        public List<Review> GetAllReviews()
        {

            List<Review> reviews = reviewRepository.GetAll();
            return reviews;
        }

        public void DeleteReview(Review review)
        {
            reviewRepository.DeleteReview(review);
        }

        public void AddReview(int authorId,string restaurantName, double foodScore, double serviceScore, double priceScore, string comment)
        {
            Review review = new Review();
            review.Date = DateTime.Today;
            review.RestaurantName = restaurantName;
            review.FoodScore = foodScore;
            review.ServiceScore = serviceScore;
            review.PriceScore = priceScore;
            review.Comment = comment;
            RestaurantManager restaurantManager = new RestaurantManager(new RestaurantRepository());
            int restaurantId = restaurantManager.GetIdByName(restaurantName);           
            reviewRepository.CreateReview(review, authorId, restaurantId);
        }
    }
}
