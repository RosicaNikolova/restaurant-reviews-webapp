using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public class ReviewManager
    {
        ReviewRepository reviewRepository = new ReviewRepository();
        public List<Review> GetReviewsForRestaurant(int id)
        {
            return reviewRepository.FindReviewsForRestaurant(id);
        }

        public List<Review> GetAllReviews()
        {
            return reviewRepository.GetAll();
        }

        public void DeleteReview(Review review)
        {
            reviewRepository.DeleteReview(review);
        }
    }
}
