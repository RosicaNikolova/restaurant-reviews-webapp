using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public class Restaurant : RatableContent
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Review> Reviews { get; set; }

    }
}
