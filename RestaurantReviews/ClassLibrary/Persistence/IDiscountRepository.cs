using ClassLibrary.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Persistence
{
    public interface IDiscountRepository
    {
        public int GetNumberOfReviewsForUser(int userId);

        public int GetNumberOfReviewsForRestaurant(int restarauntId);

        public void CreateDiscountForRestaurant(RestaurantDiscount restaurantDiscount);

        public void CreateDiscountForUser(UserDiscount userDiscount);
        List<Discount> GetAllDiscounts();
        SpeacialDish GetSpeshialDish(int restauratnId);
    }
}
