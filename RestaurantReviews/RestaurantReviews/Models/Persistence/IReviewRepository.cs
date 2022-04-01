using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models.Persistence
{
    public interface IReviewRepository
    {

        public List<Review> FindReviewsForRestaurant(int id);
        public List<Review> GetAll();
        public bool DeleteReview(Review review);
       
    }

}
