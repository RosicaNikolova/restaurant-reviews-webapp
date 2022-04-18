﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Business
{
    public class UserDiscount : Discount
    {
        public override int CalculateDiscount(int numberOfReviews)
        {
            int discountAmonut = 0;
           if(numberOfReviews <= 100)
            {
                discountAmonut = numberOfReviews / 2;
            }
            else
            {
                discountAmonut = 75;
            }
            return discountAmonut;
        }

        public int UserId { get; set; }
    }
}
