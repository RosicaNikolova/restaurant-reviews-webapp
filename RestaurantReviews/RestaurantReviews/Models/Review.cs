using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public class Review : RatableContent
    {
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public string RestaurantName { get; set; }
        public string Author { get; set; }
    }
}
