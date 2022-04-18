
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
            if (reviews == null)
            {
                throw new RestaurantException();
            }
            return reviews;
        }

        public List<Review> GetReviewsForUser(int id)
        {
            List<Review> reviews = reviewRepository.GetReviewsForUser(id);
            //if (reviews == null)
            //{
            //    throw new RestaurantException();
            //}

            return reviews;
        }

        public List<Review> GetAllReviews()
        {

            List<Review> reviews = reviewRepository.GetAll();
            if (reviews == null)
            {
                throw new RestaurantException();
            }
            return reviews;
        }

        public void DeleteReview(Review review)
        {
            if (!reviewRepository.DeleteReview(review))
            {
                throw new ReviewException();
            }
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
            if(restaurantId != -1)
            {
                reviewRepository.CreateReview(review, authorId, restaurantId);
            }
            else
            {
                throw new Exception();
            }

        }

        public void Update()
        {

        }
    }
}
