using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Business
{
    public interface IReviewManager
    {
        public List<Review> GetReviewsForRestaurant(int id);
        public void Update(double foodScore, double serviceScore, double priceScore, string comment, int id);
        public Review GetReviewById(int id);
        public List<Review> GetReviewsForUser(int id);
        public List<Review> GetAllReviews();
        public void DeleteReview(Review review);
        public void AddReview(int authorId, string restaurantName, double foodScore, double serviceScore, double priceScore, string comment);
    }
}
