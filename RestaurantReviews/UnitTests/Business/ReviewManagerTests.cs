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
    }
}
