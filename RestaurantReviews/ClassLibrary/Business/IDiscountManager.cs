using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Business
{
    public interface IDiscountManager
    {
        public void CreateUserDiscount(User user);
        public void CreateRestaurantDiscount(Restaurant restaurant);
        public List<Discount> GetAllDiscounts();
        public SpeacialDish GetSpeshialDish(int restauratnId);
    }
}
