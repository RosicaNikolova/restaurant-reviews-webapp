using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Business
{
    public class UserDiscount : Discount
    {
        public override int CalculateDiscount(int numberOfReviews)
        {
            int discountAmonut;

            if(numberOfReviews <=0)
            {
                discountAmonut = 1;
            }
            else if(numberOfReviews <= 100)
            {
                discountAmonut = numberOfReviews / 2;
                if(discountAmonut == 0)
                {
                    discountAmonut = 1;
                }
            }
            else
            {
                discountAmonut = 75;
            }
            return discountAmonut;
        }

        public int UserId { get; set; }

        public override string ToString()
        {
            return $"{this.Name} - {this.CalculatedDiscount}%, User Id: {this.UserId}";
        }
    }
}
