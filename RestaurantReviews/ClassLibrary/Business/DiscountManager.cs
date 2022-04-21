using ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Business
{
    public class DiscountManager: IDiscountManager
    {
        private IDiscountRepository discountRepository;
        public DiscountManager(IDiscountRepository repo)
        {
            this.discountRepository = repo;
        }

        public void CreateUserDiscount(User user)
        {
            UserDiscount userDiscount = new UserDiscount();
            userDiscount.Name = "Discount on total amount";
            userDiscount.IsActive = true;
            userDiscount.UserId = user.Id;
            int reviewsForUser = discountRepository.GetNumberOfReviewsForUser(user.Id);
            userDiscount.CalculatedDiscount = userDiscount.CalculateDiscount(reviewsForUser);
            discountRepository.CreateDiscountForUser(userDiscount);
        }
        public void CreateRestaurantDiscount(Restaurant restaurant)
        {
            RestaurantDiscount restaurantDiscount = new RestaurantDiscount();
            restaurantDiscount.Name = "Discount on speacil dish";
            restaurantDiscount.IsActive = true;
            restaurantDiscount.RestaurantId = restaurant.Id;
            int reviewsForRestaurant = discountRepository.GetNumberOfReviewsForRestaurant(restaurant.Id);
            restaurantDiscount.CalculatedDiscount = restaurantDiscount.CalculateDiscount(reviewsForRestaurant);
            discountRepository.CreateDiscountForRestaurant(restaurantDiscount);

        }

        public List<Discount> GetAllDiscounts()
        {
            List<Discount> discounts = new List<Discount>();
            discounts = discountRepository.GetAllDiscounts();
            return discounts;
        }

        public SpeacialDish GetSpeshialDish(int restauratnId)
        {
            SpeacialDish speacialDish = new SpeacialDish();
            speacialDish = discountRepository.GetSpeshialDish(restauratnId);
            return speacialDish;
        }
    }
}
