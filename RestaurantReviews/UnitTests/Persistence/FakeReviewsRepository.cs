
using ClassLibrary.Business;
using ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Persistence
{
    public class FakeReviewRepository : IReviewRepository
    {

        public List<Review> reviews;

        public FakeReviewRepository(List<Review> reviews)
        {
            this.reviews = reviews;
        }

        public void CreateReview(Review review, int authorId, int RestaurantId)
        {
            reviews.Add(review);
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
            foreach (Review review in reviews)
            {
                if(review.Id == id)
                {
                    return review;
                }
            }
            return null;
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
            for (int i = 0; i < reviews.Count; i++)
            {
                if (reviews[i].Id == review.Id)
                {
                    reviews[i].Comment = review.Comment;
                    reviews[i].FoodScore = review.FoodScore;
                    reviews[i].ServiceScore = review.ServiceScore;
                    reviews[i].PriceScore = review.PriceScore;
                }
            }
        }
    }
}
