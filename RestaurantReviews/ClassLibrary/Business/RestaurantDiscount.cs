using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Business
{
    public class RestaurantDiscount : Discount
    {
        public override int CalculateDiscount(int numberOfReviews)
        {
            if(numberOfReviews <= 3)
            {
                return 5;
            }
            else if(numberOfReviews <= 5)
            {
                return 7;
            }
            else if(numberOfReviews <= 10)
            {
                return 10;
            }
            else if(numberOfReviews <= 25)
            {
                return 20;
            }
            else if(numberOfReviews <= 50)
            {
                return 30;
            }
            else
            {
                return 50;
            }
        }

        public int RestaurantId { get; set; }
    }
}
