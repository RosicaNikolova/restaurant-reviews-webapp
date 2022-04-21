using ClassLibrary.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Persistence
{
    public interface IReviewRepository
    {
        public List<Review> FindReviewsForRestaurant(int id);
        public List<Review> GetAll();
        public void DeleteReview(Review review);
        public List<Review> GetReviewsForUser(int id);
        public void CreateReview(Review review, int authorId, int RestaurantId);
        Review GetReviewById(int id);
        public void UpdateReview(Review review);
       
    }

}
