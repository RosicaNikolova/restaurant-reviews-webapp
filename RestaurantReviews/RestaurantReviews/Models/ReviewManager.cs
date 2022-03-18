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
            List<Review> reviews = reviewRepository.FindReviewsForRestaurant(id);
            if (reviews == null)
            {
                throw new RestaurantException();
            }
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
    }
}
