using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Business
{
   public class SpeacialDish
    {
        public int Id { get; set; }
        public string DishName{ get; set; }
        public double Price { get; set; }
        public int RestaurantId { get; set; }
    }
}
