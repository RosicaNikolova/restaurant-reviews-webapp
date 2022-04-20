
using ClassLibrary.Business;
using ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Persistence
{
    public class FakeReviewRepository : IReviewRepository
    {

        private List<Review> reviews;

        public FakeReviewRepository(List<Review> reviews)
        {
            this.reviews = reviews;
        }

        public bool CreateReview(Review review, int authorId, int RestaurantId)
        {
            throw new NotImplementedException();
        }

        public void DeleteReview(Review review)
        {
            reviews.Remove(review);
        }

        public List<Review> FindReviewsForRestaurant(int id)
        {
            List<Review> reviewsForRestaurant = new List<Review>();
            foreach (Review review in reviews)
            {
                if (review.Id == id)
                {
                    reviewsForRestaurant.Add(review);
                }
            }
            return reviewsForRestaurant;
        }

        public List<Review> GetAll()
        {
            return reviews;
        }

        public Review GetReviewById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetReviewsForUser(int id)
        {
            List<Review> reviewsForUser = new List<Review>();
            foreach (Review review in reviews)
            {
                if(review.Id == id)
                {
                    reviewsForUser.Add(review);
                }
            }
            return reviewsForUser;
        }

        public void UpdateReview(Review review)
        {
            throw new NotImplementedException();
        }

      
    }
}
