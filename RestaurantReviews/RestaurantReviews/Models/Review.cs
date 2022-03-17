using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public class Review
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public double FoodScore { get; set; }
        public double ServiceScore { get; set; }
        public double AthmosphereScore { get; set; }
        public string RestaurantName { get; set; }
        public string Author { get; set; }

    }
}
