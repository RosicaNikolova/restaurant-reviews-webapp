using ClassLibrary.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class ReviewManagerTests
    {
        [TestMethod]
        public void GetReviewsForRestaurant()
        {
            Review reviewCreated = new Review();
            reviewCreated.Id = 1;
            List<Review> expectedReviews = new List<Review>();
            expectedReviews.Add(reviewCreated);
          
            FakeReviewRepository fakeRepo = new FakeReviewRepository(new List<Review> { reviewCreated });

            ReviewManager reviewManager = new ReviewManager(fakeRepo);
            List<Review> actual = reviewManager.GetReviewsForRestaurant(1);

            CollectionAssert.AreEqual(expectedReviews, actual); 
        }

        [TestMethod]
        public void GetReviewsForUserTest()
        {
            Review reviewCreated = new Review();
            reviewCreated.Id = 1;
            List<Review> expectedReviews = new List<Review>();
            expectedReviews.Add(reviewCreated);
            FakeReviewRepository fakeRepo = new FakeReviewRepository(new List<Review> { reviewCreated });

            ReviewManager reviewManager = new ReviewManager(fakeRepo);
            List<Review> actual = reviewManager.GetReviewsForUser(1);
            CollectionAssert.AreEqual(expectedReviews, actual);

        }

        [TestMethod]
        public void UpdateTest()
        {
            List<Review> reviews = new List<Review>();
            Review review = new Review();
            review.Id = 1;
            review.FoodScore = 10;

            reviews.Add(review);
            FakeReviewRepository fakeRepo = new FakeReviewRepository(reviews);
            ReviewManager reviewManager = new ReviewManager(fakeRepo);
            reviewManager.Update(9, 8, 6, "I liked it", 1);
            Assert.AreEqual(9, fakeRepo.reviews[0].FoodScore);
        }

        [TestMethod]
        public void GetReviewByIdTest()
        {
            Review reviewCreated = new Review();
            reviewCreated.Id = 1;
            reviewCreated.FoodScore = 9;
            List<Review> expectedReviews = new List<Review>();
            expectedReviews.Add(reviewCreated);
            FakeReviewRepository fakeRepo = new FakeReviewRepository(new List<Review> { reviewCreated });

            ReviewManager reviewManager = new ReviewManager(fakeRepo);
            Review actual = reviewManager.GetReviewById(1);
            Assert.AreEqual(reviewCreated, actual);
        }


        [TestMethod]
        public void GetAllReviewsTest()
        {
            Review reviewCreated = new Review();
            reviewCreated.Id = 1;
            Review secondReviewCreated = new Review();
            secondReviewCreated.Id = 2;
            List<Review> expectedReviews = new List<Review>();
            expectedReviews.Add(reviewCreated);
            expectedReviews.Add(secondReviewCreated);
            FakeReviewRepository fakeRepo = new FakeReviewRepository(expectedReviews);

            ReviewManager reviewManager = new ReviewManager(fakeRepo);
            List<Review> actual = reviewManager.GetAllReviews();
            CollectionAssert.AreEqual(expectedReviews, actual);
        }

        [TestMethod]
        public void AddReviewTest()
        {
            Review reviewCreated = new Review();
            reviewCreated.Id = 1;
            List<Review> expectedReviews = new List<Review>();
            expectedReviews.Add(reviewCreated);
            FakeReviewRepository fakeRepo = new FakeReviewRepository(expectedReviews);

            ReviewManager reviewManager = new ReviewManager(fakeRepo);
            reviewManager.AddReview(1, "RestaurantName", 8, 8, 8, "Comment");
            Assert.AreEqual(reviewCreated, fakeRepo.reviews[0]);
        }

        [TestMethod]
        public void DeleteReviewTest()
        {
            List<Review> reviews = new List<Review>() { new Review { Id = 1}, new Review { Id = 2} };
            FakeReviewRepository fakeRepo = new FakeReviewRepository(reviews);
            ReviewManager reviewManager = new ReviewManager(fakeRepo);
            Review review = new Review();
            review.Id = 1;
            reviewManager.DeleteReview(review);
            reviews.Remove(review);
            CollectionAssert.AreEqual(reviews, fakeRepo.reviews);
        }

    }
}
